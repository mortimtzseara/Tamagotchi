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
            Console.WriteLine("4 - Exit");
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
            public const string MsgGreet = "Welcome to TAMAGOTCHI!";
            public const string MsgName = "What's your name?";
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
 || (__V
";
            public const string Sad = @"
 /^ ^\
/ ╥ ╥ \
V\ Y /V
 / - \
 |    \
 || (__V
";
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
     "" """;
            public const string Sad = @"
     __//
    /╥__╥\
    \ \/ /
 '__/    \
  \-      )
   \_____/
_____|_|____
     "" """;
            public const string Angry = @"
     __//
    /ಠ__ಠ\
    \ \/ /
 '__/    \
  \-      )
   \_____/
_____|_|____
     "" """;
            public const string Tired = @"
     __//
    /-__-\zZ
    \ \/ /
 '__/    \
  \-      )
   \_____/
_____|_|____
     "" """;
            public const string Sick = @"
     __//
    /x__x\
    \ \/ /
 '__/    \
  \-      )
   \_____/
_____|_|____
     "" """;
        }
    }
}
