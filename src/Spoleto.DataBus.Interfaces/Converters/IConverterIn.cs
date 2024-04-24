using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The input converter.
    /// </summary>
    public interface IConverterIn : IConverter
    {
    }

    /// <summary>
    /// The input converter with generic input and output data types.
    /// </summary>
    /// <typeparam name="TInput">The input data.</typeparam>
    /// <typeparam name="TOutput">The ouput data.</typeparam>
    public interface IConverterIn<TInput, TOutput> : IConverterIn, IConverter<TInput, TOutput> 
        where TInput : IConverterData
        where TOutput : IConverterData
    { 
    }
}
