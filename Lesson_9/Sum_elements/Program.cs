Console.Write("Введите первый элемент последовательности: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второй элемент последовательности: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите количество элементов для показа: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("{0}\n{1}", a, b);

ShowNextElement(a, b, n - 2);

void ShowNextElement(int a, int b, int n)
{
   if (n > 0)
   {
      int c = NextElement(a, b);
      Console.WriteLine(c);
      ShowNextElement(b, c, n - 1);
   }
}

int NextElement(int a, int b)
{
   return a + b;
}