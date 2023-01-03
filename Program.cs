namespace ekzamen;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new[] { 1, 56, 12, 4, 6, 8, 234, 5, 14 };
        int[] bubbleSort = Bubble.BubbleSort(array);
        int[] insertionSort = Insertion.InsertionSort(array);
        for(int i = 0; i<insertionSort.Length; i++)
        {
            Console.WriteLine(insertionSort[i]);
        }
    }
    
}