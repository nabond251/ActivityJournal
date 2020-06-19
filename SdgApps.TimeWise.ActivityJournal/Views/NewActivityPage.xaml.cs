// <copyright file="NewActivityPage.xaml.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Views
{
    using System;
    using System.ComponentModel;
    using SdgApps.TimeWise.ActivityJournal.Models;
    using Xamarin.Forms;

    /// <summary>
    /// Add new activity screen.
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class NewActivityPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewActivityPage"/> class.
        /// </summary>
        public NewActivityPage()
        {
            this.InitializeComponent();

            this.Activity = new Activity
            {
                Title = "Activity name",
                Start = DateTime.Now.AddHours(-1.0d),
                End = DateTime.Now,
                Description = "This is an activity description.",
                Category = "Activity",
            };

            this.BindingContext = this;
        }

        /// <summary>
        /// Gets or sets activity being added.
        /// </summary>
        public Activity Activity { get; set; }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddActivity", this.Activity);
            await this.Navigation.PopModalAsync();
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}
