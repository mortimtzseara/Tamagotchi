using System;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public class Dog: AAnimal
    {
        public Dog(string name, Stats stats = null, TypeState state = TypeState.Happy) : base(name, stats, state)
        {
        }

        public override void GetArt()
        {
            switch (State)
            {
                case TypeState.Happy:
                    Console.WriteLine(UIConfig.DogSprites.Happy);
                    break;
                case TypeState.Sad:
                    Console.WriteLine(UIConfig.DogSprites.Sad);
                    break;
                case TypeState.Angry:
                    Console.WriteLine(UIConfig.DogSprites.Angry);
                    break;
                case TypeState.Tired:
                    Console.WriteLine(UIConfig.DogSprites.Tired);
                    break;
                case TypeState.Sick:
                    Console.WriteLine(UIConfig.DogSprites.Sick);
                    break;
                default:
                    Console.WriteLine(UIConfig.DogSprites.Happy);
                    break;
            }
        }
    }
}
