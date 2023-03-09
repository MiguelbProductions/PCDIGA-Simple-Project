using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Desktop : Computer
    {
        string internalpowesupply_model, chipset_model;
        bool watercoller;

        public Desktop(string storage_type, string storage_model, string ram_model, string processor_model, string graphiccard_model, string internalpowesupply_model, string chipset_model, bool watercoller) : base(storage_type, storage_model, ram_model, processor_model, graphiccard_model)
        {
            this.internalpowesupply_model = internalpowesupply_model;
            this.chipset_model = chipset_model;
            this.watercoller = watercoller;
        }
    }
}
