class Program
{
public static void Main(string[] args)
{
    int a = 1;
    int b = 1;
    int c;
    Console.WriteLine("Gia tri ban dau la {0} va {1}",a,b);
    Mul(ref a, ref b);
    Example(out c);
    Console.WriteLine("Gia tri sau khi thay doi la {0} va {1} va {2}",a,b,c);
}  
static void Mul(ref int a, ref int b)
{
    a = 20*2;
    b = 40*2;
}
static void Example(out int c)
{
    c = 100;
}
}




