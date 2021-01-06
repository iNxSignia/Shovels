﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels.Items.Shovels.Hardmode
{
    public class Palladium_Shovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Palladium Shovel");
            Tooltip.SetDefault("Can mine Mythril and Orichalcum");
        }
        public override void SetDefaults()
        {
            item.damage = 13;
            ShovelPower(125);
            item.width = 32;
            item.height = 32;
            item.useAnimation = 23;
            item.useTime = 23;
            item.knockBack = 1.65f;
            item.autoReuse = true;
            item.melee = true;
            item.value = Item.buyPrice(gold: 2, silver: 65);
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.LightRed;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumBar, 14);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}