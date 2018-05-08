using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkÖdevi
{
    public abstract class ListADT
    {
        public Dugum Head;
        public int Size = 0;
        public abstract void InsertLast(Arac value);
        public abstract Dugum DeletePos();
        public abstract Dugum GetElement(int position);
        public abstract string DisplayElements();
    }
}
