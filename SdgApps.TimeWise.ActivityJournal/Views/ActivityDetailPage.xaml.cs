// <copyright file="ActivityDetailPage.xaml.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Views
{
    using System;
    using System.ComponentModel;
    using SdgApps.TimeWise.ActivityJournal.Models;
    using SdgApps.TimeWise.ActivityJournal.ViewModels;
    using Xamarin.Forms;

    /// <summary>
    /// Activity details screen.
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class ActivityDetailPage : ContentPage
    {
        private readonly ActivityDetailViewModel viewModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDetailPage"/> class.
        /// </summary>
        /// <param name="viewModel">Backing view model.</param>
        public ActivityDetailPage(ActivityDetailViewModel viewModel)
        {
            this.InitializeComponent();

            this.BindingContext = this.viewModel = viewModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDetailPage"/> class.
        /// </summary>
        public ActivityDetailPage()
        {
            this.InitializeComponent();

            var activity = new Activity
            {
                Title = "Activity 1",
                Start = DateTime.Now.AddHours(-1.0d),
                End = DateTime.Now,
                Description = "This is an activity description.",
                Category = "Activity",
            };

            this.viewModel = new ActivityDetailViewModel(activity);
            this.BindingContext = this.viewModel;
        }
    }
}
