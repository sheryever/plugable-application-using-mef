using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace HostApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostMefInAnApplication();
            host.Run();

            Console.ReadKey();
        }

    }
}
