using System;
using System.Collections.Generic;
using SampleDataBinding.ViewModels;
using Xamarin.Forms;

namespace SampleDataBinding.Views
{
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {

            BindingContext = new ProductsPageViewModel();

            InitializeComponent();
        }
    }
}
