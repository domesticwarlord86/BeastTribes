using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ff14bot.Enums;
using ff14bot.Helpers;
using ff14bot.Managers;
using LlamaLibrary.Extensions;

namespace BeastTribes
{
    public partial class BeastTribesSettingsForm : Form
    {
        public static bool loading = false;
        public BeastTribesSettingsForm()
        {
        
            InitializeComponent();

            loading = true;
            int selection;
            // Activate Amalj'aa drop down
            var amaljaalist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                amaljaalist.Add(new KeyValuePair<string,ClassJobType>(gs.Class.ToString(),gs.Class));
            }

            comboBox5.DataSource = amaljaalist;
            comboBox5.DisplayMember = "Key";
            selection = amaljaalist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.ArrSettings.AmalaJaaClass);
            comboBox5.SelectedIndex = selection == -1 ? 0 : selection;

            // Activate Kobold drop down
            var koboldlist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                koboldlist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            comboBox8.DataSource = koboldlist;
            comboBox8.DisplayMember = "Key";
            selection = koboldlist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.ArrSettings.KoboldsClass);
            comboBox8.SelectedIndex = selection == -1 ? 0 : selection;
            
            
            
            // Activate Sylphs drop down
            var sylphlist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                sylphlist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            comboBox6.DataSource = sylphlist;
            comboBox6.DisplayMember = "Key";
            selection = sylphlist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.ArrSettings.SylphsClass);
            comboBox6.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Sahagin drop down
            var sahaginlist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                sahaginlist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            comboBox9.DataSource = sahaginlist;
            comboBox9.DisplayMember = "Key";
            selection = sahaginlist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.ArrSettings.SahaginClass);
            comboBox9.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Ixal drop down
            var ixallist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDoh()))
            {
                ixallist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            comboBox7.DataSource = ixallist;
            comboBox7.DisplayMember = "Key";
            selection = ixallist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.ArrSettings.IxalClass);
            comboBox7.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Vanu drop down
            var vanulist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                vanulist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            comboBox2.DataSource = vanulist;
            comboBox2.DisplayMember = "Key";
            selection = vanulist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.HWSettings.VanuClass);
            comboBox2.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Vath drop down
            var vathlist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                vathlist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            comboBox3.DataSource = vathlist;
            comboBox3.DisplayMember = "Key";
            selection = vathlist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.HWSettings.VathClass);
            comboBox3.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Moogle drop down
            var mooglelist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDoh()))
            {
                mooglelist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            comboBox4.DataSource = mooglelist;
            comboBox4.DisplayMember = "Key";
            selection = mooglelist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.HWSettings.MooglesClass);
            comboBox4.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Kojin drop down
            var kojinlist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                kojinlist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            kojinComboBox.DataSource = kojinlist;
            kojinComboBox.DisplayMember = "Key";
            selection = kojinlist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.SBSettings.KojinClass);
            kojinComboBox.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Ananta drop down
            var anantalist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                anantalist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            anantaComboBox.DataSource = anantalist;
            anantaComboBox.DisplayMember = "Key";
            selection = anantalist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.SBSettings.AnantaClass);
            anantaComboBox.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Namazu drop down
            var namazulist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDoh()))
            {
                namazulist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            comboBox1.DataSource = namazulist;
            comboBox1.DisplayMember = "Key";
            selection = namazulist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.SBSettings.NamazuClass);
            comboBox1.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Pixie drop down
            var pixielist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDow() && i.Class != ClassJobType.BlueMage))
            {
                pixielist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            pixiesComboBox1.DataSource = pixielist;
            pixiesComboBox1.DisplayMember = "Key";
            selection = pixielist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.ShBSettings.PixiesClass);
            pixiesComboBox1.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Qitari drop down
            var qitarilist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDol()))
            {
                qitarilist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            qitariComboBox1.DataSource = qitarilist;
            qitariComboBox1.DisplayMember = "Key";
            selection = qitarilist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.ShBSettings.QitariClass);
            qitariComboBox1.SelectedIndex = selection == -1 ? 0 : selection;
            
            // Activate Dwarves drop down
            var dwarveslist = new List<KeyValuePair<string, ClassJobType>>();
            foreach (var gs in GearsetManager.GearSets.Where(i=> i.InUse && i.Class.IsDoh()))
            {
                dwarveslist.Add(new KeyValuePair<string, ClassJobType>(gs.Class.ToString(),gs.Class));
            }
            
            dwarvesComboBox.DataSource = dwarveslist;
            dwarvesComboBox.DisplayMember = "Key";
            selection = dwarveslist.FindIndex(i => i.Value == (ClassJobType)BeastTribesSettings.Instance.ShBSettings.DwarvesClass);
            dwarvesComboBox.SelectedIndex = selection == -1 ? 0 : selection;
            
            
            //HERE
            //Amaljaa
            checkBox5.Checked = BeastTribes.BeastTribesSettings.ArrSettings.AmaljaaEnabled;
            //Kobolds
            checkBox8.Checked = BeastTribes.BeastTribesSettings.ArrSettings.KoboldsEnabled;
            //Slyphs
            checkBox6.Checked = BeastTribes.BeastTribesSettings.ArrSettings.SylphsEnabled;
            //Sahagin
            checkBox9.Checked = BeastTribes.BeastTribesSettings.ArrSettings.SahaginEnabled;
            //Ixal
            checkBox7.Checked = BeastTribes.BeastTribesSettings.ArrSettings.IxalEnabled;
            
            //Vanu
            checkBox2.Checked = BeastTribes.BeastTribesSettings.HWSettings.VanuEnabled;
            //Vath
            checkBox3.Checked = BeastTribes.BeastTribesSettings.HWSettings.VathEnabled;
            //Moogles
            checkBox4.Checked = BeastTribes.BeastTribesSettings.HWSettings.MooglesEnabled;
            
            //Kojin
            kojinCheckBox.Checked = BeastTribes.BeastTribesSettings.SBSettings.KojinEnabled;
            //Ananta
            anantaCheckBox.Checked = BeastTribes.BeastTribesSettings.SBSettings.AnantaEnabled;
            //Namazu
            checkBox1.Checked = BeastTribes.BeastTribesSettings.SBSettings.NamazuEnabled;
            
            // Pixies
            pixiesChckBox1.Checked = BeastTribes.BeastTribesSettings.ShBSettings.PixiesEnabled;
            // Qitari
            qitariCheckBox1.Checked = BeastTribes.BeastTribesSettings.ShBSettings.QitariEnabled;
            // Dwarves
            checkBoxDwarves.Checked = BeastTribes.BeastTribesSettings.ShBSettings.DwarvesEnabled;

            loading = false;

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void BeastTribesSettingsForm_Load(object sender, EventArgs e)
        {
            //propertyGrid1.SelectedObject = BeastTribes.BeastTribesSettings.ArrSettings;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
        

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label17_Click_1(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        // Amalj'aa
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.AmalaJaaClass = ((KeyValuePair<string, ClassJobType>)comboBox5.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox5.Refresh();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.AmaljaaEnabled = checkBox5.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Kobalds

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.KoboldsClass = ((KeyValuePair<string, ClassJobType>)comboBox8.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox8.Refresh();
        }
        
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.KoboldsEnabled = checkBox8.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }
        
        // Sylphs

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.SylphsEnabled = checkBox6.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.SylphsClass = ((KeyValuePair<string, ClassJobType>)comboBox6.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox6.Refresh();
        }

        // Sahagin
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.SahaginClass = ((KeyValuePair<string, ClassJobType>)comboBox9.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox9.Refresh();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.SahaginEnabled = checkBox9.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Ixal
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.IxalClass= ((KeyValuePair<string, ClassJobType>)comboBox7.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox7.Refresh();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ArrSettings.IxalEnabled = checkBox7.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Vanu Vanu
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.HWSettings.VanuClass= ((KeyValuePair<string, ClassJobType>)comboBox2.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox2.Refresh();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.HWSettings.VanuEnabled = checkBox2.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Vath
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.HWSettings.VathClass= ((KeyValuePair<string, ClassJobType>)comboBox3.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox3.Refresh();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.HWSettings.VathEnabled = checkBox3.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Moogles
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.HWSettings.MooglesClass= ((KeyValuePair<string, ClassJobType>)comboBox4.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox4.Refresh();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.HWSettings.MooglesEnabled = checkBox4.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Kojin
        private void kojinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.SBSettings.KojinClass= ((KeyValuePair<string, ClassJobType>)kojinComboBox.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            kojinComboBox.Refresh();
        }

        private void kojinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.SBSettings.KojinEnabled = kojinCheckBox.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }
        
        // Ananta

        private void anantaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.SBSettings.AnantaClass= ((KeyValuePair<string, ClassJobType>)anantaComboBox.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            anantaComboBox.Refresh();
        }

        private void anantaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.SBSettings.AnantaEnabled = anantaCheckBox.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Namazu
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.SBSettings.NamazuClass= ((KeyValuePair<string, ClassJobType>)comboBox1.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            comboBox1.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.SBSettings.NamazuEnabled = checkBox1.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Pixies
        private void pixiesComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ShBSettings.PixiesClass= ((KeyValuePair<string, ClassJobType>)pixiesComboBox1.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            pixiesComboBox1.Refresh();
        }

        private void pixiesChckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ShBSettings.PixiesEnabled = pixiesChckBox1.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }

        // Qitari
        private void qitariComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ShBSettings.QitariClass = ((KeyValuePair<string, ClassJobType>)qitariComboBox1.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            qitariComboBox1.Refresh();
        }

        private void qitariCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ShBSettings.QitariEnabled = qitariCheckBox1.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }
        
        // Dwarves
        
        private void dwarvesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ShBSettings.DwarvesClass = ((KeyValuePair<string, ClassJobType>)dwarvesComboBox.SelectedValue).Value;
            BeastTribes.BeastTribesSettings.Save();
            dwarvesComboBox.Refresh();
        }


        private void checkBoxDwarves_CheckedChanged(object sender, EventArgs e)
        {
            if (loading) return;
            BeastTribes.BeastTribesSettings.ShBSettings.DwarvesEnabled = checkBoxDwarves.Checked;
            BeastTribes.BeastTribesSettings.Save();
        }
    }
}