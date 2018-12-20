﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVB.Core.Model.Primitive
{
	public abstract class Card : SVBEntity
	{
		public string name { get; set; }
		public int ppCost { get; set; }
		public int rarity { get; set; }
		public Trait trait { get; set; }

		public virtual void discard() { }
		public virtual void banish() { }

		public delegate void NecromancyActions(Card caller);
		public delegate void OverflowActions(Card caller);
		public delegate void SpellboostActions(Card caller);
		public delegate void VengeanceActions(Card caller);
		public delegate void ResonanceActions(Card caller);
		public delegate void PlayedCardsActions(Card caller);

		public override string ToString()
		{
			return this.name;
		}
	}
}