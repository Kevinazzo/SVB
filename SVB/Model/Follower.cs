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
		public short baseAtk { get; set; }
		public short baseDef { get; set; }
		public short atk { get; set; }
		public short def { get; set; }
		public short attackCount { get; set; }
		

		public bool attackDisabled { get; set; }
		public bool hasAttacked { get; set; }

		//Attack flags
		public bool canAttack { get; set; }
		public bool rush { get; set; }
		public bool storm { get; set; }
		public bool ambush { get; set; }
		public bool drain { get; set; }
		public bool bane { get; set; }
		public bool ward { get; set; }
		
		public bool canBeAttacked { get; set; }
		public bool canBeDestroyedByEffects { get; set; }
		public bool canBeDamaged { get; set; }
		public bool isEvolved { get; set; }
		public bool isDamaged { get; set; }

		//protected virtual void attack(Card attacker, Card target)
		//{
			
		//}
		public void evolve(Card caller) { }

		public delegate void evolveActions(Card caller); // Delegates are containers for the methods that will be invoked
		public event evolveActions Evolve; //

		public delegate void clashActions(Card owner);


		public delegate void attackActions(Card attacker, Card target);

		#region events
		public event Action isAttacking;
		public event clashActions Clashed;
		public event Action Attacked;
		public event Action Evolved;

		#endregion
		//Effects
		public virtual void clashEffects() { }
		public virtual void evolveEffects() { }
	}
}