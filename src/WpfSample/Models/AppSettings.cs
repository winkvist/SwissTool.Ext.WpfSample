// -----------------------------------------------------------------------
// <copyright file="AppSettings.cs" company="Your company">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace SwissTool.Ext.WpfSample.Models
{
    /// <summary>
    /// The application settings class.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppSettings"/> class.
        /// </summary>
        public AppSettings()
        {
            this.ABooleanSetting = false;
            this.AStringSetting = string.Empty;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [A boolean setting].
        /// </summary>
        /// <value><c>true</c> if [A boolean setting]; otherwise, <c>false</c>.</value>
        public bool ABooleanSetting { get; set; }

        /// <summary>
        /// Gets or sets the string setting.
        /// </summary>
        /// <value>The string setting.</value>
        public string AStringSetting { get; set; }
    }
}
