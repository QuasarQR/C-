Console.Write("Задайте размер массива, состоящий из чётного количества элементов: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];

for (int i = 0; i < arraySize; i++){
   array[i] = new Random().Next(1, 21);
}

Console.WriteLine("Был задан массив из " + arraySize + " элементов, заполненный случайными числами от 1 до 21");

for (int i = 0; i != arraySize / 2; i ++){
   Console.Write("Произведение " + (i + 1) + " пары чисел равно: " + array[i] + " * " + array[arraySize - i - 1] + " = ");
   Console.WriteLine(array[i] * array[arraySize - 1 - i]);
}