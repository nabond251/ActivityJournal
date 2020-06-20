// <copyright file="NewActivityPage.xaml.cs" company="Soli Deo Gloria Apps">
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
    /// Add new activity screen.
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class NewActivityPage : ContentPage
    {
        private readonly NewActivityViewModel viewModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewActivityPage"/> class.
        /// </summary>
        public NewActivityPage()
        {
            this.InitializeComponent();

            var now = DateTime.Now;
            var then = now.AddHours(-1.0d);

            this.viewModel = new NewActivityViewModel
            {
                Title = "Activity name",
                StartDate = then.Date,
                StartTime = then.TimeOfDay,
                EndDate = now.Date,
                EndTime = now.TimeOfDay,
                Description = "This is an activity description.",
                Category = "Activity",
            };

            this.BindingContext = this.viewModel;
        }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            var activity = new Activity
            {
                Title = this.viewModel.Title,
                Start = this.viewModel.StartDate.Date + this.viewModel.StartTime,
                End = this.viewModel.EndDate.Date + this.viewModel.EndTime,
                Description = this.viewModel.Description,
                Category = this.viewModel.Category,
            };

            MessagingCenter.Send(this, "AddActivity", activity);
            await this.Navigation.PopModalAsync();
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}
