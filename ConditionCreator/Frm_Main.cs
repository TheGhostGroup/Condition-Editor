using System;
using System.Collections;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ConditionCreator
{
    public partial class FormCreator : Form
    {
        bool updateFields           = true;
        int sourceValue             = 0;
        int conditionValue          = 0;
        string connectionString     = "";
        string sqlString            = "";
        string[] sourceGroupTip     = new string[27];
        string[] sourceEntryTip     = new string[27];
        string[] sourceIdTip        = new string[27];
        string[] conditionTargetTip = new string[27];
        string[] ConditionValue1Tip = new string[49];
        string[] ConditionValue2Tip = new string[49];
        string[] ConditionValue3Tip = new string[49];

        public FormCreator()
        {
            InitializeComponent();
            // Initial setup of controls
            toolStripComboBoxSource.Text="None";
            toolStripComboBoxCondition.Text = "None";
            comboBoxConditionTarget.Text = "0";
            labelTarget.Text = "";
            tiptext();
        }

        void tiptext ()
        {
            toolTip.SetToolTip(this.labelErrorType, "Number from enum SpellCastResult in SharedDefines.h. Only used in Condition type Spell.");
            toolTip.SetToolTip(this.labelErrorTextId, "Number from enum SpellCustomErrors in SharedDefines.h. Only used in Condition type Spell.");
            toolTip.SetToolTip(this.labelElseGroup, "Allows building grouped conditions.");
            toolTip.SetToolTip(this.checkBoxNegativeCondition, "If checked the condition will be inverted.");
            toolTip.SetToolTip(this.labelScriptName, "The ScriptName this condition uses, if any.");
            toolTip.SetToolTip(this.labelComment, "Explanation of this condition or reference.");

            // Source tool tips
            // NONE
            sourceGroupTip[0] = "";
            sourceEntryTip[0] = "";
            sourceIdTip[0] = "";
            conditionTargetTip[0] = "";
            // CREATURE LOOT TEMPLATE
            sourceGroupTip[1] = "This must be a valid creature loot template entry.";
            sourceEntryTip[1] = "This must be a valid loot item Id for creature loot template.";
            sourceIdTip[1] = "";
            conditionTargetTip[1] = "";
            // DISENCHANT LOOT TEMPLATE
            sourceGroupTip[2] = "This must be a valid disenchant loot template entry.";
            sourceEntryTip[2] = "This must be a valid loot item Id for disenchant loot template.";
            sourceIdTip[2] = "";
            conditionTargetTip[2] = "";
            // FISHING LOOT TEMPLATE
            sourceGroupTip[3] = "This must be a valid fishing loot template entry.";
            sourceEntryTip[3] = "This must be a valid loot item Id for fishing loot template.";
            sourceIdTip[3] = "";
            conditionTargetTip[3] = "";
            // GAMEOBJECT LOOT TEMPLATE
            sourceGroupTip[4] = "This must be a valid gameobject loot template entry.";
            sourceEntryTip[4] = "This must be a valid loot item Id for gameobject loot template.";
            sourceIdTip[4] = "";
            conditionTargetTip[4] = "";
            // ITEM LOOT TEMPLATE
            sourceGroupTip[5] = "This must be a valid item loot template entry.";
            sourceEntryTip[5] = "This must be a valid loot item Id for item loot template.";
            sourceIdTip[5] = "";
            conditionTargetTip[5] = "";
            // MAIL LOOT TEMPLATE
            sourceGroupTip[6] = "This must be a valid mail loot template entry.";
            sourceEntryTip[6] = "This must be a valid loot item Id for mail loot template.";
            sourceIdTip[6] = "";
            conditionTargetTip[6] = "";
            // MILLING LOOT TEMPLATE
            sourceGroupTip[7] = "This must be a valid milling loot template entry.";
            sourceEntryTip[7] = "This must be a valid loot item Id for milling loot template.";
            sourceIdTip[7] = "";
            conditionTargetTip[7] = "";
            // PICKPOCKETING LOOT TEMPLATE
            sourceGroupTip[8] = "This must be a valid pickpocketing loot template entry.";
            sourceEntryTip[8] = "This must be a valid loot item Id for pickpocketing loot template.";
            sourceIdTip[8] = "";
            conditionTargetTip[8] = "";
            // PROSPECTING LOOT TEMPLATE
            sourceGroupTip[9] = "This must be a valid prospecting loot template entry.";
            sourceEntryTip[9] = "This must be a valid loot item Id for prospecting loot template.";
            sourceIdTip[9] = "";
            conditionTargetTip[9] = "";
            // REFERENCE LOOT TEMPLATE
            sourceGroupTip[10] = "This must be a valid reference loot template entry.";
            sourceEntryTip[10] = "This must be a valid loot item Id for reference loot template.";
            sourceIdTip[10] = "";
            conditionTargetTip[10] = "";
            // SKINNING LOOT TEMPLATE
            sourceGroupTip[11] = "This must be a valid skinning loot template entry.";
            sourceEntryTip[11] = "This must be a valid loot item Id for skinning loot template.";
            sourceIdTip[11] = "";
            conditionTargetTip[11] = "";
            // SPELL LOOT TEMPLATE
            sourceGroupTip[12] = "This must be a valid spell loot template entry.";
            sourceEntryTip[12] = "This must be a valid loot item Id for spell loot template.";
            sourceIdTip[12] = "";
            conditionTargetTip[12] = "";
            // SPELL IMPLICIT TARGET
            sourceGroupTip[13] = "Mask of effect which should hit target:\r\n1 = EFFECT_0\r\n2 = EFFECT_1\r\n3 = EFFECT_0 & EFFECT_1\r\n4 = EFFECT_2\r\n5 = EFFECT_0 & EFFECT_2\r\n6 = EFFECT_1 & EFFECT_2\r\n7 = EFFECT_0 & EFFECT_1 & EFFECT_2";
            sourceEntryTip[13] = "Spell requiring Implicit target (Spell Id from Spell.dbc)";
            sourceIdTip[13] = "";
            conditionTargetTip[13] = "Target:\r\n0 - Potential target of the spell\r\n1 - Caster of the spell.";
            // GOSSIP MENU
            sourceGroupTip[14] = "This is the gossip menu entry needed to trigger condition.";
            sourceEntryTip[14] = "This is the gossip menu text needed to trigger condition.";
            sourceIdTip[14] = "";
            conditionTargetTip[14] = "Target:\r\n0 - Player for which gossip text is shown\r\n1 - WorldObject providing gossip.";
            // GOSSIP MENU OPTION
            sourceGroupTip[15] = "This is the gossip menu entry needed to trigger condition.";
            sourceEntryTip[15] = "This is the gossip menu option id needed to trigger condition.";
            sourceIdTip[15] = "";
            conditionTargetTip[15] = "Target:\r\n0 - Player for which gossip text is shown\r\n1 - WorldObject providing gossip.";
            // CREATURE TEMPLATE VEHICLE
            sourceGroupTip[16] = "This is the creature entry of the vehicle. Note: creature must be a vehicle.";
            sourceEntryTip[16] = "";
            sourceIdTip[16] = "";
            conditionTargetTip[16] = "Target:\r\n0 - Player riding the vehicle\r\n1 - Vehicle creature.";
            // SPELL
            sourceGroupTip[17] = "Spell which is cast (Spell Id from Spell.dbc)";
            sourceEntryTip[17] = "";
            sourceIdTip[17] = "";
            conditionTargetTip[17] = "Target:\r\n0 - Caster of the spell\r\n1 - Explicit target of the spell (only for spells which take object selected by caster into account).";
            // SPELL CLICK EVENT
            sourceGroupTip[18] = "This is the creature player will click.";
            sourceEntryTip[18] = "This is the click Spell  (Spell Id from Spell.dbc)";
            sourceIdTip[18] = "";
            conditionTargetTip[18] = "Target:\r\n0 - Player\r\n1 - Creature.";
            // QUEST AVAILABLE
            sourceGroupTip[19] = "Quest id which will be available on condition true.";
            sourceEntryTip[19] = "";
            sourceIdTip[19] = "";
            conditionTargetTip[19] = "";
            // Condition 20 not used
            sourceGroupTip[20] = "";
            sourceEntryTip[20] = "";
            sourceIdTip[20] = "";
            conditionTargetTip[20] = "";
            // VEHICLE SPELL
            sourceGroupTip[21] = "Vehicle creature.";
            sourceEntryTip[21] = "Vehicle entry spell (Spell Id from Spell.dbc)";
            sourceIdTip[21] = "";
            conditionTargetTip[21] = "Target:\r\n0 - Player for which spell bar is shown\r\n1 - Vehicle creature";
            // SMART EVENT
            sourceGroupTip[22] = "Add 1 to the id of the SAI you wish to tie condition to.";
            sourceEntryTip[22] = "EntryOrGuid of the SAI you wish to tie condition to.";
            sourceIdTip[22] = "Valid source types:\r\n0 - SMART_SCRIPT_TYPE_CREATURE\r\n1 - SMART_SCRIPT_TYPE_GAMEOBJECT\r\n2 - SMART_SCRIPT_TYPE_AREATRIGGER\r\n3 - SMART_SCRIPT_TYPE_EVENT (not available)\r\n4 - SMART_SCRIPT_TYPE_GOSSIP (not available)\r\n5 - SMART_SCRIPT_TYPE_QUEST (not available)\r\n6 - SMART_SCRIPT_TYPE_SPELL (not available)\r\n7 - SMART_SCRIPT_TYPE_TRANSPORT (not available)\r\n8 - SMART_SCRIPT_TYPE_INSTANCE (not available)\r\n9 - SMART_SCRIPT_TYPE_TIMED_ACTIONLIST";
            conditionTargetTip[22] = "Target:\r\n0 - Invoker\r\n1 - Object";
            // NPC VENDOR
            sourceGroupTip[23] = "Creature entry of the vendor.";
            sourceEntryTip[23] = "Item entry to show.";
            sourceIdTip[23] = "";
            conditionTargetTip[23] = "";
            // SPELL PROC
            sourceGroupTip[24] = "";
            sourceEntryTip[24] = "Spell id of aura which triggers proc (Spell Id from Spell.dbc)";
            sourceIdTip[24] = "";
            conditionTargetTip[24] = "Target:\r\n0 - Actor\r\n1 - ActionTarget";
            // TERRAIN SWAP
            sourceGroupTip[25] = "";
            sourceEntryTip[25] = "Map id used in terrain swap";
            sourceIdTip[25] = "";
            conditionTargetTip[25] = "";
            // PHASE
            sourceGroupTip[26] = "Phase id used in phase change.";
            sourceEntryTip[26] = "Area id used in phase change.";
            sourceIdTip[26] = "";
            conditionTargetTip[26] = "";
            // NONE
            ConditionValue1Tip[0] = "";
            ConditionValue2Tip[0] = "";
            ConditionValue3Tip[0] = "";
            // AURA
            ConditionValue1Tip[1] = "This is the Spell Id from Spell.dbc.";
            ConditionValue2Tip[1] = "This is the mask of effect to be used by condition:\r\n1 = EFFECT_0\r\n2 = EFFECT_1\r\n3 = EFFECT_2";
            ConditionValue3Tip[1] = "";
            // ITEM
            ConditionValue1Tip[2] = "This is the item entry player must have for condition.";
            ConditionValue2Tip[2] = "The amount of item entry player must have.";
            ConditionValue3Tip[2] = "Can item be in bank:\r\n0 - false\r\n1 - true";
            // ITEM EQUIPPED
            ConditionValue1Tip[3] = "This item entry must be equiped for condition to be true.";
            ConditionValue2Tip[3] = "";
            ConditionValue3Tip[3] = "";
            // ZONE ID
            ConditionValue1Tip[4] = "This is the zone Id where the condition will be true.";
            ConditionValue2Tip[4] = "";
            ConditionValue3Tip[4] = "";
            // REPUTATION RANK
            ConditionValue1Tip[5] = "This is the faction template ID (from Faction.dbc)";
            ConditionValue2Tip[5] = "Availible ranks:\r\n1 - Hated\r\n2 - Hostile\r\n4 - Unfriendly\r\n8 - Neutral\r\n16 - Friendly\r\n32 - Honored\r\n64 - Revered\r\n128 - Exalted\r\nFlags can be added together for all ranks the condition should be true in.";
            ConditionValue3Tip[5] = "";
            // TEAM
            ConditionValue1Tip[6] = "Player team:\r\n67 - Horde\r\n469 - Alliance)";
            ConditionValue2Tip[6] = "";
            ConditionValue3Tip[6] = "";
            // SKILL
            ConditionValue1Tip[7] = "skill required, see SkillLine.dbc";
            ConditionValue2Tip[7] = "Skill Value needed.";
            ConditionValue3Tip[7] = "";
            // QUEST REWARDED
            ConditionValue1Tip[8] = "Player must have this quest rewarded for condition to be true.";
            ConditionValue2Tip[8] = "";
            ConditionValue3Tip[8] = "";
            // QUEST TAKEN
            ConditionValue1Tip[9] = "Player must have this quest taken for condition to be true.";
            ConditionValue2Tip[9] = "";
            ConditionValue3Tip[9] = "";
            // DRUNKEN STATE
            ConditionValue1Tip[10] = "Player drunken State:\r\n0 - sober\r\n1 - tipsy\r\n2 - drunk\r\n3 - smashed";
            ConditionValue2Tip[10] = "";
            ConditionValue3Tip[10] = "";
            // WORLD STATE
            ConditionValue1Tip[11] = "World state index.";
            ConditionValue2Tip[11] = "World state value.";
            ConditionValue3Tip[11] = "";
            // ACTIVE EVENT
            ConditionValue1Tip[12] = "Event Entry.";
            ConditionValue2Tip[12] = "";
            ConditionValue3Tip[12] = "";
            // INSTANCE INFO
            ConditionValue1Tip[13] = "See corresponding script source files for more info.";
            ConditionValue2Tip[13] = "See corresponding script source files for more info.";
            ConditionValue3Tip[13] = "Type:\r\n0 - INSTANCE_INFO_DATA\r\n1 - INSTANCE_INFO_DATA64\r\n2 - INSTANCE_INFO_BOSS_STATE";
            // QUEST NONE
            ConditionValue1Tip[14] = "Condition will be true if player has not taken quest.";
            ConditionValue2Tip[14] = "";
            ConditionValue3Tip[14] = "";
            // CLASS
            ConditionValue1Tip[15] = "Class flags:\r\n1 - Warrior\r\n2 - Paladin\r\n4 - Hunter\r\n8 - Rogue\r\n16 - Priest\r\n32 - Death Knight\r\n64 - Shaman\r\n128 - Mage\r\n256 - Warlock\r\n512 - Monk\r\n1024 - Druid\r\n2048 - Demon Hunter\r\nnFlags can be combined.";
            ConditionValue2Tip[15] = "";
            ConditionValue3Tip[15] = "";
            // RACE
            ConditionValue1Tip[16] = "race the player must be. Add flags together for all races condition should be true for. See ChrRaces.dbc";
            ConditionValue2Tip[16] = "";
            ConditionValue3Tip[16] = "";
            // ACHIEVEMENT
            ConditionValue1Tip[17] = "Achievement Id from Achievement.dbc";
            ConditionValue2Tip[17] = "";
            ConditionValue3Tip[17] = "";
            // TITLE
            ConditionValue1Tip[18] = "Title Id from CharTitles.dbc";
            ConditionValue2Tip[18] = "";
            ConditionValue3Tip[18] = "";
            // SPAWN MASK
            ConditionValue1Tip[19] = "SpawnMask (see Gameobject.spawnMask/Creature.spawnMask)";
            ConditionValue2Tip[19] = "";
            ConditionValue3Tip[19] = "";
            // GENDER
            ConditionValue1Tip[20] = "Gender:\r\n0 = Male\r\n1 = Female\r\n2 = None";
            ConditionValue2Tip[20] = "";
            ConditionValue3Tip[20] = "";
            // UNIT STATE
            ConditionValue1Tip[21] = "Enum";
            ConditionValue2Tip[21] = "";
            ConditionValue3Tip[21] = "";
            // MAP ID
            ConditionValue1Tip[22] = "This is the Map Id from map.dbc";
            ConditionValue2Tip[22] = "";
            ConditionValue3Tip[22] = "";
            // AREA ID
            ConditionValue1Tip[23] = "This is the Area Id from area_table.dbc";
            ConditionValue2Tip[23] = "";
            ConditionValue3Tip[23] = "";
            // CREATURE TYPE
            ConditionValue1Tip[24] = "This is the Creature type from creature_template.type\r\n0 = None\r\n1 = Beast\r\n2 = Dragonkin\r\n3 = Demon\r\n4 = Elemental\r\n5 = Giant\r\n6 = Undead\r\n7 = Humanoid\r\n8 = Critter\r\n9 = Mechanical\r\n10 = Not specified\r\n11 = Totem\r\n12 = Non-Combat Pet\r\n13 = Gas Cloud\r\n14 = Wild Pet\r\n15 = Aberration";
            ConditionValue2Tip[24] = "";
            ConditionValue3Tip[24] = "";
            // SPELL
            ConditionValue1Tip[25] = "This is the Spell Id from Spell.dbc.";
            ConditionValue2Tip[25] = "";
            ConditionValue3Tip[25] = "";
            // PHASEMASK
            ConditionValue1Tip[26] = "Phasemask";
            ConditionValue2Tip[26] = "";
            ConditionValue3Tip[26] = "";
            // LEVEL
            ConditionValue1Tip[27] = "Reference level";
            ConditionValue2Tip[27] = "Player level in repect to reference level:\r\n0 = Player level must be equal\r\n1 = Player level must be higher\r\n2 = Player level must be lesser\r\n3 = Player level must be equal or higher\r\n4 = Player level must be equal or lower";
            ConditionValue3Tip[27] = "";
            // QUEST COMPLETE
            ConditionValue1Tip[28] = "Player must have this quest completed for condition to be true.";
            ConditionValue2Tip[28] = "";
            ConditionValue3Tip[28] = "";
            // NEAR CREATURE
            ConditionValue1Tip[29] = "Creature entry to find for condition to be true.";
            ConditionValue2Tip[29] = "Maximum Distance, in yards, to creature for condition to be true.";
            ConditionValue3Tip[29] = "";
            // NEAR GAMEOBJECT
            ConditionValue1Tip[30] = "Gameobject entry to find for condition to be true.";
            ConditionValue2Tip[30] = "Maximum Distance, in yards, to Gameobject for condition to be true.";
            ConditionValue3Tip[30] = "";
            // OBJECT ENTRY GUID
            ConditionValue1Tip[31] = "Type ID:\r\n3 - TYPEID_UNIT\r\n4 - TYPEID_PLAYER\r\n5 - TYPEID_GAMEOBJECT\r\n7 - TYPEID_CORPSE (player corpse, after released spirit)";
            ConditionValue2Tip[31] = "0 for any object of given type, Gameobject entry for TypeID = TYPEID_GAMEOBJECT, Creature entry for TypeID = TYPEID_UNIT";
            ConditionValue3Tip[31] = "0 for any object of given type, any other value to match that guid.";
            // TYPE MASK
            ConditionValue1Tip[32] = "Type mask:\r\n8 - TYPEMASK_UNIT\r\n16 - TYPEMASK_PLAYER\r\n32 - TYPEMASK_GAMEOBJECT\r\n128 - TYPEMASK_CORPSE (player corpse, after released spirit)";
            ConditionValue2Tip[32] = "";
            ConditionValue3Tip[32] = "";
            // RELATION TO
            ConditionValue1Tip[33] = "Target to which relation is checked - one of ConditionTargets available in current SourceType.";
            ConditionValue2Tip[33] = "Relationship type:\r\n0 - RELATION_SELF\r\n1 - RELATION_IN_PARTY\r\n2 - RELATION_IN_RAID_OR_PARTY\r\n3 - RELATION_OWNED_BY\r\n4 - RELATION_PASSENGER_OF\r\n5 - RELATION_CREATED_BY";
            ConditionValue3Tip[33] = "";
            // REACTION TO
            ConditionValue1Tip[34] = "Target to which reaction is checked - one of ConditionTargets available in current SourceType.";
            ConditionValue2Tip[34] = "Bitmask can be combined:\r\n1 - Hated\r\n2 - Hostile\r\n4 - Unfriendly\r\n8 - Neutral\r\n16 - Friendly\r\n32 - Honored\r\n64 - Revered\r\n128 - Exalted";
            ConditionValue3Tip[34] = "";
            // DISTANCE TO
            ConditionValue1Tip[35] = "Target to which distance is checked - one of ConditionTargets available in current SourceType.";
            ConditionValue2Tip[35] = "Distance between current ConditionTarget and target specified in ConditionValue1.";
            ConditionValue3Tip[35] = "Distance must be:\r\n0 = equal to target\r\n1 = farther than target\r\n2 = closer than target\r\n3 = equal to or farther than target\r\n4 = equal to or closer than target";
            // ALIVE
            ConditionValue1Tip[36] = "Required target state:\r\n0 - target needs to be ALIVE\r\n1 - target needs to be DEAD";
            ConditionValue2Tip[36] = "";
            ConditionValue3Tip[36] = "";
            // HP VAL
            ConditionValue1Tip[37] = "Reference HP Value";
            ConditionValue2Tip[37] = "HP must be:\r\n0 = equal to HP Value\r\n1 = higher than HP Value\r\n2 = lesser than HP Value\r\n3 = equal to or higher than HP Value\r\n4 = equal to or lower than HP Value";
            ConditionValue3Tip[37] = "";
            // HP PCT
            ConditionValue1Tip[38] = "Percentage of max HP";
            ConditionValue2Tip[38] = "HP percentage must be:\r\n0 = equal to percentage of max HP\r\n1 = higher than percentage of max HP\r\n2 = lesser than percentage of max HP\r\n3 = equal to or higher than percentage of max HP\r\n4 = equal to or lower than percentage of max HP";
            ConditionValue3Tip[38] = "";
            // REALM ACHIEVEMENT
            ConditionValue1Tip[39] = "Achievement Id from Achievement.dbc";
            ConditionValue2Tip[39] = "";
            ConditionValue3Tip[39] = "";
            // IN WATER
            ConditionValue1Tip[40] = "Location:\r\n0 - target needs to be on land.\r\n1 - target needs to be in water.";
            ConditionValue2Tip[40] = "";
            ConditionValue3Tip[40] = "";
            // TERRAIN SWAP
            ConditionValue1Tip[41] = "ID od terrainSwap object must be in to be true";
            ConditionValue2Tip[41] = "";
            ConditionValue3Tip[41] = "";
            // STAND STATE
            ConditionValue1Tip[42] = "StateType:\r\n0 - Exact state used.\r\n1 - Any type of state used.";
            ConditionValue2Tip[42] = "State:\r\n0 - Standing\r\n1 - Sitting";
            ConditionValue3Tip[42] = "";
            // DAILY QUEST DONE
            ConditionValue1Tip[43] = "Condition will be true if player has done daily quest.";
            ConditionValue2Tip[43] = "";
            ConditionValue3Tip[43] = "";
            // CHARMED
            ConditionValue1Tip[44] = "";
            ConditionValue2Tip[44] = "";
            ConditionValue3Tip[44] = "";
            // PET TYPE
            ConditionValue1Tip[45] = "Type of pet:\r\n0 - Summon Pet\r\n1 - Hunter Pet";
            ConditionValue2Tip[45] = "";
            ConditionValue3Tip[45] = "";
            // TAXI
            ConditionValue1Tip[46] = "";
            ConditionValue2Tip[46] = "";
            ConditionValue3Tip[46] = "";
            // QUESTSTATE
            ConditionValue1Tip[47] = "QuestId of which needs to meet soecified state";
            ConditionValue2Tip[47] = "Quest state:\r\n0 - None \r\n1 - Complete\r\n3 - Incomplete\r\n5 - Failed\r\n6 - Rewarded";
            ConditionValue3Tip[47] = "";
            // QUEST OBJECTIVE COMPLETE
            ConditionValue1Tip[48] = "Player must have this quest objective completed for condition to be true.";
            ConditionValue2Tip[48] = "";
            ConditionValue3Tip[48] = "";
        }

        public DataSet dbread(String qry)
        {
            DataSet DS = new DataSet();
            connectionString = @"Data Source=cc.db3;Version=3;";
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

        private void FormCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Reset all input fields.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                reset_source();
                reset_condition();
                // Reset Comboboxes
                toolStripComboBoxSource.Text = "None";
                toolStripComboBoxCondition.Text = "None";
                // Reset all Others
                textBoxElseGroup.Text = "0";
                checkBoxNegativeCondition.Checked = false;
                textBoxScriptName.Text = "";
                textBoxComment.Text = "";
            }
        }

        private void buttonAddtoList_Click(object sender, EventArgs e)
        {
            string[] row = new string[15];
            row[0] = sourceValue.ToString();
            row[1] = textBoxSourceGroup.Text;
            row[2] = textBoxSourceEntry.Text;
            row[3] = textBoxSourceId.Text;
            row[4] = textBoxElseGroup.Text;
            row[5] = conditionValue.ToString();
            row[6] = comboBoxConditionTarget.Text;
            row[7] = comboBoxConditionValue1.Text;
            row[8] = comboBoxConditionValue2.Text;
            row[9] = comboBoxConditionValue3.Text;
            if (checkBoxNegativeCondition.Checked)
                row[10] = "1";
            else
                row[10] = "0";
            row[11] = textBoxErrorType.Text;
            row[12] = textBoxErrorTextId.Text;
            row[13] = textBoxScriptName.Text;
            row[14] = textBoxComment.Text;

            for (int i = 0; i < 13; i++)
            {
                if (row[i] == "")
                    row[i] = "0";
            }

            dataGridViewConditions.Rows.Add(row);
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Erase all conditions in table.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridViewConditions.Rows.Clear();
            }
        }

        private void buttonRetrieveFromList_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Retrieve condition from list and insert into edit fields.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                updateFields = false;
                // copy selected row to input fields and delete row from table
                int rowIndex = dataGridViewConditions.SelectedRows[0].Index;
                DataGridViewRow row = dataGridViewConditions.Rows[rowIndex];
                int source = Convert.ToInt32(row.Cells[0].Value);
                if (source > 19) --source; // 20 is unused so selectedindex will be off after item 19.
                toolStripComboBoxSource.SelectedIndex = source;
                textBoxSourceGroup.Text = row.Cells[1].Value.ToString();
                textBoxSourceEntry.Text = row.Cells[2].Value.ToString();
                textBoxSourceId.Text = row.Cells[3].Value.ToString();
                textBoxElseGroup.Text = row.Cells[4].Value.ToString();
                toolStripComboBoxCondition.SelectedIndex = Convert.ToInt32(row.Cells[5].Value);
                comboBoxConditionTarget.Text = row.Cells[6].Value.ToString();
                comboBoxConditionValue1.Text = row.Cells[7].Value.ToString();
                comboBoxConditionValue2.Text = row.Cells[8].Value.ToString();
                comboBoxConditionValue3.Text = row.Cells[9].Value.ToString();
                int negcondition = Convert.ToInt32(row.Cells[10].Value);
                if (negcondition == 1)
                    checkBoxNegativeCondition.Checked = true;
                else
                    checkBoxNegativeCondition.Checked = false;
                textBoxErrorType.Text = row.Cells[11].Value.ToString();
                textBoxErrorTextId.Text = row.Cells[12].Value.ToString();
                textBoxScriptName.Text = row.Cells[13].Value.ToString();
                textBoxComment.Text = row.Cells[14].Value.ToString();
                updateFields = true;
                if (this.dataGridViewConditions.SelectedRows.Count > 0)
                {
                    dataGridViewConditions.Rows.RemoveAt(this.dataGridViewConditions.SelectedRows[0].Index);
                }
            }
        }

        void reset_source()
        {
            // Reset Source data
            labelSourceGroup.Text = "SourceGroup";
            labelSourceEntry.Text = "SourceEntry";
            labelSourceId.Text = "SourceId";
            labelTarget.Text = "Condition Target";
            textBoxSourceGroup.Text = "0";
            textBoxSourceEntry.Text = "0";
            textBoxSourceId.Text = "0";
            comboBoxConditionTarget.SelectedItem = 0;
            textBoxSourceGroup.Enabled = false;
            textBoxSourceEntry.Enabled = false;
            textBoxSourceId.Enabled = false;
            comboBoxConditionTarget.Enabled = false;
            comboBoxConditionTarget.Visible = false;
            toolTip.SetToolTip(this.labelSourceGroup, "");
            toolTip.SetToolTip(this.labelSourceEntry, "");
            toolTip.SetToolTip(this.labelSourceId, "");
            toolTip.SetToolTip(this.labelTarget, "");
            textBoxErrorType.Text = "0";
            textBoxErrorTextId.Text = "0";
            textBoxErrorType.Enabled = false;
            textBoxErrorTextId.Enabled = false;
            sourceValue = toolStripComboBoxSource.SelectedIndex;
            if (sourceValue > 19) ++sourceValue; // 20 is unused so selectedindex will be off after item 19.
        }

        void reset_condition()
        {
            // Reset Condition data
            toolTip.SetToolTip(this.labelConditionValue1, "");
            toolTip.SetToolTip(this.labelConditionValue2, "");
            toolTip.SetToolTip(this.labelConditionValue3, "");
            comboBoxConditionValue1.Items.Clear();
            comboBoxConditionValue1.Enabled = false;
            comboBoxConditionValue1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxConditionValue1.Text = "0";
            comboBoxConditionValue2.Items.Clear();
            comboBoxConditionValue2.Enabled = false;
            comboBoxConditionValue2.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxConditionValue2.Text = "0";
            comboBoxConditionValue3.Items.Clear();
            comboBoxConditionValue3.Enabled = false;
            comboBoxConditionValue3.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxConditionValue3.Text = "0";
            conditionValue = toolStripComboBoxCondition.SelectedIndex;
        }

        private void textBoxSourceGroup_TextChanged(object sender, EventArgs e)
        {
            updateComment();
        }

        private void textBoxSourceEntry_TextChanged(object sender, EventArgs e)
        {
            updateComment();
        }

        private void textBoxSourceId_TextChanged(object sender, EventArgs e)
        {
            updateComment();
        }

        private void comboBoxConditionValue1_TextChanged(object sender, EventArgs e)
        {
            updateComment();
        }

        private void comboBoxConditionValue2_TextChanged(object sender, EventArgs e)
        {
            updateComment();
        }

        private void comboBoxConditionValue3_TextChanged(object sender, EventArgs e)
        {
            updateComment();
        }

        private void checkBoxNegativeCondition_CheckedChanged(object sender, EventArgs e)
        {
            updateComment();
        }

        private void comboBoxConditionTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComment();
        }

        private void textBoxSourceGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void textBoxSourceEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void textBoxSourceId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void comboBoxConditionValue1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void comboBoxConditionValue2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void comboBoxConditionValue3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void textBoxErrorType_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void textBoxErrorTextId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void textBoxElseGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 3 && ch != 22)
                e.Handled = true;
        }

        private void toolStripComboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset source data labels and fields
            reset_source();

            // Set tooltips
            toolTip.SetToolTip(this.labelSourceGroup, sourceGroupTip[sourceValue]);
            toolTip.SetToolTip(this.labelSourceEntry, sourceEntryTip[sourceValue]);
            toolTip.SetToolTip(this.labelSourceId, sourceIdTip[sourceValue]);
            toolTip.SetToolTip(this.labelTarget, conditionTargetTip[sourceValue]);

            // Set source data labels and fields
            switch (toolStripComboBoxSource.Text)
            {
                case "Creature loot template":
                case "Disenchant loot template":
                case "Fishing loot template":
                case "Gameobject loot template":
                case "Item loot template":
                case "Mail loot template":
                case "Milling loot template":
                case "Pickpocketing loot template":
                case "Prospecting loot template":
                case "Reference loot template":
                case "Skinning loot template":
                case "Spell loot template":
                    labelSourceGroup.Text = "Loot Entry";
                    labelSourceEntry.Text = "Item Id";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    break;
                case "Spell implicit target":
                    textBoxSourceGroup.Text = "1";
                    labelSourceGroup.Text = "Spell Effect Mask";
                    labelSourceEntry.Text = "Spell";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "Condition Target";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    break;
                case "Gossip menu":
                    labelSourceGroup.Text = "Gossip Menu Entry";
                    labelSourceEntry.Text = "Gossip Text Id";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "Condition Target";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    break;
                case "Gossip menu option":
                    labelSourceGroup.Text = "Gossip Menu Entry";
                    labelSourceEntry.Text = "Gossip Option Id";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "Condition Target";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    break;
                case "Creature template vehicle":
                    labelSourceGroup.Text = "";
                    labelSourceEntry.Text = "Creature Entry";
                    labelSourceId.Text = "";
                    labelTarget.Text   = "Condition Target";
                    textBoxSourceEntry.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    break;
                case "Spell":
                    labelSourceGroup.Text = "";
                    labelSourceEntry.Text = "Spell Entry";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "Condition Target";
                    textBoxSourceEntry.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    textBoxErrorType.Enabled   = true;
                    textBoxErrorTextId.Enabled = true;
                    break;
                case "Spell click event":
                    labelSourceGroup.Text = "Creature Entry";
                    labelSourceEntry.Text = "Spell Entry";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "Condition Target";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    break;
                case "Quest available":
                    labelSourceGroup.Text = "";
                    labelSourceEntry.Text = "Quest Id";
                    labelSourceId.Text = "";
                    labelTarget.Text = "";
                    textBoxSourceEntry.Enabled = true;
                    break;
                case "Vehicle spell":
                    labelSourceGroup.Text = "Creature Entry";
                    labelSourceEntry.Text = "Spell Entry";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "Condition Target";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    break;
                case "Smart event":
                    textBoxSourceGroup.Text = "1";
                    labelSourceGroup.Text = "Smartscript Id + 1";
                    labelSourceEntry.Text = "Smartscript EntryOrGuid";
                    labelSourceId.Text    = "Smartscript Source Type";
                    labelTarget.Text      = "Condition Target";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    textBoxSourceId.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    break;
                case "NPC vendor":
                    labelSourceGroup.Text = "Vendor Entry";
                    labelSourceEntry.Text = "Item Entry";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    break;
                case "Spell proc":
                    labelSourceGroup.Text = "";
                    labelSourceEntry.Text = "Spell Entry";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "Condition Target";
                    textBoxSourceEntry.Enabled = true;
                    comboBoxConditionTarget.Enabled = true;
                    comboBoxConditionTarget.Visible = true;
                    break;
                case "Terrain swap":
                    labelSourceGroup.Text = "";
                    labelSourceEntry.Text = "Map Id";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "";
                    textBoxSourceEntry.Enabled = true;
                    break;
                case "Phase":
                    labelSourceGroup.Text = "Phase Id";
                    labelSourceEntry.Text = "Area Id";
                    labelSourceId.Text    = "";
                    labelTarget.Text      = "";
                    textBoxSourceGroup.Enabled = true;
                    textBoxSourceEntry.Enabled = true;
                    break;
                default:
                    sourceValue = 0;
                    labelSourceGroup.Text = "SourceGroup";
                    labelSourceEntry.Text = "SourceEntry";
                    labelSourceId.Text    = "SourceId";
                    labelTarget.Text      = "Condition Target";
                    break;
            }
            updateComment();
        }

        private void toolStripComboBoxCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset condition data labels and fields
            reset_condition();

            // Set tooltips
            toolTip.SetToolTip(this.labelConditionValue1, ConditionValue1Tip[conditionValue]);
            toolTip.SetToolTip(this.labelConditionValue2, ConditionValue2Tip[conditionValue]);
            toolTip.SetToolTip(this.labelConditionValue3, ConditionValue3Tip[conditionValue]);

            // Set condition data labels and fields
            switch (toolStripComboBoxCondition.Text)
            {
                case "Aura":
                    labelConditionValue1.Text = "Spell";
                    labelConditionValue2.Text = "Effect Index";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue2.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue2.Items.Clear();
                    comboBoxConditionValue2.Items.Add(1);
                    comboBoxConditionValue2.Items.Add(2);
                    comboBoxConditionValue2.Items.Add(3);
                    comboBoxConditionValue2.Text = "1";
                    break;
                case "Item":
                    labelConditionValue1.Text = "Item Entry";
                    labelConditionValue2.Text = "Item Count";
                    labelConditionValue3.Text = "In Bank";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue3.Enabled = true;
                    comboBoxConditionValue3.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue3.Items.Clear();
                    comboBoxConditionValue3.Items.Add(0);
                    comboBoxConditionValue3.Items.Add(1);
                    comboBoxConditionValue3.SelectedItem = 0;
                    break;
                case "Item equipped":
                    labelConditionValue1.Text = "Item Entry";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Zone id":
                    labelConditionValue1.Text = "Zone Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Reputation rank":
                    labelConditionValue1.Text = "Faction Template Id";
                    labelConditionValue2.Text = "Rank";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    break;
                case "Team":
                    labelConditionValue1.Text = "Team Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue1.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue1.Items.Add(67);
                    comboBoxConditionValue1.Items.Add(469);
                    comboBoxConditionValue1.SelectedItem = 67;
                    break;
                case "Skill":
                    labelConditionValue1.Text = "Skill Required";
                    labelConditionValue2.Text = "Skill Value";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    break;
                case "Quest rewarded":
                    labelConditionValue1.Text = "Quest Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Quest taken":
                    labelConditionValue1.Text = "Quest Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Drunken state":
                    labelConditionValue1.Text = "Drunken State";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue1.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue1.Items.Add(0);
                    comboBoxConditionValue1.Items.Add(1);
                    comboBoxConditionValue1.Items.Add(2);
                    comboBoxConditionValue1.Items.Add(3);
                    comboBoxConditionValue1.SelectedItem = 0;
                    break;
                case "World state":
                    labelConditionValue1.Text = "World State Index";
                    labelConditionValue2.Text = "World State Value";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    break;
                case "Active world event":
                    labelConditionValue1.Text = "Event Entry";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Instance info":
                    labelConditionValue1.Text = "Event Entry";
                    labelConditionValue2.Text = "Data";
                    labelConditionValue3.Text = "Type";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue3.Enabled = true;
                    comboBoxConditionValue3.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue3.Items.Add(0);
                    comboBoxConditionValue3.Items.Add(1);
                    comboBoxConditionValue3.Items.Add(2);
                    comboBoxConditionValue3.SelectedItem = 0;
                    break;
                case "Quest not taken":
                    labelConditionValue1.Text = "Quest Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Class":
                    labelConditionValue1.Text = "Class flag Mask";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Race":
                    labelConditionValue1.Text = "Race flag Mask";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Achievement":
                    labelConditionValue1.Text = "Achievement Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Title":
                    labelConditionValue1.Text = "Title Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Spawn mask":
                    labelConditionValue1.Text = "SpawnMask";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Gender":
                    labelConditionValue1.Text = "Gender";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue1.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue1.Items.Add(0);
                    comboBoxConditionValue1.Items.Add(1);
                    comboBoxConditionValue1.Items.Add(2);
                    comboBoxConditionValue1.SelectedItem = 0;
                    break;
                case "Unit state":
                    labelConditionValue1.Text = "Unit State";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Map id":
                    labelConditionValue1.Text = "Map Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Area id":
                    labelConditionValue1.Text = "Area Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Creature type":
                    labelConditionValue1.Text = "Creature Type";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Spell":
                    labelConditionValue1.Text = "Spell Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Phase mask":
                    labelConditionValue1.Text = "Phasemask";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Level":
                    labelConditionValue1.Text = "Level";
                    labelConditionValue2.Text = "Optional";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue2.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue2.Items.Add(0);
                    comboBoxConditionValue2.Items.Add(1);
                    comboBoxConditionValue2.Items.Add(2);
                    comboBoxConditionValue2.Items.Add(3);
                    comboBoxConditionValue2.Items.Add(4);
                    comboBoxConditionValue2.SelectedItem = 0;
                    break;
                case "Quest complete":
                    labelConditionValue1.Text = "Quest Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Near creature":
                    labelConditionValue1.Text = "Creature Entry";
                    labelConditionValue2.Text = "Distance";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    break;
                case "Near gameobject":
                    labelConditionValue1.Text = "Gameobject Entry";
                    labelConditionValue2.Text = "Distance";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    break;
                case "Object entry guid":
                    labelConditionValue1.Text = "Type Id";
                    labelConditionValue2.Text = "Entry";
                    labelConditionValue3.Text = "Guid";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue1.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue1.Items.Add(3);
                    comboBoxConditionValue1.Items.Add(4);
                    comboBoxConditionValue1.Items.Add(5);
                    comboBoxConditionValue1.Items.Add(7);
                    comboBoxConditionValue1.Text = "3";
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue3.Enabled = true;
                    break;
                case "Type mask":
                    labelConditionValue1.Text = "TypeMask";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue1.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue1.Items.Add(8);
                    comboBoxConditionValue1.Items.Add(16);
                    comboBoxConditionValue1.Items.Add(32);
                    comboBoxConditionValue1.Items.Add(128);
                    comboBoxConditionValue1.Text="8";
                    break;
                case "Relation to":
                    labelConditionValue1.Text = "Target";
                    labelConditionValue2.Text = "RelationType";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue2.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue2.Items.Add(0);
                    comboBoxConditionValue2.Items.Add(1);
                    comboBoxConditionValue2.Items.Add(2);
                    comboBoxConditionValue2.Items.Add(3);
                    comboBoxConditionValue2.Items.Add(4);
                    comboBoxConditionValue2.Items.Add(5);
                    comboBoxConditionValue2.SelectedItem = 0;
                    break;
                case "Reaction to":
                    labelConditionValue1.Text = "Target";
                    labelConditionValue2.Text = "Rankmask";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue2.Text = "1";
                    break;
                case "Distance to":
                    labelConditionValue1.Text = "Target";
                    labelConditionValue2.Text = "Distance";
                    labelConditionValue3.Text = "ComparisionType";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue3.Enabled = true;
                    comboBoxConditionValue3.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue3.Items.Add(0);
                    comboBoxConditionValue3.Items.Add(1);
                    comboBoxConditionValue3.Items.Add(2);
                    comboBoxConditionValue3.Items.Add(3);
                    comboBoxConditionValue3.Items.Add(4);
                    comboBoxConditionValue3.SelectedItem = 0;
                    break;
                case "Alive":
                    labelConditionValue1.Text = "Set NegativeCondition Value";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    break;
                case "Health point value":
                    labelConditionValue1.Text = "Value";
                    labelConditionValue2.Text = "ComparisionType";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue2.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue2.Items.Add(0);
                    comboBoxConditionValue2.Items.Add(1);
                    comboBoxConditionValue2.Items.Add(2);
                    comboBoxConditionValue2.Items.Add(3);
                    comboBoxConditionValue2.Items.Add(4);
                    comboBoxConditionValue2.SelectedItem = 0;
                    break;
                case "Health point percentage":
                    labelConditionValue1.Text = "Percentage";
                    labelConditionValue2.Text = "ComparisionType";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue2.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue2.Items.Add(0);
                    comboBoxConditionValue2.Items.Add(1);
                    comboBoxConditionValue2.Items.Add(2);
                    comboBoxConditionValue2.Items.Add(3);
                    comboBoxConditionValue2.Items.Add(4);
                    comboBoxConditionValue2.SelectedItem = 0;
                    break;
                case "Realm achievement":
                    labelConditionValue1.Text = "Achievement Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "In water":
                    labelConditionValue1.Text = "Set NegativeCondition Value";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    break;
                case "Terrain swap":
                    labelConditionValue1.Text = "Terrain swap";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Stand state":
                    labelConditionValue1.Text = "StateType";
                    labelConditionValue2.Text = "State";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue1.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue1.Items.Add(0);
                    comboBoxConditionValue1.Items.Add(1);
                    comboBoxConditionValue1.SelectedItem = 0;
                    comboBoxConditionValue2.Enabled = true;
                    comboBoxConditionValue2.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxConditionValue2.Items.Add(0);
                    comboBoxConditionValue2.Items.Add(1);
                    comboBoxConditionValue2.SelectedItem = 0;
                    break;
                case "Daily quest done":
                    labelConditionValue1.Text = "Quest Id";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Charmed":
                    break;
                case "Pet type":
                    labelConditionValue1.Text = "Pet type";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                case "Taxi":
                    break;
                case "Queststate":
                    labelConditionValue1.Text = "Quest Id";
                    labelConditionValue2.Text = "Queststate";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    comboBoxConditionValue2.Enabled = true;
                    checkBoxNegativeCondition.Enabled = false;
                    break;
                case "Quest objective complete":
                    labelConditionValue1.Text = "ObjectiveID";
                    labelConditionValue2.Text = "";
                    labelConditionValue3.Text = "";
                    comboBoxConditionValue1.Enabled = true;
                    break;
                default:
                    labelConditionValue1.Text = "ConditionValue1";
                    labelConditionValue2.Text = "ConditionValue2";
                    labelConditionValue3.Text = "ConditionValue3";
                    break;
            }
            updateComment();
        }

        void updateComment()
        {
            if (!updateFields)
                return;

            DataSet DS = new DataSet();
            string SourceComment = "";
            string ConditionComment = "";
            string NegativeCondition = "";
            string dbvalue = "";
            string dbvalue1 = "";
            string dbvalue2 = "";
            string target = "INVALID_TARGET";
            string effect = "INVALID_EFFECT";
            Int32 intvalue = 0;

            // Update Source part of comment
            switch (toolStripComboBoxSource.Text)
            {
                case "Creature loot template":
                case "Disenchant loot template":
                case "Fishing loot template":
                case "Gameobject loot template":
                case "Item loot template":
                case "Mail loot template":
                case "Milling loot template":
                case "Pickpocketing loot template":
                case "Prospecting loot template":
                case "Reference loot template":
                case "Skinning loot template":
                case "Spell loot template":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Item' AND `Id`=" + textBoxSourceEntry.Text +";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_ITEM";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    switch (sourceValue)
                    {
                        case 1:
                            dbvalue1 = "creature";
                            break;
                        case 2:
                            dbvalue1 = "disenchant";
                            break;
                        case 3:
                            dbvalue1 = "fishing";
                            break;
                        case 4:
                            dbvalue1 = "gameobject";
                            break;
                        case 5:
                            dbvalue1 = "item";
                            break;
                        case 6:
                            dbvalue1 = "mail";
                            break;
                        case 7:
                            dbvalue1 = "milling";
                            break;
                        case 8:
                            dbvalue1 = "pickpocketing";
                            break;
                        case 9:
                            dbvalue1 = "prospecting";
                            break;
                        case 10:
                            dbvalue1 = "reference";
                            break;
                        case 11:
                            dbvalue1 = "skinning";
                            break;
                        case 12:
                            dbvalue1 = "spell";
                            break;
                    }
                    SourceComment = dbvalue + " will drop from " + dbvalue1 + " loot template entry " + textBoxSourceGroup.Text + " if ";
                    break;
                case "Spell implicit target":

                    switch (textBoxSourceGroup.Text)
                    {
                        case "1":
                            effect = "(effect 0)";
                            break;
                        case "2":
                            effect = "(effect 1)";
                            break;
                        case "3":
                            effect = "(effects 0 & 1)";
                            break;
                        case "4":
                            effect = "(effect 2)";
                            break;
                        case "5":
                            effect = "(effects 0 & 2)";
                            break;
                        case "6":
                            effect = "(effects 1 & 2)";
                            break;
                        case "7":
                            effect = "(effect 0 & 1 & 2)";
                            break;
                    }

                    switch (comboBoxConditionTarget.Text)
                    {
                        case "0":
                            target = "potential target of the spell";
                            break;
                        case "1":
                            target = "caster of the spell";
                            break;
                    }

                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Spell' AND `Id`=" + textBoxSourceEntry.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_SPELL";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    SourceComment = "Spell " + dbvalue + " " + effect + " will hit the " + target + " if ";
                    break;
                case "Gossip menu":
                    SourceComment = "Show gossip menu " + textBoxSourceGroup.Text + " text id " + textBoxSourceEntry.Text + " if ";
                    break;
                case "Gossip menu option":
                    SourceComment = "Show gossip menu " + textBoxSourceGroup.Text + " option id " + textBoxSourceEntry.Text + " if ";
                    break;
                case "Creature template vehicle":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Unit' AND `Id`=" + textBoxSourceEntry.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_UNIT";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    switch (comboBoxConditionTarget.Text)
                    {
                        case "0":
                            target = "player riding vehicle ";
                            break;
                        case "1":
                            target = "vehicle ";
                            break;
                    }
                    SourceComment = "Condition will be true for " + target + dbvalue + " if ";
                    break;
                case "Spell":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Spell' AND `Id`=" + textBoxSourceEntry.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_SPELL";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    switch (comboBoxConditionTarget.Text)
                    {
                        case "0":
                            target = "caster of the spell";
                            break;
                        case "1":
                            target = "explicit target of the spell";
                            break;
                    }
                    SourceComment = "Spell " + dbvalue + " will hit the " + target + " if ";
                    break;
                case "Spell click event":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Unit' AND `Id`=" + textBoxSourceGroup.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_UNIT";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Spell' AND `Id`=" + textBoxSourceEntry.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue1 = "INVALID_SPELL";
                    else
                        dbvalue1 = DS.Tables["query"].Rows[0][0].ToString();

                    switch (comboBoxConditionTarget.Text)
                    {
                        case "0":
                            target = "player";
                            break;
                        case "1":
                            target = "self";
                            break;
                    }
                    SourceComment = "Spellclick unit " + dbvalue + " will cast spell " + dbvalue1  + " on " + target + " if ";
                    break;
                case "Quest available":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Quest' AND `Id`=" + textBoxSourceEntry.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_QUEST";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    SourceComment = "Quest " + dbvalue + " available if ";
                    break;
                case "Vehicle spell":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Unit' AND `Id`=" + textBoxSourceGroup.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_UNIT";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Spell' AND `Id`=" + textBoxSourceEntry.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue1 = "INVALID_SPELL";
                    else
                        dbvalue1 = DS.Tables["query"].Rows[0][0].ToString();

                    switch (comboBoxConditionTarget.Text)
                    {
                        case "0":
                            target = "player";
                            break;
                        case "1":
                            target = "self";
                            break;
                    }
                    SourceComment = "Vehicle unit " + dbvalue + " will cast spell " + dbvalue1 + " on " + target + " if ";
                    break;
                case "Smart event":
                    switch (textBoxSourceId.Text)
                    {
                        case "0":
                            target = "Creature SAI";
                            break;
                        case "1":
                            target = "Gameobject SAI";
                            break;
                        case "2":
                            target = "Areatrigger SAI";
                            break;
                        case "3":
                            target = "Event SAI";
                            break;
                        case "4":
                            target = "Gossip SAI";
                            break;
                        case "5":
                            target = "Quest SAI";
                            break;
                        case "6":
                            target = "Spell SAI";
                            break;
                        case "7":
                            target = "Transport SAI";
                            break;
                        case "8":
                            target = "Instance SAI";
                            break;
                        case "9":
                            target = "Actionlist SAI";
                            break;
                    }
                    int id = Int32.Parse(textBoxSourceGroup.Text) - 1;
                    SourceComment = " Id " + id + " of " + target + " for EntryOrGuid " + textBoxSourceEntry.Text + " will execute if ";
                    break;
                case "NPC vendor":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Unit' AND `Id`=" + textBoxSourceGroup.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_UNIT";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Item' AND `Id`=" + textBoxSourceEntry.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue1 = "INVALID_ITEM";
                    else
                        dbvalue1 = DS.Tables["query"].Rows[0][0].ToString();

                    SourceComment = "Vendor " + dbvalue + " will sell item " + dbvalue1 + " if ";
                    break;
                case "Spell proc":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Spell' AND `Id`=" + textBoxSourceEntry.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_SPELL";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    switch (comboBoxConditionTarget.Text)
                    {
                        case "0":
                            target = "actor";
                            break;
                        case "1":
                            target = "actionTarget";
                            break;
                    }
                    SourceComment = "Spell " + dbvalue + " can proc on " + target + " if ";
                    break;
                case "Terrain swap":
                    labelSourceEntry.Text = "Map Id";
                    SourceComment = "Terrain swap map " + textBoxSourceEntry.Text + " if ";
                    break;
                case "Phase":
                    SourceComment = "Set Phase to " + textBoxSourceGroup.Text + " for area " + textBoxSourceEntry.Text + " if ";
                    break;
            }

            // Update Condition part of comment
            switch (toolStripComboBoxCondition.Text)
            {
                case "None":
                    break;
                case "Aura":
                   DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Spell' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                   if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_SPELL";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    switch (comboBoxConditionValue2.Text)
                    {
                        case "1":
                            effect = "(effect 0)";
                            break;
                        case "2":
                            effect = "(effect 1)";
                            break;
                        case "4":
                            effect = "(effect 2)";
                            break;
                    }
                    NegativeCondition = "has";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "does not have";
                    ConditionComment = "target " + NegativeCondition + " aura " + dbvalue + " " + effect + ".";
                    break;
                case "Item":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Item' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_ITEM";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    if (comboBoxConditionValue3.Text == "1")
                        dbvalue1 = " Item can be in bank.";
                    else
                        dbvalue1 = " Item cannot be in bank.";
                       
                    NegativeCondition = "has ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "does not have ";

                    ConditionComment = "player " + NegativeCondition + comboBoxConditionValue2.Text + " of " + dbvalue + "." + dbvalue1;
                    break;
                case "Item equipped":
                        DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Item' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                        if (DS.Tables["query"].Rows.Count == 0)
                            dbvalue = "INVALID_ITEM";
                        else
                            dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "has ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "does not have ";
                    ConditionComment = "player " + NegativeCondition + dbvalue + " equiped.";
                        break;
                case "Zone id":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Area' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_ZONE";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "player is " + NegativeCondition + "in zone " + dbvalue + ".";
                    break;
                case "Reputation rank":
                    dbvalue1 = "";
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Faction' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_FACTION";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    try
                    {
                        intvalue = Int32.Parse(comboBoxConditionValue2.Text);
                        BitArray b = new BitArray(new int[] { intvalue });

                        effect = "";
                        for (int i = 0; i < 8; i++)
                        {
                            if (b[i])
                            {
                                switch (i)
                                {
                                    case 0:
                                        effect = "Hated";
                                        break;
                                    case 1:
                                        effect = "Hostile";
                                        break;
                                    case 2:
                                        effect = "Unfriendly";
                                        break;
                                    case 3:
                                        effect = "Neutral";
                                        break;
                                    case 4:
                                        effect = "Friendly";
                                        break;
                                    case 5:
                                        effect = "Honored";
                                        break;
                                    case 6:
                                        effect = "Revered";
                                        break;
                                    case 7:
                                        effect = "Exalted";
                                        break;
                                }

                                if (effect != "")
                                {
                                    if (dbvalue1 != "")
                                        dbvalue1 = dbvalue1 + " or ";

                                    dbvalue1 = dbvalue1 + effect;
                                }
                            }
                        }
                    }
                    catch { }

                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "player is " + NegativeCondition + dbvalue1 + " with faction " + dbvalue + ".";
                    break;
                case "Team":
                    switch (comboBoxConditionValue1.Text)
                    {
                        case "67":
                            target = "Horde";
                            break;
                        case "469":
                            target = "Alliance";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "player is " + NegativeCondition + "on the " + target + " team.";
                    break;
                case "Skill":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Skill' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_SKILL";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "player must " + NegativeCondition + "have reached " + comboBoxConditionValue2.Text + " on skill " + dbvalue + ".";
                    break;
                case "Quest rewarded":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Quest' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_QUEST";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "quest " + dbvalue + " has " + NegativeCondition + "been rewarded.";
                    break;
                case "Quest taken":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Quest' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_QUEST";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "quest " + dbvalue + " has " + NegativeCondition + "been taken.";
                    break;
                case "Drunken state":
                    switch (comboBoxConditionValue1.Text)
                    {
                        case "0":
                            target = "sober";
                            break;
                        case "1":
                            target = "tipsy";
                            break;
                        case "2":
                            target = "drunk";
                            break;
                        case "3":
                            target = "smashed";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "player is " + NegativeCondition + target + ".";
                    break;
                case "World state":
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "world state is" + NegativeCondition + " " + comboBoxConditionValue1.Text + ".";
                    break;
                case "Active world event":
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "active event is" + NegativeCondition + " " + comboBoxConditionValue1.Text + ".";
                    break;
                case "Instance info":
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "instance info event entry " + comboBoxConditionValue1.Text + " data " + comboBoxConditionValue2.Text + " type " + comboBoxConditionValue3.Text + " has " + NegativeCondition + "been completed.";
                    break;
                case "Quest not taken":
                        if (comboBoxConditionValue1.Text == "") break;
                        DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Quest' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                        if (DS.Tables["query"].Rows.Count == 0)
                            dbvalue = "INVALID_QUEST";
                        else
                            dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    NegativeCondition = "not ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "";
                    ConditionComment = "quest " + dbvalue + " has " + NegativeCondition + "been taken.";
                    break;
                case "Class":
                        if (comboBoxConditionValue1.Text == "") break;
                        dbvalue = "";
                        try
                        {
                            intvalue = Int32.Parse(comboBoxConditionValue1.Text);
                            BitArray b = new BitArray(new int[] { intvalue }); // uint32 flag = 1 << bit_position;

                            for (int i = 0; i < 11; i++)
                            {
                                if (b[i])
                                {
                                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Class' AND `Id`=" + i + ";");
                                    if (DS.Tables["query"].Rows.Count == 0)
                                        dbvalue1 = "";
                                    else
                                        dbvalue1 = DS.Tables["query"].Rows[0][0].ToString();

                                    if (dbvalue1 !="")
                                    {
                                        if (dbvalue != "")
                                            dbvalue = dbvalue + " or ";

                                        dbvalue = dbvalue + dbvalue1;
                                    }
                                }
                            }
                        }
                        catch
                        {
                            comboBoxConditionValue1.Text = "0";
                        }

                        NegativeCondition = "";
                        if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                        ConditionComment = "player is " + NegativeCondition + "a " + dbvalue + ".";
                    break;
                case "Race":
                        try
                        {
                            intvalue = Int32.Parse(comboBoxConditionValue1.Text);
                            BitArray b = new BitArray(new int[] { intvalue });
                            dbvalue = "";
                            dbvalue1 = "";
                            for (int i = 0; i < 26; i++)
                            {
                                if (b[i])
                                {
                                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Race' AND `Id`=" + i + ";");
                                    if (DS.Tables["query"].Rows.Count != 0)
                                        dbvalue1 = DS.Tables["query"].Rows[0][0].ToString();

                                    if (dbvalue1 != "")
                                    {
                                        if (dbvalue != "")
                                            dbvalue = dbvalue + " or ";

                                        dbvalue = dbvalue + dbvalue1;
                                        dbvalue1 = "";
                                    }
                                }
                            }
                        }
                        catch
                        {
                            comboBoxConditionValue1.Text = "0";
                        }
                        NegativeCondition = "";
                        if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                        ConditionComment = "player is " + NegativeCondition + "a " + dbvalue + ".";
                    break;
                case "Acievement":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Achievement' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_ACHIEVEMENT";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "has ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "does not have ";
                    ConditionComment = "player " + NegativeCondition + "achievement " + dbvalue + ".";
                    break;
                case "Title":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Title' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_TITLE";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "has ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "does not have ";
                    ConditionComment = "player " + NegativeCondition + "title " + dbvalue + ".";
                    break;
                case "Spawn mask":
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "spawn mask is" + NegativeCondition + " " + comboBoxConditionValue1.Text + ".";
                    break;
                case "Gender":
                    switch (comboBoxConditionValue1.Text)
                    {
                        case "0":
                            target = "male";
                            break;
                        case "1":
                            target = "female";
                            break;
                        case "2":
                            target = "none";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "target gender is" + NegativeCondition + " " + target + ".";
                    break;
                case "Unit state":
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "unit state is" + NegativeCondition + " " + comboBoxConditionValue1.Text + ".";
                    break;
                case "Map id":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Map' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_MAP";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "target map is" + NegativeCondition + " " + dbvalue + ".";
                    break;
                case "Area id":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Area' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_AREA";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "target area is" + NegativeCondition + " " + dbvalue + ".";
                    break;
                case "Creature type":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'CreatureType' AND `Id`=" + comboBoxConditionValue1.Text + ";");

                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_CREATURE_TYPE";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    switch (dbvalue)
                    {
                        case "0":
                            dbvalue = "None";
                            break;
                        case "1":
                            dbvalue = "Beast";
                            break;
                        case "2":
                            dbvalue = "Dragonkin";
                            break;
                        case "3":
                            dbvalue = "Demon";
                            break;
                        case "4":
                            dbvalue = "Elemental";
                            break;
                        case "5":
                            dbvalue = "Giant";
                            break;
                        case "6":
                            dbvalue = "Undead";
                            break;
                        case "7":
                            dbvalue = "Humanoid";
                            break;
                        case "8":
                            dbvalue = "Critter";
                            break;
                        case "9":
                            dbvalue = "Mechanical";
                            break;
                        case "10":
                            dbvalue = "Not specified";
                            break;
                        case "11":
                            dbvalue = "Totem";
                            break;
                        case "12":
                            dbvalue = "Non-Combat Pet";
                            break;
                        case "13":
                            dbvalue = "Gas Cloud";
                            break;
                        case "14":
                            dbvalue = "Wild Pet";
                            break;
                        case "15":
                            dbvalue = "Aberration";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "creature type is" + NegativeCondition + " " + dbvalue + ".";
                    break;
                case "Spell":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Spell' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_SPELL";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "target spell is" + NegativeCondition + " " + dbvalue + ".";
                    break;
                case "Phase mask":
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not";
                    ConditionComment = "phasemask is" + NegativeCondition + " " + comboBoxConditionValue1.Text + ".";
                    break;
                case "Level":
                    switch (comboBoxConditionValue2.Text)
                    {
                        case "0":
                            target = "equal to ";
                            break;
                        case "1":
                            target = "higher than ";
                            break;
                        case "2":
                            target = "lesser than ";
                            break;
                        case "3":
                            target = "equal or higher than ";
                            break;
                        case "4":
                            target = "equal or lower than ";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "player level must " + NegativeCondition + "be " + target + comboBoxConditionValue1.Text + ".";
                    break;
                case "Quest complete":
                    if (comboBoxConditionValue1.Text == "") break;
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Quest' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_QUEST";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "quest " + dbvalue + " has " + NegativeCondition + "been completed.";
                    break;
                case "Near creature":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Unit' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_UNIT";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "target is " + NegativeCondition + "unit " + dbvalue + " within " + comboBoxConditionValue2.Text + " yards.";
                    break;
                case "Near gameobject":
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'GameObject' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_GAMEOBJECT";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "target is " + NegativeCondition + "gameobject " + dbvalue + " within " + comboBoxConditionValue2.Text + " yards.";
                    break;
                case "Object entry guid":
                    switch (comboBoxConditionValue1.Text)
                    {
                        case "3":
                            dbvalue = "unit";
                            break;
                        case "4":
                            dbvalue = "player";
                            break;
                        case "5":
                            dbvalue = "gameobject";
                            break;
                        case "7":
                            dbvalue = "corpse";
                            break;
                    }

                    if (dbvalue == "unit")
                    {
                        comboBoxConditionValue2.Enabled = true;
                        comboBoxConditionValue3.Enabled = true;
                        if (comboBoxConditionValue1.Text == "0")
                            dbvalue1 = "any unit";
                        else
                        {
                            if (comboBoxConditionValue1.Text == "") break;
                            DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Unit' AND `Id`=" + comboBoxConditionValue2.Text + ";");
                            if (DS.Tables["query"].Rows.Count == 0)
                                dbvalue1 = "INVALID_UNIT";
                            else
                                dbvalue1 = DS.Tables["query"].Rows[0][0].ToString();
                        }
                    }

                    if (dbvalue == "gameobject")
                    {
                        comboBoxConditionValue2.Enabled = true;
                        comboBoxConditionValue3.Enabled = true;
                        if (comboBoxConditionValue1.Text == "0")
                            dbvalue1 = "any gameobject";
                        else
                        {
                            if (comboBoxConditionValue1.Text == "") break;
                            DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'GameObject' AND `Id`=" + comboBoxConditionValue2.Text + ";");
                            if (DS.Tables["query"].Rows.Count == 0)
                                dbvalue1 = "INVALID_GAMEOBJECT";
                            else
                                dbvalue1 = DS.Tables["query"].Rows[0][0].ToString();
                        }
                    }

                    if (dbvalue == "player" || dbvalue == "corpse")
                    {
                        comboBoxConditionValue2.Enabled = false;
                        comboBoxConditionValue2.Text = "0";
                        comboBoxConditionValue3.Enabled = false;
                        comboBoxConditionValue3.Text = "0";
                        dbvalue1 = "any player";
                    }
                    dbvalue2 = "";
                    if (comboBoxConditionValue3.Text != "0")
                        dbvalue2 = " guid " + comboBoxConditionValue3.Text;
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "target is " + NegativeCondition + dbvalue + " " + dbvalue1 + dbvalue2 + ".";
                    break;
                case "Type mask":
                    target = "";
                    switch (comboBoxConditionValue1.Text)
                    {
                        case "8":
                            target = "unit";
                            break;
                        case "16":
                            target = "player";
                            break;
                        case "32":
                            target = "gameobject";
                            break;
                        case "128":
                            target = "player corpse, after released spirit";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "target is " + NegativeCondition + target + ".";
                    break;
                case "Relation to":
                    //TODO more info on targets
                    switch (comboBoxConditionValue2.Text)
                    {
                        case "0":
                            target = "the same as ";
                            break;
                        case "1":
                            target = "in a party with ";
                            break;
                        case "2":
                            target = "in a raid party with ";
                            break;
                        case "3":
                            target = "owned by ";
                            break;
                        case "4":
                            target = "a passenger of ";
                            break;
                        case "5":
                            target = "created by";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "target is " + NegativeCondition + target + "condition target.";
                    break;
                case "Reaction to":
                    dbvalue1 = "";

                    try
                    {
                        intvalue = Int32.Parse(comboBoxConditionValue2.Text);
                        BitArray b = new BitArray(new int[] { intvalue });

                        effect = "";
                        for (int i = 0; i < 8; i++)
                        {
                            if (b[i])
                            {
                                switch (i)
                                {
                                    case 0:
                                        effect = "Hated";
                                        break;
                                    case 1:
                                        effect = "Hostile";
                                        break;
                                    case 2:
                                        effect = "Unfriendly";
                                        break;
                                    case 3:
                                        effect = "Neutral";
                                        break;
                                    case 4:
                                        effect = "Friendly";
                                        break;
                                    case 5:
                                        effect = "Honored";
                                        break;
                                    case 6:
                                        effect = "Revered";
                                        break;
                                    case 7:
                                        effect = "Exalted";
                                        break;
                                }

                                if (effect != "")
                                {
                                    if (dbvalue1 != "")
                                        dbvalue1 = dbvalue1 + " or ";

                                    dbvalue1 = dbvalue1 + effect;
                                }
                            }
                        }
                    }
                    catch { }

                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "target is " + NegativeCondition + dbvalue1 + " with condition target.";
                    break;
                case "Distance to":
                    switch (comboBoxConditionValue3.Text)
                    {
                        case "0":
                            target = "equal to ";
                            break;
                        case "1":
                            target = "higher than ";
                            break;
                        case "2":
                            target = "lesser than ";
                            break;
                        case "3":
                            target = "equal or higher than ";
                            break;
                        case "4":
                            target = "equal or lower than ";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "distance to target is " + NegativeCondition + target + comboBoxConditionValue2.Text + " yards.";
                    break;
                case "Alive":
                    NegativeCondition = "alive.";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "dead.";
                    ConditionComment = "target is " + NegativeCondition;
                    break;
                case "Health point value":
                    switch (comboBoxConditionValue2.Text)
                    {
                        case "0":
                            target = "equal to ";
                            break;
                        case "1":
                            target = "higher than ";
                            break;
                        case "2":
                            target = "lesser than ";
                            break;
                        case "3":
                            target = "equal or higher than ";
                            break;
                        case "4":
                            target = "equal or lower than ";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "target health value must " + NegativeCondition + "be " + target + comboBoxConditionValue1.Text + ".";
                    break;
                case "Health point percentage":
                    switch (comboBoxConditionValue2.Text)
                    {
                        case "0":
                            target = "equal to ";
                            break;
                        case "1":
                            target = "higher than ";
                            break;
                        case "2":
                            target = "lesser than ";
                            break;
                        case "3":
                            target = "equal or higher than ";
                            break;
                        case "4":
                            target = "equal or lower than ";
                            break;
                    }
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "target health percentage must " + NegativeCondition + "be " + target + comboBoxConditionValue1.Text + "% of max Health.";
                    break;
                case "Realm achievement":
                    if (comboBoxConditionValue1.Text == "") break;
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Achievement' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_ACHIEVEMENT";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    NegativeCondition = "has ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "does not have ";
                    ConditionComment = "player " + NegativeCondition + "achievement " + dbvalue;
                    break;
                case "In water":
                    NegativeCondition = "on land.";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "in water.";
                    ConditionComment = "target is " + NegativeCondition;
                    break;
                case "Terrain swap":
                    if (comboBoxConditionValue1.Text == "") break;
                    NegativeCondition = " ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not ";
                    ConditionComment = "object is" + NegativeCondition + "on terrain swap";
                    break;
                case "Stand state":
                    if (comboBoxConditionValue1.Text == "0")
                        switch (comboBoxConditionValue2.Text)
                        {
                            case "0":
                                effect = "a standing state.";
                                break;
                            case "1":
                                effect = "a sitting state.";
                                break;
                        }
                    else
                    {
                        switch (comboBoxConditionValue2.Text)
                        {
                            case "0":
                                effect = "any standing state.";
                                break;
                            case "1":
                                effect = "any sitting state.";
                                break;
                        }
                    }
                    NegativeCondition = "in ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not in ";
                    ConditionComment = "target is " + NegativeCondition + effect;
                    break;
                case "Daily quest done":
                    if (comboBoxConditionValue1.Text == "") break;
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Quest' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_QUEST";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();

                    NegativeCondition = " ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = " not ";
                    ConditionComment = "Daily quest " + dbvalue + " has" + NegativeCondition + "been done.";
                    break;
                case "Charmed":
                    NegativeCondition = "charmed";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not charmed";
                    ConditionComment = "target is " + NegativeCondition;
                    break;
                case "Pet type":
                    string type = "";
                    if (comboBoxConditionValue1.Text == "") break;
                    else if (comboBoxConditionValue1.Text == "0")
                        type = "SUMMON_PET";
                    else if (comboBoxConditionValue1.Text == "1")
                        type = "HUNTER_PET";
                    else
                        type = "INVALID_TYPE";
                    NegativeCondition = " ";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "Pet type is " + NegativeCondition + type;
                    break;
                case "Taxi":
                    NegativeCondition = "on taxi.";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not on taxi.";
                    ConditionComment = "target is " + NegativeCondition;
                    break;
                case "Queststate":
                    if (comboBoxConditionValue1.Text == "") break;
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Quest' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_QUEST";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    string state = "";
                    if (comboBoxConditionValue2.Text == "0")
                        state = "NONE";
                    else if (comboBoxConditionValue2.Text == "1")
                        state = "COMPLETE";
                    else if(comboBoxConditionValue2.Text == "3")
                        state = "INCOMPLETE";
                    else if(comboBoxConditionValue2.Text == "5")
                        state = "FAILED";
                    else if (comboBoxConditionValue2.Text == "6")
                        state = "REWARED";
                    else
                        state = "INVALID_STATE";

                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "";
                    ConditionComment = "Daily quest " + dbvalue + " queststate must be " + state;
                    break;
                case "Quest objective complete":
                    if (comboBoxConditionValue1.Text == "") break;
                    DS = dbread("Select `Name` FROM `objectnames` WHERE `ObjectType`= 'Quest' AND `Id`=" + comboBoxConditionValue1.Text + ";");
                    if (DS.Tables["query"].Rows.Count == 0)
                        dbvalue = "INVALID_QUEST";
                    else
                        dbvalue = DS.Tables["query"].Rows[0][0].ToString();
                    NegativeCondition = "";
                    if (checkBoxNegativeCondition.Checked == true) NegativeCondition = "not ";
                    ConditionComment = "quest objective " + dbvalue + " has " + NegativeCondition + "been completed.";
                    break;
            }
            // Output comment to textbox
            textBoxComment.Text = SourceComment + ConditionComment;
        }

        void CreateSQL()
        {
            // *** TODO ***
            // Redesign for multiple insert.
            // *** TODO ***

            // Check if grid rows exist
            if (dataGridViewConditions.Rows.Count == 0)
                return;

            string sqlComment = "";
            string sqlDelete = "";
            string sqlInsertString = "INSERT INTO `conditions` (`SourceTypeOrReferenceId`, `SourceGroup`, `SourceEntry`, `SourceId`, `ElseGroup`, `ConditionTypeOrReference`, `ConditionTarget`, `ConditionValue1`, `ConditionValue2`, `ConditionValue3`, `NegativeCondition`, `ErrorType`, `ErrorTextId`, `ScriptName`, `Comment`) VALUES" + "\r\n";
            string sqlInsertValues = "";
            string source = "";
            string condition = "";

            string scriptname = "";
            string comment = "";
            sqlString = "";

            int indexsource = 0;
            int indexcondition = 0;

            DataGridViewRow row = null;
            // If there are rows then convert them to sql
            for (int i = 0; i < dataGridViewConditions.RowCount; i++)
            {
                // Get row
                row = dataGridViewConditions.Rows[i];

                // Get Source Id from row
                indexsource = Int32.Parse(row.Cells[0].Value.ToString());
                if (indexsource > 19) indexsource = indexsource - 1;
                source = toolStripComboBoxSource.Items[indexsource].ToString();

                // Get Condition Id from row
                indexcondition = Int32.Parse(row.Cells[5].Value.ToString());
                condition = toolStripComboBoxCondition.Items[indexcondition].ToString();

                // Create Comment Line from row
                sqlComment = "-- Condition for source " + source + " condition type " + condition + "\r\n";

                // Create Delete Line from row
                sqlDelete = "DELETE FROM `conditions` WHERE `SourceTypeOrReferenceId`=" + row.Cells[0].Value + " AND `SourceGroup`=" + row.Cells[1].Value + " AND `SourceEntry`=" + row.Cells[2].Value + " AND `SourceId`=" + row.Cells[3].Value + ";" + "\r\n";

                // Create Insert Values Line from row
                scriptname = row.Cells[13].Value.ToString().Replace("'", "''");
                comment = row.Cells[14].Value.ToString().Replace("'", "''");
                sqlInsertValues = "(" + row.Cells[0].Value + ", " + row.Cells[1].Value + ", " + row.Cells[2].Value + ", " + row.Cells[3].Value + ", " + row.Cells[4].Value + ", " + row.Cells[5].Value + ", " + row.Cells[6].Value + ", " + row.Cells[7].Value + ", " + row.Cells[8].Value + ", " + row.Cells[9].Value + ", " + row.Cells[10].Value + ", " + row.Cells[11].Value + ", " + row.Cells[12].Value + ", '" + row.Cells[13].Value + "', '" + comment + "');\r\n\r\n";

                // Create full SQL Insert String for row
                sqlString = sqlString + sqlComment + sqlDelete + sqlInsertString + sqlInsertValues;
            }  
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewConditions.RowCount == 0)
            {
                MessageBox.Show("Condition table is empty. You must add conditions first.", "Unable to save to file");
                return;
            }

            CreateSQL();
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "SQL File|*.sql";
            saveFileDialog1.Title = "Export to SQL File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(@saveFileDialog1.FileName, sqlString);
            }
        }

        private void copyToClipboardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewConditions.RowCount == 0)
            {
                MessageBox.Show("Condition table is empty. You must add conditions first.", "Unable to copy to clipboard");
                return;
            }

            CreateSQL();
            System.Windows.Forms.Clipboard.SetText(sqlString);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count != 2)
            {
                FormConditionHelper frm = new FormConditionHelper();
                frm.Show();
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridViewConditions.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dataGridViewConditions.SelectedCells[0].OwningRow.Index;
                if (rowIndex == 0)
                    return;
                // get index of the column for the selected cell
                int colIndex = dataGridViewConditions.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dataGridViewConditions.Rows[rowIndex];
                dataGridViewConditions.Rows.Remove(selectedRow);
                dataGridViewConditions.Rows.Insert(rowIndex - 1, selectedRow);
                dataGridViewConditions.ClearSelection();
                dataGridViewConditions.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            try
            {
                int totalRows = dataGridViewConditions.Rows.Count;
                // get index of the row for the selected cell
                int rowIndex = dataGridViewConditions.SelectedCells[0].OwningRow.Index;
                if (rowIndex == totalRows - 1)
                    return;
                // get index of the column for the selected cell
                int colIndex = dataGridViewConditions.SelectedCells[0].OwningColumn.Index;
                DataGridViewRow selectedRow = dataGridViewConditions.Rows[rowIndex];
                dataGridViewConditions.Rows.Remove(selectedRow);
                dataGridViewConditions.Rows.Insert(rowIndex + 1, selectedRow);
                dataGridViewConditions.ClearSelection();
                dataGridViewConditions.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
            }
            catch { }
        }

        private void FormCreator_Load(object sender, EventArgs e)
        {
            // Check to see if cc.db3 exist. If not exist program.
            if (!File.Exists("cc.db3"))
            {
                MessageBox.Show("Please ensure the cc.s3db database file is in your application path.", "Missing Database File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Application.Exit();
            }
        }
    }
}
