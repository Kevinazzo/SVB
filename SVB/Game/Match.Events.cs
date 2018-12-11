using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model.Primitive;
using SVB.Core.Model;

namespace SVB.Core.Game
{
	public partial class Match
	{
		public delegate void CardDestroyedActions();
		public delegate void FollowerAttackedActions();
		public delegate void cardPlayedActions(Card card);
		public delegate void damagedLeaderActions();
		public delegate void restoredLeaderDefenseActions();

		public event cardPlayedActions cardPlayed;
		public event CardDestroyedActions cardDestroyed;
		public event FollowerAttackedActions followerAttacked;
	}
}
