using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model;
using SVB.Core.Game;
using SVB.Core.Model.Primitive;
using SVBOperations;

namespace SVBData.CardPacks.Classic
{
	public sealed class HarnessedFlame:Follower
	{
		protected override void attack(Card target)
		{
			base.attack(target);
		}
	}
}