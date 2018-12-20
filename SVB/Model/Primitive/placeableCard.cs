using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model;

namespace SVB.Core.Model.Primitive
{
	public abstract class PlaceableCard : Card
	{
		public int ppCost { get; set; }
		public int rarity { get; set; }
		public trait trait { get; set; }

		protected virtual void destroy(Leader owner)
		{
			owner.shadows++;
		}
		public virtual void discard() { }
		public virtual void banish() { }
	}
}