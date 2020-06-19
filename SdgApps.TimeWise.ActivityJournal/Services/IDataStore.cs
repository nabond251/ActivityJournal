// <copyright file="IDataStore.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Generic data store interface.
    /// </summary>
    /// <typeparam name="T">Type of data to store.</typeparam>
    public interface IDataStore<T>
    {
        /// <summary>
        /// Adds item to data store.
        /// </summary>
        /// <param name="item">Item to add.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> AddItemAsync(T item);

        /// <summary>
        /// Updates item in data store.
        /// </summary>
        /// <param name="item">Item to update.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> UpdateItemAsync(T item);

        /// <summary>
        /// Deletes item from data store.
        /// </summary>
        /// <param name="id">ID of item to delete.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> DeleteItemAsync(string id);

        /// <summary>
        /// Gets item from data store.
        /// </summary>
        /// <param name="id">ID of item to get.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<T> GetItemAsync(string id);

        /// <summary>
        /// Gets all items from data store.
        /// </summary>
        /// <param name="forceRefresh">True if cache should be ignored.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}
