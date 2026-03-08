using System;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public class Inventory
    {
        public AItem[] Items { get; set; }
        public int Capacity { get => Items.Length; }

        public Inventory (int capacity = UIConfig.NumericValues.MaxCapacity)
        {
            Items = new AItem[capacity];
        }
        public void ShowInventory()
        {
            for (int i = 0; i < Capacity; i++)
            {
                string content = Items[i] != null ? Items[i].ToString() : UIConfig.Messages.EmptySlot;
                Console.WriteLine(UIConfig.Messages.ShowItem, i + 1, content);
            }
        }
        public void AddItem(AItem item)
        {
            bool isAdded = false;

            for (int i = 0; i < Capacity && !isAdded; i++)
            {
                if (Items[i] == null)
                {
                    Items[i] = item;
                    isAdded = true;
                }
            }

            if (isAdded) Console.WriteLine(UIConfig.Messages.MsgAddedItem);
            else Console.WriteLine(UIConfig.Messages.MsgFullInventory);
        }

        public void RemoveItem(AItem item)
        {
            bool isRemoved = false;

            for (int i = 0; i < Capacity && !isRemoved; i++)
            {
                if (Items[i] == item)
                {
                    Items[i] = null;
                    isRemoved = true;
                }
            }
            if (isRemoved) Console.WriteLine(UIConfig.Messages.MsgDeletedItem);
            else Console.WriteLine(UIConfig.Messages.MsgEmptyslot);
        }
    }
}
