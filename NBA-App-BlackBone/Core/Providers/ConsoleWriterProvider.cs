using NbaBlackBone.Core.Contracts;
using System;
namespace NbaBlackBone.Core.Providers
{
    public class ConsoleWriterProvider : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void EmptyLine()
        {
            Console.WriteLine();
        }
    }
}
