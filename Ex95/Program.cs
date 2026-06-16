<<<<<<< HEAD
﻿
=======
﻿int idade;
float altura;

int somaIdades = 0;
int contIdades = 0;

float somaAlturas = 0;
int contAlturas = 0;

for (int i = 1; i <= 45; i++)
{
    Console.Write("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.Write("Digite a altura: ");
    altura = float.Parse(Console.ReadLine());

    if (altura < 1.70)
    {
        somaIdades = somaIdades + idade;
        contIdades = contIdades + 1;
    }

    if (idade > 20)
    {
        somaAlturas = somaAlturas + altura;
        contAlturas = contAlturas + 1;
    }
}

Console.WriteLine("Idade média: " + (somaIdades / contIdades));
Console.WriteLine("Altura média: " + (somaAlturas / contAlturas));
>>>>>>> PRONTASAdicionar arquivos de projeto.
