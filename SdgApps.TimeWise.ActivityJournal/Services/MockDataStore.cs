﻿// <copyright file="MockDataStore.cs" company="Soli Deo Gloria Apps">
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
    public class MockDataStore : IDataStore<Activity>
    {
        private readonly List<Activity> activities;

        /// <summary>
        /// Initializes a new instance of the <see cref="MockDataStore"/> class.
        /// </summary>
        public MockDataStore()
        {
            this.activities = new List<Activity>()
            {
                new Activity { Id = Guid.NewGuid().ToString(), Title = "First item", Description = "This is an item description." },
                new Activity { Id = Guid.NewGuid().ToString(), Title = "Second item", Description = "This is an item description." },
                new Activity { Id = Guid.NewGuid().ToString(), Title = "Third item", Description = "This is an item description." },
                new Activity { Id = Guid.NewGuid().ToString(), Title = "Fourth item", Description = "This is an item description." },
                new Activity { Id = Guid.NewGuid().ToString(), Title = "Fifth item", Description = "This is an item description." },
                new Activity { Id = Guid.NewGuid().ToString(), Title = "Sixth item", Description = "This is an item description." },
            };
        }

        /// <inheritdoc/>
        public Task<bool> AddItemAsync(Activity item)
        {
            this.activities.Add(item);

            return Task.FromResult(true);
        }

        /// <inheritdoc/>
        public Task<bool> UpdateItemAsync(Activity item)
        {
            var oldActivity = this.activities.FirstOrDefault((a) => a.Id == item.Id);
            this.activities.Remove(oldActivity);
            this.activities.Add(item);

            return Task.FromResult(true);
        }

        /// <inheritdoc/>
        public Task<bool> DeleteItemAsync(string id)
        {
            var oldActivity = this.activities.FirstOrDefault((Activity arg) => arg.Id == id);
            this.activities.Remove(oldActivity);

            return Task.FromResult(true);
        }

        /// <inheritdoc/>
        public Task<Activity> GetItemAsync(string id)
        {
            return Task.FromResult(this.activities.FirstOrDefault(s => s.Id == id));
        }

        /// <inheritdoc/>
        public Task<IEnumerable<Activity>> GetItemsAsync(bool forceRefresh = false)
        {
            return Task.FromResult<IEnumerable<Activity>>(this.activities);
        }
    }
}
