static class Lesson456
{
    static void Main()
    {
      
       //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

      //Создание массива

      Console.WriteLine("Введите длину массива:  ");
      int size = Convert.ToInt32(Console.ReadLine());

      //Определение размера массива

      int[] array = new int[size];
      RandomNumbers(array);

      //Печать массива

      Console.WriteLine("Массив: ");
      PrintArray(array);

      //Заполнение массива случайными трёхзначными числами

      void RandomNumbers(int[] array)
      {
      for(int i = 0; i < size; i++)
      {
        array[i] = new Random().Next(100,1000);
      }
      }

      //Определение чётности чисел в массиве

      int count = 0;

      for (int a = 0; a < array.Length; a++)
      {
      if (array[a] % 2 == 0)
      count++;
      }

      //Печать результата

      Console.WriteLine($"из {array.Length} чисел, {count} четных");
      void PrintArray(int[] array)
      {
      Console.Write("[ ");
      for(int i = 0; i < array.Length; i++)
      {
      Console.Write(array[i] + " ");
      }
      Console.Write("]");
      Console.WriteLine();
      }  
  }
    
}
