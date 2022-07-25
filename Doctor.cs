using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsWithInterfaces
{
    public class Doctor : Warior
    {
        public override string Name => "Доктор";

        public void Heal(int hp, Warior target)
        {
            target.HP += hp;
            if (target.HP > Warior.HpMax)
            {
                target.HP = Warior.HpMax;
                Console.WriteLine("Достигнут максимальный уровень здоровья.");
            }
            else
            {
                Console.WriteLine($"Мне {target.Name}у - {Name} добавил {hp} здоровья - осталось HP {target.HP} ");
            }
        }

        public override void Hit(int dmg, Warior source)
        {
        }

        public Doctor (int HP)
        {
            hpMaх = HP;
            this.HP = HP;
        }
    }
}
