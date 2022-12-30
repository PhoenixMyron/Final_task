void PrintArray(string[] array )
{
    for ( int i = 0; i < array.Length ; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FindElements(string[] array, string[] SecondArray)
{
    for ( int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            SecondArray[i] = array[i];
            Console.Write($"{SecondArray[i]} ");
        }
    }
}


Console.Clear();
Console.Write("Enter array elements: ");
string? words = Console.ReadLine();
string[] array = words.Split(' ');
string[] SecondArray = words.Split(' ');
Console.WriteLine("Initial array: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Final array: ");
FindElements(array,SecondArray);
