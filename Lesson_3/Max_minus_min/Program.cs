Console.Write("Задайте размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];
int max = 0;
int min = 0;

for (int i = 0; i < arraySize; i++){
   array[i] = new Random().Next(-100, 101);
}

Console.WriteLine("Был задан массив из " + arraySize + " элементов, заполненный случайными числами от -100 до 100");

foreach(int el in array){
   if (el < min) min = el;
   else if (el > max) max = el;
}

Console.WriteLine("Разница между минимальным и максимальным значением массива: " + max + " - " + min + " = " + (max - min));