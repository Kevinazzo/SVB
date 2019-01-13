using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVB.Core.Model.Primitive
{
	public abstract class Card
	{
		public string name { get; set; }
		public int ppCost { get; set; }
		public int rarity { get; set; }
		public _class cardclass { get; set; }
		public trait trait { get; set; }
		
		// ↓ THYIs IS BEHAVIOUR !!!!! get this to the behaviour zone
		protected virtual void destroy(Leader owner) { owner.shadows++; }
		public virtual void discard(Leader owner) { owner.shadows++; }
		public virtual void banish() { }

		public override string ToString()
		{
			return this.name;
		}

		//debug

	}
}