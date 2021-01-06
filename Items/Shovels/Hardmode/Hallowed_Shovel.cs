using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels.Items.Shovels.Hardmode
{
    public class Hallowed_Shovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shammer (Hallowed Shovel)");
            Tooltip.SetDefault("Breaks tiles and walls" +
                "\nYeah, I know. The name really sucks. Also, this shovel can smart cursor on walls.");
        }
        public override void SetDefaults()
        {
            item.damage = 16;
            ShovelPower(200);
            item.width = 32;
            item.height = 32;
            item.useAnimation = 20;
            item.useTime = 20;
            item.hammer = 150;
            item.knockBack = 2.25f;
            item.autoReuse = true;
            item.melee = true;
            item.value = Item.buyPrice(gold: 6);
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.LightRed;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 12);
            recipe.AddIngredient(ItemID.SoulofFright, 4);
            recipe.AddIngredient(ItemID.SoulofSight, 4);
            recipe.AddIngredient(ItemID.SoulofMight, 4);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}