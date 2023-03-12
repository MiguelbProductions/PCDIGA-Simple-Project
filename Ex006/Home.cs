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
using static System.Net.Mime.MediaTypeNames;
using System.Xml;

namespace Ex006
{
    public partial class Home : Form
    {
        Product[][] products_list;

        public Home(Product[][] products_list = null)
        {
            InitializeComponent();

            if (this.products_list == null)
            {
                this.products_list = new Product[4][];

                this.products_list[0] = new Desktop[100];
                this.products_list[1] = new Laptop[100];
                this.products_list[2] = new Phone[100];
                this.products_list[3] = new HeadSet[100];

                for (int list_numx = 0; list_numx < this.products_list.Length; list_numx++)
                {
                    string data_folder = "";

                    if (list_numx == 0)
                    {
                        data_folder = "Images\\Desktop";
                    }
                    else if (list_numx == 1)
                    {
                        data_folder = "Images\\Laptop";
                    }
                    else if (list_numx == 2)
                    {
                        data_folder = "Images\\Phones";
                    }
                    else if (list_numx == 3)
                    {
                        data_folder = "Images\\HeadSets";
                    }

                    int itemproduct_num = 0;

                    string[] info_images = Directory.GetFiles(data_folder, "*.jpg");

                    foreach (string info_image in info_images)
                    {
                        FileInfo image = new FileInfo(info_image);

                        if (data_folder == "Images\\Desktop")
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load(".\\Images\\Desktop\\" + image.Name.Replace(".jpg", ".xml"));

                            XmlNode storagetype_node = doc.SelectSingleNode("//storage_type");
                            string storagetype = storagetype_node.Attributes["name"].Value;

                            XmlNode storagemodel_node = doc.SelectSingleNode("//storage_model");
                            string storagemodel = storagemodel_node.Attributes["name"].Value;

                            XmlNode ram_node = doc.SelectSingleNode("//ram_model");
                            string ram = ram_node.Attributes["name"].Value;

                            XmlNode processor_node = doc.SelectSingleNode("//processor_model");
                            string processor = processor_node.Attributes["name"].Value;

                            XmlNode graphic_node = doc.SelectSingleNode("//graphiccard_model");
                            string graphic = graphic_node.Attributes["name"].Value;

                            XmlNode internalpowesupply_node = doc.SelectSingleNode("//internalpowesupply_model");
                            string internalpowesupply = internalpowesupply_node.Attributes["name"].Value;

                            XmlNode chipset_node = doc.SelectSingleNode("//chipset_model");
                            string chipset = chipset_node.Attributes["name"].Value;

                            XmlNode watercooler_node = doc.SelectSingleNode("//watercoller");
                            string watercooler = watercooler_node.Attributes["name"].Value;

                            XmlNode price_node = doc.SelectSingleNode("//price");
                            double price = Convert.ToDouble(price_node.Attributes["value"].Value);

                            XmlNode name_node = doc.SelectSingleNode("//name");
                            string name = name_node.Attributes["name"].Value;

                            XmlNode processor_node_resumed = doc.SelectSingleNode("//processor_model");
                            string processor_resumed = processor_node.Attributes["resumed"].Value;

                            XmlNode ram_node_resumed = doc.SelectSingleNode("//ram_model");
                            string ram_resumed = ram_node.Attributes["resumed"].Value;

                            XmlNode graphic_node_resumed = doc.SelectSingleNode("//graphiccard_model");
                            string graphic_resumed = graphic_node.Attributes["resumed"].Value;

                            XmlNode storage_node_resumed = doc.SelectSingleNode("//storage_model");
                            string storage_resumed = storagemodel_node.Attributes["resumed"].Value;

                            this.products_list[0][itemproduct_num] = new Desktop(storagetype, storagemodel, ram, processor, graphic, internalpowesupply, chipset, watercooler, storage_resumed, ram_resumed, processor_resumed, graphic_resumed, name, price);
                            this.products_list[0][itemproduct_num++].Image_location = image.FullName;

                        }
                        else if (data_folder == "Images\\Laptop")
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load(".\\Images\\Laptop\\" + image.Name.Replace(".jpg", ".xml"));

                            XmlNode storagetype_node = doc.SelectSingleNode("//storage_type");
                            string storagetype = storagetype_node.Attributes["name"].Value;

                            XmlNode storagemodel_node = doc.SelectSingleNode("//storage_model");
                            string storagemodel = storagemodel_node.Attributes["name"].Value;

                            XmlNode ram_node = doc.SelectSingleNode("//ram_model");
                            string ram = ram_node.Attributes["name"].Value;

                            XmlNode processor_node = doc.SelectSingleNode("//processor_model");
                            string processor = processor_node.Attributes["name"].Value;

                            XmlNode graphic_node = doc.SelectSingleNode("//graphiccard_model");
                            string graphic = graphic_node.Attributes["name"].Value;

                            XmlNode webcam_node = doc.SelectSingleNode("//webcam_model");
                            string webcam = webcam_node.Attributes["name"].Value;

                            XmlNode microfone_node = doc.SelectSingleNode("//microfone_model");
                            string microfone = microfone_node.Attributes["name"].Value;

                            XmlNode monitor_node = doc.SelectSingleNode("//monitor_model");
                            string monitor = monitor_node.Attributes["name"].Value;

                            XmlNode battery_node = doc.SelectSingleNode("//batery_model");
                            string battery = battery_node.Attributes["name"].Value;

                            XmlNode price_node = doc.SelectSingleNode("//price");
                            double price = Convert.ToDouble(price_node.Attributes["value"].Value);

                            XmlNode name_node = doc.SelectSingleNode("//name");
                            string name = name_node.Attributes["name"].Value;

                            XmlNode processor_node_resumed = doc.SelectSingleNode("//processor_model");
                            string processor_resumed = processor_node.Attributes["resumed"].Value;

                            XmlNode ram_node_resumed = doc.SelectSingleNode("//ram_model");
                            string ram_resumed = ram_node.Attributes["resumed"].Value;

                            XmlNode graphic_node_resumed = doc.SelectSingleNode("//graphiccard_model");
                            string graphic_resumed = graphic_node.Attributes["resumed"].Value;

                            XmlNode storage_node_resumed = doc.SelectSingleNode("//storage_model");
                            string storage_resumed = storagemodel_node.Attributes["resumed"].Value;

                            this.products_list[1][itemproduct_num] = new Laptop(storagetype, storagemodel, ram, processor, graphic, battery, webcam, microfone, monitor, storage_resumed, ram_resumed, processor_resumed, graphic_resumed, name, price);
                            this.products_list[1][itemproduct_num++].Image_location = image.FullName;

                        }
                        else if (data_folder == "Images\\Phones")
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load(".\\Images\\Phones\\" + image.Name.Replace(".jpg", ".xml"));

                            XmlNode typeofphone_node = doc.SelectSingleNode("//typeofphone");
                            string typeofphone = typeofphone_node.Attributes["name"].Value;

                            XmlNode frontalcam_node = doc.SelectSingleNode("//frontalcam_model");
                            string frontalcam = frontalcam_node.Attributes["name"].Value;

                            XmlNode backcam_node = doc.SelectSingleNode("//backcam_model");
                            string backcam = backcam_node.Attributes["name"].Value;

                            XmlNode battery_node = doc.SelectSingleNode("//battery_model");
                            string battery = battery_node.Attributes["name"].Value;

                            XmlNode storagesize_node = doc.SelectSingleNode("//storagesize");
                            string storagesize = storagesize_node.Attributes["value"].Value;

                            XmlNode phoneversion_node = doc.SelectSingleNode("//phoneVersion");
                            int phoneversion = Convert.ToInt32(phoneversion_node.Attributes["value"].Value);

                            XmlNode price_node = doc.SelectSingleNode("//price");
                            double price = Convert.ToDouble(price_node.Attributes["value"].Value);

                            XmlNode name_node = doc.SelectSingleNode("//name");
                            string name = name_node.Attributes["name"].Value;

                            this.products_list[2][itemproduct_num] = new Phone(typeofphone, frontalcam, backcam, battery, storagesize, phoneversion, name, price);
                            this.products_list[2][itemproduct_num++].Image_location = image.FullName;
                        }
                        else if (data_folder == "Images\\HeadSets")
                        {
                            XmlDocument doc = new XmlDocument();
                            doc.Load(".\\Images\\HeadSets\\" + image.Name.Replace(".jpg", ".xml"));

                            XmlNode connection_node = doc.SelectSingleNode("//connection_type");
                            string connectiontype = connection_node.Attributes["name"].Value;

                            XmlNode frequency_node = doc.SelectSingleNode("//frequency");
                            string frequencyfones = frequency_node.Attributes["fones"].Value;
                            string frequencymicrofones = frequency_node.Attributes["microphones"].Value;

                            XmlNode impedance_node = doc.SelectSingleNode("//impedance");
                            string impedancefones = impedance_node.Attributes["fones"].Value;
                            string impedancemicrofones = impedance_node.Attributes["microphones"].Value;

                            XmlNode price_node = doc.SelectSingleNode("//price");
                            double price = Convert.ToDouble(price_node.Attributes["value"].Value);

                            XmlNode name_node = doc.SelectSingleNode("//name");
                            string name = name_node.Attributes["name"].Value;

                            this.products_list[3][itemproduct_num] = new HeadSet(connectiontype, frequencyfones, impedancefones, frequencymicrofones, impedancemicrofones, name, price);
                            this.products_list[3][itemproduct_num++].Image_location = image.FullName;
                        }

                    }
                }
            }
        }

        private void ComputerBox_Click(object sender, EventArgs e)
        {
            new BuyItems("Computadores > Desktop", this.products_list).Show();

            this.Hide();
        }

        private void PhoneBox_Click(object sender, EventArgs e)
        {
            new BuyItems("Phones", this.products_list).Show();

            this.Hide();
        }

        private void HeaSetBox_Click(object sender, EventArgs e)
        {
            new BuyItems("HeadSets", this.products_list).Show();

            this.Hide();
        }
    }
}
