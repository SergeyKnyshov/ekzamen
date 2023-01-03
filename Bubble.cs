namespace ekzamen;

public class Bubble
{
    public static int[] BubbleSort(int[] mas)
        {
           for (int i = 0; i < mas.Length-1; i++)
           {
                   if (mas[i] > mas[i+1])
                   {
                       (mas[i], mas[i+1]) = (mas[i+1], mas[i]);
                   }
           }
           return mas;
       }
   
}