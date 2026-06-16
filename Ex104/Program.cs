int num1;
int num2;
int resultado = 0;

Console.Write("Digite o primeiro número: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
num2 = int.Parse(Console.ReadLine());

for (int i = 1; i <= num2; i++)
{
    resultado = resultado + num1;
}

Console.WriteLine("Resultado da multiplicação: " + resultado);