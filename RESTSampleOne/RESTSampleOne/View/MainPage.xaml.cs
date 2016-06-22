using RESTSampleOne.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RESTSampleOne.View
{
    public partial class MainPage : MasterDetailPage
    {
        MenuPage menuPage;
        public MainPage()
        {
            InitializeComponent();
            menuPage = new MenuPage();

            Master = menuPage;
            Detail = new NavigationPage(new DetailPage());

            menuPage.lstOptions.ItemSelected += 
                LstOptions_ItemSelected;
        }

        private void LstOptions_ItemSelected(object sender, 
            SelectedItemChangedEventArgs e)
        {
            Option item = e.SelectedItem as Option;
            if (item != null)
            {
                Detail = new NavigationPage(
                    (Page)Activator.CreateInstance(item.TargeType));
                menuPage.lstOptions.SelectedItem = null;
                IsPresented = false;
            }
        }   
    }
}
