try
{
    Console.WriteLine("Введите четырёхзначное число: ");
    int num = int.Parse(Console.ReadLine());
    double char1 = num / 1000;
    double char2 = num % 1000 / 100;
    double char3 = num % 100 / 10;
    double char4 = num % 10;

    if (num==char4*1000+char3*100+char2*10+char1) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
