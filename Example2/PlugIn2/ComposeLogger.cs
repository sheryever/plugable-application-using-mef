using System;
using System.ComponentModel.Composition;
using Plugables;

namespace PlugIn2
{
    [Export(typeof(ILogger))]
    internal class ComposeLogger : ILogger
    {
        public void Write(string message)
        {

            Console.WriteLine("Plug-in 2: {0}",message);
        }
    }
}
