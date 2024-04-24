using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The output converter.
    /// </summary>
    public interface IConverterOut : IConverter
    {
    }

    /// <summary>
    /// The output converter with generic input and output data types.
    /// </summary>
    /// <typeparam name="TInput">The input data.</typeparam>
    /// <typeparam name="TOutput">The ouput data.</typeparam>
    public interface IConverterOut<TInput, TOutput> : IConverterOut, IConverter<TInput, TOutput>
        where TInput : IConverterData
        where TOutput : IConverterData
    {
	}
}
