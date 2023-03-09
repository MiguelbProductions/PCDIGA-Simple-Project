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
using System.Xml.Linq;
using System.Xml;


namespace Ex006
{
    public partial class BuyItems : Form
    {
        Product[] product_list = new Product[100];

        public BuyItems(string Title)
        {
            InitializeComponent();

            txt_producttitle.Text = Title;
        }

        private void BuyItems_Load(object sender, EventArgs e)
        {
            string folder = "";

            if (txt_producttitle.Text == "Computadores > Desktop")
            {
                folder = "Images\\Computers";
            }

            string[] imagens = Directory.GetFiles(folder, "*.jpg");
            string[] infos = Directory.GetFiles(folder, "*.json");

            int pos = 0;

            foreach (string imagem in imagens)
            {

                FileInfo infoArquivo = new FileInfo(imagem);

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

                XmlDocument doc = new XmlDocument();
                doc.Load(".\\Images\\Computers\\" + infoArquivo.Name.Replace(".jpg", ".xml"));

                XmlNode node = doc.SelectSingleNode("//nome");
                string name = node.Attributes["name"].Value;

                Description.Text = name;
                Description.ForeColor = Color.White;
                Description.Font = new Font("Arial", 13);
                Description.Size = new Size(232, 100);
                Description.AutoEllipsis = true;
               
                Description.Location = new Point(10, 230);

                panelx.Controls.Add(Description);
                panelx.Controls.Add(pictureBox);

                pos++;

            }

        }

        private void goto_Home_Click(object sender, EventArgs e)
        {
            new Home().Show();
        }
    }
}
