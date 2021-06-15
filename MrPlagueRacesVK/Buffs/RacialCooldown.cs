using System;
using Terraria;
using Terraria.ModLoader;

namespace MrPlagueRacesVK.Buffs {
	public class RacialCooldown : ModBuff {
		public override void SetDefaults() {
			DisplayName.SetDefault("Racial Cooldown");
			Description.SetDefault("Your racial ability is currently disabled.");
			Main.debuff[Type] = true;
			canBeCleared = false;
		}
	}
}