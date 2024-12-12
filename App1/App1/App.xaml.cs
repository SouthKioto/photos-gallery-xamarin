using App1.Classes;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        protected string file_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "photos.txt");

        // /data/user/0/com.companyname.app1/files/.local/share

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            Console.WriteLine(file_path);

            PhotoDataHandlers.CreateExampleData(file_path);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
