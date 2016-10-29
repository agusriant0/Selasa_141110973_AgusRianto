namespace Latihan_3_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bold_button = new System.Windows.Forms.ToolStripButton();
            this.italic_button = new System.Windows.Forms.ToolStripButton();
            this.underline_button = new System.Windows.Forms.ToolStripButton();
            this.isi = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bold_button,
            this.italic_button,
            this.underline_button});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(351, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bold_button
            // 
            this.bold_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bold_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold_button.Image = ((System.Drawing.Image)(resources.GetObject("bold_button.Image")));
            this.bold_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold_button.Name = "bold_button";
            this.bold_button.Size = new System.Drawing.Size(23, 22);
            this.bold_button.Text = "B";
            this.bold_button.Click += new System.EventHandler(this.bold_button_Click);
            // 
            // italic_button
            // 
            this.italic_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italic_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic_button.Image = ((System.Drawing.Image)(resources.GetObject("italic_button.Image")));
            this.italic_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic_button.Name = "italic_button";
            this.italic_button.Size = new System.Drawing.Size(23, 24);
            this.italic_button.Text = "I";
            this.italic_button.Click += new System.EventHandler(this.italic_button_Click);
            // 
            // underline_button
            // 
            this.underline_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underline_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline_button.Image = ((System.Drawing.Image)(resources.GetObject("underline_button.Image")));
            this.underline_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline_button.Name = "underline_button";
            this.underline_button.Size = new System.Drawing.Size(23, 24);
            this.underline_button.Text = "U";
            this.underline_button.Click += new System.EventHandler(this.underline_button_Click);
            // 
            // isi
            // 
            this.isi.Location = new System.Drawing.Point(12, 30);
            this.isi.Name = "isi";
            this.isi.Size = new System.Drawing.Size(315, 226);
            this.isi.TabIndex = 2;
            this.isi.Text = "";
            this.isi.TextChanged += new System.EventHandler(this.isi_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 268);
            this.Controls.Add(this.isi);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bold_button;
        private System.Windows.Forms.ToolStripButton italic_button;
        private System.Windows.Forms.ToolStripButton underline_button;
        private System.Windows.Forms.RichTextBox isi;
    }
}

