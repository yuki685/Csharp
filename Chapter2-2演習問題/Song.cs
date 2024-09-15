using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_2演習問題
{
    class Song
    {
        public string Title { get; set; } = string.Empty;
        public string ArtistName { get; set; } = string.Empty;
        public int Length { get; set; }

        public Song(string Title, string AtristName, int Length) 
        {
            Title = this.Title;
            AtristName = this.ArtistName;
            Length = this.Length;
        }
        private readonly List<Song> _Song;
        public Song(List<Song> Song)
        {
            _Song = Song;
        }
    }
}
