using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class BaseEntity
    {
        // all attributes for all entities/classes are private in this version, as it is unknown at this point whether a different approach is needed
        private int id { get; } // internal database id given to every entity; -1 if not in database

        public BaseEntity(int id)
        {
            this.id = id;
        }
        public override string ToString()
        {
            return "id[" + ((id == -1) ? "NO DATABASE ID" : id.ToString()) + "]";
        }
		public bool Equals(BaseEntity e) {
			return (this.id != -1) && (e.id != -1) // is not part of database
				&& (this.id == e.id);
		}
	}
}
