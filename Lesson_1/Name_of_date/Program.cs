Console.Write("Введите, пожалуйста, номер дня недели от 1 до 7: ");
int numberOfDate = int.Parse (Console.ReadLine());

if (numberOfDate == 1)
{
Console.WriteLine("День недели: понедельник");
}
else if (numberOfDate == 2) 
{
Console.WriteLine("День недели: вторник");
}
else if (numberOfDate == 3)
{
Console.WriteLine("День недели: среда");
}
else if (numberOfDate == 4) 
{
Console.WriteLine("День недели: четверг");
}
else if (numberOfDate == 5)
{
Console.WriteLine("День недели: пятница");
}
else if (numberOfDate == 6)
{
Console.WriteLine("День недели: суббота");
}
else if (numberOfDate == 7)
{
Console.WriteLine("День недели: воскресенье");
}
else
{
Console.WriteLine("Вы ввели некорректный номер дня недели");
}