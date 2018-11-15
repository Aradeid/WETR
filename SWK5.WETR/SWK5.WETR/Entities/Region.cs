using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Region : BaseEntity
    {
        protected string name { get; }
        public Region(string name, int id = -1) : base(id)
        {
            this.name = name;
        }
		public override string ToString() {
			return base.ToString()
				+ ", name[" + name + "]"
				;
		}
	}
}
