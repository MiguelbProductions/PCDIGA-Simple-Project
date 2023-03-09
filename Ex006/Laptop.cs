using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Laptop : Computer
    {
        string batery_model, webcam_model, microfone_model, monitor_model;

        public Laptop (string storage_type, string storage_model, string ram_model, string processor_model, string graphiccard_model, string batery_model, string webcam_model, string microfone_model, string monitor_model) : base(storage_type, storage_model, ram_model, processor_model, graphiccard_model)
        {
            this.batery_model = batery_model;
            this.webcam_model = webcam_model;
            this.microfone_model = microfone_model;
            this.monitor_model = monitor_model;
        }
    }
}
