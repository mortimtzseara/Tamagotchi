using System;

namespace tamagochi_repo.Core.Models
{
    public abstract class AItem
    {
        protected string Name { get; set; }

        protected AItem(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}
