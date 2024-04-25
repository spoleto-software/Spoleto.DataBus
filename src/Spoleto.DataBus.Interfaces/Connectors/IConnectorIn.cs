using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Connectors
{
    /// <summary>
    /// The input connector.
    /// </summary>
    public interface IConnectorIn : IConnector
    {
    }

    /// <summary>
    /// The input connector with generic input and output data types.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public interface IConnectorIn<TInput, TOutput> : IConnectorIn, IConnector<TInput, TOutput>
        where TInput : IConnectorData
        where TOutput : IConnectorData
    {
    }
}
