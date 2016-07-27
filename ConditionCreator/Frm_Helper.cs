using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ConditionCreator
{

    public partial class FormConditionHelper : Form
    {

        int classMask = 0;
        int raceMask = 0;
        int reputationMask = 0;
        string connectionString = "";

        public FormConditionHelper()
        {
            InitializeComponent();
        }

        public DataSet dbread(String qry)
        {
            DataSet DS = new DataSet();
            connectionString = @"Data Source=cc.s3db;Version=3;";
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        SQLiteDataAdapter DB = new SQLiteDataAdapter(qry, con);
                        DB.Fill(DS, "query");
                        con.Close();
                        return DS;
                    }
                }
                catch { }
            }
            DS.Tables.Add("query");
            return DS;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                classMask = classMask + 1;
            else
                classMask = classMask - 1;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                classMask = classMask + 2;
            else
                classMask = classMask - 2;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                classMask = classMask + 4;
            else
                classMask = classMask - 4;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                classMask = classMask + 8;
            else
                classMask = classMask - 8;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
                classMask = classMask + 16;
            else
                classMask = classMask - 16;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                classMask = classMask + 32;
            else
                classMask = classMask - 32;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
                classMask = classMask + 64;
            else
                classMask = classMask - 64;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
                classMask = classMask + 128;
            else
                classMask = classMask - 128;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
                classMask = classMask + 256;
            else
                classMask = classMask - 256;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
                classMask = classMask + 512;
            else
                classMask = classMask - 512;

            textBoxClass.Text = classMask.ToString();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
                classMask = classMask + 1024;
            else
                classMask = classMask - 1024;

            textBoxClass.Text = classMask.ToString();
        }

        private void buttonClassHelper_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBoxClass.Text);
        }

        private void buttonRacesHelper_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBoxRace.Text);
        }

        private void buttonReputationHelper_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(textBoxReputation.Text);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
                raceMask = raceMask + 1;
            else
                raceMask = raceMask - 1;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
                raceMask = raceMask + 2;
            else
                raceMask = raceMask - 2;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
                raceMask = raceMask + 4;
            else
                raceMask = raceMask - 4;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
                raceMask = raceMask + 8;
            else
                raceMask = raceMask - 8;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
                raceMask = raceMask + 16;
            else
                raceMask = raceMask - 16;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
                raceMask = raceMask + 32;
            else
                raceMask = raceMask - 32;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
                raceMask = raceMask + 64;
            else
                raceMask = raceMask - 64;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
                raceMask = raceMask + 128;
            else
                raceMask = raceMask - 128;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
                raceMask = raceMask + 256;
            else
                raceMask = raceMask - 256;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
                raceMask = raceMask + 512;
            else
                raceMask = raceMask - 512;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
                raceMask = raceMask + 1024;
            else
                raceMask = raceMask - 1024;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox33.Checked)
                raceMask = raceMask + 2097152;
            else
                raceMask = raceMask - 2097152;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox34.Checked)
                raceMask = raceMask + 8388608;
            else
                raceMask = raceMask - 8388608;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox35.Checked)
                raceMask = raceMask + 16777216;
            else
                raceMask = raceMask - 16777216;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox36.Checked)
                raceMask = raceMask + 33554432;
            else
                raceMask = raceMask - 33554432;

            textBoxRace.Text = raceMask.ToString();
        }

        private void checkBox47_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox47.Checked)
                reputationMask = reputationMask + 1;
            else
                reputationMask = reputationMask - 1;

            textBoxReputation.Text = reputationMask.ToString();
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox46.Checked)
                reputationMask = reputationMask + 2;
            else
                reputationMask = reputationMask - 2;

            textBoxReputation.Text = reputationMask.ToString();
        }

        private void checkBox44_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox44.Checked)
                reputationMask = reputationMask + 4;
            else
                reputationMask = reputationMask - 4;

            textBoxReputation.Text = reputationMask.ToString();
        }

        private void checkBox45_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox45.Checked)
                reputationMask = reputationMask + 8;
            else
                reputationMask = reputationMask - 8;

            textBoxReputation.Text = reputationMask.ToString();
        }

        private void checkBox42_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox42.Checked)
                reputationMask = reputationMask + 16;
            else
                reputationMask = reputationMask - 16;

            textBoxReputation.Text = reputationMask.ToString();
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox43.Checked)
                reputationMask = reputationMask + 32;
            else
                reputationMask = reputationMask - 32;

            textBoxReputation.Text = reputationMask.ToString();
        }

        private void checkBox40_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox40.Checked)
                reputationMask = reputationMask + 64;
            else
                reputationMask = reputationMask - 64;

            textBoxReputation.Text = reputationMask.ToString();
        }

        private void checkBox41_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox41.Checked)
                reputationMask = reputationMask + 128;
            else
                reputationMask = reputationMask - 128;

            textBoxReputation.Text = reputationMask.ToString();
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            fillData("Area");
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            fillData("Map");
        }

        private void buttonAchievement_Click(object sender, EventArgs e)
        {
            fillData("Achievement");
        }

        private void buttonSpell_Click(object sender, EventArgs e)
        {
            fillData("Spell");
        }

        private void buttonUnit_Click(object sender, EventArgs e)
        {
            fillData("Unit");
        }

        private void buttonGameObject_Click(object sender, EventArgs e)
        {
            fillData("GameObject");
        }

        private void buttonItem_Click(object sender, EventArgs e)
        {
            fillData("Item");
        }

        private void buttonQuest_Click(object sender, EventArgs e)
        {
            fillData("Quest");
        }

        private void buttonFaction_Click(object sender, EventArgs e)
        {
            fillData("Faction");
        }

        private void buttonSkill_Click(object sender, EventArgs e)
        {
            fillData("Skill");
        }

        private void buttonTitle_Click(object sender, EventArgs e)
        {
            fillData("Title");
        }

        void fillData (String listId)
        {
            DataSet DS = new DataSet();
            DS = dbread("Select `Id`,`Name` FROM `objectnames` WHERE `ObjectType`= '" + listId + "';");
            dataGridView.DataSource = DS.Tables["query"];
            DataGridViewColumn column = dataGridView.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            labelList.Text = "Showing " + listId + " Id List";
        }

        private void FormConditionHelper_Load(object sender, EventArgs e)
        {

        }
    }
}
