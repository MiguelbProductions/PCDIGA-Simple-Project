using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Phone : Article
    {
        public string model, brand;
        public int imei, androindVersion;

        public string Model { get { return model; } set { model = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public int IMEI { get { return imei; } set { imei = value; } }
        public int AndroindVersion { get { return androindVersion; } set { androindVersion = value; } }




    }
}
