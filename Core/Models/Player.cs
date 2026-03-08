using System;
using tamagochi_repo.Core.Models;

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
        public void AddItem(AItem item)
        {
            Console.WriteLine($"{item.ToString()} removed from inventory");
        }
        public void DeleteItem(int index)
        {

        }
        public void UseItem(AItem item)
        {
            Console.WriteLine($"You used {item.ToString()}");
        }
        
    }
}
