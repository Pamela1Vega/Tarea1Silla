using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Tarea1Silla
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new GameWindow(500, 500);
            game gm = new game(window);
        }
    }
}
