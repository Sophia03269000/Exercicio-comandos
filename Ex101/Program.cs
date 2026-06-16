int numero;
int fatorial = 1;

Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    fatorial = fatorial * i;
}

Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);