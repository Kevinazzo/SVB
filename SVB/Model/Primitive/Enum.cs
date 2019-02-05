using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVB.Core.Model.Primitive
{
	public enum leaderClass
	{
		All,
		Neutral,
		Shadowcraft,
		Forestcraft,
		Runecraft,
		Portalcraft,
		Swordcraft,
		Heavencraft,
		Dragoncraft,
		Bloodcraft
	}

	public enum trait
	{
		NoTrait,
		Mysteria,
		Officer,
		Commander,
		EarthSigil,
		Loot,
		Artifact
	}

	public enum ability
	{
		Ward,
		Drain,
		Bane,
		Rush,
		Storm,
		Fanfare,
		LastWords,
		Clash,
		Invocation,
		Spellboost,
		Necromancy,
		EarthRite,
		Evolve,
		Enhance,
		BurialRite,
		Ambush,
		Vengeance,
		Overflow,
		Resonance,
		Accelerate,
		Countdown,
		Reanimate,
		None
	}

	public enum cardType
	{
		Any,
		Amulet,
		Follower,
		Spell
	}
}