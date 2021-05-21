using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Tarea1Silla
{

    class game
    {
        GameWindow window;
        public game (GameWindow window)
        {
            this.window = window;
            Start();
        }
        void Start()
        {
            window.Load += loaded;
            window.Resize += resize;
            window.RenderFrame += renderF;
            window.Run(1.0 / 60.0);
        }
        void resize (Object o , EventArgs e )
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0.0f, 50.0f, 0.0f, 50.0f,-1.0f,1.0f);
            GL.MatrixMode(MatrixMode.Modelview);
        }
        void renderF(Object o , EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(BeginMode.Quads);

            GL.Vertex2(8.3, 20.5);         //base
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(19.0, 23.0);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(29.0, 20.5);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(18.5, 17.0);

            //GL.Color3(0.63, 0.40, 0.23); //oscuro 
           /// GL.Color3(0.69, 0.43, 0.29); //Claro

            GL.Vertex2(8.3, 19.8);                  //base -  1
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(8.3, 20.5);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(18.5, 17.0);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(18.5, 16.3);

            GL.Vertex2(18.5, 16.3);         //base -  2
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(18.5, 17.0);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(29.0, 20.5);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(29.0, 19.8);

            GL.Vertex2(9.0, 18.0);         //base -  3
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(8.9, 19.8);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(17.5, 16.7);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(17.5, 14.5);

            GL.Vertex2(20.0, 15.4);         //base -  4
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(20.0, 16.9);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(27.2, 19.2);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(27.2, 18.0);

            GL.Vertex2(9.0, 8.6);         //pata -  1
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(8.3, 19.8);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(9.0, 19.7);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(9.5, 8.2);

            GL.Vertex2(9.5, 8.2);         //pata -  1.1
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(9.0, 18.0);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(10.5, 17.4);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(11.0, 9.0);

            GL.Vertex2(17.6, 3.9);         //pata -  2
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(17.5, 16.7);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(18.5,16.3);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(18.5, 3.3);

            GL.Vertex2(18.5, 3.3);         //pata -  2.1
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(18.5, 16.7);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(20.0, 16.9);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(20.0, 4.0);

            GL.Vertex2(26.8, 8.4);         //pata -  3
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(27.2, 19.2);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(28.0, 19.5);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(27.5, 8.2);

            GL.Vertex2(27.5, 8.2);         //pata -  3.1
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(28.5, 34.5);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(30.0, 34.8);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(28.5, 8.6);

            GL.Vertex2(27.3, 20.3) ;         //pata -  3.2
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(28.0 , 34.6);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(28.8, 34.5);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(28.0, 20.0);

            GL.Vertex2(17.6, 22.7);         //pata -  4
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(17.5, 35.2);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(18.2, 35.2);
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(18.3, 22.6);

            GL.Vertex2(18.3, 22.6);         //pata -  4.1
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(18.2, 35.2);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(19.2, 35.2);
            GL.Color3(0.63, 0.40, 0.23); //oscuro 
            GL.Vertex2(19.5, 23.0);

            GL.Vertex2(18.4, 32.6);         //Espal -  1
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(18.4, 35.2);
            GL.Vertex2(28.0, 34.6);
            GL.Vertex2(27.9, 32.0);

            GL.Vertex2(18.5, 28.8);         //Espal -  2
            GL.Color3(0.69, 0.43, 0.29); //Claro
            GL.Vertex2(18.5, 31.0);
            GL.Vertex2(27.8, 30.0);
            GL.Vertex2(27.7, 27.4);





            GL.End();
            window.SwapBuffers();
        }
        void loaded (Object o , EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        }
    }
}
