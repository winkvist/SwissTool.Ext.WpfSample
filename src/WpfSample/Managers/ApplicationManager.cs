// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApplicationManager.cs" company="Winkvist.com">
//   Copyright (c) 2012 Winkvist.com. All rights reserved.
// </copyright>
// <summary>
//   The application manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Ext.WpfSample.Managers
{
    using SwissTool.Ext.WpfSample.Models;
    using SwissTool.Framework.Definitions;

    /// <summary>
    /// The application manager.
    /// </summary>
    public static class ApplicationManager
    {
        /// <summary>
        /// Gets the application.
        /// </summary>
        /// <value>The application.</value>
        internal static IApplication Application { get; private set; }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <value>The settings.</value>
        internal static AppSettings Settings { get; private set; }

        /// <summary>
        /// Setups the specified application.
        /// </summary>
        /// <param name="application">The application.</param>
        /// <param name="settings">The settings.</param>
        internal static void Setup(IApplication application, AppSettings settings)
        {
            Application = application;
            Settings = settings;
        }

        /// <summary>
        /// Saves the settings.
        /// </summary>
        internal static void SaveSettings()
        {
            Application.SaveConfiguration(Settings);
        }
    }
}
