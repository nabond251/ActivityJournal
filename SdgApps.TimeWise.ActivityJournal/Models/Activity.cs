// <copyright file="Activity.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Models
{
    using System;

    /// <summary>
    /// Activity model.
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets brief text.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the time the activity started.
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets the time the activity ended.
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// Gets or sets detailed description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the general activity category.
        /// </summary>
        public string Category { get; set; }
    }
}
