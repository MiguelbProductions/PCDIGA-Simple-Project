using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex006
{
    public partial class BuySelectedItem : Form
    {
        Product[] list_of_products;
        int product_pos;
        string type_of_product;

        public BuySelectedItem(Product[] list_of_products, int product_pos, string type_of_product)
        {
            InitializeComponent();

            this.list_of_products = list_of_products;
            this.product_pos = product_pos;
            this.type_of_product = type_of_product;
        }

        private void BuySelectedItem_Load(object sender, EventArgs e)
        {
            Img_Product.ImageLocation = this.list_of_products[product_pos].Image_location;

            if (this.type_of_product == "Desktop")
            {
                txt_nameofproduct.Text = ((Desktop)list_of_products[product_pos]).Name;
                txt_information.Text = "Processor: " + ((Desktop)list_of_products[product_pos]).Processor_model + "\nRam: " + ((Desktop)list_of_products[product_pos]).Ram_model + " \nGraphicard: " + ((Desktop)list_of_products[product_pos]).Graphiccard_model + "\nStorage: " + ((Desktop)list_of_products[product_pos]).Storage_type + " " + ((Desktop)list_of_products[product_pos]).storage_model + "\nInternal Power Supply: " + ((Desktop)list_of_products[product_pos]).Internalpowesupply_model + "\nChipset: " + ((Desktop)list_of_products[product_pos]).Chipset_model + "\nWatterColler: " + ((Desktop)list_of_products[product_pos]).Watercoller;
            }
            else if (this.type_of_product == "Laptop")
            {
                txt_nameofproduct.Text = ((Laptop)list_of_products[product_pos]).Name;
                txt_information.Text = "Processor: " + ((Laptop)list_of_products[product_pos]).Processor_model + "\nRam: " + ((Laptop)list_of_products[product_pos]).Ram_model + " \nGraphicard: " + ((Laptop)list_of_products[product_pos]).Graphiccard_model + "\nStorage: " + ((Laptop)list_of_products[product_pos]).Storage_type + " " + ((Laptop)list_of_products[product_pos]).storage_model + "\nInternal Battery: " + ((Laptop)list_of_products[product_pos]).Batery_model + "\nMicrofone and Webcam: " + ((Laptop)list_of_products[product_pos]).Microfone_model + " | " + ((Laptop)list_of_products[product_pos]).Webcam_model + "\nMonitor: " + ((Laptop)list_of_products[product_pos]).Monitor_model;
            }
            else if (this.type_of_product == "Phone")
            {
                txt_nameofproduct.Text = ((Phone)list_of_products[product_pos]).Name;
                txt_information.Text = "Tipo de Telemovel e Versão do Sistema: " + ((Phone)list_of_products[product_pos]).Typeofphone + " " + ((Phone)list_of_products[product_pos]).PhoneVersion + "\nFrontal Cam: " + ((Phone)list_of_products[product_pos]).Frontalcam_model + "\nBack Cam: " + ((Phone)list_of_products[product_pos]).Backcam_model + "\nBattery: " + ((Phone)list_of_products[product_pos]).Battery_model + "\nStorage Size: " + ((Phone)list_of_products[product_pos]).Storagesize;
            }
            else if (this.type_of_product == "HeadSet")
            {
                txt_nameofproduct.Text = ((HeadSet)list_of_products[product_pos]).Name;
                txt_information.Text = "Frequency: \n   Microphones: " + ((HeadSet)list_of_products[product_pos]).Frequency_microfones + "\n   Fones: " + ((HeadSet)list_of_products[product_pos]).Frequency_fones + "\nImpedance: \n   Microfone: " + ((HeadSet)list_of_products[product_pos]).Impedance_microfones + "\n   Fones: " + ((HeadSet)list_of_products[product_pos]).Impedance_fones + "\nConection Type: " + ((HeadSet)list_of_products[product_pos]).Connection_type;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disponivel na proxima atualizaçãio (LOGIN AND COMPUTER UPDATE)", "Disponivel na proxima atualização");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produto(s) comprado(s) com sucesso!", "Produto(s) Comprado(s)");

            this.Close();
        }
    }
}
