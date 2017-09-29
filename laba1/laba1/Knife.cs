using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    class Knife
    {
        public void Clean_potato(Potato p)
        {
            if (p.Have_scin)
            {
                p.Have_scin = false;
            }
        }
        
        public void Clean_onion(Onion p)
        {
            if (p.Have_scin)
            {
                p.Have_scin = false;
            }
        }

    }
}
