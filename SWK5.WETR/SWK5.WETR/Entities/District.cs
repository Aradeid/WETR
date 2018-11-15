using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class District : Region // TO BE EXPANDED ONCE MORE REQUIREMENTS ARE KNOWN
    {
        public District(string name, int id) : base(name, id) { }
		public override string ToString() {
			return base.ToString();
		}
	}
}
