using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naha
{
    internal class album
    {
        string artist;
        string title;
        string genre;
        string fileCover;

        public album(string artiste, string title, string genre, string fileCover)
        {
            this.artist = artiste;
            this.title = title;
            this.genre = genre;
            this.fileCover = fileCover;
        }

        public string Artist { get { return artist; } }
        public string Title { get { return title; } }   
        public string FileCover { get { return fileCover; } }
        public string Genre { get { return genre; } }
    }
}
