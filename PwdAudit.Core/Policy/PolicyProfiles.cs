using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdAudit.Core.Policy
{
    public static class PolicyProfiles
    {        

        public static Models.Policy Lenient => new(minLength: 10,
                                                   minScore: 60,
                                                   requireNoBreach: true,
                                                   maxRepeatRun: 1,
                                                   profiles: new[] { "Lenient" },
                                                   notes: "Lenient preset"
                                                   );        
        public static Models.Policy Balanced => new(minLength: 12, 
                                                    minScore: 70, 
                                                    requireNoBreach: true, 
                                                    maxRepeatRun: 5, 
                                                    profiles: new[] { "Balanced" }, 
                                                    notes: "Balanced preset"
                                                    );    
        public static Models.Policy Strict => new(minLength: 14, 
                                                  minScore: 80, 
                                                  requireNoBreach: true, 
                                                  maxRepeatRun: 10, 
                                                  profiles: new[] { "Strict" }, 
                                                  notes: "Strict preset"
                                                  );        
    }
}
