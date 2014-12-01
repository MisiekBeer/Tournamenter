using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Logic
{
    [Serializable]
    public class PointsDiffRange : ICloneable
    {
        public int MinPoints { get; set; }

        public int MaxPoints { get; set; }

        public int WinPts { get; set; }

        public int LoosePts { get; set; }

        #region ICloneable Members

        public object Clone()
        {
            return new PointsDiffRange()
            {
                MinPoints = this.MinPoints,
                MaxPoints = this.MaxPoints,
                LoosePts = this.LoosePts,
                WinPts = this.WinPts
            };
        }

        #endregion ICloneable Members
    }

    [Serializable]
    public class MatchSettings : BaseLogicClass, ICloneable
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
            set { pointRanges = value; OnPropertyChanged(PropNames.PointRanges); }
        }

        private TimeSpan roundTime;

        public TimeSpan RoundTime
        {
            get { return roundTime; }
            set { roundTime = value; OnPropertyChanged(PropNames.RoundTime); }
        }

        [XmlIgnore]
        public int RoundMinutes
        {
            get { return (int)roundTime.TotalMinutes; }
            set { RoundTime = new TimeSpan(0, value, 0); OnPropertyChanged(PropNames.RoundMinutes); }
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
            public const string RoundMinutes = "RoundMinutes";
            public const string TablesCount = "TablesCount";
        }

        #endregion properties

        public MatchSettings()
        {
        }

        public override string ToString()
        {
            return string.Format("Match settings: points for walkower:{0}; BAY: {1}; Draw {2}",
                                  WalkowerPoints, PointsForBay, PointRanges[0].WinPts);
        }

        public static MatchSettings DefaultSettings;

        static MatchSettings()
        {
            DefaultSettings = new MatchSettings()
            {
                WalkowerPoints = 20,
                RoundCount = 3,
                PointsForBay = 10,
                TablesCount = 6,
                RoundTime = new TimeSpan(2, 30, 0),

                PointRanges = new List<PointsDiffRange>()  {     //Points from, Points to , winner points
									new PointsDiffRange(){ MinPoints=0, MaxPoints=0, WinPts = 10, LoosePts = 10},
									new PointsDiffRange(){ MinPoints=1, MaxPoints=1, WinPts = 11, LoosePts = 9},
									new PointsDiffRange(){ MinPoints=2, MaxPoints=2, WinPts = 12, LoosePts = 8},
									new PointsDiffRange(){ MinPoints=3, MaxPoints=3, WinPts = 13, LoosePts = 7},
									new PointsDiffRange(){ MinPoints=4, MaxPoints=4, WinPts = 14, LoosePts = 6},
									new PointsDiffRange(){ MinPoints=5, MaxPoints=5, WinPts = 15, LoosePts = 5},
									new PointsDiffRange(){ MinPoints=6, MaxPoints=6, WinPts = 16, LoosePts = 4},
									new PointsDiffRange(){ MinPoints=7, MaxPoints=7, WinPts = 17, LoosePts = 3},
									new PointsDiffRange(){ MinPoints=8, MaxPoints=8, WinPts = 18, LoosePts = 2},
									new PointsDiffRange(){ MinPoints=9, MaxPoints=9, WinPts = 19, LoosePts = 1},
									new PointsDiffRange(){ MinPoints=10, MaxPoints=int.MaxValue, WinPts = 20, LoosePts = 0},
								}
            };
        }

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
                n => n.MinPoints <= pointsDiff && n.MaxPoints >= pointsDiff).WinPts;
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

            return PointRanges.Find(
                n => n.MinPoints <= pointsDiff && n.MaxPoints >= pointsDiff).LoosePts;
        }

        #region ICloneable Members

        public object Clone()
        {
            MatchSettings clone = new MatchSettings()
            {
                WalkowerPoints = this.WalkowerPoints,
                RoundCount = this.RoundCount,
                PointsForBay = this.PointsForBay,
                TablesCount = this.TablesCount,
                RoundTime = this.RoundTime,
                PointRanges = new List<PointsDiffRange>(this.PointRanges.Count)
            };

            this.PointRanges.ForEach((n) => clone.PointRanges.Add((PointsDiffRange)n.Clone()));
            return clone;
        }

        #endregion ICloneable Members
    }
}