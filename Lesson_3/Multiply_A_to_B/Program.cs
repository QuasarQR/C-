﻿Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 0; i < B; i++){
   result *= A;
}
Console.WriteLine("Куб числа " + A + " равен: " + result);

