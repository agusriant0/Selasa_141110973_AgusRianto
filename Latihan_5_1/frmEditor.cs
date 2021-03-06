﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;

namespace Latihan_5_1
{
    public partial class frmEditor : Form
    {
        frmMain main = (frmMain)frmMain.ActiveForm;

        public frmEditor()
        {
            InitializeComponent();
            Color warna = new Color();
            PropertyInfo[] p = warna.GetType().GetProperties();

            cbBackColor.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo c in p)
            {
                if (c.PropertyType == typeof(System.Drawing.Color))
                {
                    cbBackColor.Items.Add(c.Name);
                }
            }

            this.cbBackColor.DrawItem += new DrawItemEventHandler(cbBackColor_DItem);
        }

        private void cbBackColor_DItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.cbBackColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            cbBackColor.Text = main.rtbBackColor;

            treeConfig.ExpandAll();
            treeConfig.SelectedNode = treeConfig.Nodes[0].Nodes[0];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeConfig.SelectedNode == treeConfig.Nodes[0].Nodes[0])
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            main.rtbBackColor = cbBackColor.Text;
            this.Dispose();
            main.tampilRTB();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main.tampilRTB();
        }

        private void frmEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            main.tampilRTB();
        }

        private void lblBackColor_Click(object sender, EventArgs e)
        {

        }

        private void cbBackColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackColor_Click(object sender, EventArgs e)
        {

        }
    }
}
