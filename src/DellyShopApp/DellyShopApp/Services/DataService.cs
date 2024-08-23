﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DellyShopApp.Helpers;
using DellyShopApp.Languages;
using DellyShopApp.Models;
using Xamarin.Forms;

namespace DellyShopApp.Services
{
    public class DataService : IDisposable
    {
        static DataService _instance;

        public ObservableCollection<NotificationModel> NotificationList = new ObservableCollection<NotificationModel>();
        public ObservableCollection<ProductListModel> ProcutListModel = new ObservableCollection<ProductListModel>();
        public ObservableCollection<ProductListModel> BasketModel = new ObservableCollection<ProductListModel>();

        public List<Category> CatoCategoriesList = new List<Category>();
        public List<Category> Carousel = new List<Category>();
        public List<StartList> StartList = new List<StartList>();
        public List<Category> CatoCategoriesDetail = new List<Category>();
        public List<CommentModel> CommentList = new List<CommentModel>();
        public double BaseTotalPrice = 0;
        public static DataService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataService();
                }
                return _instance;
            }
        }
        public static void Restart()
        {

            _instance = null;
            Disposed = true;
        }
        protected static bool Disposed { get; private set; }
        protected virtual void Dispose(bool disposing)
        {
            Disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public DataService()
        {
            NotificationList.Add(new NotificationModel
            {
                Title = AppResources.NotificatinTitle,
                SubTitle = AppResources.NotificationSubtitle,
                Description = AppResources.LoremIpsum,
                Id = 1,
                Image = "elecronics.jpeg",
                InstertedAt = DateTime.Now

            });

            NotificationList.Add(new NotificationModel
            {

                Title = AppResources.NotificatinTitle,
                SubTitle = AppResources.NotificationSubtitle,
                Description = AppResources.LoremIpsum,
                Id = 2,
                Image = "shoes.jpg",
                InstertedAt = DateTime.Now

            });
            ProcutListModel.Add(new ProductListModel
            {
                Title = AppResources.ProcutTitle,
                Brand = AppResources.ProductBrand,
                Id = 1,
                Image = "shoesBlack",
                Price = 362,
                VisibleItemDelete = false,
                ProductList = new string[] { "red1", "shoesBlack" },
                OldPrice = 570
            });
            ProcutListModel.Add(new ProductListModel
            {
                Title = AppResources.ProcutTitle1,
                Brand = AppResources.ProductBrand1,
                Id = 2,
                Image = "grazy1",
                Price = 150,
                VisibleItemDelete = false,
                ProductList = new string[] { "garzy2", "grazy1" },
                OldPrice = 270
            });
            ProcutListModel.Add(new ProductListModel
            {
                Title = AppResources.ProcutTitle2,
                Brand = AppResources.ProductBrand2,
                Id = 3,
                Image = "shoesyellow",
                Price = 299,
                VisibleItemDelete = false,
                ProductList = new string[] { "py_1", "shoesyellow" },
                OldPrice = 400
            });
           
            CatoCategoriesList.Add(new Category
            {
                CategoryName = AppResources.Shoes,
                Image = "shoesCategory.png",
                Id = "1"
            });
            CatoCategoriesList.Add(new Category
            {
                CategoryName = AppResources.Electronics,

                Image = "electronicCategory.png",
                Id = "2"
            });
            CatoCategoriesList.Add(new Category
            {
                CategoryName = AppResources.Clothing,

                Image = "clothingCategory.png",
                Id = "3"
            });
            StartList.Add(new StartList
            {
                StarImg = FontAwesomeIcons.Star
            });
            StartList.Add(new StartList
            {
                StarImg = FontAwesomeIcons.Star
            });
            StartList.Add(new StartList
            {
                StarImg = FontAwesomeIcons.Star
            });
            StartList.Add(new StartList
            {
                StarImg = FontAwesomeIcons.Star
            });
            StartList.Add(new StartList
            {
                StarImg = FontAwesomeIcons.Star
            });
            CommentList.Add(new CommentModel
            {
                Name = "Ufuk Sahin",
                CommentTime = "12/1/19",
                Id = 1,
                Rates = StartList
            });
            CommentList.Add(new CommentModel
            {
                Name = "Hans Goldman",
                CommentTime = "11/6/19",
                Id = 2,
                Rates = StartList.Skip(0).ToList()
            });
            CommentList.Add(new CommentModel
            {
                Name = "Jon Goodman",
                CommentTime = "12/8/19",
                Id = 3,
                Rates = StartList.Skip(1).ToList()
            });
            CommentList.Add(new CommentModel
            {
                Name = "UfuK Zimmer",
                CommentTime = "12/8/20",
                Id = 3,
                Rates = StartList.Skip(1).ToList()
            });
            CatoCategoriesDetail.Add(new Category
            {
                Image = "shoes.jpg"
            });
            CatoCategoriesDetail.Add(new Category
            {
                Image = "bestShoes.jpg"
            });
            CatoCategoriesDetail.Add(new Category
            {
                Image = "bestofYear.jpg"
            });
            Carousel.Add(new Category
            {
                Image = "shoes.jpg"
            });
            Carousel.Add(new Category
            {
                Image = "clothing.jpg"
            });
            Carousel.Add(new Category
            {
                Image = "elecronics.jpeg"
            });
        }
    }
}

