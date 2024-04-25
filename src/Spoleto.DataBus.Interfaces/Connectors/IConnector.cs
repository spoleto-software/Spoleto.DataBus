using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Connectors
{
    /// <summary>
    /// The base connector.
    /// </summary>
    public interface IConnector
    {
        /// <summary>
        /// Gets the connector name.
        /// </summary>
        /// <remarks>
        /// The name has to be unique among input or output connectors.
        /// </remarks>
        string Name { get; }

        /// <summary>
        /// Gets the connector description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the input data type.
        /// </summary>
        Type InputType { get; }

        /// <summary>
        /// Gets the output data type.
        /// </summary>
        Type OutputType { get; }
    }

    /// <summary>
    /// The base connector with generic input and output data types..
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public interface IConnector<TInput, TOutput> : IConnector
        where TInput : IConnectorData
        where TOutput : IConnectorData
    {
        /// <summary>
        /// Converts the input data to output data.
        /// </summary>
        /// <param name="source">The input data.</param>
        /// <returns>The output data.</returns>
        TOutput Convert(TInput source);
    }
}
