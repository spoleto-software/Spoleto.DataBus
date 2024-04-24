﻿using Spoleto.DataBus.Interfaces.Models;

namespace Spoleto.DataBus.Interfaces.Converters
{
    /// <summary>
    /// The base class for input conveters.
    /// </summary>
    /// <typeparam name="TInput">The input data.</typeparam>
    /// <typeparam name="TOutput">The ouput data.</typeparam>
    public abstract class ConverterInBase<TInput, TOutput> : IConverterIn<TInput, TOutput>
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
