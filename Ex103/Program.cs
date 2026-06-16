double massa;
int tempo = 0;

Console.Write("Digite a massa inicial em gramas: ");
massa = double.Parse(Console.ReadLine());

while (massa >= 0.05)
{
    massa = massa / 2;
    tempo = tempo + 50;
}

Console.WriteLine("Tempo necessário: " + tempo + " segundos");
Console.WriteLine("Massa final: " + massa + " gramas");