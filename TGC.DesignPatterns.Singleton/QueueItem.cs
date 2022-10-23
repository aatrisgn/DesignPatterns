using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Singleton
{
    public class QueueItem
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public QueueItem(string name, int count)
        {
            Name = name;
            Count = count;
        }
        
        public void Process()
        {
            Console.WriteLine(Name + ": " + Count);
        }
    }
}
