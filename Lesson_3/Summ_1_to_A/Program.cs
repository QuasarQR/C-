Console.Write("Введите число А: ");
int A = int.Parse (Console.ReadLine());
int[] array = new int[A];
int sum = 0;

for (int i = 0; i < A; i++){
   array[i] = i + 1;
   sum += array[i];
}

Console.WriteLine("Сумма чисел от 1 до " + A + " равна: " + sum);