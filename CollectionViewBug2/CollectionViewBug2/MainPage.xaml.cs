using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace CollectionViewBug2
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
