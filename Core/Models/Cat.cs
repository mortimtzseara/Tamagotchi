using System;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public class Cat : AAnimal
    {
        public Cat(string name, TypeState state, Stats stats, bool isDead = false) : base(name, state, stats, isDead)
        {
        }
        public override void GetArt(TypeState state)
        {
            switch (state)
            {
                case TypeState.Happy:
                    Console.WriteLine(UIConfig.CatSprites.Happy);
                    break;
                case TypeState.Sad:
                    Console.WriteLine(UIConfig.CatSprites.Sad);
                    break;
                case TypeState.Angry:
                    Console.WriteLine(UIConfig.CatSprites.Angry);
                    break;
                case TypeState.Tired:
                    Console.WriteLine(UIConfig.CatSprites.Tired);
                    break;
                case TypeState.Sick:
                    Console.WriteLine(UIConfig.CatSprites.Sick);
                    break;
                default:
                    Console.WriteLine(UIConfig.CatSprites.Happy);
                    break;
            }
        }
    }
}
