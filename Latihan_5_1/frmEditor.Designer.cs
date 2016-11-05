namespace Latihan_5_1
{
    partial class frmEditor
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("BackColor");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Theme", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeConfig = new System.Windows.Forms.TreeView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.BackColor = new System.Windows.Forms.TabPage();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.cbBackColor = new System.Windows.Forms.ComboBox();
            this.tabControl2.SuspendLayout();
            this.BackColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeConfig
            // 
            this.treeConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeConfig.Location = new System.Drawing.Point(0, 0);
            this.treeConfig.Name = "treeConfig";
            treeNode1.Name = "Node1";
            treeNode1.Text = "BackColor";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Theme";
            this.treeConfig.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeConfig.Size = new System.Drawing.Size(183, 284);
            this.treeConfig.TabIndex = 2;
            this.treeConfig.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeConfig_AfterSelect);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 226);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(93, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.BackColor);
            this.tabControl2.Location = new System.Drawing.Point(189, -21);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(280, 305);
            this.tabControl2.TabIndex = 6;
            // 
            // BackColor
            // 
            this.BackColor.Controls.Add(this.lblBackColor);
            this.BackColor.Controls.Add(this.cbBackColor);
            this.BackColor.Location = new System.Drawing.Point(4, 22);
            this.BackColor.Name = "BackColor";
            this.BackColor.Padding = new System.Windows.Forms.Padding(3);
            this.BackColor.Size = new System.Drawing.Size(272, 279);
            this.BackColor.TabIndex = 1;
            this.BackColor.Text = "BackColor";
            this.BackColor.UseVisualStyleBackColor = true;
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(17, 10);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(56, 13);
            this.lblBackColor.TabIndex = 1;
            this.lblBackColor.Text = "BackColor";
            // 
            // cbBackColor
            // 
            this.cbBackColor.DropDownHeight = 175;
            this.cbBackColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBackColor.FormattingEnabled = true;
            this.cbBackColor.IntegralHeight = false;
            this.cbBackColor.Location = new System.Drawing.Point(92, 7);
            this.cbBackColor.Name = "cbBackColor";
            this.cbBackColor.Size = new System.Drawing.Size(150, 21);
            this.cbBackColor.TabIndex = 0;
            // 
            // frmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 284);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.treeConfig);
            this.Name = "frmEditor";
            this.Text = "frmEditor";
            this.tabControl2.ResumeLayout(false);
            this.BackColor.ResumeLayout(false);
            this.BackColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeConfig;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage BackColor;
        private System.Windows.Forms.Label lblBackColor;
        private System.Windows.Forms.ComboBox cbBackColor;
    }
}