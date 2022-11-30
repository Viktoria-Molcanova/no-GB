//3 задача.Найти все чётные числа от 1 до N
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int start = 1;
while (start <= a)
            {
                if (start % 2 != 1)
                {
                    Console.Write(start + " ");
                    
                }
                start++;
            }

           