namespace ekzamen;

public class Insertion
{
    public static int[] InsertionSort(int[] mas)
    {
        int x;
        int j;
        for (int i = 1; i < mas.Length; i++)
        {
            x = mas[i];
            j = i;
            while (j > 0 && mas[j - 1] > x)
            {
                Swap(mas, j, j-1);
                j -= 1;
            }

            mas[j] = x;
        }

        return mas;
    }

    static void Swap(int[] array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}