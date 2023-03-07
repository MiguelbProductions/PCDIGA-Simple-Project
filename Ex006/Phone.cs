using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Phone : Product
    {
        public int imei, androindVersion;

        public int IMEI { get { return imei; } set { imei = value; } }
        public int AndroindVersion { get { return androindVersion; } set { androindVersion = value; } }




    }
}
