using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsWithInterfaces
{
    public class Orc : Warior
    {
        public override string Name => "Орк";

        public override void Hit(int dmg, Warior source)
        {
            HP -= dmg;
            Console.WriteLine($"Мне {Name}у - {source.Name} нанес {dmg} урона - осталось HP {HP} ");
        }

        public Orc(int HP)
        {
            hpMaх = HP;
            this.HP = HP;
        }
        
    }
}
