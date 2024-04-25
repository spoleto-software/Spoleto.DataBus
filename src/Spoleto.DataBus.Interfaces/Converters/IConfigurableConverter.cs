using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base configurable converter with options.
    /// </summary>
    public interface IConfigurableConverter : IConverter
    {
        /// <summary>
        /// Gets the options type.
        /// </summary>
        Type OptionsType { get; }
    }

    /// <summary>
    /// The base configurable converter with generic input and output data types and options type.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    /// <typeparam name="TOptions">The options type.</typeparam>
    public interface IConfigurableConverter<TInput, TOutput, TOptions> : IConfigurableConverter, IConverter<TInput, TOutput>
        where TInput : IConverterData
        where TOutput : IConverterData
        where TOptions : IConnectorOptions
    {        
        /// <summary>
        /// Gets the converter options.
        /// </summary>
        /// <returns>The converter options.</returns>
        Task<TOptions?> GetOptions();

        /// <summary>
        /// Sets the converter options.
        /// </summary>
        /// <param name="options">The converter options to set.</param>
        Task SetOptions(TOptions options);
    }
}
