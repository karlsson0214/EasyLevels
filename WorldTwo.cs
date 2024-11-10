using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyLevels
{
    internal class WorldTwo : World
    {
        public WorldTwo() : base(800, 600)
        {
            BackgroundTileName = "sand2";

            // Add game objects.
            var crab = new Crab();
            Add(crab, "crab", 400, 300);
            Add(new Lobster(crab), "lobster", 100, 100);
        }
    }
}
