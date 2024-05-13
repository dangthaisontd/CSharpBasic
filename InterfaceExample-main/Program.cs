using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
          Fish fishyellow = new Fish();
          IAnimal  fishred = new Fish();
          fishred.Eat();
          IWater  fishGeen = new Fish();
          fishGeen.Swiming();
          Iattack fishBLue = new Fish();
          fishBLue.Attack();
    }
}
public abstract class CatSmall()
{
      public abstract string HowToEat();
}
public interface IAnimal
{
   void Eat();
}
public interface IWater
{
    void Swiming();
}
public interface Iattack
{
    void Attack();
}
public class Fish : IAnimal, IWater,Iattack
{
    public void Attack()
    {
       Console.WriteLine("Attack");
    }
    public void Eat()
    {
        Console.WriteLine("an  Reu");
    }
    public void Swiming()
    {
       Console.WriteLine("boi");
    }
}
public class Cat : CatSmall
{
    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}
public class CharFish: CatSmall
{
    public override string HowToEat()
    {
        throw new NotImplementedException();
    }
}
