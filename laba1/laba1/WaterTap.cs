using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class WaterTap
    {
        public bool State { set; get; }

        public Water GetWater() {
            if (State)
            {
                return new Water();

            }
            else {
                return null;
            }
        }
    }
}
