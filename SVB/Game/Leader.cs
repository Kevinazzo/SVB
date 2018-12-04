using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model.Primitive;

namespace SVB.Core.Game
{
	public class Leader
	{
		public short hitpoints = 20;
		public Trait trait;
		public Card[] cards = new Card[5];

		public void playCard() { }
		public void startTurn() { }
		public void endTurn() { }
	}
}
