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

		public static void dealDamage(int amount, Card receiver)
		{
			//receiver.def .atk;
		}

		public static void gainShadow(int amount, Leader owner)
		{
			owner.shadows += amount;
		}

		public static void sumPlayedCard(Leader forestcraftLeader)
		{

		}

		public static void peroformNecromancy(Leader shadowcraftLeader)
		{

		}

		public static bool activateVengeance(Leader bloodcraftLeader)
		{
			return true;
		}

		public static bool activateOverflow(Leader dragoncraftLeader)
		{
			return true;
		}

		public static void performSpellboost(Leader runecraftLeader)
		{

		}

		public static bool activateResonance(Leader portalcraftLeader) { return true; }
		//public static PlaceableCard selectTarget()
		//{
		//	return new Follower();
		//}
	}
}