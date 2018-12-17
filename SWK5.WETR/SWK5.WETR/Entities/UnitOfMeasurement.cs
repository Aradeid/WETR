using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class UnitOfMeasurement : BaseEntity // class might be deleted later, as it seems to only be needed internally
    {
        private string unit { get; }
        private string description { get; }
        public UnitOfMeasurement(string unit, string description, int id = -1) : base(id)
        {
            this.unit = unit;
            this.description = description;
        }
		public override string ToString() {
			return base.ToString()
				+ ", unit[" + unit + "]"
                + ", description[" + description + "]"
                ;
		}
	}
}
