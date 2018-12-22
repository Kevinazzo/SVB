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
		public delegate void leaderEffects();
		public int hitpoints { get; set; }
		public trait leaderClass { get; set; }
		public List<Card> Hand = new List<Card>(9);
		public List<Card> Deck = new List<Card>();
		public List<PlaceableCard> Area = new List<PlaceableCard>();
		public List<Follower> destroyedFollowers = new List<Follower>();
		public List<Card> playedCards = new List<Card>();

		public int evolutionPoints;
		public int shadows;



		public void playCard() { }
		public void startTurn() { }
		public void endTurn() { }
	}
}
