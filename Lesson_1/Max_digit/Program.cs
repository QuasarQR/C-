int randomDigit = new Random().Next(10, 100);
string myNumber = randomDigit.ToString();
Console.WriteLine("Ваше число: " + myNumber);
if (myNumber[0] > myNumber[1]){
   Console.WriteLine("Наибольшая цифра Вашего числа: " + myNumber[0]);
}
else{
   Console.WriteLine("Наибольшая цифра Вашего числа: " + myNumber[1]);
}