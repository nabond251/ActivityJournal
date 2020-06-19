// <copyright file="MockDataStore.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SdgApps.TimeWise.ActivityJournal.Models;

    /// <summary>
    /// Mock data store implementation.
    /// </summary>
    public class MockDataStore : IDataStore<Item>
    {
        private readonly List<Item> items;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockDataStore"/> class.
        /// </summary>
        public MockDataStore()
        {
            this.items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description = "This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description = "This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description = "This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description = "This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description = "This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description = "This is an item description." },
            };
        }

        /// <inheritdoc/>
        public async Task<bool> AddItemAsync(Item item)
        {
            this.items.Add(item);

            return await Task.FromResult(true);
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = this.items.FirstOrDefault((Item arg) => arg.Id == item.Id);
            this.items.Remove(oldItem);
            this.items.Add(item);

            return await Task.FromResult(true);
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = this.items.FirstOrDefault((Item arg) => arg.Id == id);
            this.items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        /// <inheritdoc/>
        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(this.items.FirstOrDefault(s => s.Id == id));
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(this.items);
        }
    }
}
