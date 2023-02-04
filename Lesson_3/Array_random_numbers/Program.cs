Console.Write("Задайте размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];
// Чётные числа - even, нечётные - odd
int even = 0;
int odd = 0;

for (int i = 0; i < arraySize; i++){
   array[i] = new Random().Next(100, 1000);
}

foreach(int el in array){
   if (el % 2 == 0) even++;
   else odd++;
   }

Console.WriteLine("Количество чётных чисел в массиве :" + even);
Console.WriteLine("Количество нечётных чисел в массиве :" + odd);