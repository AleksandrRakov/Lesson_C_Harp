int[] array = { 12, 32, 53, 64, 54, 66, 87, 78 };

int n = array.Length;
int find = 87;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
};