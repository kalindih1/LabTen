using System;
using System.Collections.Generic;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
           while (true)
            {


                Console.WriteLine("Please select a category: animated, horror, scifi or drama");

                string userInput = Console.ReadLine();

                MovieCategory movieCategory = SelectCategory(userInput);

                List<Movie> movieList = CreateMovieList(movieCategory);

                foreach (Movie movie in movieList)
                {
                    Console.WriteLine($"{movie.Title}");
                }
                Console.WriteLine("Do you want to continue?: yes or no");
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "no")
                {
                    break;
                }
            }
                

            

        }
        public static List<Movie> CreateMovieList(MovieCategory category)
        {
            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie("Jurassic Park", MovieCategory.scifi));
            movieList.Add(new Movie("Star wars", MovieCategory.scifi));
            movieList.Add(new Movie("Interstellar", MovieCategory.scifi));
            movieList.Add(new Movie("Spirited Away", MovieCategory.animated));
            movieList.Add(new Movie("Cars", MovieCategory.animated));
            movieList.Add(new Movie("Scream", MovieCategory.horror));
            movieList.Add(new Movie("The Grudge", MovieCategory.horror));
            movieList.Add(new Movie("1917", MovieCategory.drama));
            movieList.Add(new Movie("Fury", MovieCategory.drama));
            movieList.Add(new Movie("Room", MovieCategory.drama));

            List<Movie> moviesInCategory = new List<Movie>();
            foreach (Movie movie in movieList)
            {
                

               
                int result = movie.Category.CompareTo(category);
                if (result == 0 )
                {
                    moviesInCategory.Add(movie);

                }


            }
            return moviesInCategory;



        }
        public static MovieCategory SelectCategory(string userInput)
        {
            if (userInput.ToLower() == "animated")
            {
                return MovieCategory.animated;

            }
            else if (userInput.ToLower() == "scifi")
            {
                return MovieCategory.scifi;
            }
            else if (userInput.ToLower() == "horror")
            {
                return MovieCategory.horror;
            }
            else if (userInput.ToLower() == "drama")
            {
                return MovieCategory.drama;
            }
            else
            {
                Console.WriteLine("invalid input. Please check your spelling");
                return MovieCategory.invalid;
            }

                 

        }
    }
}
