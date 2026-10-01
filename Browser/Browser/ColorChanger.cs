using System;
using System.Drawing;

namespace Browser
{
    public class ColorChanger
    {
        private Random random = new Random();

        public Color GetRandomColor()
        {
            return Color.FromArgb(
                random.Next(256),
                random.Next(256),
                random.Next(256));
        }
    }
}