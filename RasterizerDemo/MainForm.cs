using System.Drawing;
using System.Windows.Forms;
using RasterizerDemo.Engine;

namespace RasterizerDemo.UI
{
    public partial class MainForm : Form
    {
        private Renderer _renderer = new Renderer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void RefreshTimer_Tick(object sender, System.EventArgs e)
        {
            _renderer.Begin(mainView.ClientSize, Color.Black);

            // TODO: Make draw calls

            mainView.Image = _renderer.End();

            mainView.Refresh();
        }
    }
}
