using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Computer : Product
    {
        public string storage_type, storage_model, ram_model, processor_model, graphiccard_model;

        public Computer(string storage_type, string storage_model, string ram_model, string processor_model, string graphiccard_model)
        {
            this.storage_type = storage_type;
            this.storage_model = storage_model;
            this.ram_model = ram_model;
            this.processor_model = processor_model;
            this.graphiccard_model = graphiccard_model;
            this.storage_type = storage_type;
            this.storage_model = storage_model;
            this.ram_model = ram_model;
            this.processor_model = processor_model;
            this.graphiccard_model = graphiccard_model;
        }

        public string Storage_type { get { return storage_type; } set { storage_type = value; } }
        public string Storage_model { get { return storage_model; } set { storage_model = value; } }
        public string Ram_model { get { return ram_model; } set { ram_model = value; } }
        public string Processor_model { get { return processor_model; } set { processor_model = value; } }
        public string Graphiccard_model { get { return graphiccard_model; } set { graphiccard_model = value; } }
        
    }
}
