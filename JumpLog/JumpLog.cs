using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace JumpLog
{
    public partial class JumpLog : Form
    {

        public Log Log { get; set; }
        public String FileName { get; set; }
        public String FilePath { get; set; }
        public Boolean Dirty { get; set; }
        public JumpLog()
        {
            InitializeComponent();
            Log = new Log();
            SetupToolTips();
        }

        private void SetupToolTips()
        {
            
            toolTip.SetToolTip(TrueNameLabel,
                "Your name before the chain. The name that represents you before all this. A name that has power.");
            toolTip.SetToolTip(AliasLabel, "Titles, Nicknames, Alter-Ego's and so on. Even screennames could qualify.");
            toolTip.SetToolTip(originalAgeLabel, " Time may soon lose all meaning, but how old are you at the start?");
            toolTip.SetToolTip(OriginHeightLabel, "How tall were you?");
            toolTip.SetToolTip(OriginWeightLabel, "How much did you weigh?");
            toolTip.SetToolTip(OriginSexLabel, "Your initial gender. Male, Female, Other and beyond, Jumpers come from all sorts of origins.");
            toolTip.SetToolTip(OriginBiographyLabel, "A little about the you before the chain.");
            toolTip.SetToolTip(OriginAppearenceLabel, "A short note about what you looked like before the chain. Who knows what you will become?");
            toolTip.SetToolTip(JumperNameLabel, "Going by your true name can be dangerous, but the decision is yours. What is your new identity?");
            toolTip.SetToolTip(JumperAliasLabel,
                "Titles, Nicknames Designations and more may follow you from old lives, or be forged in new ones.");
            toolTip.SetToolTip(BenefactorLabel, "Who or what is the force that hurls you through the multiverse?");

            toolTip.SetToolTip(TrueAgeLabel,
                "This is the age of all your lives combined. They could include your pre-jump memories, or only count time you are behind the drivers seat. Your call.");
            toolTip.SetToolTip(SpeciesLabel, "This is your species if you were to drop-in, and your species between jumps.");
            toolTip.SetToolTip(TrueGenderLabel,
                "When the jump asks you to pay to change your gender, this is what you are defaulting to unless otherwise specified.");
            toolTip.SetToolTip(TrueHeightLabel,
                "Your jumpers true form height, as modified by perks, species and such.");
            toolTip.SetToolTip(TrueWeightLabel,
                "Your jumpers true form weight, as modified by perks, species, fitness and so on.");

            toolTip.SetToolTip(HomePlaneLabel,
                "Sometimes its fun to forge your jumper from a universe besides your own. Earth is fine tho! Really.");
            toolTip.SetToolTip(TrueVisageLabel, "Trueseeing can glimpse beneath the mundane form you show the world. What would it see?");
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (!Dirty)
            {
                Log = new Log();
                
                ResetForm();
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "JumpLog",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                    return;
                if (result == DialogResult.Yes)
                {
                    if (!SaveLog())
                        return;
                }
                Log = new Log();
                ResetForm();
            }
        }

        private  bool SaveLog()
        {

            if (String.IsNullOrEmpty(this.FileName))
            {
                saveFileDialog1.Filter = "Jump Files|*.jmp";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.CheckPathExists = true;
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    return false;
                    
                    
                }
                FileName = saveFileDialog1.FileName;
            }
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(FileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, Log);
                // {"ExpiryDate":new Date(1230375600000),"Price":0}
            }

            Dirty = false;
            return true;
        }

        

        private void TrueNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.TrueName = TrueNameTextBox.Text;
            Dirty = true;
        }

        private void OriginalAliasTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.Alias = OriginalAliasTextBox.Text;
            Dirty = true;
        }

        private void OriginalAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.OriginalAge = OriginalAgeTextBox.Text;
            Dirty = true;
        }

        private void OriginHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.OriginalHeight = OriginHeightTextBox.Text;
            Dirty = true;
        }

        private void OriginSexComboBox_TextUpdate(object sender, EventArgs e)
        {
            Log.OriginalSex = OriginSexComboBox.Text;
            Dirty = true;
        }

        private void OriginWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.OriginalWeight = OriginWeightTextBox.Text;
            Dirty = true;
        }

        private void OriginBIographyTextbox_TextChanged(object sender, EventArgs e)
        {
            Log.OriginalBiography = OriginBIographyTextbox.Text;
            Dirty = true;
        }

        private void OriginAppearenceTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.OriginalAppearence = OriginAppearenceTextBox.Text;
            Dirty = true;
        }

        private void JumperNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.JumperName = JumperNameTextBox.Text;
            Dirty = true;
        }

        private void JumperAliasTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.JumperAlias = JumperAliasTextBox.Text;
            Dirty = true;
        }

        private void BenefactorTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.Benefactor = BenefactorTextBox.Text;
            Dirty = true;
        }

        private void TrueAgeTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.TrueAge = TrueAgeTextBox.Text;
            Dirty = true;
        }

        private void SpeciesTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.Species = SpeciesTextBox.Text;
            Dirty = true;
        }

        private void TrueGenderComboBox_TextChanged(object sender, EventArgs e)
        {
            Log.TrueGender = TrueGenderComboBox.Text;
            Dirty = true;
        }

        private void TrueHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.TrueHeight = TrueHeightTextBox.Text;
            Dirty = true;
        }

        private void TrueWeightTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.TrueWeight = TrueWeightTextBox.Text;
            Dirty = true;
        }

        private void HomePlaneTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.HomePlane = HomePlaneTextBox.Text;
            Dirty = true;
        }

        private void TrueVisageTextBox_TextChanged(object sender, EventArgs e)
        {
            Log.TrueVisage = TrueVisageTextBox.Text;
            Dirty = true;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (Dirty)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "JumpLog",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                    return;
                if (result == DialogResult.Yes)
                {
                    if (!SaveLog())
                        return;
                }
            }
            openFileDialog1.Filter = "Jump Files|*.jmp";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.AddExtension = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;

                JsonSerializer serializer = new JsonSerializer();
                using (StreamReader sr = new StreamReader(FileName))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    Log = serializer.Deserialize<Log>(reader);
                    SyncForm();
                    // {"ExpiryDate":new Date(1230375600000),"Price":0}
                }

                Dirty = false;
            }
        }

        private void SyncForm()
        {
            TrueNameTextBox.Text = Log.TrueName;
            OriginalAliasTextBox.Text = Log.Alias;
            OriginalAgeTextBox.Text = Log.OriginalAge;
            OriginHeightTextBox.Text = Log.OriginalHeight;
            OriginSexComboBox.Text = Log.OriginalSex;
            OriginWeightTextBox.Text = Log.OriginalWeight;
            OriginBIographyTextbox.Text = Log.OriginalBiography;
            OriginAppearenceTextBox.Text = Log.OriginalAppearence;
            JumperNameTextBox.Text = Log.JumperName;
            JumperAliasTextBox.Text = Log.JumperAlias;
            BenefactorTextBox.Text = Log.Benefactor;
            TrueAgeTextBox.Text = Log.TrueAge;
            SpeciesTextBox.Text = Log.Species;
            TrueGenderComboBox.Text = Log.TrueGender;
            TrueHeightTextBox.Text = Log.TrueHeight;
            TrueWeightTextBox.Text = Log.TrueWeight;
            HomePlaneTextBox.Text = Log.HomePlane;
            TrueVisageTextBox.Text = Log.TrueVisage;
        }

        private void ResetForm()
        {
            TrueNameTextBox.Text = "";
            OriginalAliasTextBox.Text = "";
            OriginalAgeTextBox.Text = "";
            OriginHeightTextBox.Text = "";
            OriginSexComboBox.Text = "";
            OriginWeightTextBox.Text = "";
            OriginBIographyTextbox.Text = "";
            OriginAppearenceTextBox.Text = "";
            JumperNameTextBox.Text = "";
            JumperAliasTextBox.Text = "";
            BenefactorTextBox.Text = "";
            TrueAgeTextBox.Text = "";
            SpeciesTextBox.Text = "";
            TrueGenderComboBox.Text = "";
            TrueHeightTextBox.Text = "";
            TrueWeightTextBox.Text = "";
            TrueWeightTextBox.Text = "";
            HomePlaneTextBox.Text = "";
            TrueVisageTextBox.Text = "";
            Dirty = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveLog();
        }
    }
}
