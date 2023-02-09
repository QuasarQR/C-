Console.Write("Введите размер массива (чётное количество элементов): ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];
Console.WriteLine("Был задан массив из " + arraySize + " элементов, заполненный случайными числами от 1 до 10");

for (int i = 0; i < array.Length; i++){
   array[i] = new Random().Next(1, 11);
   Console.Write(array[i] + " ");
}
Console.WriteLine("");

for (int i = 0; i < arraySize / 2; i++){
   Console.WriteLine("Произведение " + (i + 1) + " пары равно: " + array[i] * array[arraySize - i - 1]);
}