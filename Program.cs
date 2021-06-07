using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> MovieList = new List<Movie>();

            List<string> GenreList = new List<string>();

            List<Movie> SortedList = new List<Movie>();
            GenreList.Add("Animated");
            GenreList.Add("Drama");
            GenreList.Add("Horror");
            GenreList.Add("Science Fiction");

            Console.WriteLine("Please pick a Category ");
            for (int i = 0; i < GenreList.Count; i++)
            {

                Console.WriteLine($"{i + 1}). {GenreList[i]}");

            }



            MovieList.Add(new Movie("Toy Story", "Animated"));
            MovieList.Add(new Movie("Wreck It Ralph", "Animated"));
            MovieList.Add(new Movie("Shrek", "Animated"));
            MovieList.Add(new Movie("Shawshank Redemption", "Drama"));
            MovieList.Add(new Movie("Green Mile", "Drama"));
            MovieList.Add(new Movie("Nightmare on Elm Street", "Horror"));
            MovieList.Add(new Movie("Friday the 13th", "Horror"));
            MovieList.Add(new Movie("Interstellar", "Science Fiction"));
            MovieList.Add(new Movie("Toy Story", "Science Fiction"));
            MovieList.Add(new Movie("2001: A Space Odyssey", "Science Fiction"));


            Console.WriteLine("Which Genre of Movie would you like to view (1-4)? ");

            bool goOn = true;

            while (goOn == true)
            {
                try
                {
                    string genreselected = (Console.ReadLine());

                    int intselected = int.Parse(genreselected);

                    if (intselected < 1 || intselected >= 5)
                    {
                        throw new Exception("Out of Bounds please select another number on the list");
                    }

                    string input = "";

                    if (genreselected == "1")
                    {
                        input = "Animated";
                    }
                    else if (genreselected == "2")
                    {
                        input = "Drama";
                    }
                    else if (genreselected == "3")
                    {
                        input = "Horror";
                    }
                    else if (genreselected == "4")
                    {
                        input = "Science Fiction";
                    }



                    for (int i = 0; i < MovieList.Count; i++)
                    {

                        if (MovieList[i].Genre == input)
                        {
                            SortedList.Add(MovieList[i]);
                        }

                    }


                    Console.WriteLine("");

                    IEnumerable<Movie> sortMovie =

                        from movie in SortedList
                        orderby movie.Name
                        select movie;

                    foreach (Movie movie in sortMovie)
                    {
                        Console.WriteLine(movie.Name);
                    }

                    Console.WriteLine("Would you like to view another Genre? (y/n)");
                    string go = Console.ReadLine().ToLower();
                    if (go !="y")
                    {
                        goOn = false; 
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter valid inputs only"); ;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }

        }

        public static string GetUserInput(string message)
        {
            
                
                    Console.WriteLine(message);
                    string input = Console.ReadLine();
                    return input;
                
                
                
            
            
        }
    }
}

   
