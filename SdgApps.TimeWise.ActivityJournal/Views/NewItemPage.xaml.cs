// <copyright file="NewItemPage.xaml.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Views
{
    using System;
    using System.ComponentModel;
    using SdgApps.TimeWise.ActivityJournal.Models;
    using Xamarin.Forms;

    /// <summary>
    /// Add new item screen.
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewItemPage"/> class.
        /// </summary>
        public NewItemPage()
        {
            this.InitializeComponent();

            this.Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description.",
            };

            this.BindingContext = this;
        }

        /// <summary>
        /// Gets or sets item being added.
        /// </summary>
        public Item Item { get; set; }

        private async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", this.Item);
            await this.Navigation.PopModalAsync();
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopModalAsync();
        }
    }
}
