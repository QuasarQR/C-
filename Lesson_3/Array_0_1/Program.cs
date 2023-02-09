Console.Write("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());
int[] array = new int[arraySize];

Console.WriteLine("Результат массива заданного размера, состоящего из чисел 0 и 1: ");
for (int i = 0; i < arraySize; i++){
   array[i] = new Random().Next(0, 2);
   Console.Write(array[i] + " ");
}