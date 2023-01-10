namespace ekzamen;

public class Bubble
{
    public static int[] BubbleSort(int[] mas)
        {
           for (int i = 0; i < mas.Length-1; i++)
           {
               Console.WriteLine($"Сравниваем элементы {mas[i]} и {mas[i+1]}");
                   if (mas[i] > mas[i+1])
                   {
                       Console.WriteLine($"{mas[i]}>{mas[i+1]} поэтому меняем их местами");
                       (mas[i], mas[i+1]) = (mas[i+1], mas[i]);
                   }

                   Console.WriteLine($"Элемент {mas[i]}<{mas[i+1]} поэтому не меняем их местами");
           }

           Console.WriteLine("Массив отсортирован");
           return mas;
       }
   
}