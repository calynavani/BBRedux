using System;
using System.Collections.Generic;
using System.Text;

namespace BBMovieLabRedux
{
    class BlockBuster
    {
        public List<Movie> ListofMovies { get; set; } = new List<Movie>();

        public BlockBuster()
        {
            ListofMovies.Add(TheLittleRascals);
            ListofMovies.Add(Matilda);
            ListofMovies.Add(RushHour);
            ListofMovies.Add(CharliesAngels);
            ListofMovies.Add(LoveDontCostAThing);
            ListofMovies.Add(ScaryMovie);

        }

        public Movie TheLittleRascals = new VHS("The Little Rascals", Movie.Genre.Comedy, 90, "Heman Women Hater's Club, Darla Dates Alfalfa, The Fire, The Talent Show, The Race");
        public Movie Matilda = new VHS("Matilda", Movie.Genre.Comedy, 125, "Matilda Makes Breakfast, Matilda Goes To School, Matilda Meets The Principle, Matilda Gets Revenge, Matilda Gets Adopted");
        public Movie RushHour = new VHS("Rush Hour", Movie.Genre.Action, 110, "Meet Your New Partner, Kidnapping, Investigation Is A Go, Locates The Gang, China Town");
        public Movie CharliesAngels = new DVD("Charlie's Angels", Movie.Genre.Action, 115, "Meet the Angels, Hello Bosly, Hair Sniffer, It Takes Three To Tango, You'll Never Meet Charlie");
        public Movie LoveDontCostAThing = new DVD("Love Don't Cost A Thing", Movie.Genre.Romance, 85, "The Nerd,The Popular Girl, The Pool Party, The Car Accident, The Makeover");
        public Movie ScaryMovie = new DVD("Scary Movie", Movie.Genre.Comedy, 75, "Blondes Always Die First, You Can Run But You Can\'t hide, The Phone Call, High School, Buddy");

        public void PrintMovies()
        {
            for(int i = 0; i < ListofMovies.Count; i++)
            {
                Console.WriteLine($" {i + 1} {ListofMovies[i].Title }");
            }
        }

        public Movie CheckOut()
        {
            Movie m = ListofMovies[0];
            PrintMovies();
            Console.WriteLine();
            Console.Write("Which movie would you like to check out? ");
            int userCheckOutMovie = int.Parse(Console.ReadLine());

            for(int i = 0; i < ListofMovies.Count; i++)
            {
                if(userCheckOutMovie > 0 && userCheckOutMovie < ListofMovies.Count)
                {
                   m.PrintInfo();
                }
            }
            return 
            

        }
        public void Play() 
        { 


        }



    }
}
