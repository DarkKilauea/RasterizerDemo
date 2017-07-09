using System;

namespace RasterizerDemo.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (var window = new Window())
            {
                window.Run(30.0);
            }
        }
    }
}
