int numero;
int soma = 0;
int maior = 0;
int menor = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write("Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    soma = soma + numero;

    if (i == 1)
    {
        maior = numero;
        menor = numero;
    }

    if (numero > maior)
    {
        maior = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }
}

int media = soma / 10;

Console.WriteLine("Média: " + media);
Console.WriteLine("Maior número: " + maior);
Console.WriteLine("Menor número: " + menor);