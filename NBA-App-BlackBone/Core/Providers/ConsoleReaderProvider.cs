using NbaBlackBone.Core.Contracts;
using System;
namespace NbaBlackBone.Core.Providers
{
    public class ConsoleReaderProvider : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
