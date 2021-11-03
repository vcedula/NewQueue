using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewQueue
{
    public class QUEUE<TItem>
    {
        private QUEUEnode head;
        private QUEUEnode tail;

        private class QUEUEnode
        {
            public QUEUEnode next;
            public TItem item;

            public QUEUEnode(TItem item, QUEUEnode next)
            {
                this.item = item;
                this.next = next;
            }
        }

        public QUEUE()
        {
            this.head = null;
            this.tail = null;
        }

        public TItem this[int index]
        {
            get
            {
                var node = FindNode(index);

                return node.item;
            }
            set
            {
                var node = FindNode(index);

                node.item = value;
            }
        }

        private QUEUEnode FindNode(int index)
        {
            QUEUEnode node = head; //index 0
            for (int i = 1; i <= index; i++)
            {
                node = node.next;
                if (node == null)
                {
                    throw new IndexOutOfRangeException($"Item with index {index} not found.");
                }
            }

            return node;
        }

        public bool isempty()
        {
            return this.head == null;
        }

        public void put(TItem item)
        {
            if (this.head == null)
            {
                this.head = (this.tail = new QUEUEnode(item, this.head));
            }
            else
            {
                this.tail.next = new QUEUEnode(item, null);
                this.tail = tail.next;
            }
        }

        public TItem get()
        {
            if (isempty()) throw new FrontEmptyException($"QUEUE<{typeof(TItem).Name}>");

            TItem item = this.head.item;
            QUEUEnode t = this.head.next;
            this.head = t;

            return item;
        }
    }
}
