using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkÖdevi
{
    class BasitKuyruk : IQueue
    {
        public Arac[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        public int count = 0;
        public BasitKuyruk(int i)
        {
            this.size = i;
            Queue = new Arac[size];
        }
        public void Insert(Arac o)
        {
            if (count == size)
            {
                throw new Exception("Kat dolu.");
            }
            if (front == -1)
                front = 0;
            rear++;
            if (rear == 15)
            { rear = 0; }
            Queue[rear] = o;
            count++;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public Arac Peek()
        {
            return Queue[front];
        }

        public Arac Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("kat boş");
            }
            Arac temp = Queue[front];
            Queue[front] = null;
            front++;
            if (front == 15)
                front = 0;
            count--;
            return temp;
        }
    }
}
