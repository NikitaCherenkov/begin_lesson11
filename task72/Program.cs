/*
Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
В массиве data хранится информация о количестве бит, которые занимают числа из массива info.
Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
*/

int[] data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1 };
int[] info = new int[] { 2, 3, 3, 1, 4 };
int position = 0;
Console.WriteLine("");
Console.WriteLine("Входные данные: ");
Console.WriteLine("");
Console.WriteLine($"data = {PrintArray(data)}");
Console.WriteLine($"info = {PrintArray(info)}");
Console.WriteLine("");
Console.Write("Выходные данные: ");
for (int i = 0; i < info.Length; i++)
{
    Console.Write((Matching(data, info[i], position)));
    if (i < info.Length - 1) Console.Write(", ");
    position += info[i];
}

int Matching(int[] BinaryData, int Count, int Starting)
{
    int Multiplier = 1;
    int Value = 0;
    for (int i = 0; i < Count; i++)
    {
        Value += Multiplier * BinaryData[Starting + Count - i - 1];
        Multiplier = Multiplier * 2;
    }
    return Value;
}

string PrintArray(int[] arr)
{
    string output = "{ ";
    for (int i = 0; i < arr.Length; i++)
    {
        output += Convert.ToString(arr[i]);
        if (i < arr.Length - 1) { output += ", "; }
        else
        {
            output += " ";
        };
    }
    output += "}";
    return output;
}
