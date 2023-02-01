Console.WriteLine("Введите два числа для проверки: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
if (num1 * num1 == num2){
   Console.WriteLine("Число " + num2 + " является квадратом числа " + num1);
}
else if (num2 * num2 == num1){
   Console.WriteLine("Число " + num1 + " является квадратом числа " + num2);
}
else{
   Console.WriteLine("Числа не являются квадратами друг друга");
}