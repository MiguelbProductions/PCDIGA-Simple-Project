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
        Product[][] product_list;

        public BuyItems(string Title, Product[][] products_list)
        {
            InitializeComponent();

            txt_producttitle.Text = Title;

            this.product_list = products_list;
        }

        private void BuyItems_Load(object sender, EventArgs e)
        {

            if (txt_producttitle.Text == "Computadores > Desktop")
            {
                foreach (Desktop item in product_list[0])
                {
                    if (item != null)
                    {
                        Panel panelx = new Panel();

                        panelx.Size = new Size(232, 405);
                        panelx.Margin = new Padding(18, 45, 18, 0);
                        panelx.BackColor = Color.FromArgb(40, 40, 40);

                        itemsforsell_list.Controls.Add(panelx);

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.ImageLocation = item.Image_location;

                        pictureBox.Size = new Size(200, 200);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Location = new Point(16, 20);

                        Label Description = new Label();

                        XmlDocument doc = new XmlDocument();

                        Description.Text = item.Name;
                        Description.ForeColor = Color.White;
                        Description.Font = new Font("Arial", 13);
                        Description.Size = new Size(232, 100);
                        Description.AutoEllipsis = true;
                        Description.Location = new Point(10, 230);

                        Label SubInformations = new Label();

                        SubInformations.Text = item.Processor_model_resumed + " | " + item.Ram_model_resumed + " | " + item.Graphiccard_model_resumed + " | " + item.Storage_type + " " + item.storage_model_resumed;

                        SubInformations.ForeColor = Color.White;
                        SubInformations.Font = new Font("Arial", 7);
                        SubInformations.Size = new Size(222, 100);
                        SubInformations.AutoEllipsis = true;
                        SubInformations.Location = new Point(10, 305);

                        Label Price_Info = new Label();

                        Price_Info.Text = item.price.ToString() + " €";
                        Price_Info.ForeColor = Color.FromArgb(233, 100, 73);
                        Price_Info.Font = new Font("Arial", 22, FontStyle.Bold);
                        Price_Info.Size = new Size(222, 150);
                        Price_Info.Location = new Point(10, 350);

                        panelx.Controls.Add(Price_Info);
                        panelx.Controls.Add(SubInformations);
                        panelx.Controls.Add(Description);
                        panelx.Controls.Add(pictureBox);
                    }

                }
            }
            else if (txt_producttitle.Text == "Phones")
            {
                foreach (Phone item in product_list[2])
                {
                    if (item != null)
                    {
                        Panel panelx = new Panel();

                        panelx.Size = new Size(232, 405);
                        panelx.Margin = new Padding(18, 45, 18, 0);
                        panelx.BackColor = Color.FromArgb(40, 40, 40);

                        itemsforsell_list.Controls.Add(panelx);

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.ImageLocation = item.Image_location;

                        pictureBox.Size = new Size(200, 200);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Location = new Point(16, 20);

                        Label Description = new Label();

                        XmlDocument doc = new XmlDocument();

                        Description.Text = item.Name;
                        Description.ForeColor = Color.White;
                        Description.Font = new Font("Arial", 13);
                        Description.Size = new Size(232, 100);
                        Description.AutoEllipsis = true;
                        Description.Location = new Point(10, 230);

                        Label SubInformations = new Label();

                        SubInformations.Text = item.typeofphone + " | " + item.frontalcam_model + " | " + item.backcam_model + " | " + item.storagesize;

                        SubInformations.ForeColor = Color.White;
                        SubInformations.Font = new Font("Arial", 7);
                        SubInformations.Size = new Size(222, 100);
                        SubInformations.AutoEllipsis = true;
                        SubInformations.Location = new Point(10, 305);

                        Label Price_Info = new Label();

                        Price_Info.Text = item.price.ToString() + " €";
                        Price_Info.ForeColor = Color.FromArgb(233, 100, 73);
                        Price_Info.Font = new Font("Arial", 22, FontStyle.Bold);
                        Price_Info.Size = new Size(222, 150);
                        Price_Info.Location = new Point(10, 360 );

                        panelx.Controls.Add(Price_Info);
                        panelx.Controls.Add(SubInformations);
                        panelx.Controls.Add(Description);
                        panelx.Controls.Add(pictureBox);
                    }

                }
            }
            else if (txt_producttitle.Text == "HeadSets")
            {
                foreach (HeadSet item in product_list[3])
                {
                    if (item != null)
                    {
                        Panel panelx = new Panel();

                        panelx.Size = new Size(232, 405);
                        panelx.Margin = new Padding(18, 45, 18, 0);
                        panelx.BackColor = Color.FromArgb(40, 40, 40);

                        itemsforsell_list.Controls.Add(panelx);

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.ImageLocation = item.Image_location;

                        pictureBox.Size = new Size(200, 200);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Location = new Point(16, 20);

                        Label Description = new Label();

                        XmlDocument doc = new XmlDocument();

                        Description.Text = item.Name;
                        Description.ForeColor = Color.White;
                        Description.Font = new Font("Arial", 13);
                        Description.Size = new Size(232, 100);
                        Description.AutoEllipsis = true;
                        Description.Location = new Point(10, 230);

                        Label SubInformations = new Label();

                        SubInformations.Text = item.connection_type + " | Fones: " + item.frequency_fones + " Microfones: " + item.frequency_microfones + " | Fones: " + item.impedance_fones;

                        SubInformations.ForeColor = Color.White;
                        SubInformations.Font = new Font("Arial", 7);
                        SubInformations.Size = new Size(222, 100);
                        SubInformations.AutoEllipsis = true;
                        SubInformations.Location = new Point(10, 305);

                        Label Price_Info = new Label();

                        Price_Info.Text = item.price.ToString() + " €";
                        Price_Info.ForeColor = Color.FromArgb(233, 100, 73);
                        Price_Info.Font = new Font("Arial", 22, FontStyle.Bold);
                        Price_Info.Size = new Size(222, 150);
                        Price_Info.Location = new Point(10, 350);

                        panelx.Controls.Add(Price_Info);
                        panelx.Controls.Add(SubInformations);
                        panelx.Controls.Add(Description);
                        panelx.Controls.Add(pictureBox);
                    }

                }
            }
        }

        private void open_bar_Click(object sender, EventArgs e)
        {
            ProductsBar_List.Visible = true;
        }

        private void close_productslist_Click(object sender, EventArgs e)
        {
            ProductsBar_List.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            new Home(product_list).Show();

            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new Home(product_list).Show();

            this.Close();
        }

        private void GotoDesktopBox_Click(object sender, EventArgs e)
        {
            new BuyItems("Computadores > Desktop", this.product_list).Show();

            this.Hide();
        }

        private void GotoLaptopBox_Click(object sender, EventArgs e)
        {
            new BuyItems("Computadores > Laptop", this.product_list).Show();

            this.Hide();
        }

        private void GotoPhoneBox_Click(object sender, EventArgs e)
        {
            new BuyItems("Phones", this.product_list).Show();

            this.Hide();
        }

        private void GotoHeadSets_Click(object sender, EventArgs e)
        {
            new BuyItems("HeadSets", this.product_list).Show();

            this.Hide();
        }
    }
}
