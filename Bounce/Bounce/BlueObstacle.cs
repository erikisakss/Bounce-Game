using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounce
{
    public class BlueObstacle : Box
    {
        public BlueObstacle(int x, int y, int width, int height)
        {
            base.pen = new Pen(Color.Blue, 5);
            base.Position = new PointF(x, y);
            base.Size = new PointF(width, height);
        }

        public override void SpeedModifier(Ball ball)
        {
            if (ball.GetSpeed().X > 1 && ball.GetSpeed().Y > 1)
            {
                ball.SetSpeed(new PointF(ball.GetSpeed().X * 0.8f, ball.GetSpeed().Y * 0.8f));
            }
        }
    }
    
    
}
