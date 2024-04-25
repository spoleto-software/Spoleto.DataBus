using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Connectors
{
    /// <summary>
    /// The base class for configurable input conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data type.</typeparam>
    /// <typeparam name="TOutput">The ouput data type.</typeparam>
    /// <typeparam name="TOptions">The options type.</typeparam>
    public abstract class ConfigurableConnectorInBase<TInput, TOutput, TOptions> :
        ConfigurableConnectorBase<TInput, TOutput, TOptions>,
        IConfigurableConnectorIn<TInput, TOutput, TOptions>
        where TInput : IConnectorData
        where TOutput : IConnectorData
        where TOptions : IConnectorOptions
    {
    }
}
