namespace ekzamen;

public class Coktail
{
    //метод обмена элементов
    static void Swap(ref int e1, ref int e2)
    {
        (e1, e2) = (e2, e1);
    }

    //сортировка перемешиванием
    static int[] ShakerSort(int[] array)
    {
        for (var i = 0; i < array.Length / 2; i++)
        {
            var swapFlag = false;
            //проход слева направо
            for (var j = i; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                    swapFlag = true;
                }
            }

            //проход справа налево
            for (var j = array.Length - 2 - i; j > i; j--)
            {
                if (array[j - 1] > array[j])
                {
                    Swap(ref array[j - 1], ref array[j]);
                    swapFlag = true;
                }
            }

            //если обменов не было выходим
            if (!swapFlag)
            {
                break;
            }
        }

        return array;
    }
}          