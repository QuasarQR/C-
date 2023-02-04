Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Кубы чисел, заканчивающихся на чётную цифру: ");
// В целом любое число, заканчивающееся на чётную цифру, будет чётным, но в условии написано про
// "заканчивающееся на чётную цифру", поэтому смастерил проверку на чётность последней цифры
//Также исключил из ответов 0, поскольку его куб будет равен 0
for (int i = 1; i <= N; i++){
   string iString = i.ToString();
   char lastDigit = iString[iString.Length - 1];
   if (int.Parse(lastDigit.ToString()) % 2 == 0){
      Console.WriteLine("Куб числа " + i + " равен: " + i * i * i);
   }
}