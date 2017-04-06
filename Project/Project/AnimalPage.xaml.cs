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
    public sealed partial class AnimalPage : Page
    {
        public AnimalPage()
        {
            this.InitializeComponent();
        }

        private void Cat_pressed(object sender, TappedRoutedEventArgs e)
        {
            Cat.Play();
        }
        private void Dog_pressed(object sender, TappedRoutedEventArgs e)
        {
            Dog.Play();
        }
        private void Cow_pressed(object sender, TappedRoutedEventArgs e)
        {
            Cow.Play();
        }
        private void Chicken_pressed(object sender, TappedRoutedEventArgs e)
        {
            Chicken.Play();
        }
        private void Duck_pressed(object sender, TappedRoutedEventArgs e)
        {
            Duck.Play();
        }
        private void Sheep_pressed(object sender, TappedRoutedEventArgs e)
        {
            Sheep.Play();
        }
        private void Horse_pressed(object sender, TappedRoutedEventArgs e)
        {
            Horse.Play();
        }
        private void Goat_pressed(object sender, TappedRoutedEventArgs e)
        {
            Goat.Play();
        }
        private void Pig_pressed(object sender, TappedRoutedEventArgs e)
        {
            Pig.Play();
        }
    }
}
