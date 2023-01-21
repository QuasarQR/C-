Console.Write("Введите первое число: ");
int NumA = int.Parse (Console.ReadLine());
Console.Write("Введите второе число: ");
int NumB = int.Parse (Console.ReadLine());

if (Math.Sqrt(NumA) == NumB)
{
Console.Write("Первое число является квадратом второго числа");
}
else
{
   Console.Write("Первое число не является квадратом второго числа");
}