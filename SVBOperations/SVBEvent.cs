using System.Collections;
using System.Collections.Generic;
using SVB.Core.Model;

namespace SVBOperations
{
	public class SVBEvent
	{
		public delegate void execution(Leader owner, );
		public Queue<SVBEvent> subEvents;
	}
}