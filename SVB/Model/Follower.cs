using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model.Primitive;

namespace SVB.Core.Model
{
	public abstract class Follower : PlaceableCard
	{
		//Implementar mejor una lista de "modificadores" 
		//List[Effect] effects = { Storm, EffectOnAttack1, EffectOnAttack2 }
		//en vez de hardcoded flags ↓
		//
		// opción 2 es implementar esto ↓ con una mascara de bits [Flags]Enum
		public short atk { get; set; }
		public short def { get; set; }
		public short attackCount { get; set; }

		public bool attackDisabled { get; set; }
		public bool hasAttacked { get; set; }

		public bool canAttack { get; set; }
		public bool rush { get; set; }
		public bool storm { get; set; }
		public bool ambush { get; set; }
		
		public bool canBeAttacked { get; set; }
		public bool canBeDestroyedByEffects { get; set; }
		public bool canBeDamaged { get; set; }
		public bool isEvolved { get; set; }

		protected virtual void attack(Card attacker, Card target)
		{

		}
		public void evolve(Card caller) { }

		public delegate void evolveActions(Card caller); // Delegates are containers for the methods that will be invoked
		public event evolveActions Evolve; //

		public delegate void clashActions(Card owner);
		public event clashActions Clash;

		public delegate void attackActions(Card attacker, Card target);
		public event attackActions onAttack;

		//Effects
		public virtual void clashEffects() { }
		public virtual void evolveEffects() { }
	}
}