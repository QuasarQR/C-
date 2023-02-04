Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число В: ");
int B = int.Parse(Console.ReadLine());
int result = A;

for (int i = 0; i < B - 1; i++){
   result *= A;

}
Console.WriteLine("Результат возведения числа " + A + " в степень " + B + " равен: " + result);