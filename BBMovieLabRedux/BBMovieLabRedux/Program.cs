using System;

namespace BBMovieLabRedux
{
    class Program
    {
       
        static void Main(string[] args)
        {
            BlockBuster bb = new BlockBuster();
            


            Console.WriteLine("Welcome to My Block Buster");
            Console.WriteLine("Yes...We ARE STILL HERE!!");
            Console.WriteLine();
            Console.WriteLine("Please Select A Movie From The List: ");
            
            bb.CheckOut();
            //bb.Play();
            
           
        }
    }
}
