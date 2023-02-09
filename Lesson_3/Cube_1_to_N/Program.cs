Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++){
   Console.WriteLine("Куб числа " + i + " равен: " + (i * i * i));
}
