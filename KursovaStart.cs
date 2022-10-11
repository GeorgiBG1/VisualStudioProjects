using System;
using KursovProekt;
namespace KursovProekt
{
    class KursovaStart
    {
        static void Main(string[] args)
        {
            //double health = 100;
            //string weapon = Console.ReadLine();
            double allDamage = 0;
            double allDamage2 = 0;
            Hero items = new Hero();
            //items.LevelUp();
            //items.LevelUp();
            //items.LevelUp();
            //items.LevelUp();
            
            double predmet1 = items.pokazatel(allDamage);
            items.Level = 57;
            
                  double obshto = items.GetAttack(allDamage2);
            obshto = items.LevelUp();
            obshto = items.LevelUp();
            obshto = items.LevelUp();

            Console.WriteLine($"Attack1: {predmet1}");
                  Console.WriteLine($"Attack2: {obshto}");
            //bronq1
            //bronq2
            //bronq3
            //bronq4
            //bow
        }
    }
}
