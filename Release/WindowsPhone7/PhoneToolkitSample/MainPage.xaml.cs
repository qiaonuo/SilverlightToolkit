﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace PhoneToolkitSample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateTo(string page)
        {
            this.NavigationService.Navigate(new Uri(page, UriKind.Relative));
        }

        private void OnToggleSwitch(object sender, RoutedEventArgs e)
        {
            NavigateTo("/Samples/ToggleSwitchSample.xaml");
        }

        private void OnContextMenu(object sender, RoutedEventArgs e)
        {
            NavigateTo("/Samples/ContextMenuSample.xaml");
        }

        private void OnDateTimePicker(object sender, RoutedEventArgs e)
        {
            NavigateTo("/Samples/DateTimePickerSample.xaml");
        }

        private void OnWrapPanel(object sender, RoutedEventArgs e)
        {
            NavigateTo("/Samples/WrapPanelSample.xaml");
        }

        private void OnGestures(object sender, RoutedEventArgs e)
        {
            NavigateTo("/Samples/GestureSample.xaml");
        }
    }
}