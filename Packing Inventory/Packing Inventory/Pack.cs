using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packing_Inventory
{
    internal class Pack
    {
        public int MaxCount { get; }
        public float MaxWeight { get; }
        public float MaxVolume { get; }

        private InventoryItem[] _items;

        public int CurrentCount { get; private set; }
        public float CurrentWeight { get;  set; }
        public float CurrentVolume { get; private set; }


        public Pack(int maxCount, float maxWeight, float maxVolume)
        {
            MaxCount = maxCount;
            MaxVolume = maxVolume;
            MaxWeight = maxWeight;

            _items = new InventoryItem[maxCount];
        }

        public bool Add(InventoryItem item)
        {
            if (CurrentCount>= MaxCount) return false;
            if (CurrentWeight + item.Weight >=  MaxWeight) return false;
            if (CurrentVolume + item.Volume >= MaxVolume) return false;

            _items[CurrentCount] = item;
            CurrentCount++;
            CurrentWeight += item.Weight;
            CurrentVolume += item.Volume;
            return true;
        }
    }
}
