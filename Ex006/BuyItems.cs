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
            double min_price = 0, max_price = 0;

            if (txt_producttitle.Text == "Computadores > Desktop")
            {
                int num_of_selecteditem = 0;

                foreach (Desktop item in product_list[0])
                {
                    if (item != null)
                    {
                        Panel panelx = new Panel();

                        panelx.Name = num_of_selecteditem.ToString();
                        panelx.Size = new Size(232, 405);
                        panelx.Margin = new Padding(18, 45, 18, 0);
                        panelx.BackColor = Color.FromArgb(40, 40, 40);
                        panelx.Click += (s, e2) =>
                        {
                            new BuySelectedItem(this.product_list[0], Convert.ToInt32(panelx.Name), "Desktop").Show();
                        };

                        itemsforsell_list.Controls.Add(panelx);

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.ImageLocation = item.Image_location;

                        pictureBox.Size = new Size(200, 200);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Location = new Point(16, 20);
                        pictureBox.Enabled = false;

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

                        if (item.price > max_price)
                        {
                            max_price = item.price;
                        }

                        if (item.price < min_price || min_price == 0)
                        {
                            min_price = item.price;
                        }

                        num_of_selecteditem++;
                    }

                }
            }
            else if (txt_producttitle.Text == "Computadores > Laptop")
            {
                int num_of_selecteditem = 0;

                foreach (Laptop item in product_list[1])
                {
                    if (item != null)
                    {
                        Panel panelx = new Panel();

                        panelx.Name = num_of_selecteditem.ToString();
                        panelx.Size = new Size(232, 405);
                        panelx.Margin = new Padding(18, 45, 18, 0);
                        panelx.BackColor = Color.FromArgb(40, 40, 40);
                        panelx.Click += (s, e2) =>
                        {
                            new BuySelectedItem(this.product_list[1], Convert.ToInt32(panelx.Name), "Laptop").Show();
                        };

                        itemsforsell_list.Controls.Add(panelx);

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.ImageLocation = item.Image_location;

                        pictureBox.Size = new Size(200, 200);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Location = new Point(16, 20);
                        pictureBox.Enabled = false;

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

                        if (item.price > max_price)
                        {
                            max_price = item.price;
                        }

                        if (item.price < min_price || min_price == 0)
                        {
                            min_price = item.price;
                        }

                        num_of_selecteditem++;
                    }

                }
            }
            else if (txt_producttitle.Text == "Phones")
            {
                int num_of_selecteditem = 0;

                foreach (Phone item in product_list[2])
                {
                    if (item != null)
                    {
                        Panel panelx = new Panel();

                        panelx.Name = num_of_selecteditem.ToString();
                        panelx.Size = new Size(232, 405);
                        panelx.Margin = new Padding(18, 45, 18, 0);
                        panelx.BackColor = Color.FromArgb(40, 40, 40);
                        panelx.Click += (s, e2) =>
                        {
                            new BuySelectedItem(this.product_list[2], Convert.ToInt32(panelx.Name), "Phone").Show();
                        };

                        itemsforsell_list.Controls.Add(panelx);

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.ImageLocation = item.Image_location;

                        pictureBox.Size = new Size(200, 200);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Location = new Point(16, 20);
                        pictureBox.Enabled = false;

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
                        Price_Info.Location = new Point(10, 360);

                        panelx.Controls.Add(Price_Info);
                        panelx.Controls.Add(SubInformations);
                        panelx.Controls.Add(Description);
                        panelx.Controls.Add(pictureBox);

                        if (item.price > max_price)
                        {
                            max_price = item.price;
                        }

                        if (item.price < min_price || min_price == 0)
                        {
                            min_price = item.price;
                        }

                        num_of_selecteditem++;
                    }

                }
            }
            else if (txt_producttitle.Text == "HeadSets")
            {
                int num_of_selecteditem = 0;


                foreach (HeadSet item in product_list[3])
                {
                    if (item != null)
                    {
                        Panel panelx = new Panel();

                        panelx.Name = num_of_selecteditem.ToString();
                        panelx.Size = new Size(232, 405);
                        panelx.Margin = new Padding(18, 45, 18, 0);
                        panelx.BackColor = Color.FromArgb(40, 40, 40);
                        panelx.Click += (s, e2) =>
                        {
                            new BuySelectedItem(this.product_list[3], Convert.ToInt32(panelx.Name), "HeadSet").Show();
                        };

                        itemsforsell_list.Controls.Add(panelx);

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.ImageLocation = item.Image_location;

                        pictureBox.Size = new Size(200, 200);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Location = new Point(16, 20);
                        pictureBox.Enabled = false;

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

                        if (item.price > max_price)
                        {
                            max_price = item.price;
                        }

                        if (item.price < min_price || min_price == 0)
                        {
                            min_price = item.price;
                        }
                    }

                    num_of_selecteditem++;
                }
            }

            txt_MinPriceFilter.Text = min_price.ToString() + "€";
            txt_MidPriceFilter.Text = ((max_price - min_price) / 2 + min_price).ToString() + "€";
            txt_MaxPriceFilter.Text = max_price.ToString() + "€";

            pricefilter.Minimum = Convert.ToInt32(min_price - 1);
            pricefilter.Maximum = Convert.ToInt32(max_price - 1);
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

        private void Btn_SearchbyFilter_Click(object sender, EventArgs e)
        {
            itemsforsell_list.Controls.Clear();

            if (txt_producttitle.Text == "Computadores > Desktop")
            {
                foreach (Desktop item in product_list[0])
                {
                    if (item != null)
                    {
                        if (item.price > pricefilter.Value)
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
                            pictureBox.Enabled = false;

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
            }
            else if (txt_producttitle.Text == "Computadores > Laptop")
            {
                foreach (Laptop item in product_list[1])
                {
                    if (item != null)
                    {
                        if (item.price > pricefilter.Value)
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
            }
            else if (txt_producttitle.Text == "Phones")
            {
                foreach (Phone item in product_list[2])
                {
                    if (item != null)
                    {
                        if (item.price > pricefilter.Value)
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
                            Price_Info.Location = new Point(10, 360);

                            panelx.Controls.Add(Price_Info);
                            panelx.Controls.Add(SubInformations);
                            panelx.Controls.Add(Description);
                            panelx.Controls.Add(pictureBox);
                        }
                    }

                }
            }
            else if (txt_producttitle.Text == "HeadSets")
            {
                foreach (HeadSet item in product_list[3])
                {
                    if (item != null)
                    {
                        if (item.price > pricefilter.Value)
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
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponivel na proxima atualizaçãio (LOGIN AND COMPUTER UPDATE)", "Disponivel na proxima atualização");
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponivel na proxima atualizaçãio (LOGIN AND COMPUTER UPDATE)", "Disponivel na proxima atualização");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponivel na proxima atualizaçãio (LOGIN AND COMPUTER UPDATE)", "Disponivel na proxima atualização");
        }
    }
}
