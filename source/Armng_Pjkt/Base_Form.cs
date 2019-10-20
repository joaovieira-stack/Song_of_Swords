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
    public partial class Base_Form : Form
    {


        public save_data data = new save_data();

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void avc1n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc2n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc3n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc4n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc5n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc6n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc7n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc8n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc9n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc10n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc19n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc20n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc11n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc12n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc13n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc14n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc15n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc16n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc17n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avc18n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp1n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void av2pn_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp3n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp4n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp5n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp6n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp7n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp8n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp9n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp10n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp19n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp20n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp11n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp12n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp13n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp14n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp15n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp16n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avp17n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void weighlabel_Click(object sender, EventArgs e)
        {

        }

        private void avp18n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb1n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb2n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb3n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb4n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb5n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb6n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb7n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb8n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb9n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb10n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb19n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb20n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb11n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb12n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb13n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb14n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb15n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb16n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb17n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }

        private void avb18n_ValueChanged(object sender, EventArgs e)
        {
            set_av_table();
        }


        XmlDocument xdoc = new XmlDocument();

    public Base_Form()
        {
            InitializeComponent();
         
            data.avc1 = 0;
            data.avc2 = 0;
            data.avc3 = 0;
            data.avc4 = 0;
            data.avc5 = 0;
            data.avc6 = 0;
            data.avc7 = 0;
            data.avc8 = 0;
            data.avc9 = 0;
            data.avc10 = 0;
            data.avc11 = 0;
            data.avc12 = 0;
            data.avc13 = 0;
            data.avc14 = 0;
            data.avc15 = 0;
            data.avc16 = 0;
            data.avc17 = 0;
            data.avc18 = 0;
            data.avc19 = 0;
            data.avc20 = 0;

            data.avp1 = 0;
            data.avp2 = 0;
            data.avp3 = 0;
            data.avp4 = 0;
            data.avp5 = 0;
            data.avp6 = 0;
            data.avp7 = 0;
            data.avp8 = 0;
            data.avp9 = 0;
            data.avp10 = 0;
            data.avp11 = 0;
            data.avp12 = 0;
            data.avp13 = 0;
            data.avp14 = 0;
            data.avp15 = 0;
            data.avp16 = 0;
            data.avp17 = 0;
            data.avp18 = 0;
            data.avp19 = 0;
            data.avp20 = 0;

            data.avb1 = 0;
            data.avb2 = 0;
            data.avb3 = 0;
            data.avb4 = 0;
            data.avb5 = 0;
            data.avb6 = 0;
            data.avb7 = 0;
            data.avb8 = 0;
            data.avb9 = 0;
            data.avb10 = 0;
            data.avb11 = 0;
            data.avb12 = 0;
            data.avb13 = 0;
            data.avb14 = 0;
            data.avb15 = 0;
            data.avb16 = 0;
            data.avb17 = 0;
            data.avb18 = 0;
            data.avb19 = 0;
            data.avb20 = 0;

            xml_load();
            set_av_table();
        }

    //Updates the values of the AV table to match the variable values//
    public void set_av_table()
        {
            listView1.Items[0].SubItems[1].Text = (data.avc1 + Int32.Parse(avc1n.Value.ToString())).ToString();
            listView1.Items[0].SubItems[2].Text = (data.avp1 + Int32.Parse(avp1n.Value.ToString())).ToString();
            listView1.Items[0].SubItems[3].Text = (data.avb1 + Int32.Parse(avb1n.Value.ToString())).ToString();

            listView1.Items[1].SubItems[1].Text = (data.avc2 + Int32.Parse(avc2n.Value.ToString())).ToString();
            listView1.Items[1].SubItems[2].Text = (data.avp2 + Int32.Parse(avp2n.Value.ToString())).ToString();
            listView1.Items[1].SubItems[3].Text = (data.avb2 + Int32.Parse(avb2n.Value.ToString())).ToString();

            listView1.Items[2].SubItems[1].Text = (data.avc3 + Int32.Parse(avc3n.Value.ToString())).ToString();
            listView1.Items[2].SubItems[2].Text = (data.avp3 + Int32.Parse(avp3n.Value.ToString())).ToString();
            listView1.Items[2].SubItems[3].Text = (data.avb3 + Int32.Parse(avb3n.Value.ToString())).ToString();

            listView1.Items[3].SubItems[1].Text = (data.avc4 + Int32.Parse(avc4n.Value.ToString())).ToString();
            listView1.Items[3].SubItems[2].Text = (data.avp4 + Int32.Parse(avp4n.Value.ToString())).ToString();
            listView1.Items[3].SubItems[3].Text = (data.avb4 + Int32.Parse(avb4n.Value.ToString())).ToString();

            listView1.Items[4].SubItems[1].Text = (data.avc5 + Int32.Parse(avc5n.Value.ToString())).ToString();
            listView1.Items[4].SubItems[2].Text = (data.avp5 + Int32.Parse(avp5n.Value.ToString())).ToString();
            listView1.Items[4].SubItems[3].Text = (data.avb5 + Int32.Parse(avb5n.Value.ToString())).ToString();

            listView1.Items[5].SubItems[1].Text = (data.avc6 + Int32.Parse(avc6n.Value.ToString())).ToString();
            listView1.Items[5].SubItems[2].Text = (data.avp6 + Int32.Parse(avp6n.Value.ToString())).ToString();
            listView1.Items[5].SubItems[3].Text = (data.avb6 + Int32.Parse(avb6n.Value.ToString())).ToString();

            listView1.Items[6].SubItems[1].Text = (data.avc7 + Int32.Parse(avc7n.Value.ToString())).ToString();
            listView1.Items[6].SubItems[2].Text = (data.avp7 + Int32.Parse(avp7n.Value.ToString())).ToString();
            listView1.Items[6].SubItems[3].Text = (data.avb7 + Int32.Parse(avb7n.Value.ToString())).ToString();

            listView1.Items[7].SubItems[1].Text = (data.avc8 + Int32.Parse(avc8n.Value.ToString())).ToString();
            listView1.Items[7].SubItems[2].Text = (data.avp8 + Int32.Parse(avp8n.Value.ToString())).ToString();
            listView1.Items[7].SubItems[3].Text = (data.avb8 + Int32.Parse(avb8n.Value.ToString())).ToString();

            listView1.Items[8].SubItems[1].Text = (data.avc9 + Int32.Parse(avc9n.Value.ToString())).ToString();
            listView1.Items[8].SubItems[2].Text = (data.avp9 + Int32.Parse(avp9n.Value.ToString())).ToString();
            listView1.Items[8].SubItems[3].Text = (data.avb9 + Int32.Parse(avb9n.Value.ToString())).ToString();

            listView1.Items[9].SubItems[1].Text = (data.avc10 + Int32.Parse(avc10n.Value.ToString())).ToString();
            listView1.Items[9].SubItems[2].Text = (data.avp10+ Int32.Parse(avp10n.Value.ToString())).ToString();
            listView1.Items[9].SubItems[3].Text = (data.avb10 + Int32.Parse(avb10n.Value.ToString())).ToString();

            listView1.Items[10].SubItems[1].Text = (data.avc11 + Int32.Parse(avc11n.Value.ToString())).ToString();
            listView1.Items[10].SubItems[2].Text = (data.avp11 + Int32.Parse(avp11n.Value.ToString())).ToString();
            listView1.Items[10].SubItems[3].Text = (data.avb11 + Int32.Parse(avb11n.Value.ToString())).ToString();

            listView1.Items[11].SubItems[1].Text = (data.avc12 + Int32.Parse(avc12n.Value.ToString())).ToString();
            listView1.Items[11].SubItems[2].Text = (data.avp12 + Int32.Parse(avp12n.Value.ToString())).ToString();
            listView1.Items[11].SubItems[3].Text = (data.avb12 + Int32.Parse(avb12n.Value.ToString())).ToString();

            listView1.Items[12].SubItems[1].Text = (data.avc13 + Int32.Parse(avc13n.Value.ToString())).ToString();
            listView1.Items[12].SubItems[2].Text = (data.avp13 + Int32.Parse(avp13n.Value.ToString())).ToString();
            listView1.Items[12].SubItems[3].Text = (data.avb13 + Int32.Parse(avb13n.Value.ToString())).ToString();

            listView1.Items[13].SubItems[1].Text = (data.avc14 + Int32.Parse(avc14n.Value.ToString())).ToString();
            listView1.Items[13].SubItems[2].Text = (data.avp14 + Int32.Parse(avp14n.Value.ToString())).ToString();
            listView1.Items[13].SubItems[3].Text = (data.avb14 + Int32.Parse(avb14n.Value.ToString())).ToString();

            listView1.Items[14].SubItems[1].Text = (data.avc15 + Int32.Parse(avc15n.Value.ToString())).ToString();
            listView1.Items[14].SubItems[2].Text = (data.avp15 + Int32.Parse(avp15n.Value.ToString())).ToString();
            listView1.Items[14].SubItems[3].Text = (data.avb15 + Int32.Parse(avb15n.Value.ToString())).ToString();

            listView1.Items[15].SubItems[1].Text = (data.avc16 + Int32.Parse(avc16n.Value.ToString())).ToString();
            listView1.Items[15].SubItems[2].Text = (data.avp16 + Int32.Parse(avp16n.Value.ToString())).ToString();
            listView1.Items[15].SubItems[3].Text = (data.avb16 + Int32.Parse(avb16n.Value.ToString())).ToString();

            listView1.Items[16].SubItems[1].Text = (data.avc17 + Int32.Parse(avc17n.Value.ToString())).ToString();
            listView1.Items[16].SubItems[2].Text = (data.avp17 + Int32.Parse(avp17n.Value.ToString())).ToString();
            listView1.Items[16].SubItems[3].Text = (data.avb17 + Int32.Parse(avb17n.Value.ToString())).ToString();

            listView1.Items[17].SubItems[1].Text = (data.avc18 + Int32.Parse(avc18n.Value.ToString())).ToString();
            listView1.Items[17].SubItems[2].Text = (data.avp18 + Int32.Parse(avp18n.Value.ToString())).ToString();
            listView1.Items[17].SubItems[3].Text = (data.avb18 + Int32.Parse(avb18n.Value.ToString())).ToString();

            listView1.Items[18].SubItems[1].Text = (data.avc19 + Int32.Parse(avc19n.Value.ToString())).ToString();
            listView1.Items[18].SubItems[2].Text = (data.avp19 + Int32.Parse(avp19n.Value.ToString())).ToString();
            listView1.Items[18].SubItems[3].Text = (data.avb19 + Int32.Parse(avb19n.Value.ToString())).ToString();

            listView1.Items[19].SubItems[1].Text = (data.avc20 + Int32.Parse(avc20n.Value.ToString())).ToString();
            listView1.Items[19].SubItems[2].Text = (data.avp20 + Int32.Parse(avp20n.Value.ToString())).ToString();
            listView1.Items[19].SubItems[3].Text = (data.avb20 + Int32.Parse(avb20n.Value.ToString())).ToString();

        }

    private void xml_load()
    {
        xdoc.Load(@"armor.xml");

    }

    private void addArmorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void l3add_button_Click(object sender, EventArgs e)
        {
            Armor_Picker window = new Armor_Picker(this, this.treeView_l1);
            window.Show();
        }

        private void l2_addbutton_Click(object sender, EventArgs e)
        {
            Armor_Picker window = new Armor_Picker(this, this.treeView_l1);
            window.Show();
        }

        private void l1_addbutton_Click(object sender, EventArgs e)
        {
            Armor_Picker window = new Armor_Picker(this, this.treeView_l1);
            window.Show();
        }

        public void treeView_l1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string name = treeView_l1.SelectedNode.Text;
            if (name != "Head" && name != "Torso" && name != "Arms" && name != "Legs" )
            {

                XmlNode xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/type");
                type.Text = xn.InnerText;

                xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/avc");
                avc_l.Text = xn.InnerText;

                xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/avp");
                avp_l.Text = xn.InnerText;

                xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/avb");
                avb_l.Text = xn.InnerText;

                xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/coverage/name");
                coverage_txtbox.Text = xn.InnerText;

                xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/qualities");
                quality_textbox.Text = xn.InnerText;

                xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/pp");
                pp_l.Text = xn.InnerText;

                xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/cost");
                cost_l.Text = xn.InnerText;

                xn = xdoc.SelectSingleNode("//armor[@id='" + name + "']/wt");
                wt_L.Text = xn.InnerText;
            }
        }

        private void remove_node_Click(object sender, EventArgs e)
        {
            if (treeView_l1.SelectedNode != null)
            {
                if (treeView_l1.SelectedNode.Parent != null)
                {
                    Console.WriteLine("Entered");
                    string str = treeView_l1.SelectedNode.Text.ToString();
                    if (data.armor_list.Count == 0)
                    {
                        data.armor_list.RemoveAt(0);
                        for (int j = 0; j != 20; j++)
                        {
                            location_avc_set(j, 0);
                            location_avp_set(j, 0);
                            location_avb_set(j, 0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i != data.armor_list.Count; i++)
                        {
                                if (data.armor_list[i].name == str)
                                {
                                    Console.WriteLine("Name Found");
                                    data.armor_list.RemoveAt(i);
                                    Console.WriteLine("List has " + data.armor_list.Count.ToString() + " elements");
                                    for (int j = 0; j != 20; j++)
                                    {
                                        location_avc_set(j, 0);
                                        location_avp_set(j, 0);
                                        location_avb_set(j, 0);
                                    }
                                break;
                                }
                            
                        }
                    }
                    int[] highest_avc = new int[20];
                    int[] highest_avp = new int[20];
                    int[] highest_avb = new int[20];
                    data.weight = 0;
                    data.pp = 0;
                    for (int i = 0; i != data.armor_list.Count; i++)
                    {
                        data.pp += data.armor_list[i].pp;
                        data.weight += data.armor_list[i].wt;
                        for (int j = 0; j != data.armor_list[i].coverage.Length; j++)
                        {
                            if (data.armor_list[i].coverage[j] == 2)
                            {
                                if (highest_avc[j] > data.armor_list[i].avc)
                                {

                                }
                                else
                                {
                                    highest_avc[j] = data.armor_list[i].avc;
                                }
                                if (highest_avp[j] > data.armor_list[i].avp)
                                {

                                }
                                else
                                {
                                    highest_avp[j] = data.armor_list[i].avp;
                                }
                                if (highest_avb[j] > data.armor_list[i].avb)
                                {

                                }
                                else
                                {
                                    highest_avb[j] = data.armor_list[i].avb;
                                }
                            }
                            if (data.armor_list[i].coverage[j] == 1)
                            {
                                if (highest_avc[j] > data.armor_list[i].avc / 2)
                                {

                                }
                                else
                                {
                                    highest_avc[j] = data.armor_list[i].avc / 2;
                                }
                                if (highest_avp[j] > data.armor_list[i].avp / 2)
                                {

                                }
                                else
                                {
                                    highest_avp[j] = data.armor_list[i].avp / 2;
                                }
                                if (highest_avb[j] > data.armor_list[i].avb / 2)
                                {

                                }
                                else
                                {
                                    highest_avb[j] = data.armor_list[i].avb / 2;
                                }
                            }

                        }
                    }

                    pplabel.Text = data.pp.ToString();
                    weighlabel.Text = data.weight.ToString();

                    for (int j = 0; j != 20; j++)
                    {
                        location_avc_set(j, highest_avc[j]);
                        location_avp_set(j, highest_avp[j]);
                        location_avb_set(j, highest_avb[j]);
                    }

                    treeView_l1.SelectedNode.Remove();
                    set_av_table();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void add_armor(armor_piece armor)
        {
            if (data.armor_list.Any())
            {
                bool higher_avc_found = false;
                bool higher_avp_found = false;
                bool higher_avb_found = false;
                int coverage_type = 0;
                data.weight += armor.wt;
                data.pp += armor.pp;
                for (int i = 0; i != armor.coverage.Length; i++)
                {
                    
                    coverage_type = armor.coverage[i];
                    //Runs through the armors in the list//
                    for (int j = 0; j != data.armor_list.Count; j++)
                    {
                        
                        //Runs through the coverage array of the current armor in the list//
                        for (int c = 0; c != data.armor_list[j].coverage.Length; c++)
                        {
                            
                            //Checks if its full or half coverage//
                            if (coverage_type == 2 && data.armor_list[j].coverage[c] == 2) ////////////////////////LANDMARK////////////////////
                            {
                                Console.WriteLine(armor.name + "on position" + i.ToString() + " being Compared with " + data.armor_list[j].name + "  at location " + c.ToString());
                                if (armor.avc >= data.armor_list[j].avc)
                                {
                                    
                                }
                                else
                                {
                                    higher_avc_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVC");                                   
                                }
                                if (armor.avp >= data.armor_list[j].avp)
                                {
                                   
                                }
                                else
                                {
                                    higher_avp_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVP");
                                }
                                if (armor.avb >= data.armor_list[j].avb)
                                {
                                   
                                }
                                else
                                {
                                    higher_avb_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVB");
                                }


                            }
                            if (coverage_type == 1 && data.armor_list[j].coverage[c] == 1)////////////////////////LANDMARK////////////////////
                            {
                                Console.WriteLine(armor.name + " on position" + i.ToString() + " being Compared with " + data.armor_list[j].name + "  at location " + c.ToString());
                                int temp_avc = armor.avc / 2;
                                int temp_avb = armor.avb / 2;
                                int temp_avp = armor.avp / 2;
                                if (temp_avc >= (data.armor_list[j].avc / 2))
                                {
                                   
                                }
                                else
                                {
                                    higher_avc_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVC");
                                }
                                if (temp_avp >= (data.armor_list[j].avp / 2))
                                {
                                    
                                }
                                else
                                {
                                    higher_avp_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVP");
                                }
                                if (temp_avb >= (data.armor_list[j].avb / 2))
                                {
                                    
                                }
                                else
                                {
                                    higher_avb_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVB");
                                }

                            }
                            if (coverage_type == 1 && data.armor_list[j].coverage[c] == 2) ////////////////////////LANDMARK////////////////////
                            {
                                Console.WriteLine(armor.name + " on position" + i.ToString() + " being Compared with " + data.armor_list[j].name + "  at location " + c.ToString());
                                int temp_avc = armor.avc / 2;
                                int temp_avp = armor.avp / 2;
                                int temp_avb = armor.avb / 2;
                                if (temp_avc >= data.armor_list[j].avc)
                                {
                                    
                                }
                                else
                                {
                                    higher_avc_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVC");
                                }
                                if (temp_avp >= data.armor_list[j].avp)
                                {
                                    
                                }
                                else
                                {
                                    higher_avp_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVP");
                                }

                                if (temp_avb >= data.armor_list[j].avb)
                                {
                                   
                                }
                                else
                                {
                                    higher_avb_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVB");
                                }

                            }
                            if (coverage_type == 2 && data.armor_list[j].coverage[c] == 1) ////////////////////////LANDMARK////////////////////
                            {
                                Console.WriteLine(armor.name + " on position" + i.ToString() + " being Compared with " + data.armor_list[j].name + "  at location " + c.ToString());
                                if (armor.avc >= (data.armor_list[j].avc / 2))
                                {
                                    
                                }
                                else
                                {
                                    higher_avc_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVC");
                                }
                                if (armor.avp >= (data.armor_list[j].avp / 2))
                                {
                                    
                                }
                                else
                                {
                                    higher_avp_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVP");
                                }
                                if (armor.avb >= (data.armor_list[j].avb / 2))
                                {
                                    
                                }
                                else
                                {
                                    higher_avb_found = true;
                                    Console.WriteLine(armor.name + "has found a greater AVB");
                                }

                            }
                        }


                        if (coverage_type == 2 && location_grab(i) == 0) ////////////////////////LANDMARK////////////////////
                        {
                            Console.WriteLine("Entered 2-0, Populating Empty Sockets at " + i.ToString()+", set at " + i.ToString());
                            location_avc_set(i, armor.avc);
                            location_avp_set(i, armor.avp);
                            location_avb_set(i, armor.avb);
                        }
                        if (coverage_type == 1 && location_grab(i) == 0) ////////////////////////LANDMARK////////////////////
                        {
                            Console.WriteLine("Entered 1-0, Populating Empty Sockets, set at "+ i.ToString());
                            int temp_avc = armor.avc / 2;
                            int temp_avp = armor.avp / 2;
                            int temp_avb = armor.avb / 2;
                            location_avc_set(i, temp_avc);
                            location_avp_set(i, temp_avp);
                            location_avb_set(i, temp_avb);
                        }

                    }

                    if (higher_avc_found == false)
                    {
                        Console.WriteLine("          \n");
                        Console.WriteLine("Type: AVP being set for " + armor.name + "  Location: " + i.ToString() + "  Coverage Type: " + coverage_type.ToString());
                        if(coverage_type == 1)
                        location_avc_set(i, armor.avc/2);
                        else if(coverage_type == 2)
                            location_avc_set(i, armor.avc);
                    }
                    if (higher_avp_found == false)
                    {
                        Console.WriteLine("Type: AVC being set for " + armor.name + "  Location: " + i.ToString() + "  Coverage Type: " + coverage_type.ToString());
                        if (coverage_type == 1)
                            location_avp_set(i, armor.avp/2);
                        else if (coverage_type == 2)
                            location_avp_set(i, armor.avp);
                    }
                    if(higher_avb_found == false)
                    {
                        Console.WriteLine("Type: AVB being set for " + armor.name + "  Location: " + i.ToString() + "  Coverage Type: " + coverage_type.ToString());
                        if (coverage_type == 1)
                            location_avb_set(i, armor.avb/2);
                        else if (coverage_type == 2)
                            location_avb_set(i, armor.avb);
                    }       
                }     
             }
                            
            else if(!data.armor_list.Any())
            {
                data.pp += armor.pp;
                data.weight += armor.wt;
                int coverage_type = 0;
                for(int i = 0; i != armor.coverage.Length; i++)
                {
                    coverage_type = armor.coverage[i];
                    if (coverage_type == 1)
                    {
                        int temp_avc = armor.avc / 2;
                        int temp_avp = armor.avp / 2;
                        int temp_avb = armor.avb / 2;
                        switch (i)
                        {
                            case 0: data.avc1 = temp_avc; data.avp1 = temp_avp; data.avb1 = temp_avb; break;
                            case 1: data.avc2 = temp_avc; data.avp2 = temp_avp; data.avb2 = temp_avb; break;
                            case 2: data.avc3 = temp_avc; data.avp3 = temp_avp; data.avb3 = temp_avb; break;
                            case 3: data.avc4 = temp_avc; data.avp4 = temp_avp; data.avb4 = temp_avb; break;
                            case 4: data.avc5 = temp_avc; data.avp5 = temp_avp; data.avb5 = temp_avb; break;
                            case 5: data.avc6 = temp_avc; data.avp6 = temp_avp; data.avb6 = temp_avb; break;
                            case 6: data.avc7 = temp_avc; data.avp7 = temp_avp; data.avb7 = temp_avb; break;
                            case 7: data.avc8 = temp_avc; data.avp8 = temp_avp; data.avb8 = temp_avb; break;
                            case 8: data.avc9 = temp_avc; data.avp9 = temp_avp; data.avb9 = temp_avb; break;
                            case 9: data.avc10 = temp_avc; data.avp10 = temp_avp; data.avb10 = temp_avb; break;
                            case 10: data.avc11 = temp_avc; data.avp11 = temp_avp; data.avb11 = temp_avb; break;
                            case 11: data.avc12 = temp_avc; data.avp12 = temp_avp; data.avb12 = temp_avb; break;
                            case 12: data.avc13 = temp_avc; data.avp13 = temp_avp; data.avb13 = temp_avb; break;
                            case 13: data.avc14 = temp_avc; data.avp14 = temp_avp; data.avb14 = temp_avb; break;
                            case 14: data.avc15 = temp_avc; data.avp15 = temp_avp; data.avb15 = temp_avb; break;
                            case 15: data.avc16 = temp_avc; data.avp16 = temp_avp; data.avb16 = temp_avb; break;
                            case 16: data.avc17 = temp_avc; data.avp17 = temp_avp; data.avb17 = temp_avb; break;
                            case 17: data.avc18 = temp_avc; data.avp18 = temp_avp; data.avb18 = temp_avb; break;
                            case 18: data.avc19 = temp_avc; data.avp19 = temp_avp; data.avb19 = temp_avb; break;
                            case 28: data.avc20 = temp_avc; data.avp20 = temp_avp; data.avb20 = temp_avb; break;
                            default: break;
                        }
                    }
                    else if (coverage_type == 2)
                    {
                        switch (i)
                        {
                            case 0: data.avc1 = armor.avc; data.avp1 = armor.avp; data.avb1 = armor.avb; break;
                            case 1: data.avc2 = armor.avc; data.avp2 = armor.avp; data.avb2 = armor.avb; break;
                            case 2: data.avc3 = armor.avc; data.avp3 = armor.avp; data.avb3 = armor.avb; break;
                            case 3: data.avc4 = armor.avc; data.avp4 = armor.avp; data.avb4 = armor.avb; break;
                            case 4: data.avc5 = armor.avc; data.avp5 = armor.avp; data.avb5 = armor.avb; break;
                            case 5: data.avc6 = armor.avc; data.avp6 = armor.avp; data.avb6 = armor.avb; break;
                            case 6: data.avc7 = armor.avc; data.avp7 = armor.avp; data.avb7 = armor.avb; break;
                            case 7: data.avc8 = armor.avc; data.avp8 = armor.avp; data.avb8 = armor.avb; break;
                            case 8: data.avc9 = armor.avc; data.avp9 = armor.avp; data.avb9 = armor.avb; break;
                            case 9: data.avc10 = armor.avc; data.avp10 = armor.avp; data.avb10 = armor.avb; break;
                            case 10: data.avc11 = armor.avc; data.avp11 = armor.avp; data.avb11 = armor.avb; break;
                            case 11: data.avc12 = armor.avc; data.avp12 = armor.avp; data.avb12 = armor.avb; break;
                            case 12: data.avc13 = armor.avc; data.avp13 = armor.avp; data.avb13 = armor.avb; break;
                            case 13: data.avc14 = armor.avc; data.avp14 = armor.avp; data.avb14 = armor.avb; break;
                            case 14: data.avc15 = armor.avc; data.avp15 = armor.avp; data.avb15 = armor.avb; break;
                            case 15: data.avc16 = armor.avc; data.avp16 = armor.avp; data.avb16 = armor.avb; break;
                            case 16: data.avc17 = armor.avc; data.avp17 = armor.avp; data.avb17 = armor.avb; break;
                            case 17: data.avc18 = armor.avc; data.avp18 = armor.avp; data.avb18 = armor.avb; break;
                            case 18: data.avc19 = armor.avc; data.avp19 = armor.avp; data.avb19 = armor.avb; break;
                            case 19: data.avc20 = armor.avc; data.avp20 = armor.avp; data.avb20 = armor.avb; break;
                            default: break;
                        }
                    }
                    else
                    {

                    }
                }
            }
            set_av_table();
            weighlabel.Text = data.weight.ToString();
            pplabel.Text = "-" + data.pp.ToString();
            data.armor_list.Add(armor);
           
        }

        public void location_avc_set(int location, int value)
        {
            switch (location)
            {
                case 0: data.avc1 = value ; break;
                case 1: data.avc2 = value ; break;
                case 2: data.avc3 = value ; break;
                case 3: data.avc4 = value ; break;
                case 4: data.avc5 = value ; break;
                case 5: data.avc6 = value ; break;
                case 6: data.avc7 = value ; break;
                case 7: data.avc8 = value ; break;
                case 8: data.avc9 = value ; break;
                case 9: data.avc10 = value ; break;
                case 10: data.avc11 = value ; break;
                case 11: data.avc12 = value ; break;
                case 12: data.avc13 = value ; break;
                case 13: data.avc14 = value ; break;
                case 14: data.avc15 = value ; break;
                case 15: data.avc16 = value ; break;
                case 16: data.avc17 = value ; break;
                case 17: data.avc18 = value ; break;
                case 18: data.avc19 = value ; break;
                case 19: data.avc20 = value ; break;
                default: break;
            }
        }
        public void location_avp_set(int location, int value)
        {
            switch (location)
            {
                case 0: data.avp1 = value ; break;
                case 1: data.avp2 = value ; break;
                case 2: data.avp3 = value ; break;
                case 3: data.avp4 = value ; break;
                case 4: data.avp5 = value ; break;
                case 5: data.avp6 = value ; break;
                case 6: data.avp7 = value ; break;
                case 7: data.avp8 = value ; break;
                case 8: data.avp9 = value ; break;
                case 9: data.avp10 = value ; break;
                case 10: data.avp11 = value ; break;
                case 11: data.avp12 = value ; break;
                case 12: data.avp13 = value ; break;
                case 13: data.avp14 = value ; break;
                case 14: data.avp15 = value ; break;
                case 15: data.avp16 = value ; break;
                case 16: data.avp17 = value ; break;
                case 17: data.avp18 = value ; break;
                case 18: data.avp19 = value ; break;
                case 19: data.avp20 = value ; break;
                default: break;
            }
        }
        public void location_avb_set(int location, int value)
        {
            switch (location)
            {
                case 0: data.avb1 = value ; break;
                case 1: data.avb2 = value ; break;
                case 2: data.avb3 = value ; break;
                case 3: data.avb4 = value ; break;
                case 4: data.avb5 = value ; break;
                case 5: data.avb6 = value ; break;
                case 6: data.avb7 = value ; break;
                case 7: data.avb8 = value ; break;
                case 8: data.avb9 = value ; break;
                case 9: data.avb10 = value ; break;
                case 10: data.avb11 = value ; break;
                case 11: data.avb12 = value ; break;
                case 12: data.avb13 = value ; break;
                case 13: data.avb14 = value ; break;
                case 14: data.avb15 = value ; break;
                case 15: data.avb16 = value ; break;
                case 16: data.avb17 = value ; break;
                case 17: data.avb18 = value ; break;
                case 18: data.avb19 = value ; break;
                case 19: data.avb20 = value ; break;
                default: break;
            }
        }


        //Grabs a numerical value returns the AV at that location/
        public int location_grab(int location)
        {
            switch (location)
            {
                case 0: ; return data.avb1; 
                case 1: ; return data.avb2; 
                case 2: ; return data.avb3; 
                case 3: ; return data.avb4; 
                case 4: ; return data.avb5; 
                case 5: ; return data.avb6; 
                case 6: ; return data.avb7; 
                case 7: ; return data.avb8; 
                case 8: ; return data.avb9; 
                case 9: ; return data.avb10; 
                case 10: ; return data.avb11; 
                case 11: ; return data.avb12; 
                case 12: ; return data.avb13; 
                case 13: ; return data.avb14; 
                case 14: ; return data.avb15; 
                case 15: ; return data.avb16; 
                case 16: ; return data.avb17; 
                case 17: ; return data.avb18; 
                case 18: ; return data.avb19; 
                case 19: ; return data.avb20; 
                default: return 0; 
            }
        }

        public void set_layer_avc(int location, int value)
        {
            Console.WriteLine("Location: " + location.ToString() + "  Layer Bonus: "+ value.ToString());
            switch (location)
            {
                case 0: data.avc1 += value; break;
                case 1: data.avc2 += value; break;
                case 2: data.avc3 += value; break;
                case 3: data.avc4 += value; break;
                case 4: data.avc5 += value; break;
                case 5: data.avc6 += value; break;
                case 6: data.avc7 += value; break;
                case 7: data.avc8 += value; break;
                case 8: data.avc9 += value; break;
                case 9: data.avc10 += value; break;
                case 10: data.avc11 += value; break;
                case 11: data.avc12 += value; break;
                case 12: data.avc13 += value; break;
                case 13: data.avc14 += value; break;
                case 14: data.avc15 += value; break;
                case 15: data.avc16 += value; break;
                case 16: data.avc17 += value; break;
                case 17: data.avc18 += value; break;
                case 18: data.avc19 += value; break;
                case 19: data.avc20 += value; break;
                default: break;
            }
        }
        public void set_layer_avp(int location, int value)
        {
            switch (location)
            {
                case 0: data.avp1 += value; break;
                case 1: data.avp2 += value; break;
                case 2: data.avp3 += value; break;
                case 3: data.avp4 += value; break;
                case 4: data.avp5 += value; break;
                case 5: data.avp6 += value; break;
                case 6: data.avp7 += value; break;
                case 7: data.avp8 += value; break;
                case 8: data.avp9 += value; break;
                case 9: data.avp10 += value; break;
                case 10: data.avp11 += value; break;
                case 11: data.avp12 += value; break;
                case 12: data.avp13 += value; break;
                case 13: data.avp14 += value; break;
                case 14: data.avp15 += value; break;
                case 15: data.avp16 += value; break;
                case 16: data.avp17 += value; break;
                case 17: data.avp18 += value; break;
                case 18: data.avp19 += value; break;
                case 19: data.avp20 += value; break;
                default: break;
            }
        }
        public void set_layer_avb(int location, int value)
        {
            switch (location)
            {
                case 0: data.avb1 += value; break;
                case 1: data.avb2 += value; break;
                case 2: data.avb3 += value; break;
                case 3: data.avb4 += value; break;
                case 4: data.avb5 += value; break;
                case 5: data.avb6 += value; break;
                case 6: data.avb7 += value; break;
                case 7: data.avb8 += value; break;
                case 8: data.avb9 += value; break;
                case 9: data.avb10 += value; break;
                case 10: data.avb11 += value; break;
                case 11: data.avb12 += value; break;
                case 12: data.avb13 += value; break;
                case 13: data.avb14 += value; break;
                case 14: data.avb15 += value; break;
                case 15: data.avb16 += value; break;
                case 16: data.avb17 += value; break;
                case 17: data.avb18 += value; break;
                case 18: data.avb19 += value; break;
                case 19: data.avb20 += value; break;
                default: break;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                data.nodes = treeView_l1.Nodes.Cast<TreeNode>().ToList();
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(saveFileDialog1.FileName + ".amc", FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, data);
                stream.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                save_data data2 = new save_data();
                data2 = (save_data)formatter.Deserialize(stream);
                data = data2;
                treeView_l1.Nodes.Clear();
                treeView_l1.Nodes.AddRange(data.nodes.ToArray());
                Console.WriteLine("AVC on avc1 of data2 is: " + data2.avc1.ToString());         
                stream.Close();
            }
            
            set_av_table();
            weighlabel.Text = data.weight.ToString();
            pplabel.Text = "-" + data.pp.ToString();
        }
    }

}
