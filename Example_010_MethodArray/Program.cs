int[] array = { 1, 2, 3, 44, 5, 4, 7, 8 };

int n = array.Length;

int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.Write(index);
        break;
    }
    index++;

}