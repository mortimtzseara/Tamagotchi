using System;
using tamagochi_repo.Core.Models;
using tamagochi_repo.Core.Enums;
using tamagochi_repo.Core.Interfaces;

namespace tamagochi_repo.UI
{
    public class Program
    {
        public static void Main()
        {
            int petOp, menuOp, foodOp, inventoryOp;

            //START GAME
            Console.WriteLine(UIConfig.Messages.MsgGreet);
            Player player = new Player(Tools.Utils.ReadString(UIConfig.Messages.MsgName, UIConfig.ErrorMessages.ErrorName, 3));

            do {
                petOp = Tools.Utils.ReadInt(UIConfig.Messages.MsgPetType, UIConfig.ErrorMessages.ErrorOption);
                switch (petOp)
                {
                    case 1:
                        player.Pet = new Cat(Tools.Utils.ReadString(UIConfig.Messages.MsgPetName, UIConfig.ErrorMessages.ErrorName, 3));
                        break;
                    case 2:
                        player.Pet = new Chick(Tools.Utils.ReadString(UIConfig.Messages.MsgPetName, UIConfig.ErrorMessages.ErrorName, 3));
                        break;
                    case 3:
                        player.Pet = new Dog(Tools.Utils.ReadString(UIConfig.Messages.MsgPetName, UIConfig.ErrorMessages.ErrorName, 3));
                        break;
                    default:
                        Console.WriteLine(UIConfig.ErrorMessages.ErrorOption);
                        Console.WriteLine(UIConfig.Messages.MsgPetType);   
                        break;
                }
            } while (petOp > 3 || petOp < 1);

            //ADD ITEMS TO INVENTORY
            player.Inventory.AddItem(new Medicine("Botiquín"));
            player.Inventory.AddItem(new Medicine("Jarabe"));

            //GAME LOOP
            do
            {
                Draw(player);

                menuOp = Tools.Utils.ReadInt(UIConfig.Messages.MsgMenuOp, UIConfig.ErrorMessages.ErrorOption);

                switch (menuOp)
                {
                    case 1: //EAT
                        if (player.Pet is IEat eaterPet)
                        {
                            do
                            {
                                foodOp = Tools.Utils.ReadInt(UIConfig.Messages.MsgTypeFood, UIConfig.ErrorMessages.ErrorOption);
                                switch (foodOp)
                                {
                                    case 1: //MEAL
                                        eaterPet.Eat(new Food(TypeFood.Meal));
                                        break;

                                    case 2: //SNACK
                                        eaterPet.Eat(new Food(TypeFood.Snack));
                                        break;

                                    case 3: //CANCEL
                                        break;

                                    default: //OTHER
                                        Console.WriteLine(UIConfig.ErrorMessages.ErrorOption);
                                        break;

                                }
                            } while (foodOp > 3);
                        }
                        Console.WriteLine(UIConfig.Messages.MsgPressKey);
                        Console.ReadKey();

                        break;

                    case 2: //SLEEP

                        if (player.Pet is ISleep sleeperPet) sleeperPet.Sleep();

                        Console.WriteLine(UIConfig.Messages.MsgPressKey);
                        Console.ReadKey();
                        break;

                    case 3: //PLAY
                        if (player.Pet is IPlay playerPet) playerPet.Play();

                        Console.WriteLine(UIConfig.Messages.MsgPressKey);
                        Console.ReadKey();
                        break;

                    case 4: //INVENTORY
                        do
                        {
                            player.Inventory.ShowInventory();
                            Console.WriteLine(UIConfig.Messages.ExitInventory);
                            inventoryOp = Tools.Utils.ReadInt(UIConfig.Messages.MsgMenuItem, UIConfig.ErrorMessages.ErrorOption);

                            if (inventoryOp != 0)
                            {
                                if (player.Inventory.Items[inventoryOp - 1] != null)
                                {
                                    player.UseItem(inventoryOp - 1);
                                }
                                else Console.WriteLine(UIConfig.Messages.MsgEmptySlotUse);
                            }

                        } while (inventoryOp != 0);
                        break;

                    case 5: //EXIT
                        Console.WriteLine(UIConfig.Messages.MsgExit, player.Name);
                        break;

                    default:
                        Console.WriteLine(UIConfig.ErrorMessages.ErrorOption);
                        Console.WriteLine(UIConfig.Messages.MsgMenuOp);
                        break;
                }
            } while (menuOp != 5);

        }
        public static void Draw(Player player)
        {
            Console.Clear();

            UIConfig.ShowHeader(
                player.Pet.GetType().Name,
                player.Pet.BirthDate,
                player.Pet.Name,
                player.Pet.State);
            player.Pet.GetArt();
            Console.WriteLine(UIConfig.DrawBar(player.Pet.Stats.Energy));
            Console.WriteLine(UIConfig.DrawBar(player.Pet.Stats.Hunger));
            Console.WriteLine(UIConfig.DrawBar(player.Pet.Stats.Health));
            UIConfig.ShowMenu();
        }
    }
}