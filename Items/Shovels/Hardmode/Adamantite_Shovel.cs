using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels.Items.Shovels.Hardmode
{
    public class Adamantite_Shovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adamantite Shovel");
            Tooltip.SetDefault("");
        }
        public override void SetDefaults()
        {
            item.damage = 14;
            ShovelPower(175);
            item.width = 32;
            item.height = 32;
            item.useAnimation = 22;
            item.useTime = 22;
            item.knockBack = 2.25f;
            item.autoReuse = true;
            item.melee = true;
            item.value = Item.buyPrice(gold: 5, silver: 30);
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.LightRed;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 14);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}