using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PwdAudit.Core.Text
{
    public static class Redactor
    {

        public static string CreatePreview(string secret, int prefix = 3, int suffix = 3)
        {
            if (string.IsNullOrEmpty(secret))
                return string.Empty;

            if (secret.Length <= prefix + suffix)
                return new string('*', secret.Length);

            string start = secret.Substring(0, prefix);
            string middle = new string('*', secret.Length - prefix - suffix);
            string end = secret.Substring(secret.Length - suffix, suffix);

            return start + middle + end;
        }
    }
}
