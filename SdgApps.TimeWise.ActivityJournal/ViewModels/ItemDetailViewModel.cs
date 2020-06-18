using System;

using SdgApps.TimeWise.ActivityJournal.Models;

namespace SdgApps.TimeWise.ActivityJournal.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
