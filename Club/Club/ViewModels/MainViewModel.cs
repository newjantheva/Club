﻿using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Club.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public IList<ProductViewModel> Products { get; set; }

        private ProductViewModel _selectedProduct;

        public ProductViewModel SelectedProduct
        {
            get { return _selectedProduct; }
            set { SetProperty(ref _selectedProduct, value); }
        }

        public ShoppingCartViewModel ShoppingCart { get; set; }

        public ICommand RemoveItemCommand { private set; get; }

        public MainViewModel()
        {
            Products = new ObservableRangeCollection<ProductViewModel>()
            {
                new ProductViewModel()
                {
                    HeroColor = "#95C9F7",
                    Name="Sky Blue",
                    Price = 12,
                    ImageUrl = "blue_moss",
                    IsFeatured = true,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#FFCA81",
                    Name="Yellow Sun",
                    Price = 17,
                    ImageUrl = "yellow_moss",
                    IsFeatured = true,
                    Description = "Contained in a yellow glass polygonal florarium",
                    Humidity = "50 - 60%",
                    Light = "5k - 15k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "200 mm"
                },

                new ProductViewModel()
                {
                    HeroColor = "#A2BAD3",
                    Name="Grey Blue",
                    Price = 19,
                    ImageUrl = "grey_moss",
                    IsFeatured = true,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },

                new ProductViewModel()
                {
                    HeroColor = "#F796DD",
                    Name="Pink",
                    Price = 21,
                    ImageUrl = "pink_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },

                 new ProductViewModel()
                {
                    HeroColor = "#95C9F7",
                    Name="Sky Blue",
                    Price = 12,
                    ImageUrl = "blue_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },

                new ProductViewModel()
                {
                    HeroColor = "#D69EFC",
                    Name="Lavender",
                    Price = 19,
                    ImageUrl = "lavender_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#74D69E",
                    Name="Green Life",
                    Price = 14,
                    ImageUrl = "green_moss",
                    IsFeatured = true,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#FB8183",
                    Name="Red",
                    Price = 21,
                    ImageUrl = "red_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#FB9B64",
                    Name="Orange",
                    Price = 14,
                    ImageUrl = "orange_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },
                new ProductViewModel()
                {
                    HeroColor = "#D69EFC",
                    Name="Lavender",
                    Price = 19,
                    ImageUrl = "lavender_moss",
                    IsFeatured = false,
                    Description = "Contained in a glass polygonal florarium",
                    Humidity = "50 - 75%",
                    Light = "5k - 10k lux",
                    Temperature = "18 - 27 ℃",
                    Size = "150x150 mm",
                    Diameter = "190 mm"
                },

            };

            ShoppingCart = new ShoppingCartViewModel();
            ShoppingCart.Items.Add(new FreightItem() { FreightCharge = 15 });

            RemoveItemCommand = new Command<ShoppingCartItem>(i => RemoveItem(i));

        }

        private void RemoveItem(ShoppingCartItem i)
        {
            ShoppingCart.RemoveItem(i);
        }
    }
}
