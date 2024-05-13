internal class Program
{
    private static void Main(string[] args)
    {
        Tiger myTiger = new Tiger();
        myTiger.Breathe();
        myTiger.Move();
        myTiger.Eat(); 


        Turtle myTuple = new Turtle ();
        myTuple.Breathe();
        myTuple.Move();
        myTuple.Eat();
        
        Animal myCat = new Tiger();
        myCat.Breathe();
        myCat.Eat();
        myCat.Move();
        //

        Tiger MyTigerBlack = new TigerBlack();
        MyTigerBlack.Eat();
        MyTigerBlack.Breathe();
        MyTigerBlack.Move();

        
    }
}