using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main2
{
    public class Song
    {
        public string Name { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }

       public Song(string name, int length, Genre genre)
        {
            Name = name;
            Length = length;
            Genre = genre;
        }

    }
}
