using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Alfredo.Content.Players
{
    public class StarterBagPlayer : ModPlayer
    {
        private bool starterBagGiven = false;

        public override void OnEnterWorld()
        {
            if (!starterBagGiven)
            {
                Player.QuickSpawnItem(null, ModContent.ItemType<Items.Consumables.StarterBag>());
                starterBagGiven = true;
            }
        }

        public override void SaveData(TagCompound tag)
        {
            tag["starterBagGiven"] = starterBagGiven;
        }

        public override void LoadData(TagCompound tag)
        {
            starterBagGiven = tag.GetBool("starterBagGiven");
        }
    }
}
