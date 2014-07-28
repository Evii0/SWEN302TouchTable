using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Equilibirum.GameObjects
{
    class House : GameObject
    {
        private Point coord;
        private string name;

        public House(Point coord, string name)
        {
            this.coord = coord;
            this.name = name;
        }

        public void draw()
        {
            throw new NotImplementedException();
        }

        public System.Windows.Shapes.Rectangle boundingBox()
        {
            throw new NotImplementedException();
        }

        public string getName()
        {
            throw new NotImplementedException();
        }
    }
}
