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
		public Card[] draw(int Q, cardType _cardtype = cardType.Any, bool _isCountdown = false,
			trait hasTrait = trait.NoTrait, leaderClass _class = leaderClass.All, ability hasAbility = ability.None,
			int? MaxPpCost = null)
		{
			var paramSearch = new List<Card>();
			if ((_cardtype == cardType.Amulet))
			{
				paramSearch = cards.Cast<Amulet>().Select(a => a.signature == _cardtype && a.isCountdown == _isCountdown);
			}
		}
	}
}