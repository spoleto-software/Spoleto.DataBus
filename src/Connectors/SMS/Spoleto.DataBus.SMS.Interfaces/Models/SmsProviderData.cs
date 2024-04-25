namespace Spoleto.DataBus.SMS.Interfaces
{
    /// <summary>
    /// Additional SMS provider data.
    /// </summary>
    public record struct SmsProviderData
    {
        public SmsProviderData(string name, object value)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Value = value ?? throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Gets the name of the additinal data.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the value of the additinal data.
        /// </summary>
        public object Value { get; }
    }
}
