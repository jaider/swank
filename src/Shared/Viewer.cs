﻿using System;
using System.Collections;
using CarouselView.FormsPlugin.Abstractions;
using Xamarin.Forms;
using ScrolledEventArgs = CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs;

namespace Plugin.Swank
{
    public class Viewer : CarouselViewControl
    {
        public new IEnumerable ItemsSource
        {
            get => (IEnumerable) GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public Viewer()
        {
            HorizontalOptions = LayoutOptions.FillAndExpand;
            VerticalOptions = LayoutOptions.FillAndExpand;
            Orientation = CarouselViewOrientation.Horizontal;
            BackgroundColor = Color.Black;
            ShowIndicators = true;
            ItemTemplate = new DataTemplate(typeof(ViewerImageTemplate));
            Scrolled += OnScrolled;
            PositionSelected += OnPositionSelected;
        }

        private void OnScrolled(object o, ScrolledEventArgs scrolledEventArgs)
        {
            // scrolling
        }

        private void OnPositionSelected(object o, PositionSelectedEventArgs positionSelectedEventArgs)
        {
            Console.WriteLine("OnPositionSelected");
            var currentImage = ItemsSource.GetItem(positionSelectedEventArgs.NewValue) as ViewerImage;
        }

        public void SetIsSwipeEnabled(bool isDisabled)
        {
            Console.WriteLine($"SetIsSwipeEnabled: {isDisabled}");
            IsSwipeEnabled = isDisabled;
        }
    }
}