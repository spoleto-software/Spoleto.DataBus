using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base class for input conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data.</typeparam>
    /// <typeparam name="TOutput">The ouput data.</typeparam>
    public abstract class ConverterOutBase<TInput, TOutput> : IConverterOut<TInput, TOutput>
        where TInput : IConverterData
        where TOutput : IConverterData
    {
        public abstract string Name { get; }
        public abstract string Description { get; }

        public abstract TOutput Convert(TInput source);

#if !NET5_0_OR_GREATER
        public Type InputType => typeof(TInput);

        public Type OutputType => typeof(TOutput);
#endif
    }
}
