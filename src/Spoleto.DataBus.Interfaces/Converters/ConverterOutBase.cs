using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base class for input conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public abstract class ConverterOutBase<TInput, TOutput> : ConverterBase<TInput, TOutput>, IConverterOut<TInput, TOutput>
        where TInput : IConverterData
        where TOutput : IConverterData
    {
    }
}
