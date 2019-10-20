using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.IO;

namespace Armng_Pjkt
{
    [Serializable]
    public class save_data
    {


        public List<armor_piece> armor_list = new List<armor_piece>();
        public List<TreeNode> nodes = new List<TreeNode>();

        public decimal weight { get; set; }
        public int pp { get; set; }

        public int avc1 { get; set; }
        public int avc2 { get; set; }
        public int avc3 { get; set; }
        public int avc4 { get; set; }
        public int avc5 { get; set; }
        public int avc6 { get; set; }
        public int avc7 { get; set; }
        public int avc8 { get; set; }
        public int avc9 { get; set; }
        public int avc10 { get; set; }
        public int avc11 { get; set; }
        public int avc12 { get; set; }
        public int avc13 { get; set; }
        public int avc14 { get; set; }
        public int avc15 { get; set; }
        public int avc16 { get; set; }
        public int avc17 { get; set; }
        public int avc18 { get; set; }
        public int avc19 { get; set; }
        public int avc20 { get; set; }

        public int avp1 { get; set; }
        public int avp2 { get; set; }
        public int avp3 { get; set; }
        public int avp4 { get; set; }
        public int avp5 { get; set; }
        public int avp6 { get; set; }
        public int avp7 { get; set; }
        public int avp8 { get; set; }
        public int avp9 { get; set; }
        public int avp10 { get; set; }
        public int avp11 { get; set; }
        public int avp12 { get; set; }
        public int avp13 { get; set; }
        public int avp14 { get; set; }
        public int avp15 { get; set; }
        public int avp16 { get; set; }
        public int avp17 { get; set; }
        public int avp18 { get; set; }
        public int avp19 { get; set; }
        public int avp20 { get; set; }

        public int avb1 { get; set; }
        public int avb2 { get; set; }
        public int avb3 { get; set; }
        public int avb4 { get; set; }
        public int avb5 { get; set; }
        public int avb6 { get; set; }
        public int avb7 { get; set; }
        public int avb8 { get; set; }
        public int avb9 { get; set; }
        public int avb10 { get; set; }
        public int avb11 { get; set; }
        public int avb12 { get; set; }
        public int avb13 { get; set; }
        public int avb14 { get; set; }
        public int avb15 { get; set; }
        public int avb16 { get; set; }
        public int avb17 { get; set; }
        public int avb18 { get; set; }
        public int avb19 { get; set; }
        public int avb20 { get; set; }


    }
}
