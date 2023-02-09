Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
int result = 0;

for (int i = 1; i <= A; i++){
   result += i;
}
Console.WriteLine("Сумма чисел от 1 до " + A + " равна: " + result);