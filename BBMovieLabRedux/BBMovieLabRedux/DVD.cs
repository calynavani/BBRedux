using System;
using System.Collections.Generic;
using System.Text;

namespace BBMovieLabRedux
{
    class DVD : Movie
    {
        public DVD(string title, Genre category, int runtime, string scenes) : base(title, category, runtime, scenes)
        {

        }

        public void Play()
        {
            BlockBuster bb = new BlockBuster();

            for(int j = 0; j < bb.ListofMovies.Count; j++)
            {

                for (int i = 0; i < ListOfScenes.Count; i++)
                {
                    Console.WriteLine($"{i}: {ListOfScenes[i]}");
                }

                break;
            }

            Console.WriteLine();
            Console.Write("Which scene would like to watch: ");
            int userSelectScene = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(userSelectScene);
        }
    }
}
