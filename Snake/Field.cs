using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Field
    {
        public int Width;
        public int Height;

        public Field(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public void Render()
        {
            for (int y = 0; y <= Height; y++)
            {
                if (y == 0 || y == Height)
                {
                    for (int x = 0; x < Width; x++) Console.Write("#");
                    Console.WriteLine();
                }
                else
                {
                    Console.SetCursorPosition(0, y);
                    Console.Write("#");
                    Console.SetCursorPosition(Width - 1, y);
                    Console.Write("#");
                    Console.WriteLine();
                }
            }
        }
    }
}
