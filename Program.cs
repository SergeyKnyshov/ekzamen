namespace ekzamen;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] array = new[] { 1, 56, 12, 4, 6, 8, 234, 5, 14 };
        int[] bubbleSort = Bubble.BubbleSort(array);
        int[] insertionSort = Insertion.InsertionSort(array);
        int[] selectionSort = Selection.SelectionSort(array);
        int[] quickSort = Quick.QuickSort(array,0,8);
        int[] shellSort = Shell.ShellSort(array);
        int binarySearch = Binary.BinarySearch(array, 234, 0, 8); 
        for(int i = 0; i<bubbleSort.Length; i++)
        {
            Console.WriteLine(bubbleSort[i]);
        }
    }
    
}