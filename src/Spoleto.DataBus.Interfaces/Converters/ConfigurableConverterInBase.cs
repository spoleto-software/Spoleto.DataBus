using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base class for configurable input conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    /// <typeparam name="TOptions">The options type.</typeparam>
    public abstract class ConfigurableConverterInBase<TInput, TOutput, TOptions> :
        ConfigurableConverterBase<TInput, TOutput, TOptions>,
        IConfigurableConverterIn<TInput, TOutput, TOptions>
        where TInput : IConverterData
        where TOutput : IConverterData
        where TOptions : IConnectorOptions
    {
    }
}
