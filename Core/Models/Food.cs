using System;
using tamagochi_repo.Core.Enums;

namespace tamagochi_repo.Core.Models
{
    public class Food : AItem
    {
        public TypeFood TypeFood { get; set; }
        public int NutritionalScore { get; set; }
        public Food(string name, TypeFood typeFood) : base(name)
        {
            TypeFood = typeFood;

            if (TypeFood.Equals(TypeFood.Meal)) NutritionalScore = 50;
            else NutritionalScore = 25;
        }
    }
}
