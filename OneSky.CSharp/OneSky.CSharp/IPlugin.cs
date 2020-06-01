using System;

namespace OneSky.CSharp
{
    /// <summary>
    /// Plugin API access interface.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Provides access Account resources.
        /// </summary>
        IPluginAccount Account { get; }

        /// <summary>
        /// Provides access Locale resources.
        /// </summary>
        IPluginLocale Locale { get; }

        /// <summary>
        /// Provides access Specialization resources.
        /// </summary>
        IPluginSpecialization Specialization { get; }

        /// <summary>
        /// Provides access Project resources.
        /// </summary>
        IPluginProject Project { get; }

        /// <summary>
        /// Provides access Item resources.
        /// </summary>
        [Obsolete("Plugin Items endpoints were removed from official documentation. Will be completely removed in 2.0", false)]
        IPluginItem Item { get; }

        /// <summary>
        /// Provides access Order resources.
        /// </summary>
        IPluginOrder Order { get; }

        /// <summary>
        /// Provides access Quotation resources.
        /// </summary>
        IPluginQuotation Quotation { get; }

        /// <summary>
        /// Provides access Language Pair resources.
        /// </summary>
        IPluginLanguagePair LanguagePair { get; }
    }
}