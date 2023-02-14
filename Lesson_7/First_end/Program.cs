Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] arr = new int[m, n];


void matrix (int[,] array){
   Console.WriteLine("Массив заданного размера, заполненный случайными числами от 1 до 9: ");
   for (int i = 0; i < m; i++){
      for (int j = 0; j < n; j++){
         array[i, j] = i + j;
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine("");
   }
   Console.WriteLine("Поменяли первую и последнюю строку местами: ");
   for (int j = 0; j < n; j++)
   {
      int temp = array[0, j];
      array[0, j] = array[m - 1, j];
      array[m - 1, j] = temp;
   }
   for (int i = 0; i < m; i++){
      for (int j = 0; j < n; j++){
         Console.Write(array[i, j] + " ");
      }
      Console.WriteLine("");
   }
}

matrix(arr);