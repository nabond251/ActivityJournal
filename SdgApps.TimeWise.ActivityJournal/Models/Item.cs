// <copyright file="Item.cs" company="Soli Deo Gloria Apps">
// Copyright (c) Soli Deo Gloria Apps. All rights reserved.
// </copyright>

namespace SdgApps.TimeWise.ActivityJournal.Models
{
    /// <summary>
    /// Item model.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets ID.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets brief text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets detailed description.
        /// </summary>
        public string Description { get; set; }
    }
}
