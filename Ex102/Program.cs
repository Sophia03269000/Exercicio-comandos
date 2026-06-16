string nome;
int diarias;
double taxaServico;
double totalConta;
double totalHotel = 0;

for (int i = 1; i <= 30; i++)
{
    Console.Write("Nome do cliente: ");
    nome = Console.ReadLine();

    Console.Write("Número de diárias: ");
    diarias = int.Parse(Console.ReadLine());

    if (diarias < 15)
    {
        taxaServico = 4.00;
    }
    else if (diarias == 15)
    {
        taxaServico = 3.60;
    }
    else
    {
        taxaServico = 3.00;
    }

    totalConta = diarias * (50 + taxaServico);

    Console.WriteLine("Cliente: " + nome);
    Console.WriteLine("Total da conta: R$ " + totalConta);

    totalHotel = totalHotel + totalConta;
}

Console.WriteLine("Total ganho pelo hotel: R$ " + totalHotel);
