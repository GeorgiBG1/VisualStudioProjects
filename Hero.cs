using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovProekt
{
    public class Hero
    {
        private double attackCoef = 15;
        private double defenceCoef = 20;
        private double level;
        //name
        //fraction
        public int Level { get; set; } = 0;
        public double Health { get; set; } = 100;
        public double Stamina { get; set; } = 100;
        public double Mana { get; set; } = 100;
        List<string> ItemSet = new List<string> { "bronq1", "bronq2", "bronq3", "bronq4", "magic-staff", "sword", "magic-book", "bow", "blade" };
        public double allDamage3;

        public double pokazatel(double allDamage)
        {
            
            
            List<string> SetSave = new List<string>(5);
            string input = Console.ReadLine();
            SetSave.Add(input);

            input = Console.ReadLine();
            SetSave.Add(input);
            input = Console.ReadLine();
            SetSave.Add(input);
            input = Console.ReadLine();
            SetSave.Add(input);
            input = Console.ReadLine();
            SetSave.Add(input);
            

            double magicStaffDamage = 120;
            double swordDamage = 80;
            double magicBookDamage = 150;
            double bowDamage = 73.5;
            double bladeDamage = 81.3;

            if (ItemSet[4] == SetSave[4])
            {
                allDamage = magicStaffDamage;
            }
            else if (ItemSet[5] == SetSave[4])
            {
                allDamage = swordDamage;
            }
            else if (ItemSet[6] == SetSave[4])
            {
                allDamage = magicBookDamage;
            }
            else if (ItemSet[7] == SetSave[4])
            {
                allDamage = bowDamage;
            }
            else if (ItemSet[8] == SetSave[4])
            {
                allDamage = bladeDamage;
            }
            allDamage3 = allDamage;
            return allDamage;
        }
        public double LevelUp()
        {
            Level += 1;
            Health = 100;
            Stamina = 100;
            Mana = 100;
            return Level;
            
        }
        public double GetAttack(double allDamage3)
        {
            
            allDamage3 = Level * attackCoef + this.allDamage3;
            this.allDamage3 = allDamage3;
            return allDamage3;
        }
        public double GetDeffence()
        {
            int a = 1;
            return a;
        }
        
        
    }
}
