// SНайти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите 2, если выбираете 2D пространство или введите 3, если выбираете 3D пространство");
int d = int.Parse(Console.ReadLine());

if (d == 2)
{
    Console.WriteLine("Введите координаты точек");

    Console.WriteLine("Введите xA");
    int xA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите yA");
    int yA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите xB");
    int xB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите yB");
    int yB = int.Parse(Console.ReadLine());

    double AB = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA));
    Console.WriteLine("Длина между точками равна " + AB);
}
else
{
    Console.WriteLine("Введите координаты точек");

    Console.WriteLine("Введите xA");
    int xA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите yA");
    int yA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите zA");
    int zA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите xB");
    int xB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите yB");
    int yB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите zB");
    int zB = int.Parse(Console.ReadLine());

    double AB = Math.Sqrt((xB-xA)*(xB-xA)+(yB-yA)*(yB-yA)+(zB-zA)*(zB-zA));
    Console.WriteLine("Длина между точками равна " + AB);
}