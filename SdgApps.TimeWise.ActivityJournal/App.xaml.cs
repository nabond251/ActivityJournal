// <copyright file="App.xaml.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal
{
    using SdgApps.TimeWise.ActivityJournal.Services;
    using Xamarin.Forms;

    /// <summary>
    /// Top-level cross-platform application class.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            this.InitializeComponent();

            DependencyService.Register<MockDataStore>();
            this.MainPage = new AppShell();
        }
    }
}
