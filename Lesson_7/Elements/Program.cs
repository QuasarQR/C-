Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] arr = new int[m, n];

Console.WriteLine("Массив заданного размера, заполненный случайными числами от 1 до 9: ");
void matrix (int[,] array){
   for (int i = 0; i < m; i++){
      for (int j = 0; j < n; j++){
         array[i, j] = new Random().Next(1, 10);
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine("");
   }
   Console.WriteLine();
   Console.WriteLine("Упорядочили элементы в каждой строке по убыванию: ");
   for (int i = 0; i < m; i++)
   {
      int[] row = new int[n];
      for (int j = 0; j < n; j++)
      {
         row[j] = arr[i, j];
      }
      Array.Sort(row);
      Array.Reverse(row);
      for (int j = 0; j < n; j++)
      {
         arr[i, j] = row[j];
      }
   }
   for (int i = 0; i < m; i++){
      for (int j = 0; j < n; j++){
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine("");
   }
}

matrix(arr);