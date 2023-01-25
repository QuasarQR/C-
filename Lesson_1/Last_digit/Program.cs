Console.Write("Введите трёхзначное число: ");
int number = int.Parse (Console.ReadLine());
int last_digit = number % 10;
Console.WriteLine("Последняя цифра вашего числа: " + last_digit);