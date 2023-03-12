using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    public class Desktop : Computer
    {
        string internalpowesupply_model, chipset_model, watercoller;

        public Desktop(string storage_type, string storage_model, string ram_model, string processor_model, string graphiccard_model, string internalpowesupply_model, string chipset_model, string watercoller, string storage_model_resumed, string ram_model_resumed, string processor_model_resumed, string graphic_model_resumed, string name, double price) : base(storage_type, storage_model, ram_model, processor_model, graphiccard_model, storage_model_resumed, ram_model_resumed, processor_model_resumed, graphic_model_resumed, name, price)
        {
            this.internalpowesupply_model = internalpowesupply_model;
            this.chipset_model = chipset_model;
            this.watercoller = watercoller;
        }
    }
}
