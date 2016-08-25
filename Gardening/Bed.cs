using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardening
{
    [Serializable]
    class Bed
    {
        public int RaiseHeight { get; set; }
        public bool IsRaised { get { return RaiseHeight > 0; } }
        public enum SoilType
        {
            Clay,
            SandyClay,
            SiltyClay,
            ClayLoam,
            SandyClayLoam,
            SiltyClayLoam,
            Loam,
            SandyLoam,
            SiltLoam,
            Silt,
            LoamySand,
            Sand
        }
        public enum SunType
        {
            FullSun,
            FullShade,
            MostSun,
            MostShade,
            MoreSun,
            MoreShade,
            HalfSun
        }
        public bool HasEdge { get; set; }
        public float Width { get; set; }
        public float Length { get; set; }
        public bool HasCover { get; set; }
        public bool HasIrrigation { get; set; }
        public int DaysBetweenVisits { get; set; }
    }
}
