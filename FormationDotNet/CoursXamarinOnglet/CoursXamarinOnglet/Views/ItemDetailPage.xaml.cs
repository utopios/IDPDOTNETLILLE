using CoursXamarinOnglet.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CoursXamarinOnglet.Views
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