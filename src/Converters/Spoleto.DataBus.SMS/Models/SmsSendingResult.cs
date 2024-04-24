using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.SMS.Models
{
    public record SmsSendingResult : Spoleto.SMS.SmsSendingResult, IConverterData
    {
    }
}
