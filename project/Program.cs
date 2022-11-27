static int GetSortedArray(string[] array, int maxElementLength)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index].Length <= maxElementLength)
        {
            string temp = array[count];
            array[count] = array[index];
            array[index] = temp;
            count++;
        }
    }
    return count;
}

static void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        Console.Write("[\"");
        string print = string.Join("\", \"", array);
        Console.Write(print);
        Console.Write("\"]");
    }
    else
        Console.Write("[]");
}

static void PrintResult(string[] array, int maxElementLength)
{
    PrintArray(array);
    Console.Write(" -> ");
    int length = GetSortedArray(array, maxElementLength);
    Array.Resize(ref array, length);
    PrintArray(array);
    Console.WriteLine();
}


string[] firstArray = new string[] { "hello", "2", "world", ":-)" };
string[] secondArray = new string[] { "1234", "1567", "-2", "computer science" };
string[] thirdArray = new string[] { "Russia", "Denmark", "Kazan" };
int maxElementLength = 3;

Console.Clear();
PrintResult(firstArray, maxElementLength);
PrintResult(secondArray, maxElementLength);
PrintResult(thirdArray, maxElementLength);

