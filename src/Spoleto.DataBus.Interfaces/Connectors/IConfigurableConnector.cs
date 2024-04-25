using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Connectors
{
    /// <summary>
    /// The base configurable connector with options.
    /// </summary>
    public interface IConfigurableConnector : IConnector
    {
        /// <summary>
        /// Gets the options type.
        /// </summary>
        Type OptionsType { get; }
    }

    /// <summary>
    /// The base configurable connector with generic input and output data types and options type.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    /// <typeparam name="TOptions">The options type.</typeparam>
    public interface IConfigurableConnector<TInput, TOutput, TOptions> : IConfigurableConnector, IConnector<TInput, TOutput>
        where TInput : IConnectorData
        where TOutput : IConnectorData
        where TOptions : IConnectorOptions
    {        
        /// <summary>
        /// Gets the connector options.
        /// </summary>
        /// <returns>The connector options.</returns>
        Task<TOptions?> GetOptions();

        /// <summary>
        /// Sets the connector options.
        /// </summary>
        /// <param name="options">The connector options to set.</param>
        Task SetOptions(TOptions options);
    }
}
