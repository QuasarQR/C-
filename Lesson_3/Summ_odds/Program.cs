Console.Write("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(1, 11);
   if (i % 2 > 0){
      sum += array[i];
   }
}
Console.WriteLine("Был задан массив размера " + arraySize + ", заполненный случайными числами от 1 до 10");
Console.WriteLine("Сумма элементов, находящихся на нечётной позиции равна: " + sum);
