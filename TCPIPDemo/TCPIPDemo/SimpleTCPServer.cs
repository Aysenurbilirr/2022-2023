using System;
using System.Net;
using System.Text;

namespace TCPIPDemo
{
    internal class SimpleTCPServer
    {
        public int DataRecieved { get; internal set; }
        public Encoding StringEncoder { get; internal set; }
        public int Delimiter { get; internal set; }
        public bool IsStarted { get; internal set; }

        internal void Start(IPAddress ip, int v)
        {
            throw new NotImplementedException();
        }

        internal void Stop()
        {
            throw new NotImplementedException();
        }
    }
}