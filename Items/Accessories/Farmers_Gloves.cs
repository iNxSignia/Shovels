using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Shovels.Items.Accessories
{
    public class Farmers_Gloves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Farmer's Gloves");
            Tooltip.SetDefault("Doubles digging power at the cost of half your digging speed" +
                "\nThis accessory does not effect pickaxes");
        }

        public override void SetDefaults()
        {
            item.height = 22;
            item.width = 22;
            item.rare = ItemRarityID.Green;
            item.accessory = true;
            item.value = Item.buyPrice(0, 30, 0, 0);
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<ShovelsPlayer>().farmersGloves = true;
            if (player.HeldItem.modItem is ShovelItem)
            {
                player.HeldItem.useTime /= 2;
            }
        }
    }
}