Console.Write("Введите число N: ");
int N = int.Parse (Console.ReadLine());
int[] array = new int[N];

for (int i = 0; i < N; i++){
   array[i] = i + 1;
   Console.WriteLine("Куб числа " + array[i] + " равен: " + Math.Pow(array[i], 3));
}
