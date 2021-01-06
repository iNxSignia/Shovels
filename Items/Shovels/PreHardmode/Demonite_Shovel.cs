using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels.Items.Shovels.PreHardmode
{
    public class Demonite_Shovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skullduggery");
            Tooltip.SetDefault("Able to mine Hellstone");
        }
        public override void SetDefaults()
        {
            item.damage = 11;
            ShovelPower(65);
            item.width = 32;
            item.height = 32;
            item.useAnimation = 23;
            item.useTime = 23;
            item.knockBack = 1.65f;
            item.autoReuse = true;
            item.melee = true;
            item.value = Item.buyPrice(silver: 65);
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.Blue;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 16);
            recipe.AddIngredient(ItemID.ShadowScale, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}