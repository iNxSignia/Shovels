using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels.Items.Shovels.PreHardmode
{
    public class Blubberfish_Shovel : ShovelItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blubberfish");
            Tooltip.SetDefault("Able to mine Hellstone");
        }
        public override void SetDefaults()
        {
            item.damage = 12;
            ShovelPower(100);
            item.width = 32;
            item.height = 32;
            item.useAnimation = 26;
            item.useTime = 26;
            item.knockBack = 3.65f;
            item.autoReuse = true;
            item.melee = true;
            item.value = Item.buyPrice(gold: 2);
            item.UseSound = SoundID.Item1;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.rare = ItemRarityID.Orange;
        }
    }
}