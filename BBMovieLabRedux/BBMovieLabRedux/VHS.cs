using System;
using System.Collections.Generic;
using System.Text;

namespace BBMovieLabRedux
{
    class VHS : Movie
    {

        public int CurrentTime { get; set; } = 0;

        public VHS(string title, Genre category, int runtime, string scenes) : base(title, category, runtime, scenes)
        {

        }

        public void Play()
        {
            foreach(var scene in ListOfScenes)
            {
                Console.WriteLine(scene);
                CurrentTime++;
            }
        }

        public void Rewind()
        {
            Console.WriteLine($"Now Rewinding");
            CurrentTime = 0;
        }
    }
}
