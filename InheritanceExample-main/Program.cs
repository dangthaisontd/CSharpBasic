internal class Program
{
    private static void Main(string[] args)
    {
     Mosgian mos = new Mosgian(1,2);
     
     if(mos is Mosgian)
     {
        Console.WriteLine("Gia tri la{0} ",mos.atack);
        Console.WriteLine("Gia tri la{0} ",mos.health);
        mos.SetColor();
     }
    }
}
