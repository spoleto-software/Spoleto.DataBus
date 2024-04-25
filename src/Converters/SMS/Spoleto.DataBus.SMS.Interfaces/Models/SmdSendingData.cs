namespace Spoleto.DataBus.SMS.Interfaces
{
    /// <summary>
    /// The SMS sending data.
    /// </summary>
    public record SmdSendingData
    {
        public long Recipient {  get; set; }

        public string Text { get; set; }

        public int UserId { get; set; }

        public DateTime DateReceived { get; set; }

        public long MessageId { get; set; }

        public int RequestId { get; set; }

        public string ClientIp { get; set; }
    }
}