using ProjectV1VB.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProjectV1VB.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}