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
		public short attack { get; set; }
		public short defense { get; set; }
		public short attackCount { get; set; }
		public bool attackDisabled { get; set; }
		public bool hasAttacked { get; set; }
		public bool storm { get; set; }
		public bool rush { get; set; }
		public bool ambush { get; set; }
		public bool canAttack { get; set; }
		public bool canBeTargeted { get; set; }
		public bool canBeDestroyedByEffects { get; set; }
		public bool canBeDamaged { get; set; }

		public void Attack() { }

		//Effects
		public virtual void clashEffects() { }
		public virtual void evolveEffects() { }
	}
}