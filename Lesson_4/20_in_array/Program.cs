Console.Write("Введите размер списка: ");
int listSize = int.Parse(Console.ReadLine());
List<int> numbers = new List<int> {};
bool found = false;

for (int i = 0; i < listSize; i++){
   numbers.Add(new Random().Next(1, 21));
   Console.Write(numbers[i] + " ");
}
Console.WriteLine("");

for (int i = 0; i < numbers.Count; i++)
{
   if (numbers[i] == 20 && !found)
   {
      numbers[i] = 200;
      found = true;
   }
}

Console.WriteLine("Результат: ");
foreach (int number in numbers)
{
   Console.Write(number + " ");
}