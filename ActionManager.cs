using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsWithInterfaces
{
    public class ActionManager : IActionManager
    {
        public void Attack(Warior source, Warior target, int damage)
        { 
            if (target.HP - damage <= 0 )
            {
                target.HP=0;
                Console.WriteLine($"Персонаж {target.Name} уже убит");
            }
            else
            {
                target.Hit(damage, source);
            }
        }

        public void Heal(Doctor source, Warior target, int hp)
        {
            if (target.HP >= Warior.HpMax)
            {
                Console.WriteLine($"У персонажа {target.Name} максимальный уровень жизни.");
            }
            else
            {
                source.Heal(hp, target);
            }
        }

    }
}
