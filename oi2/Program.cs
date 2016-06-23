using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;


namespace oi2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            var game = new GameWindow(800, 500);
            game.RenderFrame += Game_RenderFrame;
            game.Run(60.0);


        }

        private static void Game_RenderFrame(object sender, FrameEventArgs e)
        {
            //throw new NotImplementedException();
            GL.ClearColor(Color.White);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);  //para limpar
            GL.Begin(BeginMode.Lines); // define a forma
            GL.Color3(Color.Red); //define a cor
            GL.Vertex2(0.0f, 1.0f);
            GL.Vertex2(0.0f, -4.0f);
            //GL.Vertex2(0.0f, 2.0f);
            GL.End();
            GL.PopMatrix();

            var game = (GameWindow)sender;
            game.SwapBuffers();


        }
    }
}
