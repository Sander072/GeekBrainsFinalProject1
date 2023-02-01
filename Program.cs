Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите строки:");

string[] array = NewArray (n);

ThreeCharacters(array, n);

void ThreeCharacters(string[] array, int n)
{
    int x = 0;
    int y = 0;
    for (int i = 0; i < n; i++)
    {
        if(array[i].Length < 4)
        {
            x = x + 1;
        }
    }
    
    string[] array1 = new string [x];
    for (int j = 0; j < n; j++)
    {
        if(array[j].Length < 4)
        {
            array1[y] = array[j];
            y = y + 1;
        }
    }
    PrintArray (array1);

}

string[] NewArray (int n)
{
    string[] array = new string [n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray (string[] array)
{
    if(array.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]},");
        }
        Console.Write(array[array.Length - 1]);
        Console.WriteLine("]");
    }
    else
    {
        Console.WriteLine("[]");
    }
} 