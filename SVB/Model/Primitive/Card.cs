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
		public override string ToString()
		{
			return this.name;
		}
	}
}