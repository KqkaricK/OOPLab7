using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace OOPLab7 
{
    class Array
    {
        public double[] dbArray;
        public int n;
        public string name;

        public Array(string Name = "Array", int N = 10)
        {
            name = Name;
            n = N;
            dbArray = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                dbArray[i] = (rnd.NextDouble() - 0.5) * 100;
        }


        public void Display(ListBox u)
        {
            u.Items.Clear();
            for (int i = 0; i < n; i++)
                u.Items.Add(Convert.ToString(dbArray[i]));
        }

        public void SRAR(TextBox u, TextBox g)
        {
            double sump = 0;
            int countp = 0;
            double summ = 0;
            int countm = 0;
            for (int i = 0; i < n; i++)
            {
                if (dbArray[i] < 0)
                {
                    summ += dbArray[i];
                    countm++;
                }
                else
                {
                    sump += dbArray[i];
                    countp++;
                }
            }
            u.Text = Convert.ToString(summ / countm);
            g.Text = Convert.ToString(sump / countp);
        }

        public void SRG(TextBox g)
        {
            double sump = 1;
            int countp = 0;
            for (int i = 0; i < n; i++)
            {
                if (dbArray[i] > 0)
                {
                    sump *= dbArray[i];
                    countp++;
                }
            }
            g.Text = Convert.ToString(Math.Pow(sump, (float)1 / countp));
        }

        public void Plus(double ggg)
        {
            for (int i = 0; i < n; i++)
                dbArray[i] += ggg;
        }

        public void NName(TextBox g)
        {
            g.Text = name;
        }
    }
}
