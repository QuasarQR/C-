
int number = 12345;
int sum = SumDigits(number);
Console.WriteLine("Сумма цифр числа {0} равна {1}", number, sum);

int SumDigits(int number)
{
   if (number == 0)
   {
      return 0;
   }
   else
   {
      int lastDigit = number % 10;
      return lastDigit + SumDigits(number / 10);
   }
}
