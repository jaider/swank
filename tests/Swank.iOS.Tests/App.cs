﻿using System;
using System.Collections.Generic;
using Plugin.Swank;
using Xamarin.Forms;

namespace Swank.iOS.Tests
{
    public class App : Xamarin.Forms.Application
    {
        public App()
        {
            var viewer = new Viewer
            {
                ItemsSource = new List<ViewerImage>
                {
                    new ViewerImage {Source = ImageSource.FromUri(new Uri("http://via.placeholder.com/800x300"))},
                    new ViewerImage {Source = ImageSource.FromUri(new Uri("http://via.placeholder.com/3600x1800")), Is360 = true},
                    new ViewerImage {Source = ImageSource.FromUri(new Uri("http://via.placeholder.com/400x300"))}
                }
            };

            MainPage = new NavigationPage(new ContentPage
            {
                Title = "Swank - iOS",
                Content = viewer
            });
        }
    }
}