// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите 5 чисел:   ");
int A1=Convert.ToInt32(Console.ReadLine());
int A2=Convert.ToInt32(Console.ReadLine());
int A3=Convert.ToInt32(Console.ReadLine());
int A4=Convert.ToInt32(Console.ReadLine());
int A5=Convert.ToInt32(Console.ReadLine());
int[] Array={A1, A2, A3, A4, A5};

int count=0;

for (int i = 0; i <Array.Length; i++)
{
   if (Array[i]>0) count++;
}
Console.WriteLine("Количество введеных положительных чисел " + count);
