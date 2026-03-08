using System;
using System.Xml.Linq;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.UI;

namespace tamagochi_repo.Core.Models
{
    public class Food : AItem
    {
        public TypeFood TypeFood { get; set; }
        public int NutritionalScore { get; set; }
        public Food(TypeFood typeFood, string name = "Food") : base(name)
        {
            TypeFood = typeFood;

            if (TypeFood.Equals(TypeFood.Meal)) NutritionalScore = UIConfig.NumericValues.MealIncrease;
            else NutritionalScore = UIConfig.NumericValues.SnackIncrease;
        }
    }
}
