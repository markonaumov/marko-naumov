using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Scary Movie", Genre.Comedy, 4, 2.5);
            Movie movie2 = new Movie("American Pie", Genre.Comedy, 4, 2.5);
            Movie movie3 = new Movie("Saw", Genre.Horror, 4, 2.5);
            Movie movie4 = new Movie("The Shining", Genre.Horror, 4, 2.5);
            Movie movie5 = new Movie("Rambo", Genre.Action, 4, 2.5);
            Movie movie6 = new Movie("The Terminator", Genre.Action, 4, 2.5);
            Movie movie7 = new Movie("Forrest Gump", Genre.Drama, 4, 2.5);
            Movie movie8 = new Movie("12 Angru Men", Genre.Drama, 4, 2.5);
            Movie movie9 = new Movie("Passengers", Genre.SciFi, 4, 2.5);
            Movie movie10 = new Movie("Interstellar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet1 = new List<Movie>() { movie1, movie2, movie3, movie4, movie5, movie6, movie7, movie8, movie9, movie10 };
            Movie movie11 = new Movie("Airplane", Genre.Comedy, 4, 2.5);
            Movie movie12 = new Movie("Johnny English", Genre.Comedy, 4, 2.5);
            Movie movie13 = new Movie("The Ring", Genre.Horror, 4, 2.5);
            Movie movie14 = new Movie("Sinister", Genre.Horror, 4, 2.5);
            Movie movie15 = new Movie("RoboCop", Genre.Action, 4, 2.5);
            Movie movie16 = new Movie("Judge Dredd", Genre.Action, 4, 2.5);
            Movie movie17 = new Movie("The Social Network", Genre.Drama, 4, 2.5);
            Movie movie18 = new Movie("The Shawshank Redemption", Genre.Drama, 4, 2.5);
            Movie movie19 = new Movie("Inception", Genre.SciFi, 4, 2.5);
            Movie movie20 = new Movie("Avatar", Genre.SciFi, 4, 2.5);
            List<Movie> MovieSet2 = new List<Movie>() { movie11, movie12, movie13, movie14, movie15, movie16, movie17, movie18, movie19, movie20 };


            Cinema cinema1 = new Cinema("Cineplex");
            cinema1.Halls = new List<int>() { 1, 2, 3, 4 };
            cinema1.ListOfMovies = MovieSet1;
            Cinema cinema2 = new Cinema("Milenium");
            cinema2.Halls = new List<int>() { 1, 2 };
            cinema2.ListOfMovies = MovieSet2;


            Console.WriteLine("Choose a Cinema: 1) Cineplex 2)Milenium");

            Cinema temp = new Cinema();

            try
            {
                int number1 = int.Parse(Console.ReadLine());
                if ((number1 > 0) && (number1 < 3))
                {
                    switch (number1)
                    {
                        case 1:
                            temp = cinema1;
                            Console.WriteLine($"you selected {temp.Name}");
                            break;
                        case 2:
                            temp = cinema2;
                            Console.WriteLine($"you selected {temp.Name}");
                            break;
                    }
                }
                else
                {
                    throw new Exception("wrong input");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            Console.WriteLine("Choose to see: 1) All Movies 2)By genre");
            try
            {

                int number2 = int.Parse(Console.ReadLine());
                if ((number2 > 0) && (number2 < 3))
                {
                    switch (number2)
                    {
                        case 1:
                            foreach (var movie in temp.ListOfMovies)
                            {
                                Console.WriteLine(movie.Title);
                            }
                            Console.WriteLine("------------------------------");
                            Console.WriteLine("Write the title of the movie you want to watch:");
                            string film = Console.ReadLine();
                            temp.ListOfMovies = temp.ListOfMovies.Where(x => x.Title.ToLower() == film.ToLower()).ToList();
                            
                            foreach(var movie in temp.ListOfMovies)
                            {
                                temp.WatchMovie(movie);
                            }
                            
                            break;

                        case 2:
                            Console.WriteLine("------------------");
                            Console.WriteLine("Comedy,Horror,Action,Drama,SciFi");
                            Console.WriteLine("write your genre bellow");
                            string genre1 = Console.ReadLine();
                            temp.ListOfMovies = temp.ListOfMovies.Where(x => x.Genre.ToString().ToLower() == genre1.ToLower()).ToList();
                            foreach(var movie in temp.ListOfMovies)
                            {
                                Console.WriteLine(movie.Title);
                            }
                            Console.WriteLine("-------------------");
                            Console.WriteLine("Write the movie you want to watch");
                            string watchMovie = Console.ReadLine();
                            temp.ListOfMovies = temp.ListOfMovies.Where(x => x.Title.ToLower() == watchMovie.ToLower()).ToList();
                            foreach(var movie in temp.ListOfMovies)
                            {
                                temp.WatchMovie(movie);
                            }
                            
                            break;

                    }

                }
                else
                {
                    throw new Exception("wrong input");
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }


    }
}