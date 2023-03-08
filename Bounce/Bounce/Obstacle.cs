using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bounce
{
    public interface Obstacle
    {
        
        void Draw(Graphics graphics);
        void IsHit(Ball ball);
    }


    
}
