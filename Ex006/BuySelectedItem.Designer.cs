namespace Ex006
{
    partial class BuySelectedItem
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
            this.Img_Product = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_information = new System.Windows.Forms.Label();
            this.txt_nameofproduct = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Product)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Img_Product);
            this.panel1.Location = new System.Drawing.Point(39, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 512);
            this.panel1.TabIndex = 0;
            // 
            // Img_Product
            // 
            this.Img_Product.Location = new System.Drawing.Point(38, 64);
            this.Img_Product.Name = "Img_Product";
            this.Img_Product.Size = new System.Drawing.Size(422, 380);
            this.Img_Product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img_Product.TabIndex = 0;
            this.Img_Product.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txt_nameofproduct);
            this.panel2.Location = new System.Drawing.Point(577, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 512);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(25, 318);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(412, 34);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(153)))), ((int)(((byte)(231)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(25, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(412, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar ao Carinho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_information
            // 
            this.txt_information.AutoEllipsis = true;
            this.txt_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F);
            this.txt_information.ForeColor = System.Drawing.Color.White;
            this.txt_information.Location = new System.Drawing.Point(6, 22);
            this.txt_information.Name = "txt_information";
            this.txt_information.Size = new System.Drawing.Size(400, 189);
            this.txt_information.TabIndex = 1;
            this.txt_information.Text = "Information";
            // 
            // txt_nameofproduct
            // 
            this.txt_nameofproduct.AutoEllipsis = true;
            this.txt_nameofproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.txt_nameofproduct.ForeColor = System.Drawing.Color.White;
            this.txt_nameofproduct.Location = new System.Drawing.Point(20, 17);
            this.txt_nameofproduct.Name = "txt_nameofproduct";
            this.txt_nameofproduct.Size = new System.Drawing.Size(417, 79);
            this.txt_nameofproduct.TabIndex = 0;
            this.txt_nameofproduct.Text = "Name of Product";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(82)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(25, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(412, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Comprar Já";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_information);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos";
            // 
            // BuySelectedItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1063, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BuySelectedItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuySelectedItem";
            this.Load += new System.EventHandler(this.BuySelectedItem_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Product)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Img_Product;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_information;
        private System.Windows.Forms.Label txt_nameofproduct;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}