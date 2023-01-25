Console.Write("Введите число: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите число для проверки кратности: ");
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber % secondNumber == 0){
   Console.WriteLine("Число " + firstNumber + " кратно числу " + secondNumber);
}
else{
   Console.WriteLine("Число " + firstNumber + " не кратно числу " + secondNumber);
   Console.WriteLine("Остаток от деления равен: " + firstNumber % secondNumber);
}