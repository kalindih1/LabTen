using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    public class Movie 
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private MovieCategory category;
        public MovieCategory Category

        {
            get { return category; }
            set { category = value; }
        }
        public Movie(string title, MovieCategory category)
        {
            Title = title;
            Category = category;
        }
            




    }
}
