using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewQueue
{
    public class QUEUEOsoba
    {
        private QUEUEnode head;
        private QUEUEnode tail;

        private class QUEUEnode
        {
            public QUEUEnode next;
            public Osoba item;

            public QUEUEnode(Osoba item, QUEUEnode next)
            {
                this.item = item;
                this.next = next;
            }
        }

        public QUEUEOsoba()
        {
            this.head = null;
            this.tail = null;
        }

        public bool isempty()
        {
            return this.head == null;
        }

        public void put(Osoba item)
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

        public Osoba get()
        {
            if (isempty()) throw new FrontEmptyException("QUEUEOsoba");

            Osoba item = this.head.item;
            QUEUEnode t = this.head.next;
            this.head = t;

            return item;
        }
    }
}
