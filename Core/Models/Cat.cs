using System;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public class Cat : AAnimal
    {
        public Cat(string name, Stats stats = null, TypeState state = TypeState.Happy) : base(name, stats, state)
        {
        }
        public override void GetArt()
        {
            switch (State)
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
