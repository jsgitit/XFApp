using Xamarin.Forms;
using XFApp.ViewModels;

namespace XFApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        private ItemDetailViewModel viewModel;
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = this.viewModel = viewModel;
        }
    }
}