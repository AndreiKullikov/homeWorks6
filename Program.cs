// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.Write("Введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// int count =0;
// int [] strs = new int[n];
// for (int i = 0; i < n; i++)
// {
//     Console.Write("Введите строку ", i + 1);
//     strs[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     Console.WriteLine(strs[i]);
// }

// for (int z = 0; z < strs.Length; z++)
// {
//     if (strs[z] > 0)
//         {
//            count++;
//         }
    
// }
// Console.Write("колличество значений больше 0= "+count);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());

int x = (-b2 + b1)/(-k1 + k2);
int y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");