using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model;
using SVB.Core.Model.Primitive;
using SVBOperations;

namespace SVBData.CardPacks.Classic
{
	public sealed class HarnessedFlame : Follower
	{
		public Dictionary<string, Action<Leader>> aa = new Dictionary<string, Action<Leader>>
		{
			{"fatherPunishmentEvolve", delegate(Leader source) { }}
		};
	}
}