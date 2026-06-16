<<<<<<< HEAD
﻿Console.WriteLine("Hello, World!");
=======
﻿Console.Write("Quantidade de funcionários: ");
int quantidade = int.Parse(Console.ReadLine());

string nome;
float salario;
float soma = 0;
float maiorSalario = 0;
float menorSalario = 0;

for (int i = 1; i <= quantidade; i++)
{
    Console.Write("Nome do funcionário: ");
    nome = Console.ReadLine();

    Console.Write("Salário: ");
    salario = float.Parse(Console.ReadLine());

    soma = soma + salario;

    if (i == 1)
    {
        maiorSalario = salario;
        menorSalario = salario;
    }

    if (salario > maiorSalario)
    {
        maiorSalario = salario;
    }

    if (salario < menorSalario)
    {
        menorSalario = salario;
    }
}

float media = soma / quantidade;

Console.WriteLine("Média dos salários: " + media);
Console.WriteLine("Maior salário: " + maiorSalario);
Console.WriteLine("Menor salário: " + menorSalario);
>>>>>>> PRONTASAdicionar arquivos de projeto.
