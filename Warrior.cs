using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorsWithInterfaces
{
    public abstract class Warior
    {
        public static int hpMaх;
        public int HP;
        public static int HpMax { get { return hpMaх; } }
        

        public abstract string Name { get; }

        public abstract void Hit(int damage, Warior source);

        
    }
}
