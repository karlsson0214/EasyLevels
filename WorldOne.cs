using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyLevels
{
    internal class WorldOne : World
    {

        public WorldOne() : base(800, 600)
        {
            BackgroundTileName = "sand2";

            // Add game objects.
            Add(new Crab(), "crab", 400, 300);
            Add(new Worm(), "worm", 600, 300);
        }
    }
}
