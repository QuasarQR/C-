Console.Write("Введите трёхзначное число: ");
int number = int.Parse (Console.ReadLine());
string secondDigit = number.ToString();
Console.WriteLine("Вторая цифра вашего числа: " + secondDigit[1]);