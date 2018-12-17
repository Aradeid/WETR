using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Location : BaseEntity
    {
        public string Address { get; }
        public string Zip { get; }
        public double Longitude { get; }
        public int Latitude { get; }
        public Location(string address, string zip, double longitude, int latitude, int id = -1) : base(id)
        {
            this.Address = address;
            this.Zip = zip;
            this.Longitude = longitude;
            this.Latitude = latitude;
        }
    }
}
