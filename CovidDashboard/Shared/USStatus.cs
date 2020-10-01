using System;
using Newtonsoft.Json;

namespace CovidDashboard.Shared
{
    public class USStatus
    {
        [JsonProperty(PropertyName = "positive")]
        public int Positive { get; set; }

        [JsonProperty(PropertyName = "negative")]
        public int Negative { get; set; }
        
        [JsonProperty(PropertyName = "pending")]
        public int Pending { get; set; }
        
        [JsonProperty(PropertyName = "hospitalizedCurrently")]
        public int HospitalizedCurrently { get; set; }

        [JsonProperty(PropertyName = "hospitalizedCumulative")]
        public int HospitalizedCumulative { get; set; }

        [JsonProperty(PropertyName = "inIcuCurrently")]
        public int InIcuCurrently { get; set; }

        [JsonProperty(PropertyName = "inIcuCumulative")]
        public int InIcuCumulative { get; set; }

        [JsonProperty(PropertyName = "onVentilatorCurrently")]
        public int OnVentilatorCurrently { get; set; }

        [JsonProperty(PropertyName = "onVentilatorCumulative")]
        public int OnVentilatorCumulative { get; set; }

        [JsonProperty(PropertyName = "recovered")]
        public int Recovered { get; set; }
        
        [JsonProperty(PropertyName = "dateChecked")]
        public DateTime DateChecked { get; set; }

        [JsonProperty(PropertyName = "death")]
        public int Death { get; set; }

        [JsonProperty(PropertyName = "hospitalized")]
        public int Hospitalized { get; set; }

        [JsonProperty(PropertyName = "totalTestResults")]
        public int TotalTestResults { get; set; }

        [JsonProperty(PropertyName = "lastModified")]
        public DateTime LastModified { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "posNeg")]
        public int PosNeg { get; set; }

        [JsonProperty(PropertyName = "deathIncrease")]
        public int DeathIncrease { get; set; }

        [JsonProperty(PropertyName = "hospitalizedIncrease")]
        public int HospitalizedIncrease { get; set; }

        [JsonProperty(PropertyName = "negativeIncrease")]
        public int NegativeIncrease { get; set; }

        [JsonProperty(PropertyName = "positiveIncrease")]
        public int PositiveIncrease { get; set; }

        [JsonProperty(PropertyName = "totalTestResultsIncrease")]
        public int TotalTestResultsIncrease { get; set; }
    }
}