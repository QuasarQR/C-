int number = new Random().Next(10, 1000);
Console.WriteLine("Программой было загадано число: " + number);
Console.WriteLine("Попробуем определить, есть ли у данного числа третий разряд?");
string myNumber = number.ToString();

if (myNumber.Length > 2){
   Console.WriteLine("Да, у данного числа есть третий разряд. Последняя цифра данного числа: " + myNumber[2]);
}
else{
   Console.WriteLine("У данного числа нет третьего разряда");
}