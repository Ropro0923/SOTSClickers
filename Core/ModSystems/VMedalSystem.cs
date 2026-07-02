using System;
using System.Collections.Generic;
using System.Reflection;
using ClickerClass.UI;
using Terraria.ModLoader;
using ClickersOfTheShadows.Content.UI;

namespace ClickersOfTheShadows.Core.ModSystems
{
    public class VMedalSystem : ModSystem
    {
        public override void OnModLoad()
        {
            Type? type = ClickersOfTheShadows.Clicker.GetType().Assembly?.GetType("ClickerClass.UI.ClickerInterfaceResources");

            if (type != null)
            {
                if (type.GetField("Resources", BindingFlags.NonPublic | BindingFlags.Static)?.GetValue(null) is List<InterfaceResource> resources)
                {
                    int index = resources.FindIndex(r => r.GetType().FullName == "ClickerClass.UI.SMedalGauge");
                    if (index >= 0)
                    {
                        resources.Insert(index + 1, new VMedalGauge());
                    }
                }
            }
        }
    }
}