using System;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public class Chick: AAnimal
    {
        public Chick(string name, TypeState state, Stats stats, bool isDead = false) : base(name, state, stats, isDead)
        {
        }

        public override void GetArt(TypeState state)
        {
            switch (state)
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
