using System.Security.Cryptography;

namespace ekzamen;

public class Selection
{
    public static int[] SelectionSort(int[] mas)
    {
        for (int i = 0; i < mas.Length - 1; i++)
        {
            //поиск минимального числа
            int min=i;
            for (int j = i + 1; j < mas.Length; j++)
            {
                if (mas[j] < mas[min])
                {
                    min = j;
                }
            }
            //обмен элементов
            (mas[min], mas[i]) = (mas[i], mas[min]);
        }
        return mas;
        
    }

}