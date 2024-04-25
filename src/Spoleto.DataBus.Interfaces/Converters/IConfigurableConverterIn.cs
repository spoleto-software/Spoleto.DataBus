using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The configurable input converter.
    /// </summary>
    public interface IConfigurableConverterIn : IConverterIn, IConfigurableConverter
    {
    }

    /// <summary>
    /// The configurable input converter with generic input and output data types and options type.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    /// <typeparam name="TOptions">The options type.</typeparam>
    public interface IConfigurableConverterIn<TInput, TOutput, TOptions> : 
        IConfigurableConverterIn, 
        IConverterIn<TInput, TOutput>, 
        IConfigurableConverter<TInput, TOutput, TOptions>
        where TInput : IConverterData
        where TOutput : IConverterData
        where TOptions : IConnectorOptions
    {
    }
}
