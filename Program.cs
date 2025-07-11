int eroeVita = 50;
int mostroVita = 50;

int eroeAttacco = 0;
int mostroAttacco = 0;

bool eroeIsAlive = true;
bool mostroIsAlive = true;

do
{
    Random random1 = new Random();
    eroeAttacco = random1.Next(1, 11);
    Console.WriteLine("E' il turno dell'eroe!");
    Console.WriteLine("L'eroe attacca! valore attacco = " + eroeAttacco);
    mostroVita -= eroeAttacco;
    if (mostroVita <= 0)
    {
        Console.WriteLine("L'eroe ha sconfitto il mostro!");
        mostroIsAlive = false;
    }
    else
    {
        Console.WriteLine("Il mostro è stato attaccato! Vita rimanente mostro = " + mostroVita);
        Console.WriteLine("E' il turno del mostro!");
        Random random2 = new Random();
        mostroAttacco = random2.Next(1, 11);
        Console.WriteLine("Il mostro attacca! valore attacco = " + mostroAttacco);
        eroeVita -= mostroAttacco;
        if (eroeVita <= 0)
        {
            Console.WriteLine("Il mostro ha sconfitto l'eroe!");
            eroeIsAlive = false;
        }
        else
        {
            Console.WriteLine("L'eroe è stato attaccato! Vita rimanente eroe = " + eroeVita);
        }
    }
    if (eroeIsAlive && mostroIsAlive)
    {
        Console.WriteLine("Premi un qualsiasi tasto per continuare la battaglia!");
        Console.ReadKey();
    }
}
while (eroeIsAlive && mostroIsAlive);