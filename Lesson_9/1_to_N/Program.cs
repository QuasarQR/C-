Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

PrintNaturalNumbers(1, n);

void PrintNaturalNumbers(int current, int max)
{
   Console.WriteLine(current);
   if (current < max)
   {
      PrintNaturalNumbers(current + 1, max);
   }
}





