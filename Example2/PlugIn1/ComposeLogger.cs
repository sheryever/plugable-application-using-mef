using System;
using System.ComponentModel.Composition;
using Plugables;

namespace PlugIn1
{
    [Export(typeof(ILogger))]
    internal class ComposeLogger : ILogger
    {
        public void Write(string message)
        {

            Console.WriteLine("Plug-in 1: {0}",message);
        }
    }
}
