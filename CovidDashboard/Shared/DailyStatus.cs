using System;
using Newtonsoft.Json;

namespace CovidDashboard.Shared
{
    public class DailyStatus
    {
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "positive")]
        public int Positive { get; set; }

        [JsonProperty(PropertyName = "probableCases", NullValueHandling = NullValueHandling.Ignore)]
        public int ProbableCases { get; set; }

        [JsonProperty(PropertyName = "negative")]
        public int Negative { get; set; }

        [JsonProperty(PropertyName = "pending", NullValueHandling = NullValueHandling.Ignore )]
        public int Pending { get; set; }

        [JsonProperty(PropertyName = "totalTestResults")]
        public int TotalTestResults { get; set; }

        [JsonProperty(PropertyName = "hospitalizedCurrently")]
        public int HospitalizedCurrently { get; set; }

        [JsonProperty(PropertyName = "hospitalizedCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public int HospitalizedCumulative { get; set; }

        [JsonProperty(PropertyName = "inIcuCurrently")]
        public int InIcuCurrently { get; set; }

        [JsonProperty(PropertyName = "inIcuCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public int InIcuCumulative { get; set; }

        [JsonProperty(PropertyName = "onVentilatorCurrently", NullValueHandling = NullValueHandling.Ignore)]
        public int OnVentilatorCurrently { get; set; }

        [JsonProperty(PropertyName = "onVentilatorCumulative", NullValueHandling = NullValueHandling.Ignore)]
        public int OnVentilatorCumulative { get; set; }

        [JsonProperty(PropertyName = "recovered")]
        public int Recovered { get; set; }

        [JsonProperty(PropertyName = "dataQualityGrade")]
        public string DataQualityGrade { get; set; }

        [JsonProperty(PropertyName = "lastUpdateEt")]
        public string LastUpdateEt { get; set; }

        [JsonProperty(PropertyName = "dateModified")]
        public DateTime DateModified { get; set; }

        [JsonProperty(PropertyName = "checkTimeEt")]
        public string CheckTimeEt { get; set; }

        [JsonProperty(PropertyName = "death")]
        public int Death { get; set; }

        [JsonProperty(PropertyName = "hospitalized", NullValueHandling = NullValueHandling.Ignore)]
        public int Hospitalized { get; set; }

        [JsonProperty(PropertyName = "dateChecked")]
        public DateTime DateChecked { get; set; }

        [JsonProperty(PropertyName = "totalTestsViral")]
        public int TotalTestsViral { get; set; }

        [JsonProperty(PropertyName = "positiveTestsViral", NullValueHandling = NullValueHandling.Ignore)]
        public int PositiveTestsViral { get; set; }

        [JsonProperty(PropertyName = "negativeTestsViral", NullValueHandling = NullValueHandling.Ignore)]
        public int NegativeTestsViral { get; set; }

        [JsonProperty(PropertyName = "positiveCasesViral")]
        public int PositiveCasesViral { get; set; }

        [JsonProperty(PropertyName = "deathConfirmed", NullValueHandling = NullValueHandling.Ignore)]
        public int DeathConfirmed { get; set; }

        [JsonProperty(PropertyName = "deathProbable", NullValueHandling = NullValueHandling.Ignore)]
        public int DeathProbable { get; set; }

        [JsonProperty(PropertyName = "totalTestEncountersViral", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestEncountersViral { get; set; }

        [JsonProperty(PropertyName = "totalTestsPeopleViral", NullValueHandling = NullValueHandling.Ignore)]
        public int TotalTestsPeopleViral { get; set; }

        [JsonProperty(PropertyName = "totalTestsAntibody")]
        public int TotalTestsAntibody { get; set; }

        [JsonProperty(PropertyName = "positiveTestsAntibody")]
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

        [JsonProperty(PropertyName = "totalTestsAntigen")]
        public int TotalTestsAntigen { get; set; }

        [JsonProperty(PropertyName = "positiveTestsAntigen")]
        public int PositiveTestsAntigen { get; set; }

        [JsonProperty(PropertyName = "fips")]
        public string Fips { get; set; }

        [JsonProperty(PropertyName = "positiveIncrease")]
        public int PositiveIncrease { get; set; }
        
        [JsonProperty(PropertyName = "negativeIncrease")]
        public int NegativeIncrease { get; set; }

        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "totalTestResultsSource")]
        public string TotalTestResultsSource { get; set; }

        [JsonProperty(PropertyName = "totalTestResultsIncrease")]
        public int TotalTestResultsIncrease { get; set; }

        [JsonProperty(PropertyName = "posNeg")]
        public int PosNeg { get; set; }

        [JsonProperty(PropertyName = "deathIncrease")]
        public int DeathIncrease { get; set; }

        [JsonProperty(PropertyName = "hospitalizedIncrease")]
        public int HospitalizedIncrease { get; set; }
        
        [JsonProperty(PropertyName = "commercialScore")]
        public int CommercialScore { get; set; }

        [JsonProperty(PropertyName = "negativeRegularScore")]
        public int NegativeRegularScore { get; set; }

        [JsonProperty(PropertyName = "negativeScore")]
        public int NegativeScore { get; set; }

        [JsonProperty(PropertyName = "positiveScore")]
        public int PositiveScore { get; set; }

        [JsonProperty(PropertyName = "score")]
        public int Score { get; set; }

        [JsonProperty(PropertyName = "grade")]
        public string Grade { get; set; }
    }
}