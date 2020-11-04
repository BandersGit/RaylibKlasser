using System.Runtime.CompilerServices;
using System;
using Raylib_cs;

namespace RaylibClass
{
    public class Paddle
    {
        
        public float x = 0;
        public float y = 0;

        public KeyboardKey upKey;
        public KeyboardKey downKey;

        public Paddle(float x, float y, KeyboardKey upKey, KeyboardKey downKey)
        {
            this.x = x;
            this.y = y;
            this.upKey = upKey;
            this.downKey = downKey;
        }

        

    }
}
