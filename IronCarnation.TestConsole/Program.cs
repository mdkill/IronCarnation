using System;

using IronCarnation.Engine;

namespace IronCarnation.TestConsole
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting");
                EngineRunner.Instance.RunAll("..\\..\\TestModelConfig\\");
                
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception");
                while(e != null)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);

                    e = e.InnerException;
                }
            }
            finally
            {
                Console.WriteLine("DONE");
                Console.ReadLine();
            }
        }
    }
}
