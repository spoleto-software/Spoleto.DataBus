using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base converter.
    /// </summary>
    /// <typeparam name="TInput">The input data.</typeparam>
    /// <typeparam name="TOutput">The ouput data.</typeparam>
    public interface IConverter<TInput, TOutput> 
        where TInput : IConverterData
        where TOutput : IConverterData
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
        /// Converts the input data to output data.
        /// </summary>
        /// <param name="source">The input data.</param>
        /// <returns>The output data.</returns>
        TOutput Convert(TInput source);

#if NET5_0_OR_GREATER
        /// <summary>
        /// Gets the input data type.
        /// </summary>
        Type InputType => typeof(TInput);

        /// <summary>
        /// Gets the output data type.
        /// </summary>
        Type OutputType => typeof(TOutput);
#else
        /// <summary>
        /// Gets the input data type.
        /// </summary>
        Type InputType { get; }

        /// <summary>
        /// Gets the output data type.
        /// </summary>
        Type OutputType { get; }
#endif

    }
}
