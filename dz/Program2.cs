public static class Lesson457
{
    static void Main()
    {
   
//Задача Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//формирует массив из строк, длина которых меньше либо равна 3 символа. 

string[] arrayOne = new string[5] {"44", "Cruassan", "hello", "world", "GB"};
string[] arrayTwo = new string[arrayOne.Length];

// Метод определения 3 элементов в массиве

void CorrectLength (string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        arrayTwo[count] = arrayOne[i];
        count = count + 1;
        }
    }
}

//Метод печати массива

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//Объявление методов

CorrectLength(arrayOne, arrayTwo);
PrintArray(arrayTwo);
    }
}