using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Singleton
{
    public class Runner
    {
        public static void Run()
        {
            var queueManager = new QueueManager();

            queueManager.AddQueueItem(new QueueItem("Some Name", 1));
            queueManager.AddQueueItem(new QueueItem("Some Name", 2));
            queueManager.AddQueueItem(new QueueItem("Some Name", 3));

            Console.WriteLine(queueManager.CountQueueItems());

            queueManager.ProcessAmount(2);

            Console.WriteLine(queueManager.CountQueueItems());

        }
    }
}
