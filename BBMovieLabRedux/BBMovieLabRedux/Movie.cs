using System;
using System.Collections.Generic;
using System.Text;

namespace BBMovieLabRedux
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category {get;set; }
        public int RunTime { get; set; }
        public string Scences { get; set; }

        public List<string> ListOfScenes { get; set; } 

        public enum Genre 
        { 
            Drama,
            Comedy,
            Horror,
            Romance,
            Action
        }
       
        public Movie(string title, Genre category, int runtime, string scenes)
        {

            this.Title = title;
            this.Category = category;
            this.RunTime = runtime;
            this.Scences = scenes;

        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}\n");
            Console.WriteLine($"Category: {Category}\n");
            Console.WriteLine($"Run Time: {RunTime}\n");
            
        }

        public void PrintScenes(List<string> listOfScenes)
        {
            for(int i = 1; i < listOfScenes.Count; i++)
            {
                Console.WriteLine($"{i} {listOfScenes[i]}");
            }

        }

        public  void Play() { }


    }
}
