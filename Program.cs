namespace AppConHilos;

class Program
{

    public static void DoTrabajoPesado()
    {
        Console.WriteLine("DoTrabajoPesado: Estoy levantando un camion!");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: Cansado! necesito una siesta de 3 segundos...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 1...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 2...");
        Thread.Sleep(1000);
        Console.WriteLine("DoTrabajoPesado: 3...");
        Console.WriteLine("DoTrabajoPesado: Ya he despertado.");
    }

    public static void DoAlgo()
    {
        Console.WriteLine("DoAlgo: Oye! Haciendo algo aquí!");
        
        for (int iterator = 0; iterator < 20; iterator++)
        {
            Console.WriteLine($"{iterator}, ");
        }
        Console.WriteLine();
        Console.WriteLine("Ya terminé!");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("El MainThread comienza aquí.");

        Thread backgroundThread = new Thread(new ThreadStart(Program.DoTrabajoPesado));
        backgroundThread.Start();

        DoAlgo();

        Console.WriteLine("El hilo principal termina aquí.");

    }
}
