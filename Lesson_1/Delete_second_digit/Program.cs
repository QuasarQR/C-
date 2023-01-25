Console.Write("Введите трёхзначное число: ");
int number = int.Parse (Console.ReadLine());
string myNumber = number.ToString();
Console.WriteLine("Удалили вторую цифру: " + myNumber[0] + myNumber[2]);
