using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bold_button_Click(object sender, EventArgs e)
        {
            Font bold;
            if (isi.SelectionFont == null)
            {
                return;
            }
            if (isi.SelectionFont.Style.ToString().Contains("Bold"))
            {
                bold = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                bold = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style | FontStyle.Bold);
            }
            isi.SelectionFont = bold;
        }

        private void italic_button_Click(object sender, EventArgs e)
        {
            Font italic;
            if (isi.SelectionFont == null)
            {
                return;
            }
            if (isi.SelectionFont.Style.ToString().Contains("Italic"))
            {
                italic = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                italic = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style | FontStyle.Italic);
            }
            isi.SelectionFont = italic;
        }

        private void underline_button_Click(object sender, EventArgs e)
        {
            Font underline;
            if (isi.SelectionFont == null)
            {
                return;
            }
            if (isi.SelectionFont.Style.ToString().Contains("Underline"))
            {
                underline = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                underline = new Font(isi.SelectionFont.FontFamily, isi.SelectionFont.Size, isi.SelectionFont.Style | FontStyle.Underline);
            }
            isi.SelectionFont = underline;
        }

        private void isi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
