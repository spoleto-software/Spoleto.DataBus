using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.SMS.Interfaces
{
    public class SmsConnectorOutOptions : IConnectorOptions
    {
        /// <summary>
        /// Gets or sets the connection string with specific connector options.
        /// </summary>
        public string ConnectionString { get; set; }
    }
}
