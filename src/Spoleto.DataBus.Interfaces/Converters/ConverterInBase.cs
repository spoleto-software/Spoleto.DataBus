using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base class for input conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public abstract class ConverterInBase<TInput, TOutput> : ConverterBase<TInput, TOutput>, IConverterIn<TInput, TOutput>
        where TInput : IConverterData
        where TOutput : IConverterData
    {
    }
}
