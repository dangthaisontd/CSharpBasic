internal class Program
{
    private static void Main(string[] args)
    {
        string sourceFolder = @"D:\BAITAP\Data"; //File nguồn
        string sourceFilePath  = @"D:\BAITAP\Data\Source.txt";
        //tao folder


       //Directory.CreateDirectory(sourceFolder);
       //File.CreateText(sourceFilePath);
       ///

       DirectoryInfo directoryInfo = new DirectoryInfo(sourceFolder);
       directoryInfo.Create();

       FileInfo fileInfo = new FileInfo(sourceFilePath);
       fileInfo.Create();
      
    
    }
}