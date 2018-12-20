using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model.Primitive;
using SVB.Core.Model;

namespace SVBOperations
{
	public static class operationManager
	{
		#region attack and Defense operations
		public static void restoreDefFollower(int amount, Follower target)
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

		public static void restoreDefLeader(int amount, Leader leader)
		{
			if (leader.hitpoints + amount > 20)
			{
				leader.hitpoints = 20;
			}
		}

		public static void dealDamage(int amount, Card dealer)
		{

		}

		public static void receiveDamage(int amount, PlaceableCard target)
		{

		}
		#endregion

	}
}