using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8MovieList
{
    class Movie
    {

        //This class is a container class for storing Movie Name as well as Genre
        
        public string Name { get; set; }

        public string Genre { get; set; }


        //This is the constructer method that combines all the data
        public Movie(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
    }
}
