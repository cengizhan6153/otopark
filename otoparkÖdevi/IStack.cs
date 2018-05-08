using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkÖdevi
{
    public interface IStack
    {
        void Push(Arac item);
        Arac Pop();
        Arac Peek();
        bool IsEmpty();
        int Top { get; set; }
    }
}
