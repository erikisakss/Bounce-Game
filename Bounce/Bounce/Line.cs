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
            if (Distance(PositionA, PositionB, ball.GetPos()) < 3.5f)
            {
                BounceBack(ball);

            }
            
            
        }


        public abstract void BounceBack(Ball ball);

        public double Distance(PointF a, PointF b, PointF c)
        {
            double distance = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
            double u = ((c.X - a.X) * (b.X - a.X) + (c.Y - a.Y) * (b.Y - a.Y)) / Math.Pow(distance, 2);
            PointF intersection = new PointF((float)(a.X + u * (b.X - a.X)), (float)(a.Y + u * (b.Y - a.Y)));
            distance = Math.Sqrt(Math.Pow(c.X - intersection.X, 2) + Math.Pow(c.Y - intersection.Y, 2));
            return distance;

        }
    }
}
