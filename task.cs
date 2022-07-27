// Напишите программу, которая из имеющегося массива строк формирует массив строк, длинна которых меньше либо равна 3 символа.


Console.Write("Добро пожаловать в программу!");
Console.WriteLine();

string[] array1 = new string[5] { "sun", "moon", "star", "comet", "qs" };
string[] array2 = new string[array1.Length];

void Array(string[] array1, string[] array2)
{
    int count = 0;
    for (int x = 0; x < array1.Length; x++)
    {
        if (array1[x].Length <= 3)
        {
            array2[count] = array1[x];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int x = 0; x < array.Length; x++)
    {
        Console.Write($"{array[x]}\v");
    }
    Console.WriteLine();
}
Array(array1, array2);
PrintArray(array2);