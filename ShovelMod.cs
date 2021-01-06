using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Shovels
{
    public class Shovels : Mod
    {
        public Shovels()
        {

        }
        public override void Load()
        {
            if (!Main.dedServ)
            {

            }
        }
        public override void AddRecipeGroups()
        {
            RecipeGroup GoldOrPlat = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " " + Lang.GetItemNameValue(19), new[]
            {
                19,
                706
            });
            RecipeGroup.RegisterGroup("PrimordialSands:Gold or Platinum Bars", GoldOrPlat);
        }
        public override void Unload()
        {

        }
    }
}