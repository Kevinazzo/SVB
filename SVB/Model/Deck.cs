using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using LiteDB;
using SVB.Core.Model.Primitive;

namespace SVB.Core.Model
{
	public class Deck
	{
		public string name { get; set; }
		public List<Card> cards { get; set; }
		public leaderClass leaderClass { get; set; }
		public List<Card> draw(int q, Card _cardtype = null, bool isCountdown = false,
			trait hasTrait = trait.NoTrait, leaderClass _class = leaderClass.All, ability hasAbility = ability.None,
			int? maxPpCost = null)
		{
			List<Card> toR = new List<Card>();
			if (_cardtype is Amulet r)
			{
//				var results = cards.Select(a => a.GetType() == r.GetType() && ((a)r))
//				var results = cards.Select(a=>where )
			}
		}
	}
}