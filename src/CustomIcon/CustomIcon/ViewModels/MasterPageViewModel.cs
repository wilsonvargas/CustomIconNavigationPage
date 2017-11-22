using CustomIcon.Models;
using CustomIcon.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIcon.ViewModels
{
    public class MasterPageViewModel : ViewModelBase
    {
        private List<MasterPageItem> _items;

        public List<MasterPageItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public MasterPageViewModel()
        {
            Items = new List<MasterPageItem>();
            Load();
        }

        private void Load()
        {
            Items.Add(new MasterPageItem
            {
                Title = "Option 1",
                Icon = "page1.png",
                Target = typeof(Page1)
            });
            Items.Add(new MasterPageItem
            {
                Title = "Option 2",
                Icon = "page2.png",
                Target = typeof(Page2)
            });
        }
    }
}
