internal class Program
{
    private static void Main(string[] args)
    {
        List<int> mylists = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            mylists.Add(i);    
        }
        Console.WriteLine(mylists.Count);
        foreach (var item in mylists)
        {
            Console.Write(item+",");
        }
        Console.WriteLine("");
        mylists.RemoveAt(5);
        foreach (var item in mylists)
        {
            Console.Write(item+",");
        }
    }
}

// Count so phan tu bao gom trong list
//Add them phan tu list
//Removeat(indext);
//clear xoa toan bo