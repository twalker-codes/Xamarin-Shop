﻿using DellyShopApp.Languages;
using DellyShopApp.Models;
using DellyShopApp.Services;
using DellyShopApp.Views.CustomView;
using DellyShopApp.Views.Pages;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DellyShopApp.Views.TabbedPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage
    {
        ProductListModel product = new ProductListModel();
        public HomePage()
        {
            if(!DataService.Instance.ProcutListModel.Any(x=>x.Id ==4))
            {
                DataService.Instance.ProcutListModel.Insert(0, new ProductListModel
                {
                    Title = AppResources.ProcutTitle3,
                    Brand = AppResources.ProductBrand3,

                    Id = 4,
                    Image = "iphone",
                    Price = 499,
                    OldPrice = 699,
                    VisibleItemDelete = false,
                    ProductList = new string[] { "ip8_1", "ip8_2" }
                });
            }
            InitializeComponent();
            CategoryList.ItemsSource = DataService.Instance.CatoCategoriesList;
            CarouselView.ItemsSource = DataService.Instance.Carousel;
            BestSellerList.ItemsSource = DataService.Instance.ProcutListModel;
            PreviousViewedList.ItemsSource = DataService.Instance.ProcutListModel;
            MostNews.FlowItemsSource = DataService.Instance.ProcutListModel;
        }

        private async void ProductDetailClick(object sender, EventArgs e)
        {
            if (!(sender is PancakeView pancake)) return;
            if (!(pancake.BindingContext is ProductListModel item)) return;
            await Navigation.PushAsync(new ProductDetail(item));
        }

        private async void ClickCategory(object sender, EventArgs e)
        {
            if (!(sender is StackLayout stack)) return;
            if (!(stack.BindingContext is Category ca)) return;
            await Navigation.PushAsync(new CategoryDetailPage(ca));
        }
       async void VireAllTapped(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BestSellerPage());
        }
        void DragGestureRecognizer_DropCompleted(System.Object sender, Xamarin.Forms.DropCompletedEventArgs e)
        {
            BasketLayout.IsVisible = false;
        }
        void DropBasketITem(System.Object sender, Xamarin.Forms.DropEventArgs e)
        {
            if (!DataService.Instance.BasketModel.Contains(product))
                DataService.Instance.BasketModel.Add(product);
        }
        void DragGestureRecognizer_DragStarting(System.Object sender, Xamarin.Forms.DragStartingEventArgs e)
        {
            BasketLayout.IsVisible = true;
            product = ((sender as Element).BindingContext) as ProductListModel;
        }
    }
}