using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//this page is to store movies
namespace Assignment3.Models
{ 
    public class TempStorage
    {
        private static List<AddMovie> movies = new List<AddMovie>();

        public static IEnumerable<AddMovie> Movies => movies;

        public static void AddTheMovie(AddMovie movie)
        {
            movies.Add(movie);
        }
    }
}
