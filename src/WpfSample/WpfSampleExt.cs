// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WpfSampleExt.cs" company="Your company">
//   TODO: Update copyright text.
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SwissTool.Ext.WpfSample
{
    using System;
    using System.Reflection;
    using System.Windows;
    using System.Windows.Media.Imaging;

    using SwissTool.Ext.WpfSample.Managers;
    using SwissTool.Ext.WpfSample.Models;
    using SwissTool.Ext.WpfSample.ViewModels;
    using SwissTool.Ext.WpfSample.Views;
    using SwissTool.Framework.Commanding;
    using SwissTool.Framework.Enums;
    using SwissTool.Framework.Infrastructure;
    using SwissTool.Framework.UI.Managers;

    /// <summary>
    /// A WPF SwissTool extension sample.
    /// IMPORTANT: 
    /// Every extension has its own GUID so remember to re-generate the GUID for all extensions that 
    /// is created from this template. Insert at: Properties / Assembly Information / GUID.
    /// </summary>
    public class WpfSampleExt : ExtensionBase
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public override void Initialize()
        {
            this.InitiateMenuItems();
            this.InitiateActions();

            this.Icon = new BitmapImage(new Uri("/WpfSample;component/Resources/Images/Unknown.png", UriKind.RelativeOrAbsolute));

            var settings = this.LoadConfiguration<AppSettings>();

            ApplicationManager.Setup(this, settings);

            /* Put your initialization routines here */
        }

        /// <summary>
        /// Performs the first menu action.
        /// </summary>
        public void PerformFirstMenuAction()
        {
            MessageBox.Show(
                "This is the first menu action." + Environment.NewLine + Environment.NewLine + "Press CTRL + SHIFT + 1 to open this dialog.",
                "First action",
                MessageBoxButton.OK,
                MessageBoxImage.Information,
                MessageBoxResult.OK,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        /// <summary>
        /// Performs the second menu action.
        /// </summary>
        public void PerformSecondMenuAction()
        {
            MessageBox.Show(
                "This is the second menu action",
                "Second action",
                MessageBoxButton.OK,
                MessageBoxImage.Information,
                MessageBoxResult.OK,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        /// <summary>
        /// Shows the about window.
        /// </summary>
        public void ShowAboutWindow()
        {
            WindowManager.ShowDialog<AboutView>(new AboutViewModel
            {
                Model = new AboutModel(Assembly.GetExecutingAssembly())
            });
        }

        /// <summary>
        /// Initiates the menu items.
        /// </summary>
        private void InitiateMenuItems()
        {
            this.AddMenuItems(
                new ExtensionMenuItem
                    {
                        Name = "First context menu item", // The name that will be displayed in the UI.
                        Description = "Performs the first context menu command", // The tooltip of the menu alternative.
                        Icon = new BitmapImage(new Uri("/WpfSample;component/Resources/Images/Unknown.png", UriKind.RelativeOrAbsolute)), // Image path, set Build Action to Resource
                        Command = new RelayCommand(o => this.PerformFirstMenuAction()) // The method that does all the heavy work.
                    },
                new ExtensionMenuItem
                    {
                        Name = "Second context menu item",
                        Description = "Performs the second context menu command",
                        Icon = new BitmapImage(new Uri("/WpfSample;component/Resources/Images/Unknown.png", UriKind.RelativeOrAbsolute)),
                        Command = new RelayCommand(o => this.PerformSecondMenuAction())
                    },
                new ExtensionMenuItem
                    {
                        Name = "About WpfSample",
                        Description = "Shows the about window.",
                        Icon = new BitmapImage(new Uri("/WpfSample;component/Resources/Images/Unknown.png", UriKind.RelativeOrAbsolute)),
                        Command = new RelayCommand((o) => this.ShowAboutWindow())
                    });
        }

        /// <summary>
        /// Initiates the actions.
        /// </summary>
        private void InitiateActions()
        {
            this.AddActions(
                new ExtensionHotKeyAction
                    {
                        Identifier = "FirstActionHotkey", // Just an internal identifier, whatever you want, but should be unique for each action.
                        Name = "First hotkey action", // The name that will be displayed in the UI.
                        Description = "The first hotkey bindable action command", // The tooltip of the action.
                        Icon = new BitmapImage(new Uri("/WpfSample;component/Resources/Images/Unknown.png", UriKind.RelativeOrAbsolute)), // Image path, set Build Action to Resource
                        Command = new RelayCommand(o => this.PerformFirstMenuAction()), // The action command to execute.
                        DefaultHotKey = new ActionHotKey(HotKeyModifier.Control, HotKeyModifier.Shift, HotKey.D1) // The hotkey to bind to the action command.
                    });
        }
    }
}
