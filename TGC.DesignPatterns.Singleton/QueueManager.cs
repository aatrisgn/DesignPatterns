using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Singleton
{
    public class QueueManager
    {
        private static QueueManagerInstance instance = new QueueManagerInstance();
        private object _lock = new object();

        public int CountQueueItems()
        {
            lock(_lock)
            {
                return instance.GetQueueCount();
            }
        }

        //Let's say we do not care about exact values, but just a close enough estimate. E.g. for dashboards over current procees
        public int CountQueueItemsDirty()
        {
            lock (_lock)
            {
                return instance.GetQueueCount();
            }
        }

        public void AddQueueItem(QueueItem queueItems)
        {
            lock (_lock)
            {
                instance.AddQueueItem(queueItems);
            }
        }

        public void ProcessAmount(int amount)
        {
            lock (_lock)
            {
                instance.ProcessAmount(amount);
            }
        }
    }
}
