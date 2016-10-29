using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (FontFamily font in FontFamily.Families.ToArray())
            {
                fontfamilylist.Items.Add(font.Name);
            }
            for (int i = 1; i <= 100; i++)
            {
                fontsizelist.Items.Add(i);
            }
            foreach (KnownColor warna in Enum.GetValues(typeof(KnownColor)))
            {
                fontcolorlist.Items.Add(warna);
            }
            fontfamilylist.SelectedIndex = 0;
            fontsizelist.SelectedIndex = 13;
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";
        }

        private void fontfamilylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionFont = new System.Drawing.Font(fontfamilylist.Text, isi.SelectionFont.Size, isi.SelectionFont.Style);
        }

        private void fontsizelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionFont = new System.Drawing.Font(isi.SelectionFont.FontFamily, Convert.ToInt32(fontsizelist.Text), isi.SelectionFont.Style);
        }

        private void fontcolorlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionColor = Color.FromName(fontcolorlist.Text);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                isi.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                isi.LoadFile(openFileDialog1.FileName);
            }
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
        private void fontfamilylist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionFont = new System.Drawing.Font(fontfamilylist.Text, isi.SelectionFont.Size, isi.SelectionFont.Style);
        }

        private void fontsizelist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionFont = new System.Drawing.Font(isi.SelectionFont.FontFamily, Convert.ToInt32(fontsizelist.Text), isi.SelectionFont.Style);
        }

        private void fontcolorlist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (isi.SelectionFont == null)
            {
                return;
            }
            isi.SelectionColor = Color.FromName(fontcolorlist.Text);
        }
    }
}
