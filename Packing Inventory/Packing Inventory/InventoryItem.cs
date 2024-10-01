﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    internal class InventoryItem
    {
        public float Weight { get; }
        public float Volume { get; }

        public InventoryItem (float weight, float volume)
        {
            Weight = weight;
            Volume = volume;
        }
    }
}
