using System;
using Raylib_cs;

namespace RaylibClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Spelmotor Demo");

            Paddle leftPaddle = new Paddle(10, 100, KeyboardKey.KEY_W, KeyboardKey.KEY_S);
            Paddle rightPaddle = new Paddle(770, 100, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN);


            while (!Raylib.WindowShouldClose())
            {
                
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.GOLD);

                Raylib.EndDrawing();

            }
        }
    }
}
