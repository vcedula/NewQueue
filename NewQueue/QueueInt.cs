using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewQueue
{
    public class QUEUEInt
    {
        private QUEUEnode head;
        private QUEUEnode tail;

        private class QUEUEnode
        {
            public QUEUEnode next;
            public int item;

            public QUEUEnode(int item, QUEUEnode next)
            {
                this.item = item;
                this.next = next;
            }
        }

        public QUEUEInt()
        {
            this.head = null;
            this.tail = null;
        }

        public bool isempty()
        {
            return this.head == null;
        }

        public void put(int item)
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

        public int get()
        {
            if (isempty()) throw new FrontEmptyException("QUEUEInt");

            int item = this.head.item;
            QUEUEnode t = this.head.next;
            this.head = t;

            return item;
        }
    }
}
