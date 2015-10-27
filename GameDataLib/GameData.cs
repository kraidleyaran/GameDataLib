using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameGraphicsLib;
using GameObserverLib;

namespace GameDataLib
{
    [Serializable]
    public class GameData
    {
        public GameData()
        {
            
        }
        public GameData(ObserverData observerData)
        {
            ObserverData = observerData;
        }

        public GameData(GraphicsData graphicsData)
        {
            GraphicsData = graphicsData;
        }

        public ObserverData ObserverData { get; set; }
        public GraphicsData GraphicsData { get; set; }
    }
}
