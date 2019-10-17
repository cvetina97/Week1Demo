using System;
using Demo.Models;
using Demo.LaundryBehavior;
using Demo.DefenceBehavior;
using Demo.AttackBehavior;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Character[] characters = new Character[]
            {
                new King(new DefenceByShield(),new AttackWithSword(),new WashIntoTheRiver()),
                new Queen(new DefenceByArmour(),new AttackWithSword(),new WashWithWashingMachine()),
                new Knight(new DefenceByShield(),new AttackWithSword(),new WashByHand()),
                new SmurfStorm(new DefenceByShield(),new AttackWithSword(),new WashByHand()),
                new Smurfette(new DefenceByArmour(),new AttackWithSword(),new WashByHand()),
                new Troll(new DefenceByArmour(),new AttackWithAxe(),new WashIntoTheRiver())
            };

            foreach (var character in characters)
            {
                switch (character.GetType().Name.ToString())
                {
                    case "Smurfette":
                        DoState(character);
                        DoSmurfetteNewState(character);
                        break;
                    case "King":
                        DoState(character);
                        DoKingNewState(character);
                        break;
                    default:
                        DoState(character);
                        break;
                }
                Console.WriteLine("-------------------------------------");
            }

            static void DoSmurfetteNewState(Character character)
            {
                Console.WriteLine("Now Smurfette decided to use different defence!");
                character.SetDefenceBehavior(new DefenceByShield());
                Console.Write($"{character.GetType().Name} : ");
                character.PerformDefence();
            }

            static void DoKingNewState(Character character)
            {
                Console.WriteLine("Dynamically set behavior to an object. Looks like our King will attack with other weapon.");
                character.SetAttackBehavior(new AttackWithKnife());
                Console.Write($"{character.GetType().Name} : ");
                character.PerformAttack("Hayah!");
            }

            static void DoState(Character character)
            {
                Console.WriteLine("Fighting ...");
                character.Fight();
                Console.WriteLine("Attacking ...");
                character.PerformAttack();
                Console.WriteLine("Defence  ...");
                character.PerformDefence();
                Console.WriteLine("Washing ...");
                character.PerformWash();
            }
        }

    }
}



