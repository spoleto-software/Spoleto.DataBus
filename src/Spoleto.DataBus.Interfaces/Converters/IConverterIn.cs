using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The input converter.
    /// </summary>
	public interface IConverterIn<TInput, TOutput> : IConverter<TInput, TOutput> 
        where TInput : IConverterData
        where TOutput : IConverterData
    { 
    }
}
