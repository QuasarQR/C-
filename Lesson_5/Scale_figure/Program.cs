Console.WriteLine("Введите координаты в формате (x,x) (x,x): ");
string start = Console.ReadLine();
List<string> list = new List<string>();
List<string> result = new List<string>();

Console.Write("Введите коэффициент масштабирования (0.5, 2, либо 4): ");
string X = Console.ReadLine();
double K = 0;
if (X == "2") K = 2;
if (X == "4") K = 4;
if (X == "0.5") K = 0.5;


foreach (string el in start.Split(" ")){
   list.Add(el);
}

for (int i = 0; i < list.Count; i++){
   string part1 = list[i][1].ToString();
   string part2 = list[i][3].ToString();
   double x = Convert.ToDouble(part1) * K;
   double y = Convert.ToDouble(part2) * K;
   result.Add("(" + x + ";" + y + ")");
}

foreach (string str in result)
{
    Console.Write(str + " ");
}