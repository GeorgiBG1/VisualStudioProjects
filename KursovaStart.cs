using System;
using KursovProekt;
namespace KursovProekt
{
    class KursovaStart
    {
        static void Main(string[] args)
        {
            Hero Marin = new Hero("Xiao", Fraction.Knight);
            Hero Emir = new Hero("Ganyu", Fraction.Ranged);
            Marin.LevelUp();
            Marin.LevelUp();
            Marin.LevelUp();
            Marin.LevelUp();
            Emir.LevelUp();
            Emir.LevelUp();
            
            Emir.Fraction = Fraction.Rogue;
            Item sword1 = new Item("sword", 5, 5);
            Item sword = new Item("bow", 15, 15);
            Item sword2 = new Item("sword", 234, 5);
            Item sword3 = new Item("sword", 2352, 5);


            Console.WriteLine("Attack: " + sword.Attack + "\nDefence: " + sword.Defence);
            Console.WriteLine();
            Console.WriteLine($"\tPlayer1\nLevel: {Marin.Level},\nName: {Marin.Name},\nHealth: {Marin.Health},\nMana: {Marin.Mana},\nStamina: {Marin.Stamina},\nFraction: {Marin.Fraction},\n {Marin.GetAttack()}");
            Console.WriteLine();
            Console.WriteLine($"\tPlayer2\nLevel: {Emir.Level},\nName: {Emir.Name},\nHealth: {Emir.Health},\nMana: {Emir.Mana},\nStamina: {Emir.Stamina},\nFraction: {Emir.Fraction},\n {Emir.GetAttack()}");

        }
    }
}
