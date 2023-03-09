using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounce
{
    public abstract class Line : Obstacle
    {
        protected Pen pen;
        protected PointF PositionA;
        protected PointF PositionB;

        public void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, PositionA, PositionB);
        }
        
        public void IsHit(Ball ball)
        {
            
            var Rect = new RectangleF(PositionA.X, PositionA.Y, PositionB.X - PositionA.X, PositionB.Y - PositionA.Y);
            var BallRect = new RectangleF(ball.GetPos().X - ball.GetRadius(), ball.GetPos().Y - ball.GetRadius(), ball.GetRadius() * 2, ball.GetRadius() * 2);
            if (Rect.IntersectsWith(BallRect))
            {
                BounceBack(ball);
            }


        }


        public abstract void BounceBack(Ball ball);

        
    }
}
