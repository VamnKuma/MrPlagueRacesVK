using System;
using Terraria;
using Terraria.ModLoader;

namespace MrPlagueRacesVK.Buffs {
	public class Celerity : ModBuff { 
		public override void SetDefaults() {
			DisplayName.SetDefault("Celerity");
			Description.SetDefault("Increased jump and movement speed.");
		}
		
		public override void Update(Player player, ref int buffIndex) {
			player.moveSpeed += 0.2f;
			player.jumpSpeedBoost += 0.2f;
		}
	}
}