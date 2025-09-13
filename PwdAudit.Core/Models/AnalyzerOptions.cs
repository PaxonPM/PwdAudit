using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdAudit.Core.Models
{
    public sealed record AnalyzerOptions(
    bool OfflineOnly = true,
    bool EnableOnline = false,
    int MaxParallelism = 4,
    int? CacheCapacity = 2048,
    int HttpTimeoutSeconds = 10,
    bool RedactLogs = true,
    bool UseAnsiColors = false
    )
    {
        public static AnalyzerOptions Default { get; } = new();
    }
}
