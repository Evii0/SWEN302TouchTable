using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Equilibirum.GameObjects
{
    interface GameObject
    {

        void draw();

        Rectangle boundingBox();

        string getName();


    }
}
