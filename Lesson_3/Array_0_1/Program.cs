int[] array = new int[8];

for (int i = 0; i < 8; i++){
   array[i] = new Random().Next(0, 2);
}
Console.WriteLine("Массив из 8 элементов, состоящий из 0 и 1: ");
foreach(int el in array){
   Console.Write(el + " ");
}