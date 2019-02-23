using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selectionsort
{
    public partial class Form1 : Form
    {
        Decimal[] numberarray = new decimal[6];
        Decimal swapnumber;
        Int32 swapselector;
        Int32 counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            readnumbers();
            compareandswap();
            writenumbers();
        }

        private void readnumbers()
        {
            numberarray[1] = ArrayIn1.Value;
            numberarray[2] = ArrayIn2.Value;
            numberarray[3] = ArrayIn3.Value;
            numberarray[4] = ArrayIn4.Value;
            numberarray[5] = ArrayIn5.Value;
        }

        private void writenumbers()
        {
            ArrayOut1.Text = numberarray[1].ToString();
            ArrayOut2.Text = numberarray[2].ToString();
            ArrayOut3.Text = numberarray[3].ToString();
            ArrayOut4.Text = numberarray[4].ToString();
            ArrayOut5.Text = numberarray[5].ToString();
        }

        private void compareandswap()
        {
            switch (counter)
            {
                case 0:
                    swapnumber = numberarray[1];
                    if (swapnumber > numberarray[2])
                    {
                        swapnumber = numberarray[2];
                        swapselector = 2;
                    }
                    if (swapnumber > numberarray[3])
                    {
                        swapnumber = numberarray[3];
                        swapselector = 3;
                    }
                    if (swapnumber > numberarray[4])
                    {
                        swapnumber = numberarray[4];
                        swapselector = 4;
                    }
                    if (swapnumber > numberarray[5])
                    {
                        swapnumber = numberarray[5];
                        swapselector = 5;
                    }
                    numberarray[swapselector] = numberarray[1];
                    numberarray[1] = swapnumber;
                    counter = counter + 1;
                    break;
                case 1:
                    swapnumber = numberarray[2];
                    if (swapnumber > numberarray[3])
                    {
                        swapnumber = numberarray[3];
                        swapselector = 3;
                    }
                    if (swapnumber > numberarray[4])
                    {
                        swapnumber = numberarray[4];
                        swapselector = 4;
                    }
                    if (swapnumber > numberarray[5])
                    {
                        swapnumber = numberarray[5];
                        swapselector = 5;
                    }
                    numberarray[swapselector] = numberarray[2];
                    numberarray[2] = swapnumber;
                    counter = counter + 1;
                    break;
                case 2:
                    swapnumber = numberarray[3];
                    if (swapnumber > numberarray[4])
                    {
                        swapnumber = numberarray[4];
                        swapselector = 4;
                    }
                    if (swapnumber > numberarray[5])
                    {
                        swapnumber = numberarray[5];
                        swapselector = 5;
                    }
                    numberarray[swapselector] = numberarray[3];
                    numberarray[3] = swapnumber;
                    counter = counter + 1;
                    break;
                case 3:
                    swapnumber = numberarray[4];
                    if (swapnumber > numberarray[5])
                    {
                        swapnumber = numberarray[5];
                        swapselector = 5;
                    }
                    numberarray[swapselector] = numberarray[4];
                    numberarray[4] = swapnumber;
                    counter = counter + 1;
                    break;
            }
        }
    }
}
