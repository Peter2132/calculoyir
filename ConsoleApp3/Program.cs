string txt;

do
{

    Console.WriteLine("Выбирете операцию");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    txt = Console.ReadLine();
    if (txt == "9")
    {
        break;
    }




    Console.WriteLine("Введи первое число");
    string input1 = Console.ReadLine();
    int x = Convert.ToInt32(input1);
    int x;
    while (!int.TryParse(input1, out x))
    {
        Console.WriteLine("Неверный");
        input1 = Console.ReadLine();
    }
    Console.WriteLine("Введи второе число");
    string input12 = Console.ReadLine();
    int y = Convert.ToInt32(input12);
    int y;
    while (!int.TryParse(input12, out y))
    {
        Console.WriteLine("Неверный");
        input12 = Console.ReadLine();
    }






    if (txt == "1")
    {
        int result = x + y;
        Console.WriteLine("Ответ:");
        Console.WriteLine(result);
    }
    else if (txt == "2")
    {
        int result = x - y;
        Console.WriteLine("Ответ:");
        Console.WriteLine(result);
    }
    else if (txt == "3")
    {
        int result = x * y;
        Console.WriteLine("Ответ:");
        Console.WriteLine(result);

    }
    else if (txt == "4")
    {
        int result = x / y;
        Console.WriteLine("Ответ:");
        Console.WriteLine(result);

    }
    else if (txt == "5")
    {
        double pow = Math.Pow(x, y);
        Console.WriteLine("Ответ:");
        Console.WriteLine(pow);
    }

    else if (txt == "6")
    {
        double sprt = Math.Sqrt(x);
        Console.WriteLine("Ответ:");
        Console.WriteLine(sprt);
    }
    else if (txt == "7")
    {
        int result = x * y / 100;
        Console.WriteLine("Ответ:");
        Console.WriteLine(result);
    }
    else if (txt == "8")
    {
        int number = x;
        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Ответ:");
        Console.WriteLine(factorial);


    }

} while (txt != "9");