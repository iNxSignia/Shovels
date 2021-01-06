using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels.Items.Shovels.Hardmode
{
    public class Chlorophyte_Shovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Trowel");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 17;
            ShovelPower(210);
            item.width = 32;
            item.height = 32;
            item.useAnimation = 20;
            item.useTime = 20;
            item.knockBack = 2.65f;
            item.autoReuse = true;
            item.melee = true;
            item.value = Item.buyPrice(gold: 8);
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.Lime;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 16);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}