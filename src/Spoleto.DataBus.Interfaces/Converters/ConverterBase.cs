using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base class for conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    public abstract class ConverterBase<TInput, TOutput> : IConverter<TInput, TOutput>
        where TInput : IConverterData
        where TOutput : IConverterData
    {
        public abstract string Name { get; }

        public abstract string Description { get; }

        public abstract TOutput Convert(TInput source);

        public Type InputType => typeof(TInput);

        public Type OutputType => typeof(TOutput);
    }
}
