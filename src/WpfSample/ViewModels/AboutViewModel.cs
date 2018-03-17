// -----------------------------------------------------------------------
// <copyright file="AboutViewModel.cs" company="Your company">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace SwissTool.Ext.WpfSample.ViewModels
{
    using SwissTool.Ext.WpfSample.Models;
    using SwissTool.Framework.UI.Infrastructure;

    /// <summary>
    /// The about view model.
    /// </summary>
    public class AboutViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public AboutModel Model { get; set; }

        /// <summary>
        /// Gets the version display string.
        /// </summary>
        public string VersionDisplayString
        {
            get
            {
                if (this.Model == null)
                {
                    return string.Empty;
                }

                return $"Version {this.Model.Version.Major}.{this.Model.Version.Minor}.{this.Model.Version.Build}";
            }
        }
    }
}
