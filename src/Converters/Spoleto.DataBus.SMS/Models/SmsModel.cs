using Spoleto.DataBus.Interfaces.Models;
using Spoleto.SMS;

namespace Spoleto.DataBus.SMS.Models
{
    /// <summary>
    /// The full information about SMS to send.
    /// </summary>
    public record SmsModel : IConverterData
    {
        /// <summary>
        /// Gets or sets the message body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the phone number or another ID of the sender.
        /// </summary>
        public string? From { get; set; }

        /// <summary>
        /// Gets or sets the phone numbers of recipients to send the SMS message to.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets or sets whether sending this message to foreign numbers is allowed.
        /// </summary>
        public bool IsAllowSendToForeignNumbers { get; set; }

        /// <summary>
        /// Gets or sets the additional provider data.
        /// </summary>
        public List<SmsProviderData> ProviderData { get; set; }

        /// <summary>
        /// Gets or sets the Sms provider used to send the message.
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or sets the Sms provider login used to send the message.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Gets or sets the Sms provider password used to send the message.
        /// </summary>
        public string Password { get; set; }
    }
}
