// See https://aka.ms/new-console-template for more information



using System.Threading.Tasks;

bool Clock(DateTime date)
{
    
    DateTime actually;
    do
    {
        actually = DateTime.Now;
        TimeSpan ts = date - actually;
        Console.WriteLine("il reste : " + ts.Seconds.ToString() + " secondes");
    } while (actually < date);

    return true;
}

void ring()
{
    Clock(DateTime.Now.AddMinutes(1));
    Console.WriteLine("Il faut se réveiller");
}

ring();


