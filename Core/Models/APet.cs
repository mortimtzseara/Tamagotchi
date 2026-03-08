using System;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public abstract class APet
    {
        public string Name { get; set; }
        public TypeState State { get; set; }
        public Stats Stats { get; set; }
        public DateTime BirthDate { get; init; }

        protected APet(string name, Stats stats = null, TypeState state = TypeState.Happy)
        {
            Name = name;
            Stats = stats ?? new Stats();
            State = state;
            BirthDate = DateTime.Now;
        }
        public abstract void GetArt();

        public virtual void RefreshState()
        {
            if (State == TypeState.Sick) return;
            if (Stats.Health <= UIConfig.NumericValues.HealthStateChange)
            {
                State = TypeState.Sick;
            }
            else if (Stats.Energy <= UIConfig.NumericValues.EnergyStateChange)
            {
                State = TypeState.Tired;
            }
            else if (Stats.Hunger <= UIConfig.NumericValues.HungerStateChange)
            {
                if (Stats.Energy <= UIConfig.NumericValues.HungerStateChange)
                    State = TypeState.Sad;
                else
                    State = TypeState.Angry;
            }
            else
            {
                State = TypeState.Happy;
            }
        }
    }
}
