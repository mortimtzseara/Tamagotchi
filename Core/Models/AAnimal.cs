using System;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.Core.Interfaces;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public abstract class AAnimal : APet, IEat, IPlay, ISleep
    {
        private static Random random = new Random();

        protected AAnimal(string name, Stats stats = null, TypeState state = TypeState.Happy) : base(name, stats, state)
        {
        }

        public void Eat(Food food)
        {
            switch (State)
            {
                case TypeState.Sick:
                    break;
                case TypeState.Angry:
                    if (random.NextDouble() < UIConfig.NumericValues.random) Console.WriteLine(UIConfig.Messages.MsgAngry, Name);
                    else
                    {
                        Console.WriteLine(UIConfig.Messages.MsgEat, Name, food.TypeFood.ToString(), food.NutritionalScore);
                        Stats.Hunger = Math.Clamp(Stats.Hunger + food.NutritionalScore, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxHunger);
                        if (food.TypeFood == TypeFood.Snack)
                            State = TypeState.Happy;
                        else
                            RefreshState();
                    }
                        break;
                default:
                    Console.WriteLine(UIConfig.Messages.MsgEat, Name, food.TypeFood.ToString(), food.NutritionalScore);
                    Stats.Hunger = Math.Clamp(Stats.Hunger + food.NutritionalScore, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxHunger);
                    if (food.TypeFood == TypeFood.Snack)
                        State = TypeState.Happy;
                    else
                        RefreshState();
                    break;
            }
            
        }

        public void Play()
        {
            switch (State) {
                case TypeState.Tired:
                    Console.WriteLine(UIConfig.Messages.MsgPlayTired, Name);
                    break;
                case TypeState.Sick:
                    Console.WriteLine(UIConfig.Messages.MsgPlaySick, Name);
                    break;
                case TypeState.Sad:
                    if (random.NextDouble() < UIConfig.NumericValues.random) Console.WriteLine(UIConfig.Messages.MsgPlaySad, Name);
                    else { 
                        Console.WriteLine(UIConfig.Messages.MsgPlaySuccess, Name);
                        Stats.Energy = Math.Clamp(Stats.Energy - UIConfig.NumericValues.EnergyPlayDecrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxEnergy);
                        Stats.Hunger = Math.Clamp(Stats.Hunger - UIConfig.NumericValues.HungerPlayDecrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxHunger);
                        State = TypeState.Happy;
                    }
                        break;
                case TypeState.Angry:
                    if (random.NextDouble() < UIConfig.NumericValues.random) Console.WriteLine(UIConfig.Messages.MsgAngry, Name);
                    else
                    {
                        Console.WriteLine(UIConfig.Messages.MsgPlaySuccess, Name);
                        Stats.Energy = Math.Clamp(Stats.Energy - UIConfig.NumericValues.EnergyPlayDecrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxEnergy);
                        Stats.Hunger = Math.Clamp(Stats.Hunger - UIConfig.NumericValues.HungerPlayDecrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxHunger);
                        State = TypeState.Happy;
                    }
                    break;
                default:
                    Console.WriteLine(UIConfig.Messages.MsgPlaySuccess, Name);
                    Stats.Energy = Math.Clamp(Stats.Energy - UIConfig.NumericValues.EnergyPlayDecrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxEnergy);
                    Stats.Hunger = Math.Clamp(Stats.Hunger - UIConfig.NumericValues.HungerPlayDecrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxHunger);
                    State = TypeState.Happy;
                    break;
            }
        }
        

        public void Sleep()
        {
            switch (State)
            {
                case TypeState.Sick:
                    Console.WriteLine(UIConfig.Messages.MsgSleepSick, Name);
                    break;

                case TypeState.Angry:
                    if (random.NextDouble() < UIConfig.NumericValues.random)
                    {
                        Console.WriteLine(UIConfig.Messages.MsgAngry, Name);
                    }
                    else
                    {
                        Console.WriteLine(UIConfig.Messages.MsgSleepSuccess, Name, UIConfig.NumericValues.EnergySleepIncrease);
                        Stats.Hunger = Math.Clamp(Stats.Hunger - UIConfig.NumericValues.HungerSleepDecrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxHunger);
                        Stats.Energy = Math.Clamp(Stats.Energy + UIConfig.NumericValues.EnergySleepIncrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxEnergy);
                        RefreshState();
                    }
                    break;

                default:
                    Console.WriteLine(UIConfig.Messages.MsgSleepSuccess, Name, UIConfig.NumericValues.EnergySleepIncrease);
                    Stats.Hunger = Math.Clamp(Stats.Hunger - UIConfig.NumericValues.HungerSleepDecrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxHunger);
                    Stats.Energy = Math.Clamp(Stats.Energy + UIConfig.NumericValues.EnergySleepIncrease, UIConfig.NumericValues.MinValue, UIConfig.NumericValues.MaxEnergy);
                    RefreshState();
                    break;
            }
        }
    }
}
