using System;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.Core.Interfaces;

namespace tamagochi_repo.Core.Models
{
    public abstract class AAnimal : APet, IEat, IPlay, ISleep
    {
        protected AAnimal(string name, TypeState state, Stats stats, bool isDead = false) : base(name, stats, state, isDead)
        {
        }

        public void Eat(Food food)
        {

        }

        public void Play()
        {
            
        }

        public void Sleep()
        {
            
        }
    }
}
