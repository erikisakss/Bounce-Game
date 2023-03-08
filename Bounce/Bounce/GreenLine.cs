using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounce
{
    public class GreenLine : Line
    {

        public GreenLine(int x, int y, int xd, int yd)
        {
            base.PositionA = new PointF(x, y);
            base.PositionB = new PointF(xd, yd);
            base.pen = new Pen(Color.Green, 5);
        }

        public override void BounceBack(Ball ball)
        {
            ball.SetSpeed(new PointF(ball.GetSpeed().X, ball.GetSpeed().Y * -1));
        }

    }
}
