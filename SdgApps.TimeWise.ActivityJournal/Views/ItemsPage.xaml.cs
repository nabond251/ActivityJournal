// <copyright file="ItemsPage.xaml.cs" company="Soli Deo Gloria Apps">
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
    /// Items list screen.
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        private readonly ItemsViewModel viewModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsPage"/> class.
        /// </summary>
        public ItemsPage()
        {
            this.InitializeComponent();

            this.BindingContext = this.viewModel = new ItemsViewModel();
        }

        /// <inheritdoc/>
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (this.viewModel.Items.Count == 0)
            {
                this.viewModel.IsBusy = true;
            }
        }

        private async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Item)layout.BindingContext;
            await this.Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        }

        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }
    }
}
