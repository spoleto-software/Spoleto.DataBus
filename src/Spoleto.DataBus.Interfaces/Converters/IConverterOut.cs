using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The output converter.
    /// </summary>
    /// <typeparam name="TInput">The input data.</typeparam>
    /// <typeparam name="TOutput">The ouput data.</typeparam>
    public interface IConverterOut<TInput, TOutput> : IConverter<TInput, TOutput>
        where TInput : IConverterData
        where TOutput : IConverterData
    {
	}
}
