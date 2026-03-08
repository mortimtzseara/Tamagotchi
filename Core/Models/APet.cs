using System;
using tamagochi_repo.Core.Enums;

namespace tamagochi_repo.Core.Models
{
    public abstract class APet
    {
        protected string Name { get; set; }
        protected TypeState State { get; set; }
        protected Stats Stats { get; set; }
        protected bool IsDead { get; set; }

        protected APet(string name, Stats stats, TypeState state = TypeState.Happy, bool isDead = false)
        {
            Name = name;
            State = state;
            Stats = stats;
            IsDead = isDead;
        }
        public abstract void GetArt(TypeState state);
    }
}
