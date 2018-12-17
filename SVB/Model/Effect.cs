using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVB.Core.Model
{
	public abstract class nonStackEffect
	{
		public override string ToString()
		{
			return base.ToString();
		}
		public virtual void effect() { }
	}
}