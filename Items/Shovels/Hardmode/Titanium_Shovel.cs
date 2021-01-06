using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels.Items.Shovels.Hardmode
{
    public class Titanium_Shovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titanium Shovel");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 16;
            ShovelPower(180);
            item.width = 32;
            item.height = 32;
            item.useAnimation = 22;
            item.useTime = 22;
            item.knockBack = 2.25f;
            item.autoReuse = true;
            item.melee = true;
            item.value = Item.buyPrice(gold: 5, silver: 50);
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.LightRed;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 14);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}