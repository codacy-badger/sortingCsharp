using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace countingsort
{
    public partial class Form1 : Form
    {
        Int32[] numberarray = new int[6];
        Int32[] outputarray = new int[6];
        Int32[] countarray = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsort_Click(object sender, EventArgs e)
        {
            writenumberarray();
            count();
            addprevious();
            sort();
            readarray();
            resetarrays();
        }

        private void writenumberarray()
        {
            numberarray[1] = Convert.ToInt32(ArrayIn1.Value);
            numberarray[2] = Convert.ToInt32(ArrayIn2.Value);
            numberarray[3] = Convert.ToInt32(ArrayIn3.Value);
            numberarray[4] = Convert.ToInt32(ArrayIn4.Value);
            numberarray[5] = Convert.ToInt32(ArrayIn5.Value);
        }

        private void count()
        {
            for (int i = 1; i < numberarray.Length; i++)
            {
                countarray[numberarray[i]]++;
            }
        }

        private void addprevious()
        {
            for (int i = 2; i < countarray.Length; i++)
            {
                countarray[i] = countarray[i] + countarray[i - 1];
            }
        }

        private void sort()
        {
            for (int i = 1; i < numberarray.Length; i++)
            {
                outputarray[countarray[numberarray[i]]] = numberarray[i];
                countarray[numberarray[i]]--;
            }
        }

        private void readarray()
        {
            ArrayOut1.Text = outputarray[1].ToString();
            ArrayOut2.Text = outputarray[2].ToString();
            ArrayOut3.Text = outputarray[3].ToString();
            ArrayOut4.Text = outputarray[4].ToString();
            ArrayOut5.Text = outputarray[5].ToString();
        }

        private void resetarrays()
        {
            for (int i = 1; i < numberarray.Length; i++)
            {
                numberarray[i] = 0;
            }

            for (int i = 0; i < countarray.Length; i++)
            {
                countarray[i] = 0;
            }

            for (int i = 0; i < outputarray.Length; i++)
            {
                outputarray[i] = 0;
            }
        }
    }
}
