using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShapePage : Page
    {
        public ShapePage()
        {
            this.InitializeComponent();
        }

        private void Circle_pressed(object sender, TappedRoutedEventArgs e)
        {
            Circle.Play();
        }
        private void Diamond_pressed(object sender, TappedRoutedEventArgs e)
        {
            Diamond.Play();
        }
        private void Heart_pressed(object sender, TappedRoutedEventArgs e)
        {
            Heart.Play();
        }
        private void Oval_pressed(object sender, TappedRoutedEventArgs e)
        {
            Oval.Play();
        }
        private void Rectangle_pressed(object sender, TappedRoutedEventArgs e)
        {
            Rectangle.Play();
        }
        private void Square_pressed(object sender, TappedRoutedEventArgs e)
        {
            Square.Play();
        }
        private void Star_pressed(object sender, TappedRoutedEventArgs e)
        {
            Star.Play();
        }
        private void Triangle_pressed(object sender, TappedRoutedEventArgs e)
        {
            Triangle.Play();
        }
    }
}
