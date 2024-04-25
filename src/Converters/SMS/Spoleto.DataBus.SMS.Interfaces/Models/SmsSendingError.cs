namespace Spoleto.DataBus.SMS.Interfaces
{
    /// <summary>
    /// The SMS sending errors.
    /// </summary>
    public record SmsSendingError
    {
        /// <summary>
        /// Gets the error code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets the numeric error code.
        /// </summary>
        public int NumCode { get; set; }

        public int Error { get; set; }

        public string Recipient { get; set; }

        public string Text { get; set; }

        public int UserId { get; set; }

        public DateTime DateReceived { get; set; }

        public int MessageId { get; set; }

        public int RequestId { get; set; }

        public string ClientIp { get; set; }
    }
}