// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y


bool x = true;
bool y = true;
bool n1 = false;

if (!(x || y) == (!x && !y))
{
     n1 = true;
    Console.WriteLine("Первый вариант " + n1);
}
else
{
     n1 = false;
    Console.WriteLine("Первый вариант " + n1);
}


x = true;
y = false;
bool n2 = false;

if (!(x || y) == (!x && !y))
{
     n2 = true;
    Console.WriteLine("Второй вариант " + n2);
}
else
{
     n2 = false;
    Console.WriteLine("Второй вариант " + n2);
}


x = false;
y = true;
bool n3 = true;

if (!(x || y) == (!x && !y))
{
     n3 = true;
    Console.WriteLine("Третий вариант " + n3);
}
else
{
    n3 = false;
    Console.WriteLine("Третий вариант " + n3);
}


x = false;
y = false;
bool n4 = true;

if (!(x || y) == (!x && !y))
{
     n4 = true;
    Console.WriteLine("Четвертый вариант " + n4);
}
else
{
     n4 = false;
    Console.WriteLine("Четвертый вариант " + n4);
}


if (n1 && n2 && n3 && n4) 
{
    Console.WriteLine("Истина");
}
else
{
    Console.WriteLine("Ложь");
}
