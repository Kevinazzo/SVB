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

		public bool hasAttacked { get; set; }
		public bool canAttack { get; set; }

		public bool canBeAttacked { get; set; }
		public bool canBeDestroyedByEffects { get; set; }
		public bool canBeDamaged { get; set; }
		public bool isEvolved { get; set; }
		public bool isDamaged { get; set; }

		public void attack()
		{
		}
	}
}