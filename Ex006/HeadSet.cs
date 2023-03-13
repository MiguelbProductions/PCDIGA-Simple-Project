 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    public class HeadSet : Product
    {
        public string connection_type, frequency_fones, impedance_fones, frequency_microfones, impedance_microfones;

        public HeadSet (string connection_type, string frequency_fones, string impedance_fones, string frequency_microfones, string impedance_microfones, string name, double price) : base(name, price)
        {
            this.Connection_type = connection_type;
            this.frequency_fones = frequency_fones;
            this.impedance_fones = impedance_fones;
            this.frequency_microfones = frequency_microfones;
            this.impedance_microfones = impedance_microfones;
        }

        public string Connection_type { get { return connection_type; } set { connection_type = value; } }
        public string Frequency_fones { get { return frequency_fones; } set { frequency_fones = value; } }
        public string Impedance_fones { get { return impedance_fones; } set { impedance_fones = value; } }
        public string Frequency_microfones { get { return frequency_microfones; } set { frequency_microfones = value; } }
        public string Impedance_microfones { get { return impedance_microfones; } set { impedance_microfones = value; } }

    }
}
