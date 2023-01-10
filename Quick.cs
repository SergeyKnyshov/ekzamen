namespace ekzamen;

public class Quick
{
    public static void Swap(ref int x, ref int y)
    {
        (x, y) = (y, x);
    }

    //метод возвращающий индекс опорного элемента
    public static int Partition(int[] array, int minIndex, int maxIndex)
    {
        var pivot = minIndex - 1;
        for (var i = minIndex; i < maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                Swap(ref array[pivot], ref array[i]);
            }
        }

        pivot++;
        Swap(ref array[pivot], ref array[maxIndex]);
        return pivot;
    }

    //быстрая сортировка
    public static int[] QuickSort(int[] array, int minIndex, int maxIndex)
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }

        var pivotIndex = Partition(array, minIndex, maxIndex);
        QuickSort(array, minIndex, pivotIndex - 1);
        QuickSort(array, pivotIndex + 1, maxIndex);

        return array;
    }

    public static int[] Q_QuickSort(int[] array)
    {
        return QuickSort(array, 0, array.Length - 1);
    }
}
