public static class Lesson457
{
    static void Main(string[] args)
    {
System.Console.Write("Введите количество элементов в массиве");
int count = int.Parse(Console.ReadLine());
int[] myArray = new int [count];
for(int i = 0; i<count;i++)
{
    Console.Write($"Введите элемент массива {i}:");
    myArray[i] = int.Parse(Console.ReadLine());
}
    }
}