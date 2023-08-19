using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetExample.Entities
{
    internal class LogRecord
    {
        public string User { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return User.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is LogRecord)) return false;

            LogRecord other = obj as LogRecord;
            return User.Equals(other.User);
        }
    }
}
