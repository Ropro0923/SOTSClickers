using ClickerClass.Items.Accessories;
using SOTS.Items.Permafrost;
using Terraria;
using Terraria.ModLoader;

namespace ClickersOfTheShadows.Common.Balance
{
    public class CotSRecipeChanges : ModSystem
    {
        public override void PostSetupRecipes()
        {
            for (int i = 0; i < Main.recipe.Length; i++)
            {
                Recipe recipe = Main.recipe[i];

                if (recipe.createItem.type == ModContent.ItemType<SMedal>() && !recipe.HasIngredient<SoulOfPlight>())
                {
                    recipe.AddIngredient<SoulOfPlight>(6);
                }
            }
        }
    }
}