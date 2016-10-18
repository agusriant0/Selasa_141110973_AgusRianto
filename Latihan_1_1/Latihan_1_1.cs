using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_1
{
    public partial class Latihan_1_1 : Form
    {
        public Latihan_1_1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int A, B;
            if(vScrollBar1.Value>vScrollBar2.Value)
            {
                label1.Text = vScrollBar2.Value + "";
                label2.Text = vScrollBar1.Value + "";
            }
            else
            {
                label1.Text = vScrollBar1.Value + "";
                label2.Text = vScrollBar2.Value + "";
            }

            A = int.Parse(label1.Text);
            B = int.Parse(label2.Text);

            kiri.Text = vScrollBar1.Value + "";
            kanan.Text = vScrollBar2.Value + "";

            dateTimePicker1.MinDate = new DateTime(DateTime.Today.Year - B, DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MaxDate = new DateTime(DateTime.Today.Year - A, DateTime.Today.Month, DateTime.Today.Day);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            int A, B;
            if (vScrollBar1.Value > vScrollBar2.Value)
            {
                label1.Text = vScrollBar2.Value + "";
                label2.Text = vScrollBar1.Value + "";
            }
            else
            {
                label1.Text = vScrollBar1.Value + "";
                label2.Text = vScrollBar2.Value + "";
            }

            A = int.Parse(label1.Text);
            B = int.Parse(label2.Text);

            kiri.Text = vScrollBar1.Value + "";
            kanan.Text = vScrollBar2.Value + "";

            dateTimePicker1.MinDate = new DateTime(DateTime.Today.Year - B, DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MaxDate = new DateTime(DateTime.Today.Year - A, DateTime.Today.Month, DateTime.Today.Day);
        }
    }
}
