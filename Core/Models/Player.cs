using System;
using tamagochi_repo.Core.Interfaces;
using tamagochi_repo.Core.Models;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public class Player
    {
        public string Name { get; set; }
        public APet? Pet { get; set; }
        public Inventory Inventory { get; set; }

        public Player(string name, APet? pet = null)
        {
            Name = name;
            Pet = pet;
            Inventory = new Inventory();
        }
        public void UseItem(int index)
        {
            AItem item = Inventory.Items[index];

            if (item == null) Console.WriteLine(UIConfig.ErrorMessages.ErrorOption);

            if (item is IUse usableItem)
            {
                usableItem.UseItem(Pet);
                Inventory.Items[index] = null;
            }
            else
            {
                Console.WriteLine(UIConfig.Messages.MsgNotUsable);
            }
        }
    }
}
