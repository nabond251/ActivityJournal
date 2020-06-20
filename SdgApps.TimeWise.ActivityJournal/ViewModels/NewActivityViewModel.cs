// <copyright file="NewActivityViewModel.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.ViewModels
{
    using System;
    using SdgApps.TimeWise.ActivityJournal.Models;

    /// <summary>
    /// View model for the Activity Detail screen.
    /// </summary>
    public class NewActivityViewModel : BaseViewModel
    {
        private DateTime startDate;
        private TimeSpan startTime;
        private DateTime endDate;
        private TimeSpan endTime;
        private string description;
        private string category;

        /// <summary>
        /// Initializes a new instance of the <see cref="NewActivityViewModel"/> class.
        /// </summary>
        /// <param name="activity">Activity whose details to view.</param>
        public NewActivityViewModel(Activity activity = null)
        {
            this.Title = activity?.Title;
        }

        /// <summary>
        /// Gets or sets the date the activity started.
        /// </summary>
        public DateTime StartDate
        {
            get => this.startDate;
            set => this.SetProperty(ref this.startDate, value);
        }

        /// <summary>
        /// Gets or sets the time the activity started.
        /// </summary>
        public TimeSpan StartTime
        {
            get => this.startTime;
            set => this.SetProperty(ref this.startTime, value);
        }

        /// <summary>
        /// Gets or sets the date the activity ended.
        /// </summary>
        public DateTime EndDate
        {
            get => this.endDate;
            set => this.SetProperty(ref this.endDate, value);
        }

        /// <summary>
        /// Gets or sets the time the activity ended.
        /// </summary>
        public TimeSpan EndTime
        {
            get => this.endTime;
            set => this.SetProperty(ref this.endTime, value);
        }

        /// <summary>
        /// Gets or sets detailed description.
        /// </summary>
        public string Description
        {
            get => this.description;
            set => this.SetProperty(ref this.description, value);
        }

        /// <summary>
        /// Gets or sets the general activity category.
        /// </summary>
        public string Category
        {
            get => this.category;
            set => this.SetProperty(ref this.category, value);
        }
    }
}
