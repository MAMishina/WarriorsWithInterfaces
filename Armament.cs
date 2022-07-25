using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsWithInterfaces
{
    class Armament
    {
        public int gun = 20;
        public int bow = 10;
        public int grenade = 30;
        public int handToHandCombat = 3;
        /// <summary>
        /// Пушка
        /// </summary>
        public int Gun { get { return gun; } }
        
        /// <summary>
        /// Лук
        /// </summary>
        public int Bow { get { return bow; } }

        /// <summary>
        /// Граната
        /// </summary>
        public int Grenade { get { return grenade; } }
        
        public int HandToHandCombat { get { return handToHandCombat; } }

    }
}
