using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkÖdevi
{
    class yigit : IStack
    {
        private int top = -1;
        public Arac[] List;
        public yigit(int i)
        {
            this.List = new Arac[i];
        }
        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public Arac Peek()
        {
            return List[Top];
        }

        public Arac Pop()
        {
                Arac temp = List[Top];
                List[Top] = null;
                Top--;
           return temp;
        }

        public void Push(Arac item)
        {
            if (List.Length == Top + 1)
            {
                throw new Exception("Bodrum dolu.");
            }
            List[++Top] = item;
        }
        public int Top { get { return top; } set { top = value; } }
    }
}
