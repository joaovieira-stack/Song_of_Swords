using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armng_Pjkt
{
    [Serializable]
    public class armor_piece
    {

            public string name { get; set; }
            public int avc { get; set; }
            public int avp { get; set; }
            public int avb { get; set; }
            public decimal wt { get; set; }
            public int[] coverage { get; set; }
            public int layer { get; set; }
            public int restrictive { get; set; }
            public int pp { get; set; }
    }
}
