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
                "c4",
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
                "https://drive.google.com/file/d/1NUt3LssNOurPCfq8G2bBSEmCSgo0pDAY/view?usp=sharing/NAUTA-Dueña de la Luna.mp3",
                "Wed",
                "Thu",
                "Fri",
                "Sat"
            };

            return Linksongs[n];
        }


    }
}
