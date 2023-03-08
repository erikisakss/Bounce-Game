using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bounce
{
    public class RedObstacle : Box
    {
        public RedObstacle(int x, int y, int width, int height)
        {
            base.pen = new Pen(Color.Red, 5);
            base.Position = new PointF(x, y);
            base.Size = new PointF(width, height);
        }

        public override void SpeedModifier(Ball ball)
        {
            if (ball.GetSpeed().X < 8 && ball.GetSpeed().Y < 8)
            {
                
                ball.SetSpeed(new PointF(ball.GetSpeed().X * 1.04f, ball.GetSpeed().Y * 1.04f));
            }
            
        }
    }   
}
