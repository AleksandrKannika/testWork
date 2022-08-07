string[] EnterArray(string[] array)
{
    Console.Write($"Введите {array.Length} елементов массива через 'Enter': ");
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}


void Resize(string[] array, int newSize)
{
    string[] newArray = new string[newSize];
    for (int i = 0; i < array.Length && i < newArray.Length; i++)
    {
        newArray[i] = array[i];
    }
    Console.WriteLine("Массив с 3 и менее символами в элементе: ");
    Console.WriteLine("[" + String.Join("; ", newArray) + "]");
}

void RebuildArray(string[] array, int condition)
{
    int count = array.Length;
    int countResult = count;
    string[] result = new string[count];
    int elementResult = 0;

    for (int i = 0; i < count; i++)
    {
        if (condition >= array[i].Length)
        {
            result[elementResult] = array[i];
            elementResult++;
        }
        else
        {
            countResult--;
        }
    }
    Resize(result, countResult);
}

string[] customArray = new string[5];

EnterArray(customArray);
Console.WriteLine("Пользовательский массив: ");
Console.Write("[" + String.Join("; ", customArray) + "]");
Console.WriteLine();
RebuildArray(customArray, 3);