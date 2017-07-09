using System.Drawing;

namespace RasterizerDemo.Engine
{
    public class Renderer
    {
        private Bitmap _frameBuffer;

        public void Begin(Size viewPortSize, Color clearColor)
        {
            // Allocate a new framebuffer if we don't already have one, or its size changed
            if (_frameBuffer == null || _frameBuffer.Size != viewPortSize)
                _frameBuffer = new Bitmap(viewPortSize.Width, viewPortSize.Height);

            // Clear the frame buffer
            for (var x = 0; x < _frameBuffer.Size.Width; ++x)
                for (var y = 0; y < _frameBuffer.Size.Height; ++y)
                    _frameBuffer.SetPixel(x, y, clearColor);
        }

        public Bitmap End()
        {
            return _frameBuffer;
        }
    }
}
