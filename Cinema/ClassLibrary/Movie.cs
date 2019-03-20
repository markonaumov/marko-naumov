using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Movie
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; } = 5;

        public Movie(string title, Genre genre, int rating, double ticketprice)
        {
            Title = title;
            Genre = genre;
            try
            {
                if((rating>0) || (rating < 6))
                {
                    Rating = rating;
                }
                else
                {
                    throw new Exception("wrong rating");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            TicketPrice = ticketprice * rating;
        }

    }
}