using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities {
	public class User : BaseEntity {
		private string name { get; }
		// private string passHash { get; } // likely shouldn't exist here
		private int privilegeId { get; } // FK on Privilege
		private int stationId { get; } // FK on Station
		public User(string name, int privilegeId, int stationId, int id = -1) : base(id) {
			this.name = name;
			this.privilegeId = privilegeId;
			this.stationId = stationId;
		}
		public override string ToString() {
			return base.ToString()
				+ ", name[" + name + "]"
				//+ ", passHash[" + passHash + "]"
				+ ", privilegeId[" + privilegeId + "]"
				+ ", stationId[" + stationId + "]"
				;
		}
	}
}
