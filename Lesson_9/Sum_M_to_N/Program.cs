int m = 1;
int n = 10;
int sum = Sum(m, n);

Console.WriteLine($"Сумма элементов от {m} до {n} равна {sum}");


int Sum(int m, int n)
{
   if (m > n)
   {
      return 0;
   }
   else
   {
      return m + Sum(m + 1, n);
   }
}