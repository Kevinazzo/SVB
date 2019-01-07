using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model.Primitive;

namespace SVB.Core.Model
{
	public class Follower : PlaceableCard
	{
		public int baseAtk { get; set; }
		public int baseDef { get; set; }
		public int evAtk { get; set; }
		public int evDef { get; set; }
		public int atk { get; set; }
		public int def { get; set; }
		public int attackCount { get; set; }

		public followerFlagSet flags { get; set; }
		
		public bool attackDisabled { get; set; }
		public bool hasAttacked { get; set; }

		public bool canAttack { get; set; }
		public bool rush { get; set; }
		public bool storm { get; set; }
		public bool ambush { get; set; }
		public bool drain { get; set; }
		public bool bane { get; set; }
		public bool ward { get; set; }
		public bool lastWords { get; set; }
		
		public bool canBeAttacked { get; set; }
		public bool canBeDestroyedByEffects { get; set; }
		public bool canBeDamaged { get; set; }
		public bool isEvolved { get; set; }
		public bool isDamaged { get; set; }

		protected virtual void attack()
		{

		}

		protected virtual void evolve()
		{

		}
	}
}