using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;
using SVB.Core.Model.Serialized;
using SVB.Core.Model.Primitive;

namespace SVB.Core.Model
{
	public class Deck
	{
		public string name { get; set; }
		public Stack<Card> cards { get; set; }
		public gameClass leaderClass { get; set; }

		public Card drawCard(CardParameters cardParameters, int qty, bool any = false)
		{
			
		}
	}
}