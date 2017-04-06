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
    public sealed partial class ColourPage : Page
    {
        public ColourPage()
        {
            this.InitializeComponent();
        }

        private void Black_pressed(object sender, TappedRoutedEventArgs e)
        {
            Black.Play();
        }
        private void Blue_pressed(object sender, TappedRoutedEventArgs e)
        {
            Blue.Play();
        }
        private void Brown_pressed(object sender, TappedRoutedEventArgs e)
        {
            Brown.Play();
        }
        private void Green_pressed(object sender, TappedRoutedEventArgs e)
        {
            Green.Play();
        }
        private void Orange_pressed(object sender, TappedRoutedEventArgs e)
        {
            Orange.Play();
        }
        private void Pink_pressed(object sender, TappedRoutedEventArgs e)
        {
            Pink.Play();
        }
        private void Purple_pressed(object sender, TappedRoutedEventArgs e)
        {
            Purple.Play();
        }
        private void Red_pressed(object sender, TappedRoutedEventArgs e)
        {
            Red.Play();
        }
        private void Yellow_pressed(object sender, TappedRoutedEventArgs e)
        {
            Yellow.Play();
        }
    }
}
