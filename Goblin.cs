using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsWithInterfaces
{
    public class Goblin : Warior
    {
        public override string Name => "Гоблин";

        public override void Hit(int dmg, Warior source)
        {
            HP -= dmg;
            Console.WriteLine($"Мне {Name}у - {source.Name} нанес {dmg} урона - осталось HP {HP} ");

        }

        public Goblin (int HP)
        {
            hpMaх = HP;
            this.HP = HP;
        }
    }
}
