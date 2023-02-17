Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(n);

void PrintNumbers(int n)
{
   if (n <= 0)
      return;

   Console.Write($"{n} ");

   PrintNumbers(n - 1);
}

