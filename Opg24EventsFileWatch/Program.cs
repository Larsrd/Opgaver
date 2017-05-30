using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg24EventsFileWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher watcher = new System.IO.FileSystemWatcher(@"C:\temp", "*.txt");
            watcher.EnableRaisingEvents = true;

            //inkluder evt en af to nedenstående, som sørger for at eventen kun registreres
            watcher.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size; // fyrer kun hvis størrelsen har ændret sig
            //watcher.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.LastWrite; //fyrer hvis der gemmes, men desværre to gange!

            watcher.Changed += Watcher_Changed;
            while (true)
            { }
        }

        private static void Watcher_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen "+e.FullPath+" er rettet") ;
        }
    }
}
