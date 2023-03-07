using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex006
{
    public partial class BuyItems : Form
    {
        public BuyItems(string Title)
        {
            InitializeComponent();

            txt_producttitle.Text = Title;
        }

        private void BuyItems_Load(object sender, EventArgs e)
        {
            string pcfolder = "";

            if (txt_producttitle.Text == "Computadores > Desktop")
            {
                pcfolder = "Images\\Computers";
            }

            string[] arquivos = Directory.GetFiles(pcfolder, "*.jpg");

            foreach (string arquivo in arquivos)
            {
                FileInfo infoArquivo = new FileInfo(arquivo);

                Panel panelx = new Panel();

                panelx.Size = new Size(232, 400);
                panelx.Margin = new Padding(18, 45, 18, 0);
                panelx.BackColor = Color.FromArgb(40, 40, 40);

                itemsforsell_list.Controls.Add(panelx);

                PictureBox pictureBox = new PictureBox();

                pictureBox.ImageLocation = infoArquivo.FullName;

                pictureBox.Size = new Size(200, 200);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new Point(16, 20);

                Label Description = new Label();

                Description.Text = infoArquivo.Name.Replace(".jpg", "");
                Description.ForeColor = Color.White;
                Description.Font = new Font("Arial", 20);
                Description.Size = new Size(222, 50);
                Description.Location = new Point(2, 230);

                panelx.Controls.Add(Description);
                panelx.Controls.Add(pictureBox);
            }            
            
        }

        private void goto_Home_Click(object sender, EventArgs e)
        {
            new Home().Show();
        }
    }
}
