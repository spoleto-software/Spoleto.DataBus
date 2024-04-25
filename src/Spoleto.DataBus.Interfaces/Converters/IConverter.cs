using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base converter.
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// Gets the converter name.
        /// </summary>
        /// <remarks>
        /// The name has to be unique among input or output converters.
        /// </remarks>
        string Name { get; }

        /// <summary>
        /// Gets the converter description.
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
    /// The base converter with generic input and output data types..
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public interface IConverter<TInput, TOutput> : IConverter
        where TInput : IConverterData
        where TOutput : IConverterData
    {
        /// <summary>
        /// Converts the input data to output data.
        /// </summary>
        /// <param name="source">The input data.</param>
        /// <returns>The output data.</returns>
        TOutput Convert(TInput source);
    }
}
