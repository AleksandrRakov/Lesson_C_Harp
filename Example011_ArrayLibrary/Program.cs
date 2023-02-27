int[] array = new int[10];

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// int size = 10;
// int[] array = new int[size];
// int index = 0;
// while (index < size)
// {
//     array[index] =  new Random().Next(1,50);
//     index++;
// };

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

 FillArray(array);
 PrintArray(array);