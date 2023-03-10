using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    public class Laptop : Computer
    {
        public string batery_model, webcam_model, microfone_model, monitor_model;

        public Laptop (string storage_type, string storage_model, string ram_model, string processor_model, string graphiccard_model, string batery_model, string webcam_model, string microfone_model, string monitor_model, string storage_model_resumed, string ram_model_resumed, string processor_model_resumed, string graphic_model_resumed, string name, double price) : base(storage_type, storage_model, ram_model, processor_model, graphiccard_model, storage_model_resumed, ram_model_resumed, processor_model_resumed, graphic_model_resumed, name, price)
        {
            this.batery_model = batery_model;
            this.webcam_model = webcam_model;
            this.microfone_model = microfone_model;
            this.monitor_model = monitor_model;
        }

        public string Batery_model { get { return batery_model; } set { batery_model = value; } }
        public string Webcam_model { get { return webcam_model; } set { webcam_model = value; } }
        public string Microfone_model { get { return microfone_model; } set { microfone_model = value; } }
        public string Monitor_model { get { return monitor_model; } set { monitor_model = value; } }

    }
}
