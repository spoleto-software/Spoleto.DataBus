using Spoleto.DataBus.Interfaces.Converters;
using Spoleto.DataBus.SMS.Models;

namespace Spoleto.DataBus.SMS.Converters
{
    public class SmsConverterIn : IConverterIn<SmsModel, SmsModel>
    {
        public string Name => "SMS";

        public string Description => "Gets the SMS model by Web API and returns it as is.";

        public SmsModel Convert(SmsModel source) => source;

#if !NET5_0_OR_GREATER
        public Type InputType => typeof(SmsModel);

        public Type OutputType => typeof(SmsModel);
#endif
    }
}
