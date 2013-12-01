using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    [Serializable]
    public class MatchSettings : BaseLogicClass
    {
        #region properties
        //Points for DRAW
        private int pointsForDraw;
        public int PointsForDraw
        {
            get { return pointsForDraw; }
            set { pointsForDraw = value; OnPropertyChanged(PropNames.PointsForDraw); 
            }
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

        private int roundCount;
        public int RoundCount
        {
            get { return roundCount; }
            set { roundCount = value; OnPropertyChanged(PropNames.RoundCount); }
        }

        private List<Tuple<int, int>> pointRanges;
        public List<Tuple<int, int>> PointRanges 
        {
            get { return pointRanges; }
            private set { pointRanges = value; OnPropertyChanged(PropNames.PointRanges); }
        }

        private TimeSpan roundTime;
        public TimeSpan RoundTime
        {
            get { return roundTime; }
            set { roundTime = value; OnPropertyChanged(PropNames.RoundTime); }
        }

        private int tablesCount;
        public int TablesCount
        {
            get { return tablesCount; }
            set { tablesCount = value; OnPropertyChanged(PropNames.TablesCount); }
        }



        public static class PropNames
        {
            public const string PointsForDraw = "PointsForDraw";
            public const string PointsForBay = "PointsForBay";
            public const string WalkowerPoints = "WalkowerPoints";
            public const string RoundCount = "RoundCount";
            public const string PointRanges = "PointRanges";
            public const string RoundTime = "RoundTime";
            public const string TablesCount = "TablesCount";
        } 
        #endregion

        public MatchSettings()
        {
            PointsForDraw = 10;
            PointsForBay = 10;
            WalkowerPoints = 20;
            RoundCount = 3;
            PointRanges = new List<Tuple<int, int>>(10);  //Small points difference ranges

            for (int i = 0; i < 10; i++)
            {
                PointRanges.Add(new Tuple<int, int>(i, i+1));
            }
            var last = PointRanges.Last();
            last = new Tuple<int,int>(last.Item1, 30);

            RoundTime = new TimeSpan(2, 30, 0);
        }

        public override string ToString()
        {
            return string.Format("Match settings: points for walkower:{0}; BAY: {1}; Draw {2}",
                                  WalkowerPoints, PointsForBay, PointsForDraw);
        }

        public static MatchSettings DefaultSettings = new MatchSettings() { };
    }
}
