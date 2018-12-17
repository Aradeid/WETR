using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Station : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int LocationId { get; set; } // may be replaced with actual location in the future
        public Station(string name, string type, int locationId, int id = -1) : base(id)
        {
            this.Name = name;
            this.Type = type;
            this.LocationId = locationId;
        }
		public override string ToString() {
			return base.ToString()
				+ ", Name[" + Name + "]"
				+ ", Type[" + Type + "]"
				+ ", LocationId[" + LocationId + "]"
				;
		}
	}
}
