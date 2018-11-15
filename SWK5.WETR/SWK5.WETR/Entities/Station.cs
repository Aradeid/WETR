using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Station : BaseEntity
    {
        private string name { get; }
        private string type { get; }
        private int locationId { get; } // may be replaced with actual location in the future
        public Station(string name, string type, int locationId, int id = -1) : base(id)
        {
            this.name = name;
            this.type = type;
            this.locationId = locationId;
        }
		public override string ToString() {
			return base.ToString()
				+ ", name[" + name + "]"
				+ ", type[" + type + "]"
				+ ", locationId[" + locationId + "]"
				;
		}
	}
}
