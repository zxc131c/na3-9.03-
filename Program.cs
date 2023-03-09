Console.WriteLine("Алгебраическая= 1; Геометрическая = 2");
string choice = Convert.ToString(Console.ReadLine());
if (choice == "1") ;
{
    Console.WriteLine("Введите первый член");
    double n = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите знаменатель  прогрессии");
    double action = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите конечное значение");
    double lastnb = Convert.ToInt32(Console.ReadLine());
    double sum = n * ((Math.Pow(action, lastnb)) - 1) / (action - 1);
    Console.WriteLine($"Сумма геометрической прогрессии равна: {sum}");
}

if (choice == "2") ;
{
    Console.WriteLine("Введите первый член"); 
    double n1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите шаг арифметической прогрессии"); 
    double action1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите конечное значение");
    double lastnb1 = Convert.ToDouble(Console.ReadLine());

    double lastnumber = n1;
    double s = n1;

    for (double i = 0; i < lastnb1 - 1; i++)
    {
        lastnumber = lastnumber + action1;
       s = s + lastnumber;
    }

    Console.WriteLine(s);

}



