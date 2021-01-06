using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Shovels
{
    public class ShovelsPlayer : ModPlayer
    {

        public bool farmersGloves = false;
        public bool diggingPotion = false;

        public override void ResetEffects()
        {
            farmersGloves = false;
            diggingPotion = false;
        }
        public override void UpdateDead()
        {
            farmersGloves = false;
            diggingPotion = false;
        }
        public void ShovelPickTile(int x, int y)
        {
            int digTile = player.HeldItem.GetGlobalItem<GlobalItemClass>().digPower;
            for (int i = -1; i < 2; i++)
            {
                int posx = x / 16 + i;
                int posy = y / 16 + i;
                Tile t1 = Main.tile[posx, y / 16];
                Tile t2 = Main.tile[x / 16, posy];

                if (Main.tile[posx, y / 16].type != TileID.DemonAltar && Main.tile[x / 16, posy].type != TileID.DemonAltar
                    && Main.tile[posx, y / 16].type != TileID.Trees && Main.tile[x / 16, posy].type != TileID.Trees
                    && Main.tile[posx, y / 16].type != TileID.PalmTree && Main.tile[x / 16, posy].type != TileID.PalmTree
                    && Main.tile[posx, y / 16].type != TileID.MushroomTrees && Main.tile[x / 16, posy].type != TileID.MushroomTrees
                    && Main.tile[posx, y / 16].type != TileID.ShadowOrbs && Main.tile[x / 16, posy].type != TileID.ShadowOrbs
                    && Main.tile[posx, y / 16].type != TileID.Cactus && Main.tile[x / 16, posy].type != TileID.Cactus)
                {
                    {
                        if (farmersGloves)
                        {
                            player.PickTile(posx, y / 16, digTile * 2);
                            player.PickTile(x / 16, posy, digTile * 2);
                        }
                        player.PickTile(posx, y / 16, digTile);
                        player.PickTile(x / 16, posy, digTile);
                    }
                }
            }
        }
    }
}