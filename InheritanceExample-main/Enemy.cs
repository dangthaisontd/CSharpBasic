public class Enemy
{
private string mycolor="";

protected string a="";
protected string  b="";
protected string  c="";
public int atack=0;
public int health=100;
public Enemy(int atack,int health)
{
this.atack = atack;
this.health = health;
}
public Enemy( string a, string  b, string  c)
{
this.a = a;
this.b = b;
this.c = c;
}
public virtual void SetColor()
{
    mycolor="Yellow";
}
}