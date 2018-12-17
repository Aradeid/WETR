using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Location : BaseEntity
    {
        public string Address { get; set; }
        public string Zip { get; set; }
        public double Longitude { get; set; }
        public int Latitude { get; set; }
        public Location(string address, string zip, double longitude, int latitude, int id = -1) : base(id)
        {
            this.Address = address;
            this.Zip = zip;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }
    }
}
