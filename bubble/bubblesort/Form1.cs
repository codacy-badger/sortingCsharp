using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubblesort
{
    public partial class Form1 : Form
    {
        Decimal swapnumber;
        Decimal[] numberarray = new decimal[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            writevariables();
            do
            {
                bubble();
            } while (insequence() == false);
            readvariables();
        }

        private void writevariables()
        {
            
            numberarray[1] = ArrayIn1.Value;
            numberarray[2] = ArrayIn2.Value;
            numberarray[3] = ArrayIn3.Value;
            numberarray[4] = ArrayIn4.Value;
            numberarray[5] = ArrayIn5.Value;
        }

        private void bubble()
        {
            if (numberarray[1] > numberarray[2])
            {
                swapnumber = numberarray[1];
                numberarray[1] = numberarray[2];
                numberarray[2] = swapnumber;
            }
            if (numberarray[2] > numberarray[3])
            {
                swapnumber = numberarray[2];
                numberarray[2] = numberarray[3];
                numberarray[3] = swapnumber;
            }
            if (numberarray[3] > numberarray[4])
            {
                swapnumber = numberarray[3];
                numberarray[3] = numberarray[4];
                numberarray[4] = swapnumber;
            }
            if (numberarray[4] > numberarray[5])
            {
                swapnumber = numberarray[4];
                numberarray[4] = numberarray[5];
                numberarray[5] = swapnumber;
            }
        }

        private bool insequence()
        {
            if (numberarray[1] <= numberarray[2])
            {
                if (numberarray[2] <= numberarray[3])
                {
                    if (numberarray[3] <= numberarray[4])
                    {
                        if (numberarray[4] <= numberarray[5])
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void readvariables()
        {
            ArrayOut1.Text = numberarray[1].ToString();
            ArrayOut2.Text = numberarray[2].ToString();
            ArrayOut3.Text = numberarray[3].ToString();
            ArrayOut4.Text = numberarray[4].ToString();
            ArrayOut5.Text = numberarray[5].ToString();
        }
    }
}
