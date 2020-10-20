using System;
using Newtonsoft.Json;

namespace CovidDashboard.Shared
{
    public class DailyStatus
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "positive", NullValueHandling = NullValueHandling.Ignore)]
        public int Positive { get; set; }

        [JsonProperty(PropertyName = "probableCases", NullValueHandling = NullValueHandling.Ignore)]
        public int ProbableCases { get; set; }

        [JsonProperty(PropertyName = "negative, NullValueHandling = NullValueHandling.Ignore")]
        public int Negative { get; set; }

        [JsonProperty(PropertyName = "pending", NullValueHandling = NullValueHandling.Ignore )]
        public int Pending { get; set; }

        [JsonProperty(PropertyName = "totalTestResults", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestResults { get; set; }

        [JsonProperty(PropertyName = "hospitalizedCurrently", NullValueHandling = NullValueHandling.Ignore)]
        public int HospitalizedCurrently { get; set; }

        [JsonProperty(PropertyName = "hospitalizedCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public int HospitalizedCumulative { get; set; }

        [JsonProperty(PropertyName = "inIcuCurrently", NullValueHandling = NullValueHandling.Ignore)]
        public int InIcuCurrently { get; set; }

        [JsonProperty(PropertyName = "inIcuCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public int InIcuCumulative { get; set; }

        [JsonProperty(PropertyName = "onVentilatorCurrently", NullValueHandling = NullValueHandling.Ignore)]
        public int OnVentilatorCurrently { get; set; }

        [JsonProperty(PropertyName = "onVentilatorCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public int OnVentilatorCumulative { get; set; }

        [JsonProperty(PropertyName = "recovered", NullValueHandling = NullValueHandling.Ignore)]
        public int Recovered { get; set; }

        [JsonProperty(PropertyName = "dataQualityGrade")]
        public string DataQualityGrade { get; set; }

        [JsonProperty(PropertyName = "lastUpdateEt", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateEt { get; set; }

        [JsonProperty(PropertyName = "dateModified", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DateModified { get; set; }

        [JsonProperty(PropertyName = "checkTimeEt", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckTimeEt { get; set; }

        [JsonProperty(PropertyName = "death", NullValueHandling = NullValueHandling.Ignore)]
        public int Death { get; set; }

        [JsonProperty(PropertyName = "hospitalized", NullValueHandling = NullValueHandling.Ignore)]
        public int Hospitalized { get; set; }

        [JsonProperty(PropertyName = "dateChecked", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime DateChecked { get; set; }

        [JsonProperty(PropertyName = "totalTestsViral", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestsViral { get; set; }

        [JsonProperty(PropertyName = "positiveTestsViral", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveTestsViral { get; set; }

        [JsonProperty(PropertyName = "negativeTestsViral", NullValueHandling = NullValueHandling.Ignore)]
        public int NegativeTestsViral { get; set; }

        [JsonProperty(PropertyName = "positiveCasesViral", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveCasesViral { get; set; }

        [JsonProperty(PropertyName = "deathConfirmed", NullValueHandling = NullValueHandling.Ignore)]
        public int DeathConfirmed { get; set; }

        [JsonProperty(PropertyName = "deathProbable", NullValueHandling = NullValueHandling.Ignore)]
        public int DeathProbable { get; set; }

        [JsonProperty(PropertyName = "totalTestEncountersViral", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestEncountersViral { get; set; }

        [JsonProperty(PropertyName = "totalTestsPeopleViral", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestsPeopleViral { get; set; }

        [JsonProperty(PropertyName = "totalTestsAntibody", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestsAntibody { get; set; }

        [JsonProperty(PropertyName = "positiveTestsAntibody", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveTestsAntibody { get; set; }

        [JsonProperty(PropertyName = "negativeTestsAntibody", NullValueHandling = NullValueHandling.Ignore)]
        public int NegativeTestsAntibody { get; set; }

        [JsonProperty(PropertyName = "totalTestsPeopleAntibody", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestsPeopleAntibody { get; set; }

        [JsonProperty(PropertyName = "positiveTestsPeopleAntibody", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveTestsPeopleAntibody { get; set; }

        [JsonProperty(PropertyName = "negativeTestsPeopleAntibody", NullValueHandling = NullValueHandling.Ignore)]
        public int NegativeTestsPeopleAntibody { get; set; }

        [JsonProperty(PropertyName = "totalTestsPeopleAntigen", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestsPeopleAntigen { get; set; }

        [JsonProperty(PropertyName = "positiveTestsPeopleAntigen", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveTestsPeopleAntigen { get; set; }

        [JsonProperty(PropertyName = "totalTestsAntigen", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestsAntigen { get; set; }

        [JsonProperty(PropertyName = "positiveTestsAntigen", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveTestsAntigen { get; set; }

        [JsonProperty(PropertyName = "fips")]
        public string Fips { get; set; }

        [JsonProperty(PropertyName = "positiveIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveIncrease { get; set; }
        
        [JsonProperty(PropertyName = "negativeIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public int NegativeIncrease { get; set; }

        [JsonProperty(PropertyName = "total", NullValueHandling = NullValueHandling.Ignore)]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "totalTestResultsSource", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalTestResultsSource { get; set; }

        [JsonProperty(PropertyName = "totalTestResultsIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestResultsIncrease { get; set; }

        [JsonProperty(PropertyName = "posNeg", NullValueHandling = NullValueHandling.Ignore)]
        public int PosNeg { get; set; }

        [JsonProperty(PropertyName = "deathIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public int DeathIncrease { get; set; }

        [JsonProperty(PropertyName = "hospitalizedIncrease", NullValueHandling = NullValueHandling.Ignore)]
        public int HospitalizedIncrease { get; set; }
        
        [JsonProperty(PropertyName = "commercialScore", NullValueHandling = NullValueHandling.Ignore)]
        public int CommercialScore { get; set; }

        [JsonProperty(PropertyName = "negativeRegularScore", NullValueHandling = NullValueHandling.Ignore)]
        public int NegativeRegularScore { get; set; }

        [JsonProperty(PropertyName = "negativeScore", NullValueHandling = NullValueHandling.Ignore)]
        public int NegativeScore { get; set; }

        [JsonProperty(PropertyName = "positiveScore", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveScore { get; set; }

        [JsonProperty(PropertyName = "score", NullValueHandling = NullValueHandling.Ignore)]
        public int Score { get; set; }

        [JsonProperty(PropertyName = "grade")]
        public string Grade { get; set; }
    }
}