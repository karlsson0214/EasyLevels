using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyLevels
{
    internal class Worm : Actor
    {

        public Worm()
        {
            ImageName = "worm";
            Position = new Vector2(600, 300);

        }
        public override void Update(GameTime gameTime)
        {
            // do nothing
        }
    }
}
