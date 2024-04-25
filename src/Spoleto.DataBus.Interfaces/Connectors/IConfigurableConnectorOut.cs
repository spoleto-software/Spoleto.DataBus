using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Connectors
{
    /// <summary>
    /// The configurable output connector.
    /// </summary>
    public interface IConfigurableConnectorOut : IConnectorOut, IConfigurableConnector
    {
    }

    /// <summary>
    /// The configurable output connector with generic input and output data types and options type.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    /// <typeparam name="TOptions">The options type.</typeparam>
    public interface IConfigurableConnectorOut<TInput, TOutput, TOptions> : 
        IConfigurableConnectorOut,
        IConnectorOut<TInput, TOutput>,
        IConfigurableConnector<TInput, TOutput, TOptions>
        where TInput : IConnectorData
        where TOutput : IConnectorData
        where TOptions : IConnectorOptions
    {
	}
}
