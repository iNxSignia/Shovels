using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;
using Shovels.Items.Shovels.PreHardmode;

namespace Shovels
{
    public static class ShovelsHooks
    {
        public static bool IsShovel(this Item item)
        {
            return item.GetGlobalItem<GlobalItemClass>().Shovel;
        }
    }
    public class GlobalItemClass : GlobalItem
    {
        public override bool InstancePerEntity => true;
        public override bool CloneNewInstances => true;

        public bool Shovel;
        public int digPower = 0;
        public static int GetDigPower(int shovel)
        {
            Item i = GetModItem(shovel).item;
            return i.GetGlobalItem<GlobalItemClass>().digPower;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            base.ModifyTooltips(item, tooltips);
            if (item.IsShovel())
            {
                TooltipLine tooltipLine = new TooltipLine(mod, "PickPower", $"{digPower}% digging power");
                tooltips.Add(tooltipLine);
            }
        }
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (context == "crate" && arg == ItemID.WoodenCrate && Main.rand.NextBool(22))
            {
                player.QuickSpawnItem(ItemType<Blubberfish_Shovel>());
            }
            if (context == "crate" && arg == ItemID.IronCrate && Main.rand.NextBool(15))
            {
                player.QuickSpawnItem(ItemType<Blubberfish_Shovel>());
            }
            if (context == "crate" && arg == ItemID.GoldenCrate && Main.rand.NextBool(8))
            {
                player.QuickSpawnItem(ItemType<Blubberfish_Shovel>());
            }
        }
    }
    public abstract class ShovelItem : ModItem
    {
        public override bool CloneNewInstances => false;

        public void ShovelPower(int digPower)
        {
            item.GetGlobalItem<GlobalItemClass>().Shovel = true;
            item.GetGlobalItem<GlobalItemClass>().digPower = digPower;
            item.melee = false;
            item.ranged = false;
            item.magic = false;
            item.summon = false;
            Main.HoverItem.pick = digPower;
            return;
        }
        public override bool UseItem(Player player)
        {
            DigTile(player, 6); //default value
            return true;
        }            
        public void DigTile(Player player, int rangeinBlocks)
        {
            if (player.Distance(Main.MouseWorld) < 16 * rangeinBlocks)
            {
                player.GetModPlayer<ShovelsPlayer>().ShovelPickTile((int)Main.MouseWorld.X, (int)Main.MouseWorld.Y);
            }
        }

        public override int ChoosePrefix(UnifiedRandom rand)
        {
            return rand.Next(new int[] { PrefixID.Agile, 
                PrefixID.Quick, PrefixID.Light, 
                PrefixID.Slow, PrefixID.Sluggish, 
                PrefixID.Lazy, PrefixID.Large, 
                PrefixID.Broken, PrefixID.Heavy, 
                PrefixID.Awful, PrefixID.Nimble, 
                PrefixID.Shoddy, PrefixID.Small, 
                PrefixID.Shoddy, PrefixID.Tiny, 
                PrefixID.Weak, PrefixID.Unhappy,
                PrefixID.Hasty });
        }
    }
}