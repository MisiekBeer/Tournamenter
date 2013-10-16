using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class MatchSettings : BaseLogicClass
    {
        #region properties
        //Points for DRAW
        private int pointsForDraw;
        public int PointsForDraw
        {
            get { return pointsForDraw; }
            set { pointsForDraw = value; OnPropertyChanged(PropNames.PointsForDraw); }
        }


        //Points for BAY
        private int pointsForBAY;
        public int PointsForBay
        {
            get { return pointsForBAY; }
            set { pointsForBAY = value; OnPropertyChanged(PropNames.PointsForBay); }
        }

        //Points for WALKOVER 
        private int walkowerPoints;
        public int WalkowerPoints
        {
            get { return walkowerPoints; }
            set { walkowerPoints = value; OnPropertyChanged(PropNames.WalkowerPoints); }
        }


        public static class PropNames
        {
            public const string PointsForDraw = "PointsForDraw";
            public const string PointsForBay = "PointsForBay";
            public const string WalkowerPoints = "WalkowerPoints";
        } 
        #endregion

        public MatchSettings()
        {
            PointsForDraw = 10;
            PointsForBay = 10;
            WalkowerPoints = 20;
        }

        public override string ToString()
        {
            return string.Format("Match settings: points for walkower:{0}; BAY: {1}; Draw {2}",
                                  WalkowerPoints, PointsForBay, PointsForDraw);
        }
    }
}
