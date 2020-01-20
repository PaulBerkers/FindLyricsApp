using FindLyricsApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static FindLyricsApp.Pages.HomeScreen;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FindLyricsApp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ResultScreen : Page, INotifyPropertyChanged
    {
        string Artist;
        string Song;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string lyricResult;

        public string Lyrics
        {
            get { return lyricResult; }
            set { lyricResult = value; NotifyPropertyChanged(); }
        }

        public ResultScreen()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            if ((Show)e.Parameter == null)
            {
                
            }
            else
            {
                Show s = (Show)e.Parameter;

                Artist += s.Artist;
                Song += s.Song;

                GetLyrics();
            }
        }

        private async void GetLyrics()
        {
            Lyrics = await LyricsWrapper.GetTheLyrics(Artist, Song);
        }
      
    }
}
