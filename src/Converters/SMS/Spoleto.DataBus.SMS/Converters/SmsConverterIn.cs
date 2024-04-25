using Spoleto.DataBus.Interfaces.Converters;
using Spoleto.DataBus.SMS.Interfaces;

namespace Spoleto.DataBus.SMS.Converters
{
    /// <summary>
    /// The SMS input converter.
    /// </summary>
    /// <remarks>
    /// Gets the SMS model by Web API and returns it as is.
    /// </remarks>
    public class SmsConverterIn : ConverterInBase<SmsModelIn, SmsModelIn>
    {
        public const string ConnectorName = "SMS"; //todo: add "In" ?

        public override string Name => ConnectorName;

        public override string Description => "Gets the SMS model by Web API and returns it as is.";

        public override SmsModelIn Convert(SmsModelIn source) => source;
    }
}
