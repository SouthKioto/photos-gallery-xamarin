using App1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        protected string file_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "photos.txt");

        List<PhotoData> photos;
        public MainPage()
        {
            InitializeComponent();

            photos = PhotoDataHandlers.GetDataFromTextFile(file_path);
            photoGalleryCollection.ItemsSource = photos;

        }

        private async void DisplayPhotoDetails(object sender, EventArgs e)
        {
            var button = (ImageButton)sender;
            var photoData = button.CommandParameter as PhotoData;

            if (photoData != null)
            {
                await DisplayAlert("Photo Details", $"Tytuł: {photoData.Photo_Title}\nDescription: {photoData.Photo_Description}\n", "OK");
            }
        }

    }
}
