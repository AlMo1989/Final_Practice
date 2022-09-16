string[] array = { "777", "cat", "Code", "Array", "bad", ":-)", "lot", "Boo", "Yes", ":)" };

string[] FindCountStringLessThanFourChar(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

void PrintArray(string[] arr)
{
    if (arr.Length == 0)
    {
        Console.WriteLine("There is NO suitable elements in array");
    }
    else
    {
        Console.Write("Array with elements length less than 3 is: ");
        for (int i = 0; i < arr.Length; i++)
        {
           Console.Write($"{arr[i]} ");
        }
    }
}

Console.WriteLine("Result:");
string[] newArray = FindCountStringLessThanFourChar(array);
PrintArray(newArray);
Console.WriteLine();