using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using Plugables;
using System.Reflection;
using System.Text;

namespace HostApplication
{
    internal class HostMefInAnApplication
    {
        [ImportMany]
        private  IEnumerable<ILogger> Loggers { get; set; }

        internal void Run()
        {
            Compose();
            if ((Loggers == null) || Loggers.Count() < 1)
            {
                Console.WriteLine("No plug-in is installed.");
                return;
            }

            foreach (var logger in Loggers)
            {
                logger.Write("My Message");
            }
        }

        private void Compose()
        {
            var directory = Directory.GetCurrentDirectory() +"\\Plug-ins\\";// GetFiles(GetExecutingFilePath() + "\\*.dll");

            var catelog = new DirectoryCatalog(directory);
            var container = new CompositionContainer(catelog);

            container.ComposeParts(this);
            /*
            foreach (var file in files.Where(f => f.EndsWith(".dll")))
            {
                DirectoryCatalog catelog = new Directorycate(Assembly.LoadFrom(file));
                 
                var container = new CompositionContainer(catelog);
                container.ComposeParts(this);    
            }
            */
        }


    }

}
