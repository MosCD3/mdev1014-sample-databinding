using System;
using System.Collections.Generic;
using SampleDataBinding.ViewModels;
using Xamarin.Forms;

namespace SampleDataBinding.Views
{
    public partial class InventoryPage : ContentPage
    {
        public InventoryPage()
        {
            BindingContext = new GenericRepoViewModel();
            InitializeComponent();
            
        }
    }
}
