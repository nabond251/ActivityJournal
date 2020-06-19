// <copyright file="ItemDetailPage.xaml.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Views
{
    using System.ComponentModel;
    using SdgApps.TimeWise.ActivityJournal.Models;
    using SdgApps.TimeWise.ActivityJournal.ViewModels;
    using Xamarin.Forms;

    /// <summary>
    /// Item details screen.
    /// </summary>
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        private readonly ItemDetailViewModel viewModel;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDetailPage"/> class.
        /// </summary>
        /// <param name="viewModel">Backing view model.</param>
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            this.InitializeComponent();

            this.BindingContext = this.viewModel = viewModel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDetailPage"/> class.
        /// </summary>
        public ItemDetailPage()
        {
            this.InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description.",
            };

            this.viewModel = new ItemDetailViewModel(item);
            this.BindingContext = this.viewModel;
        }
    }
}
