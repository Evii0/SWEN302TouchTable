using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equilibirum.Board
{
    class Terrain
    {
        public TerrainTile[,] tiles{get;set;}

        public Terrain()
        {
            tiles = new TerrainTile[100,100];

            for(int i = 0 ; i < 100 ; ++i)
            {
                for(int j = 0 ; j < 100 ; ++j)
                {
                    tiles[i, j] = new TerrainTile();
                }
            }
        }



    }
}
