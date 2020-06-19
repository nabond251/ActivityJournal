// <copyright file="ItemsViewModel.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using SdgApps.TimeWise.ActivityJournal.Models;
    using SdgApps.TimeWise.ActivityJournal.Views;
    using Xamarin.Forms;

    /// <summary>
    /// View model for the items list screen.
    /// </summary>
    public class ItemsViewModel : BaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemsViewModel"/> class.
        /// </summary>
        public ItemsViewModel()
        {
            this.Title = "Browse";
            this.Items = new ObservableCollection<Item>();
            this.LoadItemsCommand = new Command(async () => await this.ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item;
                this.Items.Add(newItem);
                await this.DataStore.AddItemAsync(newItem);
            });
        }

        /// <summary>
        /// Gets or sets items list to view.
        /// </summary>
        public ObservableCollection<Item> Items { get; set; }

        /// <summary>
        /// Gets or sets command to load items list.
        /// </summary>
        public Command LoadItemsCommand { get; set; }

        private async Task ExecuteLoadItemsCommand()
        {
            this.IsBusy = true;

            try
            {
                this.Items.Clear();
                var items = await this.DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    this.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                this.IsBusy = false;
            }
        }
    }
}
