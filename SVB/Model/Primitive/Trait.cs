using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVB.Core.Model.Primitive
{
	public enum Trait
	{
		Neutral,
		Shadowcraft,
		Forestcraft,
		Portalcraft,
		Swordcraft,
		Heavencraft,
		Dragoncraft,
		Bloodcraft
	}
	[Flags]
	public enum cardAttackFlags
	{
		None = 0,
		canAttack = 0b0001,
		rush = 0b0010,
		storm = 0b0100,
	}
	[Flags]
	public enum cardDefenseFlags
	{
		none											= 0b0,
		cantBeAttacked									= 0b0001,
		cantBeTargetedBySpells							= 0b0010,
		cantBeDamaged									= 0b0100,
		cantBeDestroyedByEffects						= 0b1000,
		ambush = cantBeAttacked | cantBeTargetedBySpells,
		invulnerable = cantBeDestroyedByEffects | cantBeDamaged
	}	
}