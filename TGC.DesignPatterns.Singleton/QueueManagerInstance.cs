using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGC.DesignPatterns.Singleton
{
    internal class QueueManagerInstance
    {
        private List<QueueItem> queueItems;


        public QueueManagerInstance()
        {
            queueItems = new List<QueueItem>();
        }
        public void AddQueueItem(QueueItem queueItem)
        {
            queueItems.Add(queueItem);
        }

        public int GetQueueCount()
        {
            return queueItems.Count;
        }

        public void ProcessAmount(int amount)
        {
            var listOfTasks = new List<Task>();
            var itemsToProcess = queueItems.Take(amount);

            foreach (var item in itemsToProcess)
            {
                listOfTasks.Add(Task.Factory.StartNew(() =>
                {
                    item.Process();
                }));
            }

            Task.WaitAll(listOfTasks.ToArray());
        }
    }
}
