namespace ConditionCreator
{
    partial class FormCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreator));
            this.menuStripSourceCondition = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSourceType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxSource = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripMenuItemConditionType = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBoxCondition = new System.Windows.Forms.ToolStripComboBox();
            this.textBoxScriptName = new System.Windows.Forms.TextBox();
            this.labelScriptName = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.groupBoxConditionType = new System.Windows.Forms.GroupBox();
            this.textBoxSourceId = new System.Windows.Forms.TextBox();
            this.labelSourceId = new System.Windows.Forms.Label();
            this.textBoxSourceEntry = new System.Windows.Forms.TextBox();
            this.labelSourceEntry = new System.Windows.Forms.Label();
            this.textBoxSourceGroup = new System.Windows.Forms.TextBox();
            this.labelSourceGroup = new System.Windows.Forms.Label();
            this.groupBoxReferenceType = new System.Windows.Forms.GroupBox();
            this.comboBoxConditionValue3 = new System.Windows.Forms.ComboBox();
            this.comboBoxConditionValue2 = new System.Windows.Forms.ComboBox();
            this.comboBoxConditionValue1 = new System.Windows.Forms.ComboBox();
            this.comboBoxConditionTarget = new System.Windows.Forms.ComboBox();
            this.labelTarget = new System.Windows.Forms.Label();
            this.labelConditionValue3 = new System.Windows.Forms.Label();
            this.labelConditionValue2 = new System.Windows.Forms.Label();
            this.labelConditionValue1 = new System.Windows.Forms.Label();
            this.groupBoxErrorHandling = new System.Windows.Forms.GroupBox();
            this.textBoxErrorTextId = new System.Windows.Forms.TextBox();
            this.labelErrorTextId = new System.Windows.Forms.Label();
            this.textBoxErrorType = new System.Windows.Forms.TextBox();
            this.labelErrorType = new System.Windows.Forms.Label();
            this.buttonResetAll = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxLogicalGrouping = new System.Windows.Forms.GroupBox();
            this.textBoxElseGroup = new System.Windows.Forms.TextBox();
            this.labelElseGroup = new System.Windows.Forms.Label();
            this.groupBoxReverseTrueCondition = new System.Windows.Forms.GroupBox();
            this.checkBoxNegativeCondition = new System.Windows.Forms.CheckBox();
            this.dataGridViewConditions = new System.Windows.Forms.DataGridView();
            this.SourceTypeOrReferenceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceEntry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElseGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionTypeOrReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionValue1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConditionValue3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NegativeCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorTextId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScriptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddtoList = new System.Windows.Forms.Button();
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxScript = new System.Windows.Forms.GroupBox();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonRetrieveFromList = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.menuStripSourceCondition.SuspendLayout();
            this.groupBoxConditionType.SuspendLayout();
            this.groupBoxReferenceType.SuspendLayout();
            this.groupBoxErrorHandling.SuspendLayout();
            this.groupBoxLogicalGrouping.SuspendLayout();
            this.groupBoxReverseTrueCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConditions)).BeginInit();
            this.menuStripMenu.SuspendLayout();
            this.groupBoxScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripSourceCondition
            // 
            this.menuStripSourceCondition.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSourceType,
            this.toolStripComboBoxSource,
            this.ToolStripMenuItemConditionType,
            this.toolStripComboBoxCondition});
            this.menuStripSourceCondition.Location = new System.Drawing.Point(0, 24);
            this.menuStripSourceCondition.Name = "menuStripSourceCondition";
            this.menuStripSourceCondition.Size = new System.Drawing.Size(1054, 27);
            this.menuStripSourceCondition.TabIndex = 1;
            this.menuStripSourceCondition.Text = "menuStrip1";
            // 
            // toolStripMenuItemSourceType
            // 
            this.toolStripMenuItemSourceType.Name = "toolStripMenuItemSourceType";
            this.toolStripMenuItemSourceType.Size = new System.Drawing.Size(83, 23);
            this.toolStripMenuItemSourceType.Text = "Source Type";
            // 
            // toolStripComboBoxSource
            // 
            this.toolStripComboBoxSource.AutoSize = false;
            this.toolStripComboBoxSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxSource.DropDownWidth = 200;
            this.toolStripComboBoxSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBoxSource.Items.AddRange(new object[] {
            "None",
            "Creature loot template",
            "Disenchant loot template",
            "Fishing loot template",
            "Gameobject loot template",
            "Item loot template",
            "Mail loot template",
            "Milling loot template",
            "Pickpocketing loot template",
            "Prospecting loot template",
            "Reference loot template",
            "Skinning loot template",
            "Spell loot template",
            "Spell implicit target",
            "Gossip menu",
            "Gossip menu option",
            "Creature template vehicle",
            "Spell",
            "Spell click event",
            "Quest accept",
            "Quest show mark",
            "Vehicle spell",
            "Smart event",
            "NPC vendor",
            "Spell proc",
            "Terrain swap",
            "Phase"});
            this.toolStripComboBoxSource.Name = "toolStripComboBoxSource";
            this.toolStripComboBoxSource.Size = new System.Drawing.Size(200, 23);
            this.toolStripComboBoxSource.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSource_SelectedIndexChanged);
            // 
            // ToolStripMenuItemConditionType
            // 
            this.ToolStripMenuItemConditionType.Name = "ToolStripMenuItemConditionType";
            this.ToolStripMenuItemConditionType.Size = new System.Drawing.Size(100, 23);
            this.ToolStripMenuItemConditionType.Text = "Condition Type";
            // 
            // toolStripComboBoxCondition
            // 
            this.toolStripComboBoxCondition.AutoSize = false;
            this.toolStripComboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCondition.DropDownWidth = 200;
            this.toolStripComboBoxCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toolStripComboBoxCondition.Items.AddRange(new object[] {
            "None",
            "Aura",
            "Item",
            "Item equipped",
            "Zone id",
            "Reputation rank",
            "team",
            "Skill",
            "Quest rewarded",
            "Quest taken",
            "Drunken state",
            "World state",
            "Active world event",
            "Instance Info",
            "Quest not taken",
            "Class",
            "Race",
            "Achievement",
            "Title",
            "Spawn mask",
            "Gender",
            "Unit state",
            "Map id",
            "Area id",
            "Spell",
            "Phase mask",
            "Level",
            "Quest complete",
            "Near creature",
            "Near gameobject",
            "Object entry guid",
            "Type mask",
            "Relation to",
            "Reaction to",
            "Distance to",
            "Alive",
            "Health point value",
            "Health point percentage",
            "Realm achievement",
            "In water",
            "Stand state"});
            this.toolStripComboBoxCondition.Name = "toolStripComboBoxCondition";
            this.toolStripComboBoxCondition.Size = new System.Drawing.Size(200, 23);
            this.toolStripComboBoxCondition.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxCondition_SelectedIndexChanged);
            // 
            // textBoxScriptName
            // 
            this.textBoxScriptName.Location = new System.Drawing.Point(6, 39);
            this.textBoxScriptName.Name = "textBoxScriptName";
            this.textBoxScriptName.Size = new System.Drawing.Size(245, 20);
            this.textBoxScriptName.TabIndex = 28;
            // 
            // labelScriptName
            // 
            this.labelScriptName.AutoSize = true;
            this.labelScriptName.Location = new System.Drawing.Point(3, 23);
            this.labelScriptName.Name = "labelScriptName";
            this.labelScriptName.Size = new System.Drawing.Size(62, 13);
            this.labelScriptName.TabIndex = 27;
            this.labelScriptName.Text = "ScriptName";
            this.labelScriptName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComment.Location = new System.Drawing.Point(69, 198);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.ReadOnly = true;
            this.textBoxComment.Size = new System.Drawing.Size(972, 20);
            this.textBoxComment.TabIndex = 30;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(12, 201);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(51, 13);
            this.labelComment.TabIndex = 29;
            this.labelComment.Text = "Comment";
            this.labelComment.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBoxConditionType
            // 
            this.groupBoxConditionType.Controls.Add(this.textBoxSourceId);
            this.groupBoxConditionType.Controls.Add(this.labelSourceId);
            this.groupBoxConditionType.Controls.Add(this.textBoxSourceEntry);
            this.groupBoxConditionType.Controls.Add(this.labelSourceEntry);
            this.groupBoxConditionType.Controls.Add(this.textBoxSourceGroup);
            this.groupBoxConditionType.Controls.Add(this.labelSourceGroup);
            this.groupBoxConditionType.Location = new System.Drawing.Point(14, 62);
            this.groupBoxConditionType.Name = "groupBoxConditionType";
            this.groupBoxConditionType.Size = new System.Drawing.Size(187, 129);
            this.groupBoxConditionType.TabIndex = 31;
            this.groupBoxConditionType.TabStop = false;
            this.groupBoxConditionType.Text = "Reference Type";
            // 
            // textBoxSourceId
            // 
            this.textBoxSourceId.Location = new System.Drawing.Point(110, 69);
            this.textBoxSourceId.MaxLength = 10;
            this.textBoxSourceId.Name = "textBoxSourceId";
            this.textBoxSourceId.Size = new System.Drawing.Size(70, 20);
            this.textBoxSourceId.TabIndex = 12;
            this.textBoxSourceId.Text = "0";
            this.textBoxSourceId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSourceId.TextChanged += new System.EventHandler(this.textBoxSourceId_TextChanged);
            this.textBoxSourceId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSourceId_KeyPress);
            // 
            // labelSourceId
            // 
            this.labelSourceId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSourceId.Location = new System.Drawing.Point(10, 70);
            this.labelSourceId.Name = "labelSourceId";
            this.labelSourceId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSourceId.Size = new System.Drawing.Size(97, 16);
            this.labelSourceId.TabIndex = 11;
            this.labelSourceId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSourceEntry
            // 
            this.textBoxSourceEntry.Location = new System.Drawing.Point(110, 43);
            this.textBoxSourceEntry.MaxLength = 10;
            this.textBoxSourceEntry.Name = "textBoxSourceEntry";
            this.textBoxSourceEntry.Size = new System.Drawing.Size(70, 20);
            this.textBoxSourceEntry.TabIndex = 10;
            this.textBoxSourceEntry.Text = "0";
            this.textBoxSourceEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSourceEntry.TextChanged += new System.EventHandler(this.textBoxSourceEntry_TextChanged);
            this.textBoxSourceEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSourceEntry_KeyPress);
            // 
            // labelSourceEntry
            // 
            this.labelSourceEntry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSourceEntry.Location = new System.Drawing.Point(10, 44);
            this.labelSourceEntry.Name = "labelSourceEntry";
            this.labelSourceEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSourceEntry.Size = new System.Drawing.Size(97, 16);
            this.labelSourceEntry.TabIndex = 9;
            this.labelSourceEntry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSourceGroup
            // 
            this.textBoxSourceGroup.Location = new System.Drawing.Point(110, 17);
            this.textBoxSourceGroup.MaxLength = 10;
            this.textBoxSourceGroup.Name = "textBoxSourceGroup";
            this.textBoxSourceGroup.Size = new System.Drawing.Size(70, 20);
            this.textBoxSourceGroup.TabIndex = 8;
            this.textBoxSourceGroup.Text = "0";
            this.textBoxSourceGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxSourceGroup.TextChanged += new System.EventHandler(this.textBoxSourceGroup_TextChanged);
            this.textBoxSourceGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSourceGroup_KeyPress);
            // 
            // labelSourceGroup
            // 
            this.labelSourceGroup.Location = new System.Drawing.Point(7, 19);
            this.labelSourceGroup.Name = "labelSourceGroup";
            this.labelSourceGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSourceGroup.Size = new System.Drawing.Size(100, 15);
            this.labelSourceGroup.TabIndex = 7;
            this.labelSourceGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxReferenceType
            // 
            this.groupBoxReferenceType.Controls.Add(this.comboBoxConditionValue3);
            this.groupBoxReferenceType.Controls.Add(this.comboBoxConditionValue2);
            this.groupBoxReferenceType.Controls.Add(this.comboBoxConditionValue1);
            this.groupBoxReferenceType.Controls.Add(this.comboBoxConditionTarget);
            this.groupBoxReferenceType.Controls.Add(this.labelTarget);
            this.groupBoxReferenceType.Controls.Add(this.labelConditionValue3);
            this.groupBoxReferenceType.Controls.Add(this.labelConditionValue2);
            this.groupBoxReferenceType.Controls.Add(this.labelConditionValue1);
            this.groupBoxReferenceType.Location = new System.Drawing.Point(207, 62);
            this.groupBoxReferenceType.Name = "groupBoxReferenceType";
            this.groupBoxReferenceType.Size = new System.Drawing.Size(202, 129);
            this.groupBoxReferenceType.TabIndex = 32;
            this.groupBoxReferenceType.TabStop = false;
            this.groupBoxReferenceType.Text = "Condition Type";
            // 
            // comboBoxConditionValue3
            // 
            this.comboBoxConditionValue3.BackColor = System.Drawing.Color.White;
            this.comboBoxConditionValue3.Enabled = false;
            this.comboBoxConditionValue3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxConditionValue3.FormattingEnabled = true;
            this.comboBoxConditionValue3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxConditionValue3.Location = new System.Drawing.Point(125, 68);
            this.comboBoxConditionValue3.Name = "comboBoxConditionValue3";
            this.comboBoxConditionValue3.Size = new System.Drawing.Size(70, 21);
            this.comboBoxConditionValue3.TabIndex = 49;
            this.comboBoxConditionValue3.Text = "0";
            this.comboBoxConditionValue3.TextChanged += new System.EventHandler(this.comboBoxConditionValue3_TextChanged);
            this.comboBoxConditionValue3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxConditionValue3_KeyPress);
            // 
            // comboBoxConditionValue2
            // 
            this.comboBoxConditionValue2.BackColor = System.Drawing.Color.White;
            this.comboBoxConditionValue2.Enabled = false;
            this.comboBoxConditionValue2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxConditionValue2.FormattingEnabled = true;
            this.comboBoxConditionValue2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxConditionValue2.Location = new System.Drawing.Point(125, 41);
            this.comboBoxConditionValue2.Name = "comboBoxConditionValue2";
            this.comboBoxConditionValue2.Size = new System.Drawing.Size(70, 21);
            this.comboBoxConditionValue2.TabIndex = 48;
            this.comboBoxConditionValue2.Text = "0";
            this.comboBoxConditionValue2.TextChanged += new System.EventHandler(this.comboBoxConditionValue2_TextChanged);
            this.comboBoxConditionValue2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxConditionValue2_KeyPress);
            // 
            // comboBoxConditionValue1
            // 
            this.comboBoxConditionValue1.BackColor = System.Drawing.Color.White;
            this.comboBoxConditionValue1.Enabled = false;
            this.comboBoxConditionValue1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxConditionValue1.FormattingEnabled = true;
            this.comboBoxConditionValue1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxConditionValue1.Location = new System.Drawing.Point(125, 14);
            this.comboBoxConditionValue1.Name = "comboBoxConditionValue1";
            this.comboBoxConditionValue1.Size = new System.Drawing.Size(70, 21);
            this.comboBoxConditionValue1.TabIndex = 47;
            this.comboBoxConditionValue1.Text = "0";
            this.comboBoxConditionValue1.TextChanged += new System.EventHandler(this.comboBoxConditionValue1_TextChanged);
            this.comboBoxConditionValue1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxConditionValue1_KeyPress);
            // 
            // comboBoxConditionTarget
            // 
            this.comboBoxConditionTarget.BackColor = System.Drawing.Color.White;
            this.comboBoxConditionTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConditionTarget.Enabled = false;
            this.comboBoxConditionTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxConditionTarget.FormattingEnabled = true;
            this.comboBoxConditionTarget.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxConditionTarget.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxConditionTarget.Location = new System.Drawing.Point(125, 95);
            this.comboBoxConditionTarget.Name = "comboBoxConditionTarget";
            this.comboBoxConditionTarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxConditionTarget.Size = new System.Drawing.Size(70, 21);
            this.comboBoxConditionTarget.TabIndex = 31;
            this.comboBoxConditionTarget.Visible = false;
            this.comboBoxConditionTarget.SelectedIndexChanged += new System.EventHandler(this.comboBoxConditionTarget_SelectedIndexChanged);
            // 
            // labelTarget
            // 
            this.labelTarget.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTarget.Location = new System.Drawing.Point(8, 98);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTarget.Size = new System.Drawing.Size(111, 13);
            this.labelTarget.TabIndex = 29;
            this.labelTarget.Text = "Condition Target";
            this.labelTarget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelConditionValue3
            // 
            this.labelConditionValue3.Location = new System.Drawing.Point(8, 72);
            this.labelConditionValue3.Name = "labelConditionValue3";
            this.labelConditionValue3.Size = new System.Drawing.Size(111, 13);
            this.labelConditionValue3.TabIndex = 27;
            this.labelConditionValue3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelConditionValue2
            // 
            this.labelConditionValue2.Location = new System.Drawing.Point(11, 45);
            this.labelConditionValue2.Name = "labelConditionValue2";
            this.labelConditionValue2.Size = new System.Drawing.Size(108, 13);
            this.labelConditionValue2.TabIndex = 25;
            this.labelConditionValue2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // labelConditionValue1
            // 
            this.labelConditionValue1.Location = new System.Drawing.Point(11, 19);
            this.labelConditionValue1.Name = "labelConditionValue1";
            this.labelConditionValue1.Size = new System.Drawing.Size(108, 13);
            this.labelConditionValue1.TabIndex = 23;
            this.labelConditionValue1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBoxErrorHandling
            // 
            this.groupBoxErrorHandling.Controls.Add(this.textBoxErrorTextId);
            this.groupBoxErrorHandling.Controls.Add(this.labelErrorTextId);
            this.groupBoxErrorHandling.Controls.Add(this.textBoxErrorType);
            this.groupBoxErrorHandling.Controls.Add(this.labelErrorType);
            this.groupBoxErrorHandling.Location = new System.Drawing.Point(415, 62);
            this.groupBoxErrorHandling.Name = "groupBoxErrorHandling";
            this.groupBoxErrorHandling.Size = new System.Drawing.Size(121, 129);
            this.groupBoxErrorHandling.TabIndex = 33;
            this.groupBoxErrorHandling.TabStop = false;
            this.groupBoxErrorHandling.Text = "Error Handling";
            // 
            // textBoxErrorTextId
            // 
            this.textBoxErrorTextId.Enabled = false;
            this.textBoxErrorTextId.Location = new System.Drawing.Point(85, 45);
            this.textBoxErrorTextId.MaxLength = 3;
            this.textBoxErrorTextId.Name = "textBoxErrorTextId";
            this.textBoxErrorTextId.Size = new System.Drawing.Size(30, 20);
            this.textBoxErrorTextId.TabIndex = 30;
            this.textBoxErrorTextId.Text = "0";
            this.textBoxErrorTextId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxErrorTextId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxErrorTextId_KeyPress);
            // 
            // labelErrorTextId
            // 
            this.labelErrorTextId.AutoSize = true;
            this.labelErrorTextId.Location = new System.Drawing.Point(20, 48);
            this.labelErrorTextId.Name = "labelErrorTextId";
            this.labelErrorTextId.Size = new System.Drawing.Size(59, 13);
            this.labelErrorTextId.TabIndex = 29;
            this.labelErrorTextId.Text = "ErrorTextId";
            this.labelErrorTextId.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBoxErrorType
            // 
            this.textBoxErrorType.Enabled = false;
            this.textBoxErrorType.Location = new System.Drawing.Point(85, 19);
            this.textBoxErrorType.MaxLength = 3;
            this.textBoxErrorType.Name = "textBoxErrorType";
            this.textBoxErrorType.Size = new System.Drawing.Size(30, 20);
            this.textBoxErrorType.TabIndex = 28;
            this.textBoxErrorType.Text = "0";
            this.textBoxErrorType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxErrorType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxErrorType_KeyPress);
            // 
            // labelErrorType
            // 
            this.labelErrorType.AutoSize = true;
            this.labelErrorType.Location = new System.Drawing.Point(26, 22);
            this.labelErrorType.Name = "labelErrorType";
            this.labelErrorType.Size = new System.Drawing.Size(53, 13);
            this.labelErrorType.TabIndex = 27;
            this.labelErrorType.Text = "ErrorType";
            this.labelErrorType.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // buttonResetAll
            // 
            this.buttonResetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResetAll.Location = new System.Drawing.Point(942, 140);
            this.buttonResetAll.Name = "buttonResetAll";
            this.buttonResetAll.Size = new System.Drawing.Size(99, 23);
            this.buttonResetAll.TabIndex = 36;
            this.buttonResetAll.Text = "Clear Input";
            this.buttonResetAll.UseVisualStyleBackColor = true;
            this.buttonResetAll.Click += new System.EventHandler(this.buttonResetAll_Click);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.Yellow;
            this.toolTip.IsBalloon = true;
            // 
            // groupBoxLogicalGrouping
            // 
            this.groupBoxLogicalGrouping.Controls.Add(this.textBoxElseGroup);
            this.groupBoxLogicalGrouping.Controls.Add(this.labelElseGroup);
            this.groupBoxLogicalGrouping.Location = new System.Drawing.Point(542, 62);
            this.groupBoxLogicalGrouping.Name = "groupBoxLogicalGrouping";
            this.groupBoxLogicalGrouping.Size = new System.Drawing.Size(119, 52);
            this.groupBoxLogicalGrouping.TabIndex = 43;
            this.groupBoxLogicalGrouping.TabStop = false;
            this.groupBoxLogicalGrouping.Text = "Logical Grouping";
            // 
            // textBoxElseGroup
            // 
            this.textBoxElseGroup.Location = new System.Drawing.Point(83, 19);
            this.textBoxElseGroup.MaxLength = 1;
            this.textBoxElseGroup.Name = "textBoxElseGroup";
            this.textBoxElseGroup.Size = new System.Drawing.Size(30, 20);
            this.textBoxElseGroup.TabIndex = 24;
            this.textBoxElseGroup.Text = "0";
            this.textBoxElseGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxElseGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxElseGroup_KeyPress);
            // 
            // labelElseGroup
            // 
            this.labelElseGroup.AutoSize = true;
            this.labelElseGroup.Location = new System.Drawing.Point(21, 22);
            this.labelElseGroup.Name = "labelElseGroup";
            this.labelElseGroup.Size = new System.Drawing.Size(56, 13);
            this.labelElseGroup.TabIndex = 23;
            this.labelElseGroup.Text = "ElseGroup";
            this.labelElseGroup.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBoxReverseTrueCondition
            // 
            this.groupBoxReverseTrueCondition.Controls.Add(this.checkBoxNegativeCondition);
            this.groupBoxReverseTrueCondition.Location = new System.Drawing.Point(667, 62);
            this.groupBoxReverseTrueCondition.Name = "groupBoxReverseTrueCondition";
            this.groupBoxReverseTrueCondition.Size = new System.Drawing.Size(133, 52);
            this.groupBoxReverseTrueCondition.TabIndex = 46;
            this.groupBoxReverseTrueCondition.TabStop = false;
            this.groupBoxReverseTrueCondition.Text = "Reverse True Condition";
            // 
            // checkBoxNegativeCondition
            // 
            this.checkBoxNegativeCondition.AutoSize = true;
            this.checkBoxNegativeCondition.Location = new System.Drawing.Point(11, 22);
            this.checkBoxNegativeCondition.Name = "checkBoxNegativeCondition";
            this.checkBoxNegativeCondition.Size = new System.Drawing.Size(116, 17);
            this.checkBoxNegativeCondition.TabIndex = 48;
            this.checkBoxNegativeCondition.Text = "Negative Condition";
            this.checkBoxNegativeCondition.UseVisualStyleBackColor = true;
            this.checkBoxNegativeCondition.CheckedChanged += new System.EventHandler(this.checkBoxNegativeCondition_CheckedChanged);
            // 
            // dataGridViewConditions
            // 
            this.dataGridViewConditions.AllowUserToAddRows = false;
            this.dataGridViewConditions.AllowUserToResizeColumns = false;
            this.dataGridViewConditions.AllowUserToResizeRows = false;
            this.dataGridViewConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewConditions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SourceTypeOrReferenceId,
            this.SourceGroup,
            this.SourceEntry,
            this.SourceId,
            this.ElseGroup,
            this.ConditionTypeOrReference,
            this.ConditionTarget,
            this.ConditionValue1,
            this.ConditionValue2,
            this.ConditionValue3,
            this.NegativeCondition,
            this.ErrorType,
            this.ErrorTextId,
            this.ScriptName,
            this.Comment});
            this.dataGridViewConditions.Location = new System.Drawing.Point(12, 224);
            this.dataGridViewConditions.MultiSelect = false;
            this.dataGridViewConditions.Name = "dataGridViewConditions";
            this.dataGridViewConditions.ReadOnly = true;
            this.dataGridViewConditions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConditions.ShowEditingIcon = false;
            this.dataGridViewConditions.Size = new System.Drawing.Size(979, 311);
            this.dataGridViewConditions.TabIndex = 47;
            // 
            // SourceTypeOrReferenceId
            // 
            this.SourceTypeOrReferenceId.HeaderText = "SourceTypeOrReferenceId";
            this.SourceTypeOrReferenceId.Name = "SourceTypeOrReferenceId";
            this.SourceTypeOrReferenceId.ReadOnly = true;
            this.SourceTypeOrReferenceId.Width = 140;
            // 
            // SourceGroup
            // 
            this.SourceGroup.HeaderText = "SourceGroup";
            this.SourceGroup.Name = "SourceGroup";
            this.SourceGroup.ReadOnly = true;
            this.SourceGroup.Width = 75;
            // 
            // SourceEntry
            // 
            this.SourceEntry.HeaderText = "SourceEntry";
            this.SourceEntry.Name = "SourceEntry";
            this.SourceEntry.ReadOnly = true;
            this.SourceEntry.Width = 70;
            // 
            // SourceId
            // 
            this.SourceId.HeaderText = "SourceId";
            this.SourceId.Name = "SourceId";
            this.SourceId.ReadOnly = true;
            this.SourceId.Width = 60;
            // 
            // ElseGroup
            // 
            this.ElseGroup.HeaderText = "ElseGroup";
            this.ElseGroup.Name = "ElseGroup";
            this.ElseGroup.ReadOnly = true;
            this.ElseGroup.Width = 60;
            // 
            // ConditionTypeOrReference
            // 
            this.ConditionTypeOrReference.HeaderText = "ConditionTypeOrReference";
            this.ConditionTypeOrReference.Name = "ConditionTypeOrReference";
            this.ConditionTypeOrReference.ReadOnly = true;
            this.ConditionTypeOrReference.Width = 140;
            // 
            // ConditionTarget
            // 
            this.ConditionTarget.HeaderText = "ConditionTarget";
            this.ConditionTarget.Name = "ConditionTarget";
            this.ConditionTarget.ReadOnly = true;
            this.ConditionTarget.Width = 90;
            // 
            // ConditionValue1
            // 
            this.ConditionValue1.HeaderText = "ConditionValue1";
            this.ConditionValue1.Name = "ConditionValue1";
            this.ConditionValue1.ReadOnly = true;
            this.ConditionValue1.Width = 90;
            // 
            // ConditionValue2
            // 
            this.ConditionValue2.HeaderText = "ConditionValue2";
            this.ConditionValue2.Name = "ConditionValue2";
            this.ConditionValue2.ReadOnly = true;
            this.ConditionValue2.Width = 90;
            // 
            // ConditionValue3
            // 
            this.ConditionValue3.HeaderText = "ConditionValue3";
            this.ConditionValue3.Name = "ConditionValue3";
            this.ConditionValue3.ReadOnly = true;
            this.ConditionValue3.Width = 90;
            // 
            // NegativeCondition
            // 
            this.NegativeCondition.HeaderText = "NegativeCondition";
            this.NegativeCondition.Name = "NegativeCondition";
            this.NegativeCondition.ReadOnly = true;
            // 
            // ErrorType
            // 
            this.ErrorType.HeaderText = "ErrorType";
            this.ErrorType.Name = "ErrorType";
            this.ErrorType.ReadOnly = true;
            this.ErrorType.Width = 70;
            // 
            // ErrorTextId
            // 
            this.ErrorTextId.HeaderText = "ErrorTextId";
            this.ErrorTextId.Name = "ErrorTextId";
            this.ErrorTextId.ReadOnly = true;
            this.ErrorTextId.Width = 70;
            // 
            // ScriptName
            // 
            this.ScriptName.HeaderText = "ScriptName";
            this.ScriptName.Name = "ScriptName";
            this.ScriptName.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.FillWeight = 500F;
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            this.Comment.Width = 800;
            // 
            // buttonAddtoList
            // 
            this.buttonAddtoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddtoList.Location = new System.Drawing.Point(942, 62);
            this.buttonAddtoList.Name = "buttonAddtoList";
            this.buttonAddtoList.Size = new System.Drawing.Size(99, 23);
            this.buttonAddtoList.TabIndex = 48;
            this.buttonAddtoList.Text = "Add to List";
            this.buttonAddtoList.UseVisualStyleBackColor = true;
            this.buttonAddtoList.Click += new System.EventHandler(this.buttonAddtoList_Click);
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(1054, 24);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem1.Text = "Output SQL";
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click_1);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBoxScript
            // 
            this.groupBoxScript.Controls.Add(this.textBoxScriptName);
            this.groupBoxScript.Controls.Add(this.labelScriptName);
            this.groupBoxScript.Location = new System.Drawing.Point(543, 121);
            this.groupBoxScript.Name = "groupBoxScript";
            this.groupBoxScript.Size = new System.Drawing.Size(257, 70);
            this.groupBoxScript.TabIndex = 49;
            this.groupBoxScript.TabStop = false;
            this.groupBoxScript.Text = "Add script name if needed";
            // 
            // buttonClearList
            // 
            this.buttonClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearList.Location = new System.Drawing.Point(942, 169);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(99, 23);
            this.buttonClearList.TabIndex = 50;
            this.buttonClearList.Text = "Clear List";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // buttonRetrieveFromList
            // 
            this.buttonRetrieveFromList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRetrieveFromList.Location = new System.Drawing.Point(943, 91);
            this.buttonRetrieveFromList.Name = "buttonRetrieveFromList";
            this.buttonRetrieveFromList.Size = new System.Drawing.Size(99, 23);
            this.buttonRetrieveFromList.TabIndex = 51;
            this.buttonRetrieveFromList.Text = "Retrieve from List";
            this.buttonRetrieveFromList.UseVisualStyleBackColor = true;
            this.buttonRetrieveFromList.Click += new System.EventHandler(this.buttonRetrieveFromList_Click);
            //
            // buttonDown
            //
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.Image = global::ConditionCreator.Properties.Resources.down;
            this.buttonDown.Location = new System.Drawing.Point(997, 277);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(45, 47);
            this.buttonDown.TabIndex = 1;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            //
            // buttonUp
            //
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.Image = global::ConditionCreator.Properties.Resources.up;
            this.buttonUp.Location = new System.Drawing.Point(997, 224);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(45, 47);
            this.buttonUp.TabIndex = 0;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            //
            // FormCreator
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 547);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRetrieveFromList);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.groupBoxScript);
            this.Controls.Add(this.buttonAddtoList);
            this.Controls.Add(this.dataGridViewConditions);
            this.Controls.Add(this.groupBoxReverseTrueCondition);
            this.Controls.Add(this.groupBoxLogicalGrouping);
            this.Controls.Add(this.buttonResetAll);
            this.Controls.Add(this.groupBoxErrorHandling);
            this.Controls.Add(this.groupBoxReferenceType);
            this.Controls.Add(this.groupBoxConditionType);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.menuStripSourceCondition);
            this.Controls.Add(this.menuStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripSourceCondition;
            this.MinimumSize = new System.Drawing.Size(1001, 496);
            this.Name = "FormCreator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condition Creator";
            this.menuStripSourceCondition.ResumeLayout(false);
            this.menuStripSourceCondition.PerformLayout();
            this.groupBoxConditionType.ResumeLayout(false);
            this.groupBoxConditionType.PerformLayout();
            this.groupBoxReferenceType.ResumeLayout(false);
            this.groupBoxErrorHandling.ResumeLayout(false);
            this.groupBoxErrorHandling.PerformLayout();
            this.groupBoxLogicalGrouping.ResumeLayout(false);
            this.groupBoxLogicalGrouping.PerformLayout();
            this.groupBoxReverseTrueCondition.ResumeLayout(false);
            this.groupBoxReverseTrueCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConditions)).EndInit();
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            this.groupBoxScript.ResumeLayout(false);
            this.groupBoxScript.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripSourceCondition;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConditionType;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCondition;
        private System.Windows.Forms.TextBox textBoxScriptName;
        private System.Windows.Forms.Label labelScriptName;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSourceType;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxSource;
        private System.Windows.Forms.GroupBox groupBoxConditionType;
        private System.Windows.Forms.TextBox textBoxSourceId;
        private System.Windows.Forms.Label labelSourceId;
        private System.Windows.Forms.TextBox textBoxSourceEntry;
        private System.Windows.Forms.Label labelSourceEntry;
        private System.Windows.Forms.TextBox textBoxSourceGroup;
        private System.Windows.Forms.Label labelSourceGroup;
        private System.Windows.Forms.GroupBox groupBoxReferenceType;
        private System.Windows.Forms.Label labelConditionValue3;
        private System.Windows.Forms.Label labelConditionValue2;
        private System.Windows.Forms.Label labelConditionValue1;
        private System.Windows.Forms.GroupBox groupBoxErrorHandling;
        private System.Windows.Forms.TextBox textBoxErrorTextId;
        private System.Windows.Forms.Label labelErrorTextId;
        private System.Windows.Forms.TextBox textBoxErrorType;
        private System.Windows.Forms.Label labelErrorType;
        private System.Windows.Forms.Button buttonResetAll;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBoxLogicalGrouping;
        private System.Windows.Forms.TextBox textBoxElseGroup;
        private System.Windows.Forms.Label labelElseGroup;
        private System.Windows.Forms.GroupBox groupBoxReverseTrueCondition;
        private System.Windows.Forms.CheckBox checkBoxNegativeCondition;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.ComboBox comboBoxConditionTarget;
        private System.Windows.Forms.ComboBox comboBoxConditionValue1;
        private System.Windows.Forms.ComboBox comboBoxConditionValue2;
        private System.Windows.Forms.ComboBox comboBoxConditionValue3;
        private System.Windows.Forms.DataGridView dataGridViewConditions;
        private System.Windows.Forms.Button buttonAddtoList;
        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxScript;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonRetrieveFromList;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceTypeOrReferenceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ElseGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionTypeOrReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionValue1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionValue2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConditionValue3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NegativeCondition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorTextId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScriptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
    }
}

