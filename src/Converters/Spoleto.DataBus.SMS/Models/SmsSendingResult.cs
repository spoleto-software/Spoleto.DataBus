using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.SMS.Models
{
    /// <summary>
    /// The result of SMS sending.
    /// </summary>
    public record SmsSendingResult : Spoleto.SMS.SmsSendingResult, IConverterData
    {
    }
}
