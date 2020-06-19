// <copyright file="ActivityDetailViewModel.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.ViewModels
{
    using SdgApps.TimeWise.ActivityJournal.Models;

    /// <summary>
    /// View model for the Activity Detail screen.
    /// </summary>
    public class ActivityDetailViewModel : BaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDetailViewModel"/> class.
        /// </summary>
        /// <param name="activity">Activity whose details to view.</param>
        public ActivityDetailViewModel(Activity activity = null)
        {
            this.Title = activity?.Title;
            this.Activity = activity;
        }

        /// <summary>
        /// Gets or sets viewed activity.
        /// </summary>
        public Activity Activity { get; set; }
    }
}
