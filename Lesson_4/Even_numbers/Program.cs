Console.Write("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];
int even = 0;

Console.WriteLine("Был задан массив размером " + arraySize + " элементов, заполненный случайными числами от 100 до 999");

for (int i = 0; i < array.Length; i++){
   array[i] = new Random().Next(100, 1000);
   Console.Write(array[i] + " ");
}
Console.WriteLine("");

for (int i = 0; i < array.Length; i++){
   if (array[i] % 2 == 0) even ++;
}

Console.WriteLine("Количество чётных чисел в заданном массиве равно: " + even);