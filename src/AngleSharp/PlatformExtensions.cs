using System;
using System.Collections.Generic;
using System.Text;

namespace AngleSharp
{
    public static class PlatformExtensions
    {
        public static Lazy<IEnumerable<Tuple<string, Encoding>>> AvailableEncodings { get; set; }

    }
}

