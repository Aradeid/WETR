using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class UnitOfMeasurement : BaseEntity // class might be deleted later, as it seems to only be needed internally
    {
        public string Unit { get; set; }
        public string Description { get; set; }
        public UnitOfMeasurement(string unit, string description, int id = -1) : base(id)
        {
            this.Unit = unit;
            this.Description = description;
        }
		public override string ToString() {
			return base.ToString()
				+ ", Unit[" + Unit + "]"
                + ", Description[" + Description + "]"
                ;
		}
	}
}
