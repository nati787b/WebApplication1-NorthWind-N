// Written by Nathnael Tegegne
// 10/21/2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1_NorthWind_N.Models
{
    public class Shipper
    {
        // class variables
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        // gets and sets
        public int ShipperId
        {
            get { return this.shipperId; }
            set
            {
                if (value > -1)
                { this.shipperId = value; }
            }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }

        // constructors
        public Shipper() : this(-1, "n/a", "n/a")
        {
            //empty string
        }
        public Shipper(int aShiperid) : this(aShiperid, "n/a", "n/a")
        {
            //partial string
        }
        public Shipper(int aShipperid, string aCompanyname, string aPhone)
        {
            this.ShipperId = aShipperid;
            this.CompanyName = aCompanyname;
            this.Phone = aPhone;
        }
        // methods
        public override string ToString()
        {
            string msg = "";
            msg = msg + "ShipperId:" + this.ShipperId + "\n";
            msg = msg + "CompanyName:" + this.CompanyName + "\n";
            msg = msg + "Phone:" + this.Phone + "\n";
            return msg;
        }
    }
}
