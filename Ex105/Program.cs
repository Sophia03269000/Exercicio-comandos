<<<<<<< HEAD
﻿Console.WriteLine("Hello, World!");
=======
﻿int primeiro = 0;
int segundo = 1;
int proximo;

Console.Write(primeiro + " " + segundo + " ");

for (int i = 3; i <= 20; i++)
{
    proximo = primeiro + segundo;
    Console.Write(proximo + " ");

    primeiro = segundo;
    segundo = proximo;
}
>>>>>>> PRONTASAdicionar arquivos de projeto.
