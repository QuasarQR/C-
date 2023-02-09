int[] array = new int[123];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(1, 1001);
}

foreach (int el in array){
   if (el >= 10 && el <= 99){
      count++;
   }
}

Console.WriteLine("Был задан одномерный массив из 123 случайных чисел от 1 до 1000.");
Console.WriteLine("Количество элементов, принадлежащих отрезку от 10 до 99 включительно равно: " + count);