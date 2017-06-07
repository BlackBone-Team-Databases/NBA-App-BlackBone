using NbaBlackBone.Core.Contracts;
using System;
namespace NbaBlackBone.Core.Providers
{
    public class ConsoleReaderProvider : IReader
    {
        public ConsoleReaderProvider()
        {

        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
