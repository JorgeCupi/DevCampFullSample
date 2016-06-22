using RESTSampleOne.ViewModel;

using Xamarin.Forms;

namespace RESTSampleOne.View
{
    public partial class MenuPage : ContentPage
    {
        public ListView lstOptions { get; set; }

        public MenuPage()
        {
            InitializeComponent();

            MenuPageViewModel menuPageViewModel = new MenuPageViewModel();
            BindingContext = menuPageViewModel;

            lstOptions = new ListView();
            lstOptions.ItemsSource = menuPageViewModel.Options;
            lstOptions.ItemTemplate = new DataTemplate(() => {
                var imageCell = new ImageCell();
                imageCell.SetBinding(TextCell.TextProperty, "optionName");
                imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                return imageCell;
            });
            lstOptions.VerticalOptions = LayoutOptions.FillAndExpand;
            lstOptions.SeparatorVisibility = SeparatorVisibility.None;

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { lstOptions }
            };
        }
    }
}
