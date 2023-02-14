Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] arr = new int[m, n];

Console.WriteLine("Массив заданного размера, заполненный случайными числами от 1 до 9: ");
void matrix (int[,] array){
   for (int i = 0; i < m; i++){
      for (int j = 0; j < n; j++){
         if (i % 2 == 0 && j % 2 == 0){
            array[i, j] = new Random().Next(1, 10);
            array[i, j] *= array[i, j];
            Console.Write(array[i, j] + " ");
         }
         else{
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
         }
      }
      Console.WriteLine("");
   }

}

matrix(arr);