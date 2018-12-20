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
		//Effects
		public List<Action> otherEffects;
		public List<genericEffect> Effects;

		//Events
		public virtual void destroy(Leader owner)
		{
			owner.shadows++;
		}
				
		public virtual void AlliedFollowerAttack() { }
		protected virtual void onStartTurn() { }
		public virtual void onEndTurn() { }

		public delegate void genericEffect(Card caller);

		public delegate void fanfareEffects(Card caller);
		public event fanfareEffects Fanfare; 

		public delegate void lastWordsEffects(Card caller);
		public event lastWordsEffects LastWords;

		public delegate void enhanceEffects(Card owner);
		public event enhanceEffects enhance;
	}
}