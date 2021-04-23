using System;

namespace Ballspel_met_overerving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WindowHeight = 40;
            Console.WindowWidth = 70;
            Ball[] balls = new Ball[2] 
                {
                    new Ball(4, 4, 1, 1), 
                    new Ball(2, 15, 1, -1) 
                };

            PlayerBall player = new PlayerBall(10, 15, 0, 0);

            int score = 0;

            while (true)
            {
                foreach (var ball in balls)
                {
                    //Ball
                    ball.Update();
                    ball.Draw();
                }
                

                //SpelerBall
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    player.ChangeVelocity(key);
                }

                player.Update();
                player.Draw();

                //Check collisions
                if (Ball.CheckHit(balls[0], player) || Ball.CheckHit(balls[1], player))
                {
                    Console.Clear();
                    Console.WriteLine("Gewonnen!");
                    Console.WriteLine("score: {0}", score);
                    Console.ReadLine();
                }
                System.Threading.Thread.Sleep(50);
                score++;
            }
        }
    }
}
