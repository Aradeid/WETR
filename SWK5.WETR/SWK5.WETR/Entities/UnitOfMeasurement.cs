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
        public UnitOfMeasurement(string unit, int id = -1) : base(id)
        {
            this.unit = unit;
        }
		public override string ToString() {
			return base.ToString()
				+ ", unit[" + unit + "]"
				;
		}
	}
}
