using Spoleto.DataBus.Interfaces.Converters;
using Spoleto.DataBus.SMS.Models;
using Spoleto.SMS;


namespace Spoleto.DataBus.SMS.Converters
{
    public class SmsConverterOut : IConverterOut<SmsModel, Spoleto.DataBus.SMS.Models.SmsSendingResult>
    {
        public string Name => "SMS";

        public string Description => "Makes the HTTP request to the SMS service, receives the respond and returns it as output.";

        public Spoleto.DataBus.SMS.Models.SmsSendingResult Convert(SmsModel source)
        {
            var smsMessage = new SmsMessage(source.Body, source.From, source.To, source.IsAllowSendToForeignNumbers, source.ProviderData);
            var smsService = SmsConverterOut.CreateSmsService(source);
            var result = smsService.Send(source.ProviderName, smsMessage);

            var dataResult = new Spoleto.DataBus.SMS.Models.SmsSendingResult
            {
                ProviderName = source.ProviderName,
                Errors = result.Errors,
                SmsSendingData = result.SmsSendingData,
                Success = result.Success
            };

            return dataResult;
        }

        //todo: make cache of SMS services ? (with the same provider + login + pwd)
        private static ISmsService CreateSmsService(SmsModel smsModel)
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

#if !NET5_0_OR_GREATER
        public Type InputType => typeof(SmsModel);

        public Type OutputType => typeof(SmsSendingResult);
#endif
    }
}
