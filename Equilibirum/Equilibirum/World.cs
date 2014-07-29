using Equilibirum.GameObjects;
using Equilibirum.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Equilibirum
{
    class World
    {
        public Terrain terrain { get; set; }
        public GameObject[,] gameObjects{get;set;}

        public World()
        {
            terrain = new Terrain();
            gameObjects = new GameObject[100, 100];
        }

        public void draw()
        {
            //THINGS TO DRAW GO HERE
            throw new NotImplementedException();
        }




    }
}
