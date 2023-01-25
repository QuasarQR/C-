Console.Write("Введите число для проверки на чётность: ");
int evenNumber = int.Parse (Console.ReadLine());
if (evenNumber % 2 == 0){
   Console.WriteLine("Число " + evenNumber + " является чётным");
}
else{
   Console.WriteLine("Число " + evenNumber + " явялется нечётным");
}