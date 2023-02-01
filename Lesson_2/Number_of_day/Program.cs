Console.Write("Введите номер дня денели: ");
int numberDate = int.Parse(Console.ReadLine());
if (numberDate == 6 || numberDate == 7){
   Console.WriteLine("Данный день недели является выходным");
}
else if (numberDate >= 1 && numberDate < 6){
   Console.WriteLine("Данный день недели не является выходным");
}
else{
   Console.WriteLine("Введите число от 1 до 7");
}