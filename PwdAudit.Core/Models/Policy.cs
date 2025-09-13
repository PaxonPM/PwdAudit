using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdAudit.Core.Models
{
    public class Policy
    {
        public int MinLength { get; }
        public int MinScore { get; }
        public bool RequireNoBreach { get; }
        public int? MaxRepeatRun { get; }
        public IReadOnlyList<string> Profiles { get; }
        public string? Notes { get; }

        public Policy( int minLength, int minScore, bool requireNoBreach, int? maxRepeatRun, IReadOnlyList<string>? profiles, string? notes)
        {
            MinLength = minLength;
            MinScore = minScore;
            RequireNoBreach = requireNoBreach;
            MaxRepeatRun = maxRepeatRun;
            Profiles = profiles ?? Array.Empty<string>();
            Notes = notes;

        }

    }
}
