using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloniexSharp.Entities
{
    public class TwentyFourHourVolumeDetails
    {
        public string CurrencyPair { get; set; }
        public Dictionary<string, double> Volumes { get; set; }
    }
}
