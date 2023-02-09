// Кубы чисел, заканчивающихся на чётную цифру
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++){
   if (i % 2 == 0){
      Console.WriteLine("Куб числа " + i + " равен: " + Math.Pow(i, 3));
   }
}