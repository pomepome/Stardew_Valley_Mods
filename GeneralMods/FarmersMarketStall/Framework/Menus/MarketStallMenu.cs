﻿using StardewValley;
using StardewValley.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersMarketStall.Framework.Menus
{
    class MarketStallMenu
    {
        public MarketStallMenu(MarketStall marketStall)
        {
            openMenu(marketStall);
        }

        public static IClickableMenu openMenu(MarketStall marketStall)
        {
            throw new NotImplementedException("This menu isn't implemented because the author is busy/lazy. Please encorage Omegasis to finish it!",null);
            //return new StardewValley.Menus.InventoryMenu((int)(Game1.viewport.Width*.25f),(int)(Game1.viewport.Height*.25f),true,marketStall.stock);
        }

    }
}
