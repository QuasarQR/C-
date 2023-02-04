int[] array = new int[123];
int count = 0;

for (int i = 0; i < array.Length; i++){
   array[i] = new Random().Next(1, 1000);
}
Console.WriteLine("Был задан массив из 123 случайных чисел");

foreach (int el in array){
   if (el > 9 && el < 100) count++;
}

Console.WriteLine("В заданном массиве количество чисел, принадлежащих отрезу [10,99]: " + count);