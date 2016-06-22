using RESTSampleOne.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RESTSampleOne.View
{
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();

            UserPageViewModel vm = new UserPageViewModel();
            BindingContext = vm;
        }
    }
}
