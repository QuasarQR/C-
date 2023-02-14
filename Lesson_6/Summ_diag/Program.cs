Console.Write("Введите количество строк и столбцов (для подсчёта суммы элементов главной диагонали): ");
int n = int.Parse(Console.ReadLine());
int[,] arr = new int[n, n];
int sum = 0;

Console.WriteLine("Массив заданного размера, заполненный случайными числами от 1 до 9: ");
void matrix (int[,] array){
   for (int i = 0; i < n; i++){
      for (int j = 0; j < n; j++){
         array[i, j] = new Random().Next(1, 10);
         Console.Write(array[i, j] + " ");
         if (i == j) sum+= array[i, j];
      }
      Console.WriteLine("");
   }
}

matrix(arr);
Console.WriteLine("Сумма элементов на главной диагонали: " + sum);