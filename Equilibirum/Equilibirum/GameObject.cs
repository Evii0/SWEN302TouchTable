using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Equilibirum.GameObjects
{
    interface GameObject
    {

       void draw(Canvas c);

       int[] boundingBox();

        string getName();


    }
}
