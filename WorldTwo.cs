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
            Load();
            AddContent();
        }

        private void Load()
        {
            GameArt.Add("crab");
            GameArt.Add("lobster");
            GameArt.Add("sand2");

            BackgroundTileName = "sand2";
        }
        private void AddContent()
        {
            var crab = new Crab();
            Add(crab);
            Add(new Lobster(crab));
        }
    }
}
