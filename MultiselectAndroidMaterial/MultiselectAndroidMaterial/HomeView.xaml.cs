using MultiselectAndroidMaterial.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MultiselectAndroidMaterial
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            LoadTestData();
        }

        private void LoadTestData()
        {
            //MultiSelectListView
            List<MultiselectListViewItem> itemsList = new List<CustomControls.MultiselectListViewItem>();
            for (int i = 0; i < 30; i++)
            {
                MultiselectListViewItem item = new CustomControls.MultiselectListViewItem("Test " + i);
                itemsList.Add(item);
            }

            MultiSelectListView.ItemsSource = itemsList;
        }
    }

   
}
