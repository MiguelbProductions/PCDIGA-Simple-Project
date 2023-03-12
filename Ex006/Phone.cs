using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    public class Phone : Product
    {
        public string typeofphone, frontalcam_model, backcam_model, battery_model, storagesize;
        public int phoneVersion;

        public Phone(string typeofphone, string frontalcam_model, string backcam_model, string battery_model, string storagesize, int phoneVersion, string name, double price) : base(name, price)
        {
            this.typeofphone = typeofphone;
            this.frontalcam_model = frontalcam_model;
            this.backcam_model = backcam_model;
            this.battery_model = battery_model;
            this.storagesize = storagesize;
            this.phoneVersion = phoneVersion;
            this.price = price;

        }

        public string Typeofphone { get { return typeofphone; } set { value = typeofphone; } }
        public string Frontalcam_model { get { return frontalcam_model; } set { value = frontalcam_model; } }
        public string Backcam_model { get { return Backcam_model; } set { value = Backcam_model; } }
        public string Battery_model { get { return battery_model; } set { value = battery_model; } }
        public string Storagesize { get { return storagesize; } set { value = storagesize; } }
        public int PhoneVersion { get { return phoneVersion; } set { phoneVersion = value; } }




    }
}
