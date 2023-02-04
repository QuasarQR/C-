Console.Write("Задайте размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];
bool inArray = false;

Console.Write("Заполнять массив будем случаными числами. Введите минимально допустимое число для заполнения: ");
int minArray = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число для заполнения: ");
int maxArray = int.Parse(Console.ReadLine());

Console.Write("Введите число для проверки, присутствует ли оно в массиве: ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < arraySize; i++){
   array[i] = new Random().Next(minArray, maxArray + 1);
}
foreach (int el in array){
   if (el == number){
      inArray = true;
   }
}
if (inArray == true){
   Console.WriteLine("Ваше число присутсвует в заданном масиве: ");
}
else{
   Console.WriteLine("Ваше число отсутствует в заданном масиве: ");
}
foreach(int el in array){
   Console.Write(el + " ");
}