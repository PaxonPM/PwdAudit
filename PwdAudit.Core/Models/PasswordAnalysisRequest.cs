using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PwdAudit.Core.Models
{
    public class PasswordAnalysisRequest
    {
        public Guid Id { get;  }
        public DateTimeOffset SubmittedAt { get;}
        public string Locale { get; }
        public AnalysisMode Mode { get;  }  
        public Policy Policy { get; }
        public AnalyzerOptions Options { get; }
        public string RedactedPreview { get; }
        public string Source { get; }


        public PasswordAnalysisRequest(Guid id, 
                                        DateTimeOffset submittedAt, 
                                        string locale, 
                                        AnalysisMode mode, 
                                        Policy policy, 
                                        AnalyzerOptions options, 
                                        string redactedPreview, 
                                        string source )
        {
            Id = id;
            SubmittedAt = submittedAt;
            Locale = locale;
            Mode = mode;
            Policy = policy;
            Options = options;
            RedactedPreview = redactedPreview;
            Source = source;

        }





    }
}
