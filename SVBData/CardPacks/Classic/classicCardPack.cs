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
		public Dictionary<string, Action<Leader,Card>> aa = new Dictionary<string, Action<Leader,Card>>
		{
			{"fatherPunishmentEvolve", delegate(Leader source, Card caster) {  }}
		};
	}
}