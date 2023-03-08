using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounce
{
    public abstract class Box : Obstacle 
    {
        protected Pen pen;
        protected PointF Position;
        protected PointF Size;

        public void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, Position.X, Position.Y, Size.X, Size.Y);
        }

        public void IsHit(Ball ball)
        {
            var RectOne = new RectangleF(Position.X, Position.Y, Size.X, Size.Y);
        
            var BallX = ball.GetPos().X;
            var BallY = ball.GetPos().Y;
            var Radius = ball.GetRadius();
            var RectTwo = new RectangleF(BallX - Radius, BallY - Radius, 2 * Radius, 2 * Radius);

            if (RectOne.IntersectsWith(RectTwo))
            {
                SpeedModifier(ball);
            }





        }
        public abstract void SpeedModifier(Ball ball);

    }
}
