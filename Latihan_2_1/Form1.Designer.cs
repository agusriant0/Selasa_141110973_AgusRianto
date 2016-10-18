namespace Latihan_2_1
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
            this.Tanggal = new System.Windows.Forms.NumericUpDown();
            this.Bulan = new System.Windows.Forms.DomainUpDown();
            this.Tambah = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.Kalender = new System.Windows.Forms.MonthCalendar();
            this.Birth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // Tanggal
            // 
            this.Tanggal.Location = new System.Drawing.Point(12, 12);
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(120, 20);
            this.Tanggal.TabIndex = 2;
            this.Tanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bulan
            // 
            this.Bulan.Location = new System.Drawing.Point(138, 12);
            this.Bulan.Name = "Bulan";
            this.Bulan.Size = new System.Drawing.Size(120, 20);
            this.Bulan.TabIndex = 3;
            this.Bulan.Text = "Bulan";
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(264, 9);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(75, 23);
            this.Tambah.TabIndex = 4;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(345, 9);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(75, 23);
            this.Hapus.TabIndex = 5;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Kalender
            // 
            this.Kalender.BoldedDates = new System.DateTime[] {
        new System.DateTime(2016, 10, 3, 0, 0, 0, 0)};
            this.Kalender.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.Kalender.Location = new System.Drawing.Point(12, 44);
            this.Kalender.Name = "Kalender";
            this.Kalender.TabIndex = 6;
            // 
            // Birth
            // 
            this.Birth.AutoSize = true;
            this.Birth.Location = new System.Drawing.Point(12, 355);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(114, 13);
            this.Birth.TabIndex = 7;
            this.Birth.Text = "Birth date : 13 Agustus";
            this.Birth.Click += new System.EventHandler(this.Birth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 377);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Kalender);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.Bulan);
            this.Controls.Add(this.Tanggal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tanggal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Tanggal;
        private System.Windows.Forms.DomainUpDown Bulan;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.MonthCalendar Kalender;
        private System.Windows.Forms.Label Birth;
    }
}

