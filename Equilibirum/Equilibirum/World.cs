using Equilibirum.GameObjects;
using Equilibirum.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


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

        public void TestHouse(){
            gameObjects[0,0] = new House(new Point(0,0), "House");
            Console.WriteLine("House added via method.");
        }
    }
}
