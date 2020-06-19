// <copyright file="ActivitiesViewModel.cs" company="Soli Deo Gloria Apps">
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
    /// View model for the activities list screen.
    /// </summary>
    public class ActivitiesViewModel : BaseViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitiesViewModel"/> class.
        /// </summary>
        public ActivitiesViewModel()
        {
            this.Title = "Browse";
            this.Activities = new ObservableCollection<Activity>();
            this.LoadActivitiesCommand = new Command(async () => await this.ExecuteLoadActivitiesCommand());

            MessagingCenter.Subscribe<NewActivityPage, Activity>(this, "AddActivity", async (obj, act) =>
            {
                var newActivity = act;
                this.Activities.Add(newActivity);
                await this.DataStore.AddItemAsync(newActivity);
            });
        }

        /// <summary>
        /// Gets or sets activities list to view.
        /// </summary>
        public ObservableCollection<Activity> Activities { get; set; }

        /// <summary>
        /// Gets or sets command to load activities list.
        /// </summary>
        public Command LoadActivitiesCommand { get; set; }

        private async Task ExecuteLoadActivitiesCommand()
        {
            this.IsBusy = true;

            try
            {
                this.Activities.Clear();
                var activities = await this.DataStore.GetItemsAsync(true);
                foreach (var activity in activities)
                {
                    this.Activities.Add(activity);
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
