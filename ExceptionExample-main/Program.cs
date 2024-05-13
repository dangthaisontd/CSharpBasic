internal class Program
{
    private static void Main(string[] args)
    {
        int[] myArray = {0,1,2,3,4,5,6,7,8,9}; 
        try
        {
           Console.WriteLine(myArray[11]); 
        }
        catch (System.Exception ex)
        {
             Console.WriteLine($"{ex.Message}");
        }
        finally
        {
          // các lệnh được thực thi
        }
        //
        int a=10;
        int b=0;
        try
        {
           try
        {
            int c = a/b;
        }
        catch (FormatException ex)
        {
        Console.WriteLine(ex.Message);
        } 
        }
        catch (DivideByZeroException ex)
        {
            
            Console.WriteLine(ex.Message);
        }
    }
}