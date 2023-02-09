Console.Write("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];

int evenCount = 0, oddCount = 0;

for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(1, 101);
   if (array[i] % 2 == 0)
   {
      evenCount++;
   }
   else
   {
      oddCount++;
   }
}

Console.WriteLine("Чётных чисел в массиве: " + evenCount);
Console.WriteLine("Нечётных чисел в массиве: " + oddCount);