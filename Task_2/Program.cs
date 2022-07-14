// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

Console.WriteLine("Введите число №1");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
Console.WriteLine("Число №1 максимальое. Число №2 минимальное");
else Console.WriteLine("Число №2 максимальое. Число №1 минимальное");
