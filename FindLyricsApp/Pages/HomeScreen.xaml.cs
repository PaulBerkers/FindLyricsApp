using FindLyricsApp.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FindLyricsApp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomeScreen : Page
    {
        public Show Show { get; set; } = new Show();
        public HomeScreen()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ResultScreen), Show);
        }
    }

    public class Show
    {
        private string _artist;

        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        private string _song;

        public string Song
        {
            get { return _song; }
            set { _song = value; }
        }
    }
}
