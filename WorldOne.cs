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
            Load();
            AddContent();
        }

        private void Load()
        {
            GameArt.Add("crab");
            GameArt.Add("worm");
            GameArt.Add("sand2");

            BackgroundTileName = "sand2";
        }
        private void AddContent()
        {
            Add(new Crab(), "crab", 400, 300);
            Add(new Worm(), "worm", 600, 300);
        }
    }
}
