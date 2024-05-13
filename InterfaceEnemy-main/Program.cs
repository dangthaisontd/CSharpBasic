
internal class Program
{
    private static void Main(string[] args)
    {
      // Wood wood= new Wood();
      // wood.Efect();
      //Iron iron = new Iron();
      //  iron.Efect();
       Grass grass= new Grass();
       grass.Efect();
       
    }
}

public interface IDamager
{
    public void Efect();
}
public interface ISource
{
    void Efect();
}
public class Wood : IDamager
{
    public void  Efect()
    {
        Console.WriteLine("Tao lo dan ban");
    }
}
public class Iron : IDamager
{
    public void Efect()
    {
       Console.WriteLine("Tao tia lua dien khi dan ban");
    }
}

public class Grass : IDamager
{
    public void Efect()
    {
       Console.WriteLine("Tao bun dat ban len khi dan ban");
    }
}
public class Water : IDamager,ISource
{
   void ISource.Efect()
    {
       
    }
   void IDamager.Efect()
    {
        
    }
}
