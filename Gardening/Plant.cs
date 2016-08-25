using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Gardening.Business
{
    [Serializable]
    public class Plant
    {
        #region properties
        public string Name { get; set; }
        public DateTime PlantStart { get; set; }
        public DateTime PlantStop { get; set; }
        public int DaysToMaturity { get; set; }
        public int FreezeTempF { get; set; }
        public int MinTransplantWeeks { get; set; }
        public int MaxTransplantWeeks { get; set; }
        public float PlantDepthInches { get; set; }
        public enum SeedType
        {
            plants,
            packets,
            pounds,
            cloves,
            oz
        }
        public float SeedAmount { get; set; }
        public float SeparationNeighborDistanceInches { get; set; }
        public int SeparationRowDistanceInches { get; set; }
        //all production amounts will be set to accomodate a common area.
        //input to this common area to simplify math in the long run.
        //public int RowLengthInches { get; set; }
        public enum ProductionType
        {
            plants,
            pounds,
            bushels,
            items
        }
        public float ProductionAmount { get; set; }
        public int MinStorageTimeDays { get; set; }
        public int MaxStorageTimeDays { get; set; }
        public int MinStorageTempF { get; set; }
        public int MaxStorageTempF { get; set; }
        public int MinStorageHumidity { get; set; }
        public int MaxStorageHumidity { get; set; }
        public int FreezeTemp { get; set; }
        public List<Plant> GoodNeighbors { get; set; }
        public List<Plant> BadNeighbors { get; set; }
        public float HeightInches { get; set; }
        public bool GrowOverEdgePreferred { get; set; }
        public enum TrellisType
        {
            None,
            Cage,
            Standard,
            Tall
        }

        #endregion
    }
}
