using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Computer : Article
    {
        public string storage_type, storage_model, ram_model, processor_model, graphiccard_model;

        public string Storage_type { get { return storage_type; } set { storage_type = value; } }
        public string Storage_model { get { return storage_model; } set { storage_model = value; } }
        public string Ram_model { get { return ram_model; } set { ram_model = value; } }
        public string Processor_model { get { return processor_model; } set { processor_model = value; } }
        public string Graphiccard_model { get { return graphiccard_model; } set { graphiccard_model = value; } }
    }
}
