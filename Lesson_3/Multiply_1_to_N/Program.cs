Console.Write("Введите число N: ");
int N = int.Parse (Console.ReadLine());
int[] array = new int[N];
int result = 1;

for (int i = 0; i < N; i++){
   array[i] = i + 1;
   result *= array[i];
}

Console.WriteLine("Произведение чисел от 1 до " + N + " равна: " + result);