using System;

namespace Emmie_Bubblesort___Insertionsort
{

    //https://csharpskolan.se/article/bubble-sort/
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<int> rndlist = new List<int>();
            List<int> randList = new List<int>();

            Stopwatch sw = new Stopwatch();
            Stopwatch stopwatch = new Stopwatch();


            for (int i = 0; i < 1000; i++){
                rndlist.Add(rnd.Next());
                randList.Add(rnd.Next());
            }



        //Bubblesort


        }
    }
}
