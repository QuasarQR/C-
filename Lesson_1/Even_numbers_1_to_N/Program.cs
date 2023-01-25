Console.Write("В промеутке от 1 до N будут отображены все чётные числа. Введите число N: ");
int nNumber = int.Parse (Console.ReadLine());
int count = 1;
while (count != nNumber + 1){
   if (count % 2 == 0){
      Console.WriteLine(count);
   }
   count += 1;
}