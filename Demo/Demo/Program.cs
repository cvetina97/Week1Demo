using System;
using Demo.Models;
using Demo.WeaponBehavior;
using Demo.LaundryBehavior;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Character[] characters = new Character[]
            {
                new King(new BowAndArrowBehavior(),new WashIntoTheRiver()),
                new Queen(new KnifeBehavior(),new WashWithWashingMachine()),
                new Knight(new SwordBehavior(),new WashByHand()),
                new SmurfStorm(new MutatedSeaBehavior(),new WashByHand()),
                new Smurfette(new ToothPasteBehavior(),new WashWithWashingMachine()),
                new Troll(new AxeBahavior(),new WashIntoTheRiver())
            };

            foreach (var character in characters)
            {
                switch (character.GetType().Name.ToString())
                {
                    case "Smurfette":
                        DoState(character);
                        DoSmurfetteNewState(character);
                        break;
                    case "SmurfStorm":
                         DoState(character);
                        DoSmurfStormNewState(character);
                        break;
                    default:
                        DoState(character);
                        break;
                }
                Console.WriteLine("-------------------------------------");
            }

            static void DoSmurfetteNewState(Character character)
            {
                Console.WriteLine("Now Smurfette decided to take a new weapon!");
                character.SetWeaponBehavior(new ToiletPaperBehavior());
                Console.Write($"{character.GetType().Name} : ");
                character.PerformUseWeapon();
            }

            static void DoSmurfStormNewState(Character character)
            {
                Console.WriteLine("Dynamically set behavior to an object. Looks like our SmurfStorm will use other weapon.");
                character.SetWeaponBehavior(new BowAndArrowBehavior());
                Console.Write($"{character.GetType().Name} : ");
                character.PerformUseWeapon("Peoooww!");
            }

            static void DoState(Character character)
            {
                character.Fight();
                character.PerformUseWeapon();
                character.PerformDamage();
                character.PerformLaundry();
            }
        }

    }
}



