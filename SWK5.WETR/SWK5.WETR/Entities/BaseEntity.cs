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
        public int Id { get; set; } // internal database id given to every entity; -1 if not in database

        public BaseEntity(int id)
        {
            this.Id = id;
        }
        public override string ToString()
        {
            return "Id[" + ((Id == -1) ? "NO DATABASE ID" : Id.ToString()) + "]";
        }
		public bool Equals(BaseEntity e) {
			return (this.Id != -1) && (e.Id != -1) // is not part of database
				&& (this.Id == e.Id);
		}
	}
}
