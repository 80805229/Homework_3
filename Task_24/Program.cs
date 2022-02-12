// Найти кубы чисел от 1 до N

int n = 10;
int x = 1;
int i=1;

while(x<=n)
{
    Console.Write(x + "\t");
    x++;
}
Console.WriteLine();

while(i<=n)
{
    int i1 = i*i*i;
    Console.Write(i1 + "\t");
    i++;
}
