using System;
using System.Diagnostics;
using System.Threading;
namespace mergsort
{
   class MergeSort {
  
   
    void merge(int[] arr, int l, int m, int r)
    {
        
        int n1 = m - l + 1;
        int n2 = r - m;
  
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;
  
      
        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];
  
      
        i = 0;
        j = 0;
  
     
        int k = l;
        while (i < n1 && j < n2) {
            if (L[i] <= R[j]) {
                arr[k] = L[i];
                i++;
            }
            else {
                arr[k] = R[j];
                j++;
            }
            k++;
        }
  
      
        while (i < n1) {
            arr[k] = L[i];
            i++;
            k++;
        }
  
        
        while (j < n2) {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
  
   
    void sort(int[] arr, int l, int r)
    {
        if (l < r) {
            
            int m = l+ (r-l)/2;
  
           
            sort(arr, l, m);
            sort(arr, m + 1, r);
  
          
            merge(arr, l, m, r);
        }
    }
  
    
    static void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
  
   
    public static void Main(String[] args)
    {int []arr = new int[8000];
    Random rnd = new Random();
    for (int i = 0; i < 8000; i++) {
  arr[i] = rnd.Next(0,1000) ;
    }
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
     MergeSort ob = new MergeSort();
        ob.sort(arr, 0, arr.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("\nSorted array");
        printArray(arr);
        Console.WriteLine("Mergsort: {0} ", stopwatch.ElapsedMilliseconds);
}
   }}
