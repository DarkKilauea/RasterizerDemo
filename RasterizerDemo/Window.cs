using System.Drawing;
using System.Drawing.Imaging;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using RasterizerDemo.Engine;

namespace RasterizerDemo.UI
{
    internal class Window : GameWindow
    {
        private Renderer _renderer;

        public Window() : base(1024, 768, GraphicsMode.Default, "Rasterizer Demo")
        {
            VSync = VSyncMode.Adaptive;

            _renderer = new Renderer();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (Keyboard[Key.Escape])
                Exit();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            _renderer.Begin(ClientSize, Color.DarkCyan);

            var image = _renderer.End();

            var data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            GL.WindowPos2(0, 0);
            GL.DrawPixels(data.Width, data.Height, OpenTK.Graphics.OpenGL.PixelFormat.Rgba, PixelType.UnsignedByte, data.Scan0);
            image.UnlockBits(data);

            SwapBuffers();
        }
    }
}
