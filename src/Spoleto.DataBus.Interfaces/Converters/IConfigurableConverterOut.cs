using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The configurable output converter.
    /// </summary>
    public interface IConfigurableConverterOut : IConverterOut, IConfigurableConverter
    {
    }

    /// <summary>
    /// The configurable output converter with generic input and output data types and options type.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    /// <typeparam name="TOptions">The options type.</typeparam>
    public interface IConfigurableConverterOut<TInput, TOutput, TOptions> : 
        IConfigurableConverterOut,
        IConverterOut<TInput, TOutput>,
        IConfigurableConverter<TInput, TOutput, TOptions>
        where TInput : IConverterData
        where TOutput : IConverterData
        where TOptions : IConnectorOptions
    {
	}
}
