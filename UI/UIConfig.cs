using System;
using tamagochi_repo.Core.Enums;

namespace tamagochi_repo.UI
{
    public static class UIConfig
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1 - Eat");
            Console.WriteLine("2 - Sleep");
            Console.WriteLine("3 - Play");
            Console.WriteLine("4 - Inventory");
            Console.WriteLine("5 - Exit");
        }
        public static void ShowHeader(string type, DateTime dob, string name, TypeState state)
        {
            string dateStr = dob.ToShortDateString();

            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║          TAMAGOTCHI            ║");
            Console.WriteLine($"║    DateOfBirth: {dateStr,-14} ║");
            Console.WriteLine($"║    Type: {type,-21} ║");
            Console.WriteLine("╚════════════════════════════════╝");
            Console.WriteLine($"Name: {name}");
            Console.Write($"Emotional State: {state}");
            switch (state)
            {
                case TypeState.Happy: Console.WriteLine("😄");
                    break;
                case TypeState.Angry: Console.WriteLine("😠");
                    break;
                case TypeState.Sad: Console.WriteLine("😭");
                    break;
                case TypeState.Sick: Console.WriteLine("🤢");
                    break;
                case TypeState.Tired: Console.WriteLine("😴");
                    break;
                default: Console.WriteLine("?");
                    break;
            }
        }
        public static string DrawBar(int value)
        {
            int totalBlocks = 20;
            int filledBlocks = value * totalBlocks / 100;

            return "[" +
                   new string('#', filledBlocks) +
                   new string('-', totalBlocks - filledBlocks) +
                   $"] {value}%";
        }
        public static class Messages
        {
            //on start
            public const string MsgGreet = "Welcome to TAMAGOTCHI!";
            public const string MsgName = "What's your name?";
            public const string MsgPetType = "What kind of pet do you want? 1- Cat 2- Chick 3- Dog";
            public const string MsgPetName = "Give it a name: ";
            public const string MsgMenuOp = "Choose an option: ";

            //stats
            public const string Energy = "Energy: ";
            public const string Hunger = "Hunger: ";
            public const string Health = "Health: ";

            //action messages
            //eat
            public const string MsgTypeFood = "What type of food do you want to use? 1- Meal 2- Snack 3- Cancel";
            public const string MsgEat = "{0} ate a {1}. Hunger +{2}";
            public const string MsgEatSick = "{0} is too sick to eat... It needs medicine!";

            //play
            public const string MsgPlaySuccess = "{0} played for a while and now it's happy!";
            public const string MsgPlayTired = "{0} is too tired to play...";
            public const string MsgPlaySick = "{0} is too sick to play... It needs medicine!";
            public const string MsgPlaySad = "{0} is too sad to play...";

            //sleep
            public const string MsgSleepSuccess = "{0} took a nap. Energy +{1}";
            public const string MsgSleepSick = "{0} couldn't sleep because it's sick... It needs medicine!";

            //angry
            public const string MsgAngry = "{0} is angry and it's ignoring you!";

            //medicine
            public const string MsgCured = "{0} has been cured with the medicine!";

            //inventory
            public const string MsgMenuItem = "Choose an object to use: ";
            public const string ExitInventory = "Presso 0 to leave";
            public const string MsgEmptySlotUse = "That slot is empty, unable to use item.";
            public const string EmptySlot = "(Empty)";
            public const string ShowItem = "{0}- {1}";
            public const string MsgFullInventory = "Unable to add item, the inventory is full.";
            public const string MsgNotUsable = "The item is not usable.";
            public const string MsgDeletedItem = "The item has been removed successfully.";
            public const string MsgEmptyslot = "Nothing to delete here, the slot is already empty";
            public const string MsgAddedItem = "The item has been successfully added.";

            //generic
            public const string MsgPressKey = "Press any key to continue...";
            public const string MsgExit = "Goodbye {0}!";
        }
        public static class ErrorMessages
        {
            public const string ErrorName = "Please enter a valid name";
            public const string ErrorOption = "Please enter a valid option";
        }
        public static class NumericValues
        {
            //default values
            public const int MaxEnergy = 100;
            public const int MaxHunger = 100;
            public const int MaxCapacity = 10;
            public const int MinValue = 0;

            //increases & decreases
            public const int EnergySleepIncrease = 30;
            public const int MealIncrease = 30;
            public const int SnackIncrease = 15;
            public const int EnergyPlayDecrease = 20;
            public const int HungerPlayDecrease = 15;
            public const int HungerSleepDecrease = 10;

            //State caps
            public const int HealthStateChange = 20;
            public const int HungerStateChange = 50;
            public const int EnergyStateChange = 30;

            //random const
            public const double random = 0.5;

            //time tick loss
            public const int HungerTickLoss = 2;
            public const int EnergyTickLoss = 1;
        }
        public static class CatSprites
        {
            public const string Happy = @"
      /\_/\      
     ( ^‿^ )     
    /       \    
   |         |   
    \__/\___/    ";
            public const string Sad = @"
      /\_/\      
     ( ╥﹏╥ )     
    /       \    
   |         |   
    \__/\___/    ";
            public const string Angry = @"
      /\_/\      
     ( ಠ_ಠ )     
    /       \    
   |         |   
    \__/\___/    ";
            public const string Tired = @"
      /\_/\      
     ( -_- ) zZ  
    /       \    
   |         |   
    \__/\___/    ";
            public const string Sick = @"
      /\_/\      
     ( x_x )     
    /       \    
   |   +--+  |   
    \__/\___/    ";
        }
        public static class DogSprites
        {
            public const string Happy = @"
     /^ ^\
    / ^ ^ \
    V\ Y /V
     / - \
     |    \
     || (__V";
            public const string Sad = @"
     /^ ^\
    / ╥ ╥ \
    V\ Y /V
     / - \
     |    \
     || (__V";
            public const string Angry = @"
     /^ ^\
    / ಠ ಠ \
    V\ Y /V
     / - \
     |    \
     || (__V   ";
            public const string Tired = @"
     /^ ^\
    / - - \zZ
    V\ Y /V
     / - \
     |    \
     || (__V   ";
            public const string Sick = @"
     /^ ^\
    / x x \
    V\ Y /V
     / - \
     |    \
     || (__V   ";
        }
        public static class ChickSprites
        {
            public const string Happy = @"
         __//
        /^__^\
        \ \/ /
     '__/    \
      \-      )
       \_____/
    _____|_|____
         """" """"";
            public const string Sad = @"
         __//
        /╥__╥\
        \ \/ /
     '__/    \
      \-      )
       \_____/
    _____|_|____
         """" """"";
            public const string Angry = @"
         __//
        /ಠ__ಠ\
        \ \/ /
     '__/    \
      \-      )
       \_____/
    _____|_|____
         """" """"";
            public const string Tired = @"
         __//
        /-__-\zZ
        \ \/ /
     '__/    \
      \-      )
       \_____/
    _____|_|____
         """" """"";
            public const string Sick = @"
         __//
        /x__x\
        \ \/ /
     '__/    \
      \-      )
       \_____/
    _____|_|____
         """" """"";
        }
       
    }
}