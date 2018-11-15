using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Location : BaseEntity
    {
        private string address { get; }
        private string zip { get; }
        private double longitude { get; }
        private int latitude { get; }
        public Location(string address, string zip, double longitude, int latitude, int id = -1) : base(id)
        {
            this.address = address;
            this.zip = zip;
            this.longitude = longitude;
            this.latitude = latitude;
        }
    }
}
