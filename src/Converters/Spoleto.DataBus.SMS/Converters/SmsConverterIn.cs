using Spoleto.DataBus.Interfaces.Converters;
using Spoleto.DataBus.SMS.Models;

namespace Spoleto.DataBus.SMS.Converters
{
    /// <summary>
    /// The SMS input converter.
    /// </summary>
    /// <remarks>
    /// Gets the SMS model by Web API and returns it as is.
    /// </remarks>
    public class SmsConverterIn : ConverterInBase<SmsModel, SmsModel>
    {
        public override string Name => "SMS";

        public override string Description => "Gets the SMS model by Web API and returns it as is.";

        public override SmsModel Convert(SmsModel source) => source;
    }
}
