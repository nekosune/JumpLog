using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            toolTip.SetToolTip(TrueAgeLabel,
                "This is the age of all your lives combined. They could include your pre-jump memories, or only count time you are behind the drivers seat. Your call.");

            toolTip.SetToolTip(TrueGenderLabel,
                "When the jump asks you to pay to change your gender, this is what you are defaulting to unless otherwise specified.");
            toolTip.SetToolTip(HomePlaneLabel,
                "Sometimes its fun to forge your jumper from a universe besides your own. Earth is fine tho! Really.");
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
            return true;
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
    }
}
