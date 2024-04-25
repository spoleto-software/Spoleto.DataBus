using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.SMS.Interfaces
{
    /// <summary>
    /// The result of SMS sending.
    /// </summary>
    public record SmsModelOut : IConnectorData
    {
        /// <summary>
        /// Gets or sets if the SMS has been sent successfully.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the name of the provider used to send the SMS.
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or sets the data about the sms sending.
        /// </summary>
        public IEnumerable<SmdSendingData> SmsSendingData { get; set; }

        /// <summary>
        /// Gets or sets the errors associated with the sending failure.
        /// </summary>
        public IEnumerable<SmsSendingError> Errors { get; set; }
    }
}
