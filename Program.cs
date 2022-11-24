//string[] arr = { "hello", "2", "world", ":-)" };
//string[] arr = { "1234", "1567", "-2", "computer science" };
string[] arr = { "Russia", "Denmark",  "kazan" };

void PrintArray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SortArray(string[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i].Length <= 3) Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

