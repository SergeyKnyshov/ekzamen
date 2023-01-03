namespace ekzamen;

public class Tree
{
    public Tree(int data)
    {
        Data = data;
    }

    //данные
    public int Data { get; set; }

    //левая ветка дерева
    public Tree Left { get; set; }

    //правая ветка дерева
    public Tree Right { get; set; }

    //рекурсивное добавление узла в дерево
    public void Insert(Tree node)
    {
        if (node.Data < Data)
        {
            if (Left == null)
            {
                Left = node;
            }
            else
            {
                Left.Insert(node);
            }
        }
        else
        {
            if (Right == null)
            {
                Right = node;
            }
            else
            {
                Right.Insert(node);
            }
        }
    }

    //преобразование дерева в отсортированный массив
    public int[] Transform(List<int> elements = null)
    {
        if (elements == null)
        {
            elements = new List<int>();
        }

        if (Left != null)
        {
            Left.Transform(elements);
        }

        elements.Add(Data);

        if (Right != null)
        {
            Right.Transform(elements);
        }

        return elements.ToArray();
    }

    //метод для сортировки с помощью двоичного дерева
    public static int[] TreeSort(int[] array)
    {
        var tree = new Tree(array[0]);
        for (int i = 1; i < array.Length; i++)
        {
            tree.Insert(new Tree(array[i]));
        }

        return tree.Transform();
    }
    
}