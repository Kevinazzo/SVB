using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model.Primitive;

namespace SVB.Core.Model
{
	public abstract class Leader
	{
		public short hitpoints = 20;
		public List<Card> Hand = new List<Card>(9);
		public List<Card> Deck = new List<Card>();
		public List<PlaceableCard> Area = new List<PlaceableCard>();

		public Trait trait;
		public short evolutionPoints;
		public int shadows;



		public void playCard() { }
		public void startTurn() { }
		public void endTurn() { }
	}
}
