int numero;
int somaPositivos = 0;
int quantidadeNegativos = 0;

for (int i = 1; i <= 50; i++)
{
    Console.Write("Digite um valor inteiro: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        somaPositivos = somaPositivos + numero;
    }

    if (numero < 0)
    {
        quantidadeNegativos = quantidadeNegativos + 1;
    }
}

Console.WriteLine("Soma dos números positivos: " + somaPositivos);
Console.WriteLine("Quantidade de valores negativos: " + quantidadeNegativos);