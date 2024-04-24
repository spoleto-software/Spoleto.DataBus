using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The output converter.
    /// </summary>
    public interface IConverterOut<TInput, TOutput> : IConverter<TInput, TOutput>
        where TInput : IConverterData
        where TOutput : IConverterData
    {
	}
}
