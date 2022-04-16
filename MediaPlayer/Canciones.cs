using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    class Canciones
    {
        public string Songs(int n)
        {

            string[] songs = new string[]
            {
                "Morat - El Embrujo",
                "Morat - Mi Suerte",
                "The Beatles - Help! (Remastered 2009)",
                "Hunter Hayes - Tell Me",
                "c5",
                "c6",
                "c7"
            };

            return songs[n];
        }

        public string LinkSongs(int n)
        {

            string[] Linksongs = new string[]
            {
                "http://filesfor.epizy.com/songs/Morat%20-%20El%20Embrujo%20-%20Copy.mp3",
                "http://filesfor.epizy.com/songs/Morat%20-%20Mi%20Suerte.mp3",
                "https://cdn-124.anonfiles.com/L7i6aeX2xe/79565073-1650080880/Hunter%20Hayes%20-%20Tell%20Me.mp3",
                "https://cdn-124.anonfiles.com/L7i6aeX2xe/79565073-1650080880/Hunter%20Hayes%20-%20Tell%20Me.mp3",
                "Thu",
                "Fri",
                "Sat"
            };

            return Linksongs[n];
        }


    }
}
