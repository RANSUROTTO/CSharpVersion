// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double a = 0.01;
double b = 0.02;
Console.WriteLine($"a={a},b={b}, a + b = 0.03? {a + b == 0.03}");
if (a + b == 0.03)
{
    Console.WriteLine(" a + b == 0.03");
}
else
{
    Console.WriteLine("a + b != 0.03");
}

double c = 0.1;
double d = 0.2;
Console.WriteLine($"c={c},d={d}, c + d = 0.3? {c + d == 0.3}");
if (a + b == 0.3)
{
    Console.WriteLine(" c + d == 0.3");
}
else
{
    Console.WriteLine(" c + d != 0.3");
}

double e = 1.0;
double f = 2.0;
Console.WriteLine($"e={e},f={f}, e + f = 3? {e + f == 3}");
if (e + f == 3)
{
    Console.WriteLine(" e + f == 3");
}
else
{
    Console.WriteLine(" e + f != 3");
}
    