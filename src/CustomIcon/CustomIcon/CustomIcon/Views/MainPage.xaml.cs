using CustomIcon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomIcon.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Master = masterPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Page1)));
            masterPage.ListView.ItemSelected += OnItemSelected;
            MasterBehavior = MasterBehavior.Popover;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
