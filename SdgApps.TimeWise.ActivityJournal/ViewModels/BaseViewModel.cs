// <copyright file="BaseViewModel.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using SdgApps.TimeWise.ActivityJournal.Models;
    using SdgApps.TimeWise.ActivityJournal.Services;
    using Xamarin.Forms;

    /// <summary>
    /// Base view model class.
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool isBusy = false;
        private string title = string.Empty;

        /// <inheritdoc/>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the items data store.
        /// </summary>
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        /// <summary>
        /// Gets or sets a value indicating whether the view is busy.
        /// </summary>
        public bool IsBusy
        {
            get { return this.isBusy; }
            set { this.SetProperty(ref this.isBusy, value); }
        }

        /// <summary>
        /// Gets or sets view title.
        /// </summary>
        public string Title
        {
            get { return this.title; }
            set { this.SetProperty(ref this.title, value); }
        }

        /// <summary>
        /// Sets a property and invokes event on view if data changed.
        /// </summary>
        /// <typeparam name="T">Type of property.</typeparam>
        /// <param name="backingStore">Original property data.</param>
        /// <param name="value">New property data.</param>
        /// <param name="onChanged">Additional, optional callback to execute if data changed.</param>
        /// <param name="propertyName">Name of property whose data to set.</param>
        /// <returns>True if property changed sucessfully.</returns>
        protected bool SetProperty<T>(
            ref T backingStore,
            T value,
            Action onChanged = null,
            [CallerMemberName] string propertyName = "")
        {
            var retVal = false;

            if (!EqualityComparer<T>.Default.Equals(backingStore, value))
            {
                backingStore = value;
                onChanged?.Invoke();
                this.OnPropertyChanged(propertyName);
                retVal = true;
            }

            return retVal;
        }

        /// <summary>
        /// Invokes the <see cref="PropertyChanged"/> event.
        /// </summary>
        /// <param name="propertyName">Name of changed property.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
