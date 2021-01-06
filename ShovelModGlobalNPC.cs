using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Shovels.Items.Shovels.PreHardmode;
using Shovels.Items.Accessories;

namespace Shovels.NPCs
{
    public class ShovelsGlobalNPC : GlobalNPC {
        public override bool InstancePerEntity {
            get {
                return true;
            }
        }
      
        public override void NPCLoot(NPC npc) {
            if (npc.type == NPCID.Skeleton) {
                if (Main.rand.Next(60) == 0) {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemType<Bone_Shovel>());
                }
            }
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot) {
            if (type == NPCID.TravellingMerchant) {
                shop.item[nextSlot].SetDefaults(ItemType<Farmers_Gloves>());
                nextSlot++;
            }
        }
    }
}