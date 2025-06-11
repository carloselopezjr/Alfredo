using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alfredo.Content.Items.Accessories
{
    public class JpShoes : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.accessory = true;
            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Green;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {

            // increases movement speed and how fast it reaches running speed
            player.moveSpeed += 0.15f;
            //player.runAcceleration = 0.1f * player.moveSpeed;

            // Maximum running speed ( default is 3 (30 mph) )
            player.maxRunSpeed = 2.5f;

            // Determines when player is in running state ( when the run particles come ) 
            player.accRunSpeed = 5f;

        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}
