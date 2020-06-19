// <copyright file="ItemDetailViewModel.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.ViewModels
{
    using SdgApps.TimeWise.ActivityJournal.Models;

    /// <summary>
    /// View model for the Item Detail screen.
    /// </summary>
    public class ItemDetailViewModel : BaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemDetailViewModel"/> class.
        /// </summary>
        /// <param name="item">Item whose details to view.</param>
        public ItemDetailViewModel(Item item = null)
        {
            this.Title = item?.Text;
            this.Item = item;
        }

        /// <summary>
        /// Gets or sets viewed item.
        /// </summary>
        public Item Item { get; set; }
    }
}
