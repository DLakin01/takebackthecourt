using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TakeBackTheCourt.Models
{
    public class Resource
    {

        public long Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public List<CourtImpact> PastCourtImpacts { get; set; }
        public List<CourtImpact> FutureCourtImpacts { get; set; }
        public string IssueIntro { get; set; }
        public List<SuggestedResource> SuggestedResources { get; set; }
    }

    public class CourtImpact
    {
        [Key]
        public long ImpactID { get; set; }
        public string Impact { get; set; }
    }

    public class SuggestedResource
    {
        [Key]
        public long SuggestedResourceId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
