using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class HeadSet : Article
    {
        public string model, brand, connection_type;
        public double frequency, impedance, weight;

        public string Model { get { return model; } set { model = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Connection_type { get { return connection_type; } set { connection_type = value; } }
        public double Frequency { get { return frequency; } set { frequency = value; } }
        public double Impedance { get { return impedance; } set { impedance = value; } }
        public double Weight { get { return weight; } set { weight = value; } }


    }
}
