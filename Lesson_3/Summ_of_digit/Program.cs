Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 0; i < number.ToString().Length; i++){
   char digit = number.ToString()[i];
   result += int.Parse(digit.ToString());
}
Console.WriteLine("Сумма чисел равна: " + result);