// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти");
int num = int.Parse(Console.ReadLine());

if (num < 5)
{
    Console.Write("Диапазон возможных координат ");

    if (num == 1)
    {
        Console.WriteLine("x > 0; y > 0");
    }

    if (num == 2)
    {
        Console.WriteLine("x > 0; y < 0");
    }

    if (num == 3)
    {
        Console.WriteLine("x < 0; y < 0");
    }

    if (num == 4)
    {
        Console.WriteLine("x < 0; y > 0");
    }
}

else
{
  Console.WriteLine("Введено не верное значение");  
}
