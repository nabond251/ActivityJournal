// <copyright file="ActivitiesPage.xaml.cs" company="Soli Deo Gloria Apps">
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
    /// Activities list screen.
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class ActivitiesPage : ContentPage
    {
        private readonly ActivitiesViewModel viewModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesPage"/> class.
        /// </summary>
        public ActivitiesPage()
        {
            this.InitializeComponent();

            this.BindingContext = this.viewModel = new ActivitiesViewModel();
        }

        /// <inheritdoc/>
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (this.viewModel.Activities.Count == 0)
            {
                this.viewModel.IsBusy = true;
            }
        }

        private async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var activity = (Activity)layout.BindingContext;
            await this.Navigation.PushAsync(new ActivityDetailPage(new ActivityDetailViewModel(activity)));
        }

        private async void AddActivity_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new NewActivityPage()));
        }
    }
}
