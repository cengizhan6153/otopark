using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkÖdevi
{
    public interface IQueue
    {
        void Insert(Arac o);
        Arac Remove();
        Arac Peek();
        bool IsEmpty();
    }
}
