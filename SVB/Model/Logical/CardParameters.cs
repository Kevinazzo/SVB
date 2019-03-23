using System.Collections.Generic;
using SVB.Core.Model.Primitive;

namespace SVB.Core.Model.Serialized
{
	public class CardParameters
	{
		public CardParameters(cardType _type = cardType.Any, trait _trait = trait.NoTrait,
			int _pp = 12, bool _specificPP = false, int _baseAtk = 20, bool _specificAtk = false)
		{
			
		}
		public cardType cardType { get; set; }
		public trait trait { get; set; }
		public int pp { get; set; }
		public int baseAtk { get; set; }
		public int baseDef { get; set; }
		public bool specificBaseAtk { get; set; }
		public bool specificPPCost { get; set; }
	}
}