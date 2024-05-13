public class Mosgian : Enemy
{
    private int valueTemp=3;
    
    public Mosgian(int atack, int health) : base(atack, health)
    {
    }

    public Mosgian(string a, string b, string c) : base(a, b, c)
    {

    }
    public override void SetColor()
    {
      base.SetColor();
      Console.WriteLine("Gia tri nay la mau mac dinh",valueTemp.ToString());
    }
}