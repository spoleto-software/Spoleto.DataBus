using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base class for configurable conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    /// <typeparam name="TOptions">The options type.</typeparam>
    public abstract class ConfigurableConverterBase<TInput, TOutput, TOptions> :
        ConverterBase<TInput, TOutput>,
        IConfigurableConverter<TInput, TOutput, TOptions>
        where TInput : IConverterData
        where TOutput : IConverterData
        where TOptions : IConnectorOptions
    {
        public abstract Task<TOptions?> GetOptions();

        public abstract Task SetOptions(TOptions? options);

        public Type OptionsType => typeof(TOptions);
    }
}
