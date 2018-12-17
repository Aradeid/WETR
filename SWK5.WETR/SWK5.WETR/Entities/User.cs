using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities {
	public class User : BaseEntity {
		public string Name { get; }
		// private string passHash { get; } // likely shouldn't exist here
		public int PrivilegeId { get; } // FK on Privilege
		public int StationId { get; } // FK on Station
		public User(string name, int privilegeId, int stationId, int id = -1) : base(id) {
			this.Name = name;
			this.PrivilegeId = privilegeId;
			this.StationId = stationId;
		}
		public override string ToString() {
			return base.ToString()
				+ ", Name[" + Name + "]"
				//+ ", passHash[" + passHash + "]"
				+ ", PrivilegeId[" + PrivilegeId + "]"
				+ ", StationId[" + StationId + "]"
				;
		}
	}
}
