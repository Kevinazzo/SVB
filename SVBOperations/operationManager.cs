using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model.Primitive;
using SVB.Core.Model;

namespace SVBOperations
{
	public class operationManager
	{
		#region restoreDefense
		public void restoreDef(int amount, Follower target)
		{
			if (target.def + amount > target.baseDef)
			{
				target.def = target.baseDef;
				target.isDamaged = false;
			}
			else
			{
				target.def += amount;
			}
		}

		public void restoreDef(int amount, Leader leader)
		{
			if (leader.hitpoints + amount > 20)
			{
				leader.hitpoints = 20;
			}
		}
		#endregion
		public void dealDamage(int amount, object target)
		{
			switch (target)
			{
				case Leader a:
					receiveDamage(amount, a);
					break;
				case Follower a:
					receiveDamage(amount, a);
					break;
			}
			if (target is Follower)
			{
				var a = (Follower)target;
				receiveDamage(amount, a);
			}
			else if (target is Leader)
			{
				var a = (Leader)target;
				receiveDamage(amount, a);
			}
		}

		public void receiveDamage(int amount, Leader target)
		{
				target.hitpoints -= amount;
		}

		public void receiveDamage(int amount, Follower target) { }

		public void attack(Follower target)
		{

		}
		public void attack(Leader target)
		{

		}

		public Card drawCard(leaderClass cardClass) { return new Follower(); }

		public void gainShadows(int amount, Leader owner)
		{
			owner.shadows += amount;
		}
	}
}