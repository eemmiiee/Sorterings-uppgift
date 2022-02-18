using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sorterings_uppgift
{
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

        //bubblesort
        int listLenght = rndlist.Count;

        sw.Start();

        for(int a = 0; a < (listLenght - 1); a++){
            for(int b = 0; b < (listLenght - 1 - a); b++){
                if(rndlist[b] > rndlist[b + 1]){
                    int c = rndlist[b + 1];
                    rndlist[b + 1] = rndlist[b];
                    rndlist[b] = c;
                }
            }
        }

        sw.Stop();

        foreach(int a in rndlist){
            Console.WriteLine(a);
        }


        //Insertionsort
        int Lenghtlist = randList.Count;

        stopwatch.Start();
        for(int d = 1; d < Lenghtlist; ++d){
            int key = randList[d];
            int e = d - 1;

            while(e >= 0 && randList[e] > key)
            {
                randList[e + 1] = randList[e];
                e = e - 1;
            }
            randList[e + 1] = key;
        }
        
    
        stopwatch.Stop();

        foreach(int b in randList){
            Console.WriteLine(b);
        }


        Console.WriteLine($"Bubblesort: {sw.ElapsedMilliseconds} \nInsertionsort: {stopwatch.ElapsedMilliseconds}");
    
        }
    }
        

}
