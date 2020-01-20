using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLyricsApp.Classes
{
    public class Lyrics
    {

        [JsonProperty("lyrics")]
        public string LyricsResult { get; set; }
    }
}
