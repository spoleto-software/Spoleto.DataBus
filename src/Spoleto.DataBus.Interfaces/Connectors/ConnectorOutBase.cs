using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Connectors
{
    /// <summary>
    /// The base class for input conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public abstract class ConnectorOutBase<TInput, TOutput> : ConnectorBase<TInput, TOutput>, IConnectorOut<TInput, TOutput>
        where TInput : IConnectorData
        where TOutput : IConnectorData
    {
    }
}
