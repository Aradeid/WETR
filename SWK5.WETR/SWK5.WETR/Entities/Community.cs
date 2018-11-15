using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWK5.WETR.Entities
{
    public class Community : Region // TO BE EXPANDED ONCE MORE REQUIREMENTS ARE KNOWN
    {
        public Community(string name, int id) : base(name, id) { }
		public override string ToString() {
			return base.ToString();
		}
	}
}
