Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string numberS = number.ToString();
int result = 0;

for (int i = 0; i < numberS.Length; i ++){
   Console.WriteLine(int.Parse(numberS[i].ToString()));
   result += int.Parse(numberS[i].ToString());
}
Console.WriteLine("Результат суммы всех цифр числа " + number + ": " + result);