using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace otoparkÖdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[] Renkler = {"Mavi","Kirmizi","Siyah","Beyaz","Bordo","Sarı" };
        BasitKuyruk bk = new BasitKuyruk(15);
        yigit y = new yigit(15);
        DaireselBağlı ds = new DaireselBağlı();
        public Random r = new Random();
        Arac temp;
        Dugum tmp;
        int a = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //random olarak tüm araçlar eklenmektedir
            if(a==0)
            for(int i = 1; i <= 45; i++)
            {
                Arac a = new Arac();
                a.No = i;
                a.AracRengi = Renkler[r.Next(0, 6)];
                if (i < 16)
                    y.Push(a);
                else if (i < 31 && i >= 16)
                    bk.Insert(a);
                else
                    ds.InsertLast(a);
            }
            a++;
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            //katlarda bulunan araçların ekranda listelenmesini sağlanıyor
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            foreach (Arac item in y.List)
            {
                if (item != null)
                    listBox1.Items.Add(item.No + "  nolu  " + item.AracRengi + "  renkli araç");
                else
                    continue;
            }
            foreach (Arac item in bk.Queue)
            {
                if (item != null)
                    listBox2.Items.Add(item.No + "  nolu  " + item.AracRengi + "  renkli araç");
                else
                    continue;
            }
            for(int i = 0; i <ds.Size; i++)
            {
                Dugum t = ds.GetElement(i);
                if (t.Data != null)
                {
                    listBox3.Items.Add(t.Data.No + "  nolu  " + t.Data.AracRengi + "  renkli araç");
                }
                else
                    break;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (bk.count == 0)
            {
                return;
            }
            temp = bk.Remove();
            lbl1_kat.Text = temp.No + "  nolu arac  " + temp.AracRengi+"  cıktı";
            //bodrum ve 2.kattan %50 ihtimalle araç çıkışını sağlıyor
            int n = r.Next(1, 3);
            if (ds.Size == 0 && y.Top!=-1)
            {
                n = 1;
            }
            else if (ds.Size != 0 && y.Top==-1)
            {
                n = 2;
            }
            else if(ds.Size==0 && y.Top==-1)
                return ;
            switch (n)
            {
                case 1:
                        temp = y.Pop();
                        bk.Insert(temp);
                        lblBodrum.Text = temp.No + "  nolu arac  " + temp.AracRengi + "  cıktı";
                        break; 
                case 2:
                        tmp = ds.DeletePos();
                        bk.Insert(tmp.Data);
                        lbl2_kat.Text = tmp.Data.No + "  nolu arac  " + tmp.Data.AracRengi + "  cıktı";
                    
                    break;
            }
            a = 0;
        }

        private void btnTcikar_Click(object sender, EventArgs e)
        {
            //tüm çıkarma işlemlerinin tek seferde yapılması ve bu esnada geçen zamanın hesaplanması yapılmakta
            DateTime dtBas = DateTime.Now;
            for (int i = 0; i < 45; i++)
            {

                if (bk.count == 0)
                {
                    return;
                }  
                temp = bk.Remove();
                lbl1_kat.Text = temp.No + "  nolu arac  " + temp.AracRengi + "  cıktı";
                int n = r.Next(1, 3);
                if (ds.Size == 0 && y.Top != -1)
                {
                    n = 1;
                }
                else if (ds.Size != 0 && y.Top == -1)
                {
                    n = 2;
                }
                else if (ds.Size == 0 && y.Top == -1)
                    continue; ;
                switch (n)
                {
                    case 1:
                        temp = y.Pop();
                        bk.Insert(temp);
                        lblBodrum.Text = temp.No + "  nolu arac  " + temp.AracRengi + "  cıktı";
                        break;
                    case 2:
                        tmp = ds.DeletePos();
                        bk.Insert(tmp.Data);
                        lbl2_kat.Text = tmp.Data.No + "  nolu arac  " + tmp.Data.AracRengi + "  cıktı";

                        break;
                }
            }
            a = 0;
            TimeSpan ts = DateTime.Now.Subtract(dtBas);
            MessageBox.Show("45 aracın çıkışında geçen süre: " + ts.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
