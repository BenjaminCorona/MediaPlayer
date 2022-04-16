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
                "The Beatles - Help!",
                "Hunter Hayes - Tell Me",
                "Kygo, Avicii - Forever Yours",
                "Nauta - Dueña de la Luna",
                "Nauta - Ladrona",
                "Nauta - Cierto"

            };

            return songs[n];
        }

        public string LinkSongs(int n)
        {

            string[] Linksongs = new string[]
            {
                "https://cdn-143.anonfiles.com/18oca5Xax3/79aaf88e-1650081471/Morat%20-%20El%20Embrujo.mp3",
                "https://cdn-123.anonfiles.com/Z9pca6Xcx1/555b5744-1650081626/Morat%20-%20Mi%20Suerte.mp3",
                "https://cdn-142.anonfiles.com/b5q6adX8x6/a5d0c029-1650082533/The%20Beatles%20-%20Help!%20(Remastered%202009).mp3",
                "https://cdn-144.anonfiles.com/L7i6aeX2xe/eaeb7d71-1650081778/Hunter%20Hayes%20-%20Tell%20Me.mp3",
                "https://cdn-144.anonfiles.com/f608afXfx8/a7cf28cd-1650081964/Kygo_Forever_Yours_with_Avicii_&.mp3",
                "https://cdn-144.anonfiles.com/j204a2X9xe/6e91a73a-1650082031/NAUTA%20-%20Due%C3%B1a%20de%20la%20Luna.mp3",
                "https://cdn-141.anonfiles.com/da0ca1X6x6/06240459-1650082044/Nauta%20-%20Ladrona.mp3",
                "https://cdn-143.anonfiles.com/b403afX2xa/76630fe8-1650082175/NAUTA%20-%20CIERTO.mp3"
            };

            return Linksongs[n];
        }


    }
}
