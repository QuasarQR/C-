Console.Write("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];

Console.WriteLine("Был задан массив размером " + arraySize + " элементов, заполненный случайными числами от -100 до 100");

for (int i = 0; i < array.Length; i++){
   array[i] = new Random().Next(-100, 101);
   Console.Write(array[i] + " ");
}
Console.WriteLine("");

int max = array[0];
int min = array[0];

foreach(int el in array){
   if (el < min) min = el;
   if (el > max) max = el;
}

Console.WriteLine("Разница между минимальным и максимальным значением в массиве равна: " + (max - min));