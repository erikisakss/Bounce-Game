using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bounce
{
	public class Engine
	{
		MainForm Form = new MainForm();
		Timer Timer = new Timer();
		List<Ball> Balls = new List<Ball>();
        List<Obstacle> Obstacles = new List<Obstacle>();
        Random Random = new Random();

		public void Run()
		{
            Form.Paint += Draw;
			Timer.Tick += TimerEventHandler;
			Timer.Interval = 1000/30;
			Timer.Start();

            //Obstacles
            Obstacles.Add(new RedObstacle(200, 200, 75, 75));
            Obstacles.Add(new RedObstacle(600, 150, 50, 100));
			Obstacles.Add(new BlueObstacle(400, 50, 100, 100));
            Obstacles.Add(new BlueObstacle(500, 300, 100, 100));
			Obstacles.Add(new YellowLine(750, 600, 750, 0));
            Obstacles.Add(new YellowLine(25, 0, 25, 600));
           // Obstacles.Add(new GreenLine(0, 25, 800, 25));
            //Obstacles.Add(new GreenLine(275, 550, 600, 550));



            Application.Run(Form);
		}

		void TimerEventHandler(Object obj, EventArgs args)
		{
			if (Random.Next(100) < 25)
            {
				var ball = new Ball(400, 300, 10);
				Balls.Add(ball);
			}
			
			foreach (var ball in Balls)
			{
                ball.Move();
				foreach (var obstacle in Obstacles)
				{
					obstacle.IsHit(ball);
				}

            }
				

            

            Form.Refresh();
		}

		void Draw(Object obj, PaintEventArgs args)
		{
			foreach (var ball in Balls) ball.Draw(args.Graphics);
            foreach (var obstacle in Obstacles) obstacle.Draw(args.Graphics);
        }

	}
}
