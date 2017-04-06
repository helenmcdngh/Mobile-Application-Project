using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.MediaProperties;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddPage : Page
    {
        public AddPage()
        {
            this.InitializeComponent();
        }

       

        private async void SelectTextFile_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker();
            openPicker.ViewMode = PickerViewMode.Thumbnail;
            openPicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            openPicker.FileTypeFilter.Add(".txt");

            StorageFile file = await openPicker.PickSingleFileAsync();

            if (file != null)
            {
                var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read); using
                (StreamReader reader = new StreamReader(stream.AsStream()))
                {
                    FileText.Text = reader.ReadToEnd();
                }
            }
        }

        private async void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StorageFolder localFolder = await KnownFolders.PicturesLibrary.CreateFolderAsync("Toddler Tap", CreationCollisionOption.OpenIfExists);
                StorageFile file = await localFolder.CreateFileAsync(DocumentName.Text + ".txt", CreationCollisionOption.ReplaceExisting);
                using (IRandomAccessStream iRandomAccessStream = await file.OpenAsync(FileAccessMode.ReadWrite))
                {
                    using (DataWriter textWriter = new DataWriter(iRandomAccessStream))
                    {
                        textWriter.WriteString(Content.Text);
                        await textWriter.StoreAsync();
                        await textWriter.FlushAsync();
                    }
                }
                var messageDialog = new MessageDialog("Done");
                await messageDialog.ShowAsync();
              
            }
            catch
            {
                var messageDialog = new MessageDialog("Didn't save file");
                await messageDialog.ShowAsync();
            }

            
        }

    }
}
