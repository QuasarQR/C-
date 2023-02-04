Console.Write("Задайте размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];
int sum = 0;

for (int i = 0; i < arraySize; i++){
   array[i] = new Random().Next(1, 101);
}

Console.WriteLine("Был задан массив из " + arraySize + " элементов, заполненный случайными числами от 1 до 100");

for (int i = 0; i < arraySize; i++){
   if (i % 2 > 0) sum += array[i];
}

Console.WriteLine("Сумма всех элементов массива на нечётной позиции равна: " + sum);