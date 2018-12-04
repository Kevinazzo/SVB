using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVB.Core.Model.Primitive
{
	public abstract class PlaceableCard : Card
	{
		//Effects
		public void fanfare() { }
		public void lastWords() { }
		public List<Action> otherEffects;

		//Events
		public void destroy() { }
		public void banish() { }
		public virtual void AlliedFollowerAttack() { }
		public virtual void onStartTurn() { }
		public virtual void onEndTurn() { }
	}
}