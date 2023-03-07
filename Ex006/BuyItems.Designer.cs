namespace Ex006
{
    partial class BuyItems
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.goto_Home = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_producttitle = new System.Windows.Forms.Label();
            this.itemsforsell_list = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goto_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.goto_Home);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2060, 115);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Ex006.Properties.Resources.Shop_Icon3;
            this.pictureBox9.Location = new System.Drawing.Point(1434, 23);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(73, 65);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Ex006.Properties.Resources.Account_Icon;
            this.pictureBox10.Location = new System.Drawing.Point(1345, 23);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(68, 65);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // goto_Home
            // 
            this.goto_Home.Image = global::Ex006.Properties.Resources.PCDIGA_Logo;
            this.goto_Home.Location = new System.Drawing.Point(43, 14);
            this.goto_Home.Name = "goto_Home";
            this.goto_Home.Size = new System.Drawing.Size(281, 80);
            this.goto_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.goto_Home.TabIndex = 0;
            this.goto_Home.TabStop = false;
            this.goto_Home.Click += new System.EventHandler(this.goto_Home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(27, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 843);
            this.panel2.TabIndex = 2;
            // 
            // txt_producttitle
            // 
            this.txt_producttitle.AutoSize = true;
            this.txt_producttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.txt_producttitle.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_producttitle.Location = new System.Drawing.Point(28, 147);
            this.txt_producttitle.Name = "txt_producttitle";
            this.txt_producttitle.Size = new System.Drawing.Size(362, 51);
            this.txt_producttitle.TabIndex = 3;
            this.txt_producttitle.Text = "PRODUCT TITLE";
            // 
            // itemsforsell_list
            // 
            this.itemsforsell_list.AutoScroll = true;
            this.itemsforsell_list.Location = new System.Drawing.Point(418, 225);
            this.itemsforsell_list.Name = "itemsforsell_list";
            this.itemsforsell_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemsforsell_list.Size = new System.Drawing.Size(1100, 645);
            this.itemsforsell_list.TabIndex = 4;
            // 
            // BuyItems
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1942, 1055);
            this.Controls.Add(this.itemsforsell_list);
            this.Controls.Add(this.txt_producttitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyItems";
            this.Text = "BuyItems";
            this.Load += new System.EventHandler(this.BuyItems_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goto_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox goto_Home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txt_producttitle;
        private System.Windows.Forms.FlowLayoutPanel itemsforsell_list;
    }
}