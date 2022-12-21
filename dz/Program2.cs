public static class Lesson457
{
    static void Main()
    {

      /*Задача 47. 
      Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
      */
    
    int colums = ReadInt("Укажите количество столбцов: ");
    int rows = ReadInt("Укажите количество строк: ");
    double[,] numbers = new double[rows, colums];
    FillArray2D(numbers);
    PrintArray2D(numbers);
    // Ввод массива
    int ReadInt(string message)
    {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }
    // Функция заполнения массива 
    void FillArray2D(double[,] array)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10.0;
        }
    }
}

    //  Функция вывода массива в терминал
    void PrintArray2D(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
                Console.WriteLine();
         }
    Console.WriteLine();
}
    }}