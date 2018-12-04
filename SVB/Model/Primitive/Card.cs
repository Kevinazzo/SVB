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
		public short playPoints { get; set; }
		public short rarity { get; set; }
		public Trait trait { get; set; }
	}
}