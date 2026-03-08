using System;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public class Chick: AAnimal
    {
        public Chick(string name, Stats stats = null, TypeState state = TypeState.Happy) : base(name, stats, state)
        {
        }

        public override void GetArt()
        {
            switch (State)
            {
                case TypeState.Happy:
                    Console.WriteLine(UIConfig.ChickSprites.Happy);
                    break;
                case TypeState.Sad:
                    Console.WriteLine(UIConfig.ChickSprites.Sad);
                    break;
                case TypeState.Angry:
                    Console.WriteLine(UIConfig.ChickSprites.Angry);
                    break;
                case TypeState.Tired:
                    Console.WriteLine(UIConfig.ChickSprites.Tired);
                    break;
                case TypeState.Sick:
                    Console.WriteLine(UIConfig.ChickSprites.Sick);
                    break;
                default:
                    Console.WriteLine(UIConfig.ChickSprites.Happy);
                    break;
            }
        }
    }
}
