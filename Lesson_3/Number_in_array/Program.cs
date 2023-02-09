Console.Write("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];

Console.Write("Введите минимально допустимое число в массиве: ");
int minValue = int.Parse(Console.ReadLine());

Console.Write("Введите максимально допустимое число в массиве: ");
int maxValue = int.Parse(Console.ReadLine());

Console.Write("Введите загаданное число для проверки наличия его в массиве: ");
int number = int.Parse(Console.ReadLine());
bool contains = false;

for (int i = 0; i < array.Length; i++){
   array[i] = new Random().Next(minValue, maxValue + 1);
}

foreach (int el in array)
{
   if (el == number)
   {
      contains = true;
      break;
   }
}

if (contains == true){
   Console.WriteLine("Число " + number + " присутствует в массиве");
}
else{
   Console.WriteLine("Число " + number + " отсутствует в массиве");
}