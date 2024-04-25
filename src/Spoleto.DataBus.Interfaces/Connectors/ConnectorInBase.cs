using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Connectors
{
    /// <summary>
    /// The base class for input conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public abstract class ConnectorInBase<TInput, TOutput> : ConnectorBase<TInput, TOutput>, IConnectorIn<TInput, TOutput>
        where TInput : IConnectorData
        where TOutput : IConnectorData
    {
    }
}
