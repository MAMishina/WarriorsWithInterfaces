using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsWithInterfaces
{
    public interface IActionManager
    {
        /// <summary>
        /// Нанести урон
        /// </summary>
        /// <param name="source"> кто </param>
        /// <param name="target"> кому </param>
        /// <param name="damage"> какой урон </param>
        public void Attack(Warior source, Warior target, int damage);

        /// <summary>
        /// Лечить
        /// </summary>
        /// <param name="source"></param>
        /// <param name="target"></param>
        /// <param name="hp"></param>
        public void Heal(Doctor source, Warior target, int hp);


    }
}
