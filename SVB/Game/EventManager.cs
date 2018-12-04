using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVB.Core.Model.Primitive;

namespace SVB.Core.Game
{
	public class EventManager
	{
		#region delegate

		public delegate void Fanfare(Card playedCard);
		public delegate void LastWords(Card destroyedCard);


		#endregion endregion

		#region event

		public event Fanfare onPlay;


		#endregion
	}
}
