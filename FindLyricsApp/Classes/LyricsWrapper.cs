using System;
using FindLyricsApp.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace FindLyricsApp.Classes
{
    public class LyricsWrapper
    {
        public static async Task<string> GetTheLyrics(string artist, string song)
        {
            Uri request = new Uri(@"https://api.lyrics.ovh/v1/" + artist + "/" + song);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "FindLyricsApp");
            HttpResponseMessage respons = await client.GetAsync(request);
            if (respons.IsSuccessStatusCode == false)
            {
                MessageDialog md = new MessageDialog("Sorry no lyrics found");
                await md.ShowAsync();

                return null;
            }

            respons.EnsureSuccessStatusCode();

            Lyrics ly = await respons.Content.ReadAsAsync<Lyrics>();

            return ly.LyricsResult;
        }
    }
}
