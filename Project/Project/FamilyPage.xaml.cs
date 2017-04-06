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
    public sealed partial class FamilyPage : Page
    {
        public FamilyPage()
        {
            this.InitializeComponent();
        }

        private void Mom_pressed(object sender, TappedRoutedEventArgs e)
        {
            Mom.Play();
        }
        private void Dad_pressed(object sender, TappedRoutedEventArgs e)
        {
            Dad.Play();
        }
        private void Grandmom_pressed(object sender, TappedRoutedEventArgs e)
        {
            Granny.Play();
        }
        private void Granddad_pressed(object sender, TappedRoutedEventArgs e)
        {
            Granddad.Play();
        }
        private void Brother_pressed(object sender, TappedRoutedEventArgs e)
        {
            Brother.Play();
        }
        private void Sister_pressed(object sender, TappedRoutedEventArgs e)
        {
            Sister.Play();
        }

    }
}
