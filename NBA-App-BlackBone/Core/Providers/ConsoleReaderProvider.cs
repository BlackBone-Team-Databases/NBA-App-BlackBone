using NBABlackBone.Core.Contracts;
using System;
namespace NBABlackBone.Core.Providers
{
    public class ConsoleReaderProvider : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
