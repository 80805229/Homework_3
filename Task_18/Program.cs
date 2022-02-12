// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


Console.WriteLine("Введите значение x и y (true/false)");

Console.Write("x = ");
bool x = bool.Parse(Console.ReadLine());

Console.Write("y = ");
bool y = bool.Parse(Console.ReadLine());

 if (!(x || y) == !x && !y)
    {
        Console.WriteLine("Истина");
    }

else
    {
        Console.WriteLine("Не истина");
    }


