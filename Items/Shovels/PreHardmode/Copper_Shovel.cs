﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels.Items.Shovels.PreHardmode
{
    public class Copper_Shovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Copper Shovel");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 4;
            ShovelPower(30);
            item.width = 32;
            item.height = 32;
            item.useAnimation = 23;
            item.useTime = 23;
            item.knockBack = 1.5f;
            item.tileBoost -= 1;
            DigTile(Main.player[item.owner], 5);
            item.autoReuse = true;
            item.melee = true;
            item.value = Item.buyPrice(copper: 80);
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.White;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBar, 12);
            recipe.AddIngredient(ItemID.Wood, 4);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}