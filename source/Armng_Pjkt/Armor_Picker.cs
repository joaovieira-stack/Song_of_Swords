using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Armng_Pjkt
{
    public partial class Armor_Picker : Form
    {
        XmlDocument xdoc = new XmlDocument();

        public int avc;
        public int avp;
        public int avb;

        public int layer;
        public int restrictive;
        public int pp;

        public int[] coverage = new int[20];
        public int[] halfcoverage = new int[20];

        public decimal weight;

        //Grabs the first form once instanced//
        private Base_Form mainForm = null;
        private TreeView node_tree = null;
        public Armor_Picker(Form calling_form, TreeView tree)
        {
            mainForm = calling_form as Base_Form;
            node_tree = tree as TreeView;
            InitializeComponent();
            xml_load();
            comboBox.Text = "Torso";
            listBox.Items.Clear();
            var xnList = xdoc.SelectNodes("armor_manager/torso/armor");
            Console.WriteLine(xnList.Count.ToString());
            foreach (XmlNode xn in xnList)
            {
                string name = xn["name"].InnerText;
                listBox.Items.Add(name);
            }

        }

        private void xml_load()
        {
            xdoc.Load(@"armor.xml");
  
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i=0; i != coverage.Length; i++)
            {
                coverage[i] = 0;
            }
            string name = listBox.SelectedItem.ToString();
            XmlNode xn = xdoc.SelectSingleNode("//armor[@id='"+name+"']/type");
            type_l.Text = xn.InnerText;

             xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/avc");
            avc_l.Text = xn.InnerText;
            avc = Int32.Parse(avc_l.Text);

            

             xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/avp");
            avp_l.Text = xn.InnerText;
            avp = Int32.Parse(avp_l.Text);

            xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/avb");
            avb_l.Text = xn.InnerText;
            avb = Int32.Parse(avb_l.Text);

            xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/coverage/name");
            coverage_txtbox.Text = xn.InnerText;
            

            xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/qualities");
            quality_textbox.Text = xn.InnerText;

            xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/pp");
            pp_l.Text = xn.InnerText;
            pp = Int32.Parse(pp_l.Text);

             xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/cost");
            cost_l.Text = xn.InnerText;

             xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/wt");
            wt_L.Text = xn.InnerText;
            weight = System.Xml.XmlConvert.ToDecimal(xn.InnerText);
           

            xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/restrictive");
            if (xn != null)
            {
                string str2 = xn.InnerText.ToString();
                restrictive = Int32.Parse(str2.ToString());
                Console.WriteLine(restrictive.ToString());
            }

            xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/layer");
            if (xn != null)
            {
                string str2 = xn.InnerText.ToString();
                layer = Int32.Parse(str2.ToString());
                Console.WriteLine(layer.ToString());
            }

            xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/coverage/location");

            char[] delimiterChars = { ' ', ',', '.', '[', ']' , '"', '\t'};
            string str;
            str = xn.InnerText.ToString();
            str = str.Replace(" ", String.Empty);
            str = str.Replace("[", String.Empty);
            str = str.Replace("]", String.Empty);
            int[] array = new int[str.Length];
            for(int i=0; i != str.Length; i++)
            {
                array = str.Split(',').Select(h => Int32.Parse(h)).ToArray();
            }
            long position;
            for(int i=0; i != array.Length; i++)
            {
                position = array[i];
                Console.Write("Array length " + coverage.ToString());
                coverage[position-1] = 2;
            }

            xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/coverage/halflocation");
            if (xn == null) { }
            else{
                str = xn.InnerText.ToString();
                str = str.Replace(" ", String.Empty);
                str = str.Replace("[", String.Empty);
                str = str.Replace("]", String.Empty);
                int[] array2 = new int[str.Length];
                for (int i = 0; i != str.Length; i++)
                {
                    array2 = str.Split(',').Select(h => Int32.Parse(h)).ToArray();
                }

                for (int i = 0; i != array2.Length; i++)
                {
                    position = array2[i];
                    coverage[position-1] = 1;
                }
            }
            /*
            for (int i=0; i != coverage.Length; i++)
            {
                Console.Write(coverage[i].ToString());
            }
            */
        





        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            if (comboBox.SelectedItem == "Helmets")
            {
                listBox.Items.Clear();
                var xnList = xdoc.SelectNodes("armor_manager/head_armor/armor");
                Console.WriteLine(xnList.Count.ToString());
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    listBox.Items.Add(name);
                }
            }
            else if(comboBox.SelectedItem == "Visors")
            {
                listBox.Items.Clear();
                var xnList = xdoc.SelectNodes("armor_manager/visors/armor");
                Console.WriteLine(xnList.Count.ToString());
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    listBox.Items.Add(name);
                }
            }
            else if(comboBox.SelectedItem == "Non-Helmet Head")
            {
                listBox.Items.Clear();
                var xnList = xdoc.SelectNodes("armor_manager/nonhelmet_head_armor/armor");
                Console.WriteLine(xnList.Count.ToString());
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    listBox.Items.Add(name);
                }
            }
            else if(comboBox.SelectedItem == "Neck")
            {
                listBox.Items.Clear();
                var xnList = xdoc.SelectNodes("armor_manager/neck/armor");
                Console.WriteLine(xnList.Count.ToString());
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    listBox.Items.Add(name);
                }
            }
            else if (comboBox.SelectedItem == "Torso")
            {
                listBox.Items.Clear();
                var xnList = xdoc.SelectNodes("armor_manager/torso/armor");
                Console.WriteLine(xnList.Count.ToString());
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    listBox.Items.Add(name);
                }
            }
            else if (comboBox.SelectedItem == "Arms")
            {
                listBox.Items.Clear();
                var xnList = xdoc.SelectNodes("armor_manager/arms/armor");
                Console.WriteLine(xnList.Count.ToString());
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    listBox.Items.Add(name);
                }
            }
            else if (comboBox.SelectedItem == "Legs")
            {
                listBox.Items.Clear();
                var xnList = xdoc.SelectNodes("armor_manager/legs/armor");
                Console.WriteLine(xnList.Count.ToString());
                foreach (XmlNode xn in xnList)
                {
                    string name = xn["name"].InnerText;
                    listBox.Items.Add(name);
                }
            }
        }



        public void accept_button_Click(object sender, EventArgs e)
        {
                if (listBox.SelectedItem != null)
                {
                int location = 0;
                string selected = comboBox.SelectedItem.ToString();
                switch (selected)
                {
                    case "Helmets": location = 0; break;
                    case "Visors": location = 0; break;
                    case "Neck": location = 0; break;
                    case "Non - Helmet Head": location = 0; break;
                    case "Torso": location = 1; break;
                    case "Arms": location = 2; break;
                    case "Legs": location = 3; break;
                }
                    
                    node_tree.Nodes[location].Nodes.Add(listBox.SelectedItem.ToString());
                    node_tree.Nodes[location].Expand();
                    armor_piece gear = new armor_piece();
                    gear.name = listBox.SelectedItem.ToString();
                    gear.avc = avc;
                    gear.avp = avp;
                    gear.avb = avb;
                    gear.wt = weight;
                    gear.pp = pp;
                    gear.coverage = coverage;
                    gear.layer = layer;
                    gear.restrictive = restrictive;
                    mainForm.add_armor(gear);
                    Close();
                    
                }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
