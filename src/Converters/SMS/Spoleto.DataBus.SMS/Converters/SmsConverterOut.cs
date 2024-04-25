using Spoleto.DataBus.Interfaces.Converters;
using Spoleto.DataBus.SMS.Interfaces;
using Spoleto.SMS;

namespace Spoleto.DataBus.SMS.Converters
{
    /// <summary>
    /// The SMS output converter.
    /// </summary>
    /// <remarks>
    /// Makes the HTTP request to the SMS service, receives the respond and returns it as output.
    /// </remarks>
    public class SmsConverterOut : ConfigurableConverterOutBase<SmsModelIn, SmsModelOut, SmsConnectorOutOptions>
    {
        public const string ConnectorName = "SMS"; //todo: add "Out" ?

        public override string Name => ConnectorName;

        public override string Description => "Makes the HTTP request to the SMS service, receives the respond and returns it as output.";

        public override SmsModelOut Convert(SmsModelIn source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var providerData = source.ProviderData?.Select(x => new Spoleto.SMS.SmsProviderData(x.Name, x.Value)).ToList();

            var smsMessage = new SmsMessage(source.Body, source.From, source.To, source.IsAllowSendToForeignNumbers, providerData);
            
            var smsService = CreateSmsService(source);
            var result = smsService.Send(source.ProviderName, smsMessage);

            var errors = result.Errors?.Select(x => new Spoleto.DataBus.SMS.Interfaces.SmsSendingError
            {
                ClientIp = x.ClientIp,
                Code = x.Code,
                DateReceived = x.DateReceived,
                Error = x.Error,
                Message = x.Message,
                MessageId = x.MessageId,
                NumCode = x.NumCode,
                Recipient = x.Recipient,
                RequestId = x.RequestId,
                Text = x.Text,
                UserId = x.UserId
            }).ToList();

            var data = result.SmsSendingData?.Select(x => new Spoleto.DataBus.SMS.Interfaces.SmdSendingData
            {
                ClientIp = x.ClientIp,
                DateReceived = x.DateReceived,
                MessageId = x.MessageId,
                Recipient = x.Recipient,
                RequestId = x.RequestId,
                Text = x.Text,
                UserId = x.UserId
            });

            var dataResult = new SmsModelOut
            {
                ProviderName = source.ProviderName,
                Errors = errors,
                SmsSendingData = data,
                Success = result.Success
            };

            return dataResult;
        }

        //todo: make cache of SMS services ? (with the same provider + login + pwd)
        private static ISmsService CreateSmsService(SmsModelIn smsModel)
        {
            if (smsModel == null)
                throw new ArgumentNullException(nameof(smsModel));

            if (smsModel.ProviderName == null
                || smsModel.Login == null
                || smsModel.Password == null)
            {
                throw new NullReferenceException($"{nameof(smsModel.ProviderName)} and {nameof(smsModel.Login)} and {nameof(smsModel.Password)} have to be specified.");
            }

            var smsServiceFactory = new SmsServiceFactory()
               .WithOptions(options =>
               {
                   //options.DefaultFrom = "Default Sender ID";
                   options.DefaultProvider = smsModel.ProviderName;
               });

            if (smsModel.ProviderName == SmsProviderName.SMSC.ToString())
            {
                smsServiceFactory.AddSmsc(smsModel.Login, smsModel.Password);
            }

            if (smsModel.ProviderName == SmsProviderName.GetSMS.ToString())
            {
                smsServiceFactory.AddGetSms(smsModel.Login, smsModel.Password);
            }

            if (smsModel.ProviderName == SmsProviderName.SmsTraffic.ToString())
            {
                smsServiceFactory.AddSmsTraffic(smsModel.Login, smsModel.Password);
            }

            var smsService = smsServiceFactory.Build();

            return smsService;
        }

        public override Task<SmsConnectorOutOptions?> GetOptions()
        {
            //todo: read from db. Where is the connection string? Local?
            throw new NotImplementedException();
        }

        public override Task SetOptions(SmsConnectorOutOptions? options)
        {
            //todo: write to db. Where is the connection string? Local?
            throw new NotImplementedException();
        }
    }
}
