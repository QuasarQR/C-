Console.Write("Введите номер четверти: ");
int numQuarter = int.Parse(Console.ReadLine());
if (numQuarter == 1){
   Console.WriteLine("X - [0; бесконечность)");
   Console.WriteLine("y - [0; бесконечность)");
}
else if (numQuarter == 2){
   Console.WriteLine("x - [0; -бесконечность)");
   Console.WriteLine("y - [0; бесконечность)");
}
else if (numQuarter == 3){
   Console.WriteLine("x - [0; -бесконечность)");
   Console.WriteLine("y - [0; -бесконечность)");
}
else if (numQuarter == 4){
   Console.WriteLine("x - [0; бесконечность)");
   Console.WriteLine("y - [0; -бесконечность)");
}
else{
   Console.WriteLine("Введите число от 1 до 4");
}