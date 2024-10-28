using System;
using System.Collections.Generic;
using System.Globalization;

namespace WVS.Abstractions.PluginSettings
{
    /// <summary>
    ///     Interface for plugin for plugin settings.
    /// </summary>
    public interface IPluginSettings
    {
        /// <summary>
        ///     Get child node by a slash-separated path (choosing always the first element).
        /// </summary>
        /// <exception cref="KeyNotFoundException"></exception>
        IPluginSettings GetNode(string key);

        /// <summary>
        ///     Get child node as output and output true/false if it is real.
        ///     `output` is set to null also if key was not found.
        /// </summary>
        bool TryGetNode(string key, out IPluginSettings? output);

        /// <summary>
        ///     Get a value and cast it from the nested tree.
        ///     Always the first item for a list is used.
        /// </summary>
        /// <exception cref="KeyNotFoundException"></exception>
        T GetValue<T>(string key);

        /// <summary>
        ///     Get a value (as output) and return whether it really existed.
        /// </summary>
        /// <see cref="GetValue" />
        bool TryGetValue<T>(string key, out T? output);


        /// <summary>
        ///     Get a value but return a default if the key does not exist.
        /// </summary>
        /// <see cref="GetValue" />
        T? GetValueOrDefault<T>(string key, T? defaultValue = default);

        /// <summary>
        ///     Get the value of this element - typically only when there are no children.
        /// </summary>
        public string GetValue();

        /// <summary>
        ///     Get the list of children, keyed by their names.
        /// </summary>
        public Dictionary<string, List<IPluginSettings>> GetChildren();
    }
}
