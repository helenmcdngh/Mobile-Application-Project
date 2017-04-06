using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


namespace Project
{
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //topics like FamilyMembers, activites, shapes and colours. etc 
        
        private void FamilyButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(FamilyPage));
        }
        private void ShapeButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(ShapePage));
        }

        private void ColourButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(ColourPage));
        }

        private void AnimalButton_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(AnimalPage));
        }

        private void AddButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(AddPage));
        }
    }
    
}
