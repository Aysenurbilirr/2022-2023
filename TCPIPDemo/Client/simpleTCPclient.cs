using System;
using System.Text;

namespace Client
{
    internal class SimpleTCPClient
    {
        public Encoding StringEncoder { get; internal set; }
        public int DataRecieved { get; internal set; }

        internal void WriteLineAndGetreply(string text, TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }
    }
}