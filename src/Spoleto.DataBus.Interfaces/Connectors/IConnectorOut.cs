using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Connectors
{
    /// <summary>
    /// The output connector.
    /// </summary>
    public interface IConnectorOut : IConnector
    {
    }

    /// <summary>
    /// The output connector with generic input and output data types.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public interface IConnectorOut<TInput, TOutput> : IConnectorOut, IConnector<TInput, TOutput>
        where TInput : IConnectorData
        where TOutput : IConnectorData
    {
	}
}
