using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public interface Tehnika
    {
        void moveAIRvehical(Graphics g);

        void drawAIRvehical(Graphics g);

        void setPosition(int x, int y);

        void loadPassenger(int count);

        int getPassenger();

        void setMainColor(Color color);

        string getInfo();
    }
}
