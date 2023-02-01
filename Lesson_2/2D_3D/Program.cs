Console.WriteLine("Введите номер измерения: ");
Console.WriteLine("2D - 1");
Console.WriteLine("3D - 2");
int num = int.Parse(Console.ReadLine());
if (num == 1){
   Console.WriteLine("Введите координаты первой точки: ");
   Console.Write("X: ");
   int Xfirst = int.Parse(Console.ReadLine());
   Console.Write("Y: ");
   int Yfirst = int.Parse(Console.ReadLine());

   Console.WriteLine("Введите координаты второй точки: ");
   Console.Write("X: ");
   int Xsecond = int.Parse(Console.ReadLine());
   Console.Write("Y: ");
   int Ysecond = int.Parse(Console.ReadLine());

   int result = Convert.ToInt32(Math.Sqrt(Math.Pow(Xsecond - Xfirst, 2) + Math.Pow(Ysecond - Yfirst, 2)));
   Console.WriteLine("Расстояние между точками на плоскости с учётом округления равно: " + result);
}
else if (num == 2){
   Console.WriteLine("Введите координаты первой точки: ");
   Console.Write("X: ");
   int Xfirst = int.Parse(Console.ReadLine());
   Console.Write("Y: ");
   int Yfirst = int.Parse(Console.ReadLine());
   Console.Write("Z: ");
   int Zfirst = int.Parse(Console.ReadLine());

   Console.WriteLine("Введите координаты второй точки: ");
   Console.Write("X: ");
   int Xsecond = int.Parse(Console.ReadLine());
   Console.Write("Y: ");
   int Ysecond = int.Parse(Console.ReadLine());
   Console.Write("Z: ");
   int Zsecond = int.Parse(Console.ReadLine());

   int result = Convert.ToInt32(Math.Sqrt(Math.Pow(Xsecond - Xfirst, 2) + Math.Pow(Ysecond - Yfirst, 2) + Math.Pow(Zsecond - Zfirst, 2)));
   Console.WriteLine("Расстояние между точками в трёхмерном пространстве с учётом округления равно: " + result);
}
else{
   Console.WriteLine("Введите число 1 или 2");
}