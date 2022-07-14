// Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число №1");
  int num_1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите число №2");
  int num_2 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Введите число №3");
  int num_3 = Convert.ToInt32(Console.ReadLine());
  int max ;

  if (num_1 > num_2)
  max = num_1;
  else max = num_2;

  if (num_3 > max)
  max = num_3;

Console.WriteLine($"Число {max} максимальое");

 