﻿using FindLyricsApp.Classes;
using FindLyricsApp.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FindLyricsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<MenuItem> _menuItems;
        public MainPage()
        {
            this.InitializeComponent();

            _menuItems = new ObservableCollection<MenuItem>()
            {
                new MenuItem(
                    typeof(HomeScreen),
                    "Home",Symbol.Home),
                new MenuItem(
                    typeof(ResultScreen),
                    "Resultaten",Symbol.ShowResults)

            };
            fRootFrame.Navigate(_menuItems[0].Page);

        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            MenuItem mi = (MenuItem)sender.SelectedItem;
            fRootFrame.Navigate(mi.Page);
        }

        private void NavigationView_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (fRootFrame.CanGoBack)
            {
                fRootFrame.GoBack();
            }

        }
    }
}
