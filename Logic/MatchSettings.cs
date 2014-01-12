using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    [Serializable]
    public class PointsDiffRange
    {
        public int MinPoints { get; internal set; }
        public int MaxPoints { get; internal set; }
        public int WinnerPoints { get; internal set; }
    }


    [Serializable]
    public class MatchSettings : BaseLogicClass
    {
        #region properties

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

        private List<PointsDiffRange> pointRanges;
        public List<PointsDiffRange> PointRanges 
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
            WalkowerPoints = 20;
            RoundCount = 3;

            PointRanges = new List<PointsDiffRange>()  {     //Points from, Points to , winner points
                                new PointsDiffRange(){ MinPoints=0, MaxPoints=0, WinnerPoints = 10},
                                new PointsDiffRange(){ MinPoints=1, MaxPoints=1, WinnerPoints = 11},
                                new PointsDiffRange(){ MinPoints=2, MaxPoints=2, WinnerPoints = 12},
                                new PointsDiffRange(){ MinPoints=3, MaxPoints=3, WinnerPoints = 13},
                                new PointsDiffRange(){ MinPoints=4, MaxPoints=4, WinnerPoints = 14},
                                new PointsDiffRange(){ MinPoints=5, MaxPoints=5, WinnerPoints = 15},
                                new PointsDiffRange(){ MinPoints=6, MaxPoints=6, WinnerPoints = 16},
                                new PointsDiffRange(){ MinPoints=7, MaxPoints=7, WinnerPoints = 17},
                                new PointsDiffRange(){ MinPoints=8, MaxPoints=8, WinnerPoints = 18},
                                new PointsDiffRange(){ MinPoints=9, MaxPoints=9, WinnerPoints = 19},
                                new PointsDiffRange(){ MinPoints=10, MaxPoints=int.MaxValue, WinnerPoints = 20},
                            };
            PointsForBay = 10;

            RoundTime = new TimeSpan(2, 30, 0);
        }

        public override string ToString()
        {
            return string.Format("Match settings: points for walkower:{0}; BAY: {1}; Draw {2}",
                                  WalkowerPoints, PointsForBay, PointRanges[0].WinnerPoints);
        }

        public static MatchSettings DefaultSettings = new MatchSettings() { };

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsDiff">difference</param>
        /// <returns></returns>
        public int GetWinnerPoints(int pointsDiff)
        {
            if (pointsDiff < 0)
                pointsDiff = -pointsDiff;

            return PointRanges.Find(
                n => n.MinPoints <= pointsDiff && n.MaxPoints >= pointsDiff).WinnerPoints;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsDiff">difference</param>
        /// <returns></returns>
        public int GetLooserPoints(int pointsDiff)
        {
            if (pointsDiff < 0)
                pointsDiff = -pointsDiff;

            return PointRanges.Last().WinnerPoints - GetWinnerPoints(pointsDiff);
        }
    }
}
