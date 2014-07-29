using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Equilibirum.Board
{
    class TerrainTile
    {

        public Color tileColour { get; set; }

        public TerrainTile()
        {
            tileColour = Colors.Green;
        }
        public void draw()
        {
            throw new NotImplementedException();
        }

    }
}
