using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Equilibirum.GameObjects
{
    class House : GameObject
    {
        private Point coord;
        private string name = "house";
        private int width;
        private int height;

        public House(Point coord, string name)
        {
            this.coord = coord;
            this.name = name;
        }

        public void draw(Canvas c)
        {
           //TODO
        }

        public int[] boundingBox()
        {
            int[] box = { (int)coord.X, (int)coord.Y, width, height };
            return box;
        }

        public string getName()
        {
            return name;
        }
    }
}
