using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoparkÖdevi
{
    class DaireselBağlı:ListADT
    {
        public override void InsertLast(Arac value)
        {
            //Listenin durumuna göre eleman eklemesi yapılır.
            Dugum tmpHead = new Dugum
            {
                Data = value
            };
            Dugum eskiSon = Head;
            if (Head == null)
            {
                Head = tmpHead;
                Head.Next = Head;
            }
            else
            {
                while (eskiSon != null)
                {
                    if (eskiSon.Next != Head)
                    {
                        eskiSon = eskiSon.Next;
                    }
                    else
                        break;
                }
                eskiSon.Next = tmpHead;
                tmpHead.Next = Head;
            }
            Size++;
        }
        public int sayac = 0;
        public override Dugum DeletePos()
        {
            Dugum tmp = Head;
            Dugum tmpOncesi=Head;
            //Jhosefus problemi mantığında çıkacak elamanın ısrası bulunması için 
            //N=2^a+l; çıkacak elaeman ise: 2.l+1  olmaktadır
            int d = Size;
            int sayac = 1;
            while (d != 1)
            {
                if (d % 2 == 0)
                {
                    d /= 2;
                    sayac *= 2;
                }
                else
                    d--;
            }
            //belirlenen indisteki elemanın taranarak bulunması
            if ((2 * (Size - sayac) + 1) != 1)
            {
                for (int i = 1; i < (2 * (Size - sayac) + 1); i++)
                {
                    tmpOncesi = tmp;
                    tmp = tmp.Next;
                }
                tmpOncesi.Next = tmp.Next;
                Size--;
            }
            else
            {
                if (Size!=1)
                {
                    while (tmpOncesi.Next != Head)
                    {
                        tmpOncesi = tmpOncesi.Next;
                    }
                    tmpOncesi.Next = tmp.Next;
                    Head = tmp.Next;
                    Size--;
                }
                else
                {
                    Size--;
                }
            }
            return tmp;
        }

        public override Dugum GetElement(int position)
        {
            //listemizdeki elemanların listelene bilmesi için
            Dugum retNode = null;
            Dugum tempNode = Head;
            int count = 0;
            while (tempNode != null)
            {
                if (count == position)
                {
                    retNode = tempNode;
                    break;
                }
                else if(tempNode.Next!=Head)
                tempNode = tempNode.Next;
                count++;
            }
            return retNode;
        }

        public override string DisplayElements()
        {
            string temp = "";
            Dugum item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }

            return temp;
        }
    }

}
