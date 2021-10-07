using System;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                //var path = File.ReadAllText(@"..\..\..\ArquivoTXT\arquivo.txt");
                var path = new StreamReader(@"..\..\..\ArquivoTXT\arquivo.txt", Encoding.UTF7);
                //var current = Environment.CurrentDirectory;
                using (path)
                {
                    while(!path.EndOfStream)
                    {
                        var pathLine = path.ReadLine();
                        Console.WriteLine(pathLine);
                    }
                }
                //Console.WriteLine(path);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }
}
