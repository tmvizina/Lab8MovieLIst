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
            GenreList.Add("Animated");
            GenreList.Add("Drama");
            GenreList.Add("Horror");
            GenreList.Add("Science Fiction");

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

         

            string input = GetUserInput("Which Genre of Movie would you like to view ? ");
           

            for (int i = 0; i < MovieList.Count; i++)
            {
                if (MovieList[i].Genre==input)
                {
                    Console.WriteLine($"{MovieList[i].Name}");
                }

            }

        }

        public static string GetUserInput(string message)
        {
            bool goOn = true;

            while (goOn == true)
            {
                try
                {
                    Console.WriteLine(message);
                    string input = Console.ReadLine();


                    if (input == "" || input == " ")
                    {
                        throw new Exception("Blanks are not a valid input Sorry");
                    }
                    else
                    {
                        goOn = false;
                        return input;
                       
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                }
            }
        }
    }

