using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace Alfredo.Content.Items.Consumables
{
    public class StarterBag : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 1;
            Item.value = Item.buyPrice(gold: 0);
            Item.consumable = true;

        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void ModifyItemLoot(ItemLoot itemLoot)
        {
            itemLoot.Add(ItemDropRule.Common(ItemID.HermesBoots, 1, 1, 1));
            itemLoot.Add(ItemDropRule.Common(ItemID.IronPickaxe, 1, 1, 1));
            itemLoot.Add(ItemDropRule.Common(ItemID.SlimeStaff, 1, 1, 1));
        }

        // this is here for testing, it'll be given to the player automatically
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();

        }
    }
}