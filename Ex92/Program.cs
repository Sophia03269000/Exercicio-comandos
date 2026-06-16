double N;
double A = 0;

Console.Write("Digite um valor para N: ");
N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        A = A - (1.0 / i);
    }
    else
    {
        A = A + (1.0 / i);
    }
}

Console.WriteLine("Valor de A = " + A);