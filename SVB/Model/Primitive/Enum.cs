using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVB.Core.Model.Primitive
{
	public enum trait
	{
		Neutral,
		Shadowcraft,
		Forestcraft,
		Runecraft,
		Portalcraft,
		Swordcraft,
		Heavencraft,
		Dragoncraft,
		Bloodcraft,
		Mysteria,
		Officer,
		Commander,
		EarthRite,
		Loot
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
	[Flags]
	public enum followerFlagSet
	{
		None						= 0b0,
		attackDisabled				= 0b0000_0000_0000_0001,
		hasAttacked					= 0b0000_0000_0000_0010,
		canAttack					= 0b0000_0000_0000_0100,
		rush						= 0b0000_0000_0000_1000,

		storm						= 0b0000_0000_0001_0000,
		ambush						= 0b0000_0000_0010_0000,
		drain						= 0b0000_0000_0100_0000,
		bane						= 0b0000_0000_1000_0000,

		ward						= 0b0000_0001_0000_0000,
		canBeAttacked				= 0b0000_0010_0000_0000,
		canBeDestroyedBySpAE		= 0b0000_0100_0000_0000,
		canBeDamaged				= 0b0000_1000_0000_0000,

		isEvolved					= 0b0001_0000_0000_0000,
		isDamaged					= 0b0010_0000_0000_0000
	}
}