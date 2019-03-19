using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main2
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(string fname, string lname, int age, Genre genre)
        {
            
            FirstName = fname;
            LastName = lname;
            Age = age;
            FavoriteMusicType = genre;
        }

        public void GetPersonName()
        {
            Console.WriteLine($"Name:{FirstName}, {LastName} Age:{Age}");
        }


        public void GetFavoiteSongs()
        {
            if (FavoriteSongs.Count > 0)
            {
                foreach (var song in FavoriteSongs)
                {
                    Console.WriteLine($"this person's favorite song is:");
                    Console.WriteLine($"Name:{song.Name} Length:{song.Length} Genre:{song.Genre}");
                }
            }
            else
            {
                Console.WriteLine($"this person hates music");
            }
        }
    }
}
