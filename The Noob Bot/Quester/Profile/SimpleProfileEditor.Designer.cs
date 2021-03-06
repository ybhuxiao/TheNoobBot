using System.Windows.Forms;
using System;
using nManager.Helpful;

namespace Quester.Profile
{
    partial class SimpleProfileEditor : System.Windows.Forms.Form
    {

        //Form remplace la méthode Dispose pour nettoyer la liste des composants.
        [System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        //Requise par le Concepteur Windows Form
        private System.ComponentModel.IContainer components;
        //REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        //Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        //Ne la modifiez pas à l'aide de l'éditeur de code.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleProfileEditor));
            this.TreeView = new System.Windows.Forms.TreeView();
            this.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertDownToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonLoadXML = new System.Windows.Forms.Button();
            this.PanelNPC = new System.Windows.Forms.Panel();
            this.ButtonNpcImport = new System.Windows.Forms.Button();
            this.CBNpcType = new System.Windows.Forms.ComboBox();
            this.CBNpcFaction = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TBNpcContinentId = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.ButtonSaveNPC = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TBNpcPosition = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TBNpcId = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TBNpcName = new System.Windows.Forms.TextBox();
            this.ButtonNewNPC = new System.Windows.Forms.Button();
            this.PanelSimpleQuest = new System.Windows.Forms.Panel();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPageQuest = new System.Windows.Forms.TabPage();
            this.ButtonQuestImpotTurnInID = new System.Windows.Forms.Button();
            this.QuestCompletedButton = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.TBQuestAutoAcceptIDs = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.TBQuestAutoCompleteIDs = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.TBQuestNeedQuestNotCompId = new System.Windows.Forms.TextBox();
            this.ContextMenuStripNeedQuest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemAddNeedQuestComp = new System.Windows.Forms.ToolStripMenuItem();
            this.Label28 = new System.Windows.Forms.Label();
            this.TBQuestWQ = new System.Windows.Forms.TextBox();
            this.CBQuestWQ = new System.Windows.Forms.CheckBox();
            this.CBQuestAutoAccepted = new System.Windows.Forms.CheckBox();
            this.ButtonQuestAlliance = new System.Windows.Forms.Button();
            this.ButtonQuestHorde = new System.Windows.Forms.Button();
            this.CLBQuestRaceMask = new System.Windows.Forms.CheckedListBox();
            this.CLBQuestClassMask = new System.Windows.Forms.CheckedListBox();
            this.ButtonQuestImportFromGame = new System.Windows.Forms.Button();
            this.ButtonOpenWowHead = new System.Windows.Forms.Button();
            this.TBQuestNeedQuestCompId = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.ButtonQuestNew = new System.Windows.Forms.Button();
            this.ButtonQuestSave = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.TBQuestQuestName = new System.Windows.Forms.TextBox();
            this.TBQuestID = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.CBClassMask = new System.Windows.Forms.ComboBox();
            this.TBQuestTurnInID = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.CheckBoxItemPickUp = new System.Windows.Forms.CheckBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.TBQuestLevel = new System.Windows.Forms.TextBox();
            this.TBQuestPickUpID = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.CBRaceMask = new System.Windows.Forms.ComboBox();
            this.TBQuestMaxLvl = new System.Windows.Forms.TextBox();
            this.TBQuestMinLvl = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.TabPageObjectives = new System.Windows.Forms.TabPage();
            this.ButtonObjHotSpotsPlayerPosRelative = new System.Windows.Forms.Button();
            this.ButtonObjImportGPSExtraPoint = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.TBObjExtraFloat = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.TBObjExtraInt = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.TBObjExtraPoint = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.TBObjExtraString = new System.Windows.Forms.TextBox();
            this.ButtonObjHotSpotsTargetPos = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.TBObjLuaMacro = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.TBObjCompletedScript = new System.Windows.Forms.TextBox();
            this.CBObjPressKeys = new System.Windows.Forms.ComboBox();
            this.label43 = new System.Windows.Forms.Label();
            this.TBObjMessage = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.LBObjHotspots = new System.Windows.Forms.ListBox();
            this.CBObjInternalQuestIdManual = new System.Windows.Forms.CheckBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.TBObjInternalIndex = new System.Windows.Forms.TextBox();
            this.ButtonObjDumpIndex = new System.Windows.Forms.Button();
            this.PanelObjAll = new System.Windows.Forms.Panel();
            this.CBObjIgnoreAllFight = new System.Windows.Forms.CheckBox();
            this.CBObjIsBonusObjective = new System.Windows.Forms.CheckBox();
            this.CBObjDismissPet = new System.Windows.Forms.CheckBox();
            this.CBObjIgnoreItemNotUsable = new System.Windows.Forms.CheckBox();
            this.ButtonObjImportCursorItemID = new System.Windows.Forms.Button();
            this.CBObjDeactivateMount = new System.Windows.Forms.CheckBox();
            this.CBObjIgnoreFight = new System.Windows.Forms.CheckBox();
            this.CBObjForceTravelToQuestZone = new System.Windows.Forms.CheckBox();
            this.CBObjIgnoreNotSelectable = new System.Windows.Forms.CheckBox();
            this.CBObjAllowPlayerControlled = new System.Windows.Forms.CheckBox();
            this.CBObjIgnoreBlackList = new System.Windows.Forms.CheckBox();
            this.CBObjIsDead = new System.Windows.Forms.CheckBox();
            this.TBObjGossipOption = new System.Windows.Forms.TextBox();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.CBObjCanPullUnitsInFight = new System.Windows.Forms.CheckBox();
            this.ButtonObjImportGPS = new System.Windows.Forms.Button();
            this.TBObjCount = new System.Windows.Forms.TextBox();
            this.ButtonObjImportEntry = new System.Windows.Forms.Button();
            this.TBObjEntry = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TBObjCollectItemID = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.TBObjCollectCount = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.TBObjUseItemID = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.TBObjPosition = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.TBObjWaitMs = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.TBObjRange = new System.Windows.Forms.TextBox();
            this.Label25 = new System.Windows.Forms.Label();
            this.TBObjUseSpellId = new System.Windows.Forms.TextBox();
            this.Label26 = new System.Windows.Forms.Label();
            this.ButtonObjHotSpotsPlayerPos = new System.Windows.Forms.Button();
            this.ButtonObjImportFromGame = new System.Windows.Forms.Button();
            this.CBObjKillMobPickUpItem = new System.Windows.Forms.CheckBox();
            this.CBObjInternalQuestID = new System.Windows.Forms.ComboBox();
            this.CBInternalObj = new System.Windows.Forms.CheckBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.CBObjIgnoreQuestCompleted = new System.Windows.Forms.CheckBox();
            this.Label30 = new System.Windows.Forms.Label();
            this.TBObjQuestName = new System.Windows.Forms.TextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.TBObjQuestID = new System.Windows.Forms.TextBox();
            this.LabelObjNPCIDorName = new System.Windows.Forms.Label();
            this.TBObjNPCId = new System.Windows.Forms.TextBox();
            this.ButtonObjectiveNew = new System.Windows.Forms.Button();
            this.ButtonObjectiveSave = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.CBObjType = new System.Windows.Forms.ComboBox();
            this.PanelObjTaxi = new System.Windows.Forms.Panel();
            this.TBObjFlightWaitMs = new System.Windows.Forms.TextBox();
            this.Label36 = new System.Windows.Forms.Label();
            this.ButtonObjGetXY = new System.Windows.Forms.Button();
            this.TBObjDestinationY = new System.Windows.Forms.TextBox();
            this.TBObjTaxiEntryId = new System.Windows.Forms.TextBox();
            this.Label33 = new System.Windows.Forms.Label();
            this.TBObjDestinationX = new System.Windows.Forms.TextBox();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.TabPageBlackList = new System.Windows.Forms.TabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.TBBlackListRadius = new System.Windows.Forms.TextBox();
            this.ButtonBlackListSave = new System.Windows.Forms.Button();
            this.TBBlackList = new System.Windows.Forms.TextBox();
            this.ButtonBlackListAdd = new System.Windows.Forms.Button();
            this.TabPageCustomPath = new System.Windows.Forms.TabPage();
            this.ButtonCPAdd = new System.Windows.Forms.Button();
            this.ButtonCPDelete = new System.Windows.Forms.Button();
            this.ComboCPContB = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.ComboCPContA = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.ComboCPFaction = new System.Windows.Forms.ComboBox();
            this.CBCPUseMount = new System.Windows.Forms.CheckBox();
            this.CBCPRoundTrip = new System.Windows.Forms.CheckBox();
            this.CBCPForceFlying = new System.Windows.Forms.CheckBox();
            this.CBCPAllowFar = new System.Windows.Forms.CheckBox();
            this.label51 = new System.Windows.Forms.Label();
            this.TBCPName = new System.Windows.Forms.TextBox();
            this.LBCPCustomPaths = new System.Windows.Forms.ListBox();
            this.label50 = new System.Windows.Forms.Label();
            this.NumUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.LBCPPoints = new System.Windows.Forms.ListBox();
            this.ButtonCPSave = new System.Windows.Forms.Button();
            this.ButtonCPRecord = new System.Windows.Forms.Button();
            this.ButtonSaveAsXML = new System.Windows.Forms.Button();
            this.ButtonNewXML = new System.Windows.Forms.Button();
            this.CBMainDisplayXML = new System.Windows.Forms.CheckBox();
            this.ButtonSaveXML = new System.Windows.Forms.Button();
            this.TNBControlMenu = new nManager.Helpful.Forms.UserControls.TnbControlMenu();
            this.UcXmlRichTextBox1 = new nManager.Helpful.Forms.UserControls.UCXmlRichTextBox();
            this.ButtonCPDeleteSelectedPoints = new System.Windows.Forms.Button();
            this.ContextMenuStrip.SuspendLayout();
            this.PanelNPC.SuspendLayout();
            this.PanelSimpleQuest.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPageQuest.SuspendLayout();
            this.ContextMenuStripNeedQuest.SuspendLayout();
            this.TabPageObjectives.SuspendLayout();
            this.PanelObjAll.SuspendLayout();
            this.PanelObjTaxi.SuspendLayout();
            this.TabPageBlackList.SuspendLayout();
            this.TabPageCustomPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeView
            // 
            this.TreeView.ContextMenuStrip = this.ContextMenuStrip;
            this.TreeView.Location = new System.Drawing.Point(9, 50);
            this.TreeView.Margin = new System.Windows.Forms.Padding(2);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(258, 590);
            this.TreeView.TabIndex = 0;
            this.TreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_AfterSelect);
            this.TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseClick);
            // 
            // ContextMenuStrip
            // 
            this.ContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.InsertUpToolStripMenuItem,
            this.InsertDownToolStripMenuItem1});
            this.ContextMenuStrip.Name = "ContextMenuStrip1";
            this.ContextMenuStrip.Size = new System.Drawing.Size(141, 70);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // InsertUpToolStripMenuItem
            // 
            this.InsertUpToolStripMenuItem.Name = "InsertUpToolStripMenuItem";
            this.InsertUpToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.InsertUpToolStripMenuItem.Text = "Insert Above";
            this.InsertUpToolStripMenuItem.Click += new System.EventHandler(this.InsertUpToolStripMenuItem_Click);
            // 
            // InsertDownToolStripMenuItem1
            // 
            this.InsertDownToolStripMenuItem1.Name = "InsertDownToolStripMenuItem1";
            this.InsertDownToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.InsertDownToolStripMenuItem1.Text = "Insert Below";
            this.InsertDownToolStripMenuItem1.Click += new System.EventHandler(this.InsertUpToolStripMenuItem_Click);
            // 
            // ButtonLoadXML
            // 
            this.ButtonLoadXML.Location = new System.Drawing.Point(275, 50);
            this.ButtonLoadXML.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonLoadXML.Name = "ButtonLoadXML";
            this.ButtonLoadXML.Size = new System.Drawing.Size(56, 20);
            this.ButtonLoadXML.TabIndex = 1;
            this.ButtonLoadXML.Text = "Load Xml";
            this.ButtonLoadXML.UseVisualStyleBackColor = true;
            this.ButtonLoadXML.Click += new System.EventHandler(this.ButtonLoadXML_Click);
            // 
            // PanelNPC
            // 
            this.PanelNPC.Controls.Add(this.ButtonNpcImport);
            this.PanelNPC.Controls.Add(this.CBNpcType);
            this.PanelNPC.Controls.Add(this.CBNpcFaction);
            this.PanelNPC.Controls.Add(this.Label6);
            this.PanelNPC.Controls.Add(this.TBNpcContinentId);
            this.PanelNPC.Controls.Add(this.Label5);
            this.PanelNPC.Controls.Add(this.Label4);
            this.PanelNPC.Controls.Add(this.ButtonSaveNPC);
            this.PanelNPC.Controls.Add(this.Label3);
            this.PanelNPC.Controls.Add(this.TBNpcPosition);
            this.PanelNPC.Controls.Add(this.Label2);
            this.PanelNPC.Controls.Add(this.TBNpcId);
            this.PanelNPC.Controls.Add(this.Label1);
            this.PanelNPC.Controls.Add(this.TBNpcName);
            this.PanelNPC.Controls.Add(this.ButtonNewNPC);
            this.PanelNPC.Location = new System.Drawing.Point(270, 74);
            this.PanelNPC.Margin = new System.Windows.Forms.Padding(2);
            this.PanelNPC.Name = "PanelNPC";
            this.PanelNPC.Size = new System.Drawing.Size(390, 415);
            this.PanelNPC.TabIndex = 0;
            // 
            // ButtonNpcImport
            // 
            this.ButtonNpcImport.Location = new System.Drawing.Point(148, 165);
            this.ButtonNpcImport.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNpcImport.Name = "ButtonNpcImport";
            this.ButtonNpcImport.Size = new System.Drawing.Size(68, 19);
            this.ButtonNpcImport.TabIndex = 15;
            this.ButtonNpcImport.Text = "Import";
            this.ButtonNpcImport.UseVisualStyleBackColor = true;
            this.ButtonNpcImport.Click += new System.EventHandler(this.ButtonNpcImport_Click);
            // 
            // CBNpcType
            // 
            this.CBNpcType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNpcType.FormattingEnabled = true;
            this.CBNpcType.Location = new System.Drawing.Point(70, 106);
            this.CBNpcType.Margin = new System.Windows.Forms.Padding(2);
            this.CBNpcType.Name = "CBNpcType";
            this.CBNpcType.Size = new System.Drawing.Size(92, 21);
            this.CBNpcType.TabIndex = 14;
            // 
            // CBNpcFaction
            // 
            this.CBNpcFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNpcFaction.FormattingEnabled = true;
            this.CBNpcFaction.Location = new System.Drawing.Point(70, 81);
            this.CBNpcFaction.Margin = new System.Windows.Forms.Padding(2);
            this.CBNpcFaction.Name = "CBNpcFaction";
            this.CBNpcFaction.Size = new System.Drawing.Size(92, 21);
            this.CBNpcFaction.TabIndex = 13;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(2, 130);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(66, 13);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Continent ID";
            // 
            // TBNpcContinentId
            // 
            this.TBNpcContinentId.Location = new System.Drawing.Point(70, 130);
            this.TBNpcContinentId.Margin = new System.Windows.Forms.Padding(2);
            this.TBNpcContinentId.Name = "TBNpcContinentId";
            this.TBNpcContinentId.Size = new System.Drawing.Size(76, 20);
            this.TBNpcContinentId.TabIndex = 11;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(2, 106);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(31, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Type";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(2, 81);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(42, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "Faction";
            // 
            // ButtonSaveNPC
            // 
            this.ButtonSaveNPC.Location = new System.Drawing.Point(76, 165);
            this.ButtonSaveNPC.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveNPC.Name = "ButtonSaveNPC";
            this.ButtonSaveNPC.Size = new System.Drawing.Size(68, 19);
            this.ButtonSaveNPC.TabIndex = 6;
            this.ButtonSaveNPC.Text = "Save NPC";
            this.ButtonSaveNPC.UseVisualStyleBackColor = true;
            this.ButtonSaveNPC.Click += new System.EventHandler(this.ButtonSaveNPC_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(2, 58);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Position";
            // 
            // TBNpcPosition
            // 
            this.TBNpcPosition.Location = new System.Drawing.Point(70, 58);
            this.TBNpcPosition.Margin = new System.Windows.Forms.Padding(2);
            this.TBNpcPosition.Name = "TBNpcPosition";
            this.TBNpcPosition.Size = new System.Drawing.Size(76, 20);
            this.TBNpcPosition.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(2, 36);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(18, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "ID";
            // 
            // TBNpcId
            // 
            this.TBNpcId.Location = new System.Drawing.Point(70, 36);
            this.TBNpcId.Margin = new System.Windows.Forms.Padding(2);
            this.TBNpcId.Name = "TBNpcId";
            this.TBNpcId.Size = new System.Drawing.Size(76, 20);
            this.TBNpcId.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(2, 12);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "NPC Name";
            // 
            // TBNpcName
            // 
            this.TBNpcName.Location = new System.Drawing.Point(70, 13);
            this.TBNpcName.Margin = new System.Windows.Forms.Padding(2);
            this.TBNpcName.Name = "TBNpcName";
            this.TBNpcName.Size = new System.Drawing.Size(76, 20);
            this.TBNpcName.TabIndex = 0;
            // 
            // ButtonNewNPC
            // 
            this.ButtonNewNPC.Location = new System.Drawing.Point(4, 165);
            this.ButtonNewNPC.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNewNPC.Name = "ButtonNewNPC";
            this.ButtonNewNPC.Size = new System.Drawing.Size(68, 19);
            this.ButtonNewNPC.TabIndex = 5;
            this.ButtonNewNPC.Text = "New NPC";
            this.ButtonNewNPC.UseVisualStyleBackColor = true;
            this.ButtonNewNPC.Click += new System.EventHandler(this.ButtonNewNPC_Click);
            // 
            // PanelSimpleQuest
            // 
            this.PanelSimpleQuest.Controls.Add(this.TabControl1);
            this.PanelSimpleQuest.Location = new System.Drawing.Point(270, 74);
            this.PanelSimpleQuest.Margin = new System.Windows.Forms.Padding(2);
            this.PanelSimpleQuest.Name = "PanelSimpleQuest";
            this.PanelSimpleQuest.Size = new System.Drawing.Size(392, 566);
            this.PanelSimpleQuest.TabIndex = 12;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPageQuest);
            this.TabControl1.Controls.Add(this.TabPageObjectives);
            this.TabControl1.Controls.Add(this.TabPageBlackList);
            this.TabControl1.Controls.Add(this.TabPageCustomPath);
            this.TabControl1.Location = new System.Drawing.Point(5, 1);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(383, 565);
            this.TabControl1.TabIndex = 31;
            // 
            // TabPageQuest
            // 
            this.TabPageQuest.Controls.Add(this.ButtonQuestImpotTurnInID);
            this.TabPageQuest.Controls.Add(this.QuestCompletedButton);
            this.TabPageQuest.Controls.Add(this.label40);
            this.TabPageQuest.Controls.Add(this.TBQuestAutoAcceptIDs);
            this.TabPageQuest.Controls.Add(this.label39);
            this.TabPageQuest.Controls.Add(this.TBQuestAutoCompleteIDs);
            this.TabPageQuest.Controls.Add(this.label38);
            this.TabPageQuest.Controls.Add(this.TBQuestNeedQuestNotCompId);
            this.TabPageQuest.Controls.Add(this.Label28);
            this.TabPageQuest.Controls.Add(this.TBQuestWQ);
            this.TabPageQuest.Controls.Add(this.CBQuestWQ);
            this.TabPageQuest.Controls.Add(this.CBQuestAutoAccepted);
            this.TabPageQuest.Controls.Add(this.ButtonQuestAlliance);
            this.TabPageQuest.Controls.Add(this.ButtonQuestHorde);
            this.TabPageQuest.Controls.Add(this.CLBQuestRaceMask);
            this.TabPageQuest.Controls.Add(this.CLBQuestClassMask);
            this.TabPageQuest.Controls.Add(this.ButtonQuestImportFromGame);
            this.TabPageQuest.Controls.Add(this.ButtonOpenWowHead);
            this.TabPageQuest.Controls.Add(this.TBQuestNeedQuestCompId);
            this.TabPageQuest.Controls.Add(this.Label27);
            this.TabPageQuest.Controls.Add(this.ButtonQuestNew);
            this.TabPageQuest.Controls.Add(this.ButtonQuestSave);
            this.TabPageQuest.Controls.Add(this.Label12);
            this.TabPageQuest.Controls.Add(this.TBQuestQuestName);
            this.TabPageQuest.Controls.Add(this.TBQuestID);
            this.TabPageQuest.Controls.Add(this.Label11);
            this.TabPageQuest.Controls.Add(this.Label19);
            this.TabPageQuest.Controls.Add(this.CBClassMask);
            this.TabPageQuest.Controls.Add(this.TBQuestTurnInID);
            this.TabPageQuest.Controls.Add(this.Label13);
            this.TabPageQuest.Controls.Add(this.CheckBoxItemPickUp);
            this.TabPageQuest.Controls.Add(this.Label14);
            this.TabPageQuest.Controls.Add(this.Label18);
            this.TabPageQuest.Controls.Add(this.TBQuestLevel);
            this.TabPageQuest.Controls.Add(this.TBQuestPickUpID);
            this.TabPageQuest.Controls.Add(this.Label15);
            this.TabPageQuest.Controls.Add(this.Label17);
            this.TabPageQuest.Controls.Add(this.CBRaceMask);
            this.TabPageQuest.Controls.Add(this.TBQuestMaxLvl);
            this.TabPageQuest.Controls.Add(this.TBQuestMinLvl);
            this.TabPageQuest.Controls.Add(this.Label16);
            this.TabPageQuest.Location = new System.Drawing.Point(4, 22);
            this.TabPageQuest.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageQuest.Name = "TabPageQuest";
            this.TabPageQuest.Padding = new System.Windows.Forms.Padding(2);
            this.TabPageQuest.Size = new System.Drawing.Size(375, 539);
            this.TabPageQuest.TabIndex = 0;
            this.TabPageQuest.Text = "Quest";
            this.TabPageQuest.UseVisualStyleBackColor = true;
            // 
            // ButtonQuestImpotTurnInID
            // 
            this.ButtonQuestImpotTurnInID.Location = new System.Drawing.Point(278, 308);
            this.ButtonQuestImpotTurnInID.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonQuestImpotTurnInID.Name = "ButtonQuestImpotTurnInID";
            this.ButtonQuestImpotTurnInID.Size = new System.Drawing.Size(23, 19);
            this.ButtonQuestImpotTurnInID.TabIndex = 89;
            this.ButtonQuestImpotTurnInID.Text = "Import From Game";
            this.ButtonQuestImpotTurnInID.UseVisualStyleBackColor = true;
            this.ButtonQuestImpotTurnInID.Click += new System.EventHandler(this.ButtonQuestImpotTurnInID_Click);
            // 
            // QuestCompletedButton
            // 
            this.QuestCompletedButton.Location = new System.Drawing.Point(116, 428);
            this.QuestCompletedButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuestCompletedButton.Name = "QuestCompletedButton";
            this.QuestCompletedButton.Size = new System.Drawing.Size(142, 37);
            this.QuestCompletedButton.TabIndex = 88;
            this.QuestCompletedButton.Text = "Show Quest Completed";
            this.QuestCompletedButton.UseVisualStyleBackColor = true;
            this.QuestCompletedButton.Click += new System.EventHandler(this.QuestCompletedButton_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(211, 82);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(66, 13);
            this.label40.TabIndex = 87;
            this.label40.Text = "Auto Accept";
            // 
            // TBQuestAutoAcceptIDs
            // 
            this.TBQuestAutoAcceptIDs.Location = new System.Drawing.Point(290, 82);
            this.TBQuestAutoAcceptIDs.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestAutoAcceptIDs.Multiline = true;
            this.TBQuestAutoAcceptIDs.Name = "TBQuestAutoAcceptIDs";
            this.TBQuestAutoAcceptIDs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBQuestAutoAcceptIDs.Size = new System.Drawing.Size(76, 24);
            this.TBQuestAutoAcceptIDs.TabIndex = 86;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(211, 56);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(76, 13);
            this.label39.TabIndex = 85;
            this.label39.Text = "Auto Complete";
            // 
            // TBQuestAutoCompleteIDs
            // 
            this.TBQuestAutoCompleteIDs.Location = new System.Drawing.Point(290, 56);
            this.TBQuestAutoCompleteIDs.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestAutoCompleteIDs.Multiline = true;
            this.TBQuestAutoCompleteIDs.Name = "TBQuestAutoCompleteIDs";
            this.TBQuestAutoCompleteIDs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBQuestAutoCompleteIDs.Size = new System.Drawing.Size(76, 24);
            this.TBQuestAutoCompleteIDs.TabIndex = 84;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(2, 81);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(126, 13);
            this.label38.TabIndex = 83;
            this.label38.Text = "Need Quest Not Comp Id";
            // 
            // TBQuestNeedQuestNotCompId
            // 
            this.TBQuestNeedQuestNotCompId.ContextMenuStrip = this.ContextMenuStripNeedQuest;
            this.TBQuestNeedQuestNotCompId.Location = new System.Drawing.Point(131, 82);
            this.TBQuestNeedQuestNotCompId.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestNeedQuestNotCompId.Multiline = true;
            this.TBQuestNeedQuestNotCompId.Name = "TBQuestNeedQuestNotCompId";
            this.TBQuestNeedQuestNotCompId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBQuestNeedQuestNotCompId.Size = new System.Drawing.Size(78, 23);
            this.TBQuestNeedQuestNotCompId.TabIndex = 82;
            // 
            // ContextMenuStripNeedQuest
            // 
            this.ContextMenuStripNeedQuest.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStripNeedQuest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddNeedQuestComp});
            this.ContextMenuStripNeedQuest.Name = "ContextMenuStripNeedQuest";
            this.ContextMenuStripNeedQuest.Size = new System.Drawing.Size(193, 26);
            // 
            // ToolStripMenuItemAddNeedQuestComp
            // 
            this.ToolStripMenuItemAddNeedQuestComp.Name = "ToolStripMenuItemAddNeedQuestComp";
            this.ToolStripMenuItemAddNeedQuestComp.Size = new System.Drawing.Size(192, 22);
            this.ToolStripMenuItemAddNeedQuestComp.Text = "Add Previous Quest ID";
            this.ToolStripMenuItemAddNeedQuestComp.Click += new System.EventHandler(this.ToolStripMenuItemAddNeedQuestComp_Click);
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(148, 332);
            this.Label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(47, 13);
            this.Label28.TabIndex = 81;
            this.Label28.Text = "WQ Pos";
            // 
            // TBQuestWQ
            // 
            this.TBQuestWQ.Location = new System.Drawing.Point(202, 330);
            this.TBQuestWQ.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestWQ.Name = "TBQuestWQ";
            this.TBQuestWQ.Size = new System.Drawing.Size(76, 20);
            this.TBQuestWQ.TabIndex = 80;
            // 
            // CBQuestWQ
            // 
            this.CBQuestWQ.AutoSize = true;
            this.CBQuestWQ.Location = new System.Drawing.Point(282, 333);
            this.CBQuestWQ.Margin = new System.Windows.Forms.Padding(2);
            this.CBQuestWQ.Name = "CBQuestWQ";
            this.CBQuestWQ.Size = new System.Drawing.Size(91, 17);
            this.CBQuestWQ.TabIndex = 79;
            this.CBQuestWQ.Text = "World Quest?";
            this.CBQuestWQ.UseVisualStyleBackColor = true;
            this.CBQuestWQ.CheckedChanged += new System.EventHandler(this.CBQuestWQ_CheckedChanged);
            // 
            // CBQuestAutoAccepted
            // 
            this.CBQuestAutoAccepted.AutoSize = true;
            this.CBQuestAutoAccepted.Location = new System.Drawing.Point(213, 35);
            this.CBQuestAutoAccepted.Margin = new System.Windows.Forms.Padding(2);
            this.CBQuestAutoAccepted.Name = "CBQuestAutoAccepted";
            this.CBQuestAutoAccepted.Size = new System.Drawing.Size(94, 17);
            this.CBQuestAutoAccepted.TabIndex = 78;
            this.CBQuestAutoAccepted.Text = "AutoAccepted";
            this.CBQuestAutoAccepted.UseVisualStyleBackColor = true;
            // 
            // ButtonQuestAlliance
            // 
            this.ButtonQuestAlliance.Location = new System.Drawing.Point(9, 228);
            this.ButtonQuestAlliance.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonQuestAlliance.Name = "ButtonQuestAlliance";
            this.ButtonQuestAlliance.Size = new System.Drawing.Size(64, 19);
            this.ButtonQuestAlliance.TabIndex = 77;
            this.ButtonQuestAlliance.Text = "Alliance";
            this.ButtonQuestAlliance.UseVisualStyleBackColor = true;
            this.ButtonQuestAlliance.Click += new System.EventHandler(this.ButtonQuestAlliance_Click);
            // 
            // ButtonQuestHorde
            // 
            this.ButtonQuestHorde.Location = new System.Drawing.Point(9, 206);
            this.ButtonQuestHorde.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonQuestHorde.Name = "ButtonQuestHorde";
            this.ButtonQuestHorde.Size = new System.Drawing.Size(64, 19);
            this.ButtonQuestHorde.TabIndex = 76;
            this.ButtonQuestHorde.Text = "Horde";
            this.ButtonQuestHorde.UseVisualStyleBackColor = true;
            this.ButtonQuestHorde.Click += new System.EventHandler(this.ButtonQuestHorde_Click);
            // 
            // CLBQuestRaceMask
            // 
            this.CLBQuestRaceMask.CheckOnClick = true;
            this.CLBQuestRaceMask.ColumnWidth = 90;
            this.CLBQuestRaceMask.FormattingEnabled = true;
            this.CLBQuestRaceMask.HorizontalScrollbar = true;
            this.CLBQuestRaceMask.Location = new System.Drawing.Point(86, 191);
            this.CLBQuestRaceMask.Margin = new System.Windows.Forms.Padding(2);
            this.CLBQuestRaceMask.MaximumSize = new System.Drawing.Size(280, 87);
            this.CLBQuestRaceMask.MinimumSize = new System.Drawing.Size(280, 87);
            this.CLBQuestRaceMask.MultiColumn = true;
            this.CLBQuestRaceMask.Name = "CLBQuestRaceMask";
            this.CLBQuestRaceMask.ScrollAlwaysVisible = true;
            this.CLBQuestRaceMask.Size = new System.Drawing.Size(280, 79);
            this.CLBQuestRaceMask.TabIndex = 74;
            // 
            // CLBQuestClassMask
            // 
            this.CLBQuestClassMask.CheckOnClick = true;
            this.CLBQuestClassMask.ColumnWidth = 70;
            this.CLBQuestClassMask.FormattingEnabled = true;
            this.CLBQuestClassMask.HorizontalScrollbar = true;
            this.CLBQuestClassMask.Location = new System.Drawing.Point(86, 111);
            this.CLBQuestClassMask.Margin = new System.Windows.Forms.Padding(2);
            this.CLBQuestClassMask.MaximumSize = new System.Drawing.Size(280, 73);
            this.CLBQuestClassMask.MinimumSize = new System.Drawing.Size(280, 73);
            this.CLBQuestClassMask.MultiColumn = true;
            this.CLBQuestClassMask.Name = "CLBQuestClassMask";
            this.CLBQuestClassMask.ScrollAlwaysVisible = true;
            this.CLBQuestClassMask.Size = new System.Drawing.Size(280, 64);
            this.CLBQuestClassMask.TabIndex = 72;
            // 
            // ButtonQuestImportFromGame
            // 
            this.ButtonQuestImportFromGame.Location = new System.Drawing.Point(272, 11);
            this.ButtonQuestImportFromGame.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonQuestImportFromGame.Name = "ButtonQuestImportFromGame";
            this.ButtonQuestImportFromGame.Size = new System.Drawing.Size(94, 21);
            this.ButtonQuestImportFromGame.TabIndex = 71;
            this.ButtonQuestImportFromGame.Text = "Import";
            this.ButtonQuestImportFromGame.UseVisualStyleBackColor = true;
            this.ButtonQuestImportFromGame.Click += new System.EventHandler(this.ButtonQuestImportFromGame_Click);
            // 
            // ButtonOpenWowHead
            // 
            this.ButtonOpenWowHead.Location = new System.Drawing.Point(276, 363);
            this.ButtonOpenWowHead.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonOpenWowHead.Name = "ButtonOpenWowHead";
            this.ButtonOpenWowHead.Size = new System.Drawing.Size(94, 19);
            this.ButtonOpenWowHead.TabIndex = 28;
            this.ButtonOpenWowHead.Text = "Open Wowhead";
            this.ButtonOpenWowHead.UseVisualStyleBackColor = true;
            this.ButtonOpenWowHead.Click += new System.EventHandler(this.ButtonOpenWowHead_Click);
            // 
            // TBQuestNeedQuestCompId
            // 
            this.TBQuestNeedQuestCompId.ContextMenuStrip = this.ContextMenuStripNeedQuest;
            this.TBQuestNeedQuestCompId.Location = new System.Drawing.Point(131, 56);
            this.TBQuestNeedQuestCompId.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestNeedQuestCompId.Multiline = true;
            this.TBQuestNeedQuestCompId.Name = "TBQuestNeedQuestCompId";
            this.TBQuestNeedQuestCompId.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBQuestNeedQuestCompId.Size = new System.Drawing.Size(78, 23);
            this.TBQuestNeedQuestCompId.TabIndex = 2;
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(2, 58);
            this.Label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(106, 13);
            this.Label27.TabIndex = 27;
            this.Label27.Text = "Need Quest Comp Id";
            // 
            // ButtonQuestNew
            // 
            this.ButtonQuestNew.Location = new System.Drawing.Point(69, 363);
            this.ButtonQuestNew.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonQuestNew.Name = "ButtonQuestNew";
            this.ButtonQuestNew.Size = new System.Drawing.Size(56, 19);
            this.ButtonQuestNew.TabIndex = 15;
            this.ButtonQuestNew.Text = "New Quest";
            this.ButtonQuestNew.UseVisualStyleBackColor = true;
            this.ButtonQuestNew.Click += new System.EventHandler(this.ButtonQuestNew_Click);
            // 
            // ButtonQuestSave
            // 
            this.ButtonQuestSave.Location = new System.Drawing.Point(9, 363);
            this.ButtonQuestSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonQuestSave.Name = "ButtonQuestSave";
            this.ButtonQuestSave.Size = new System.Drawing.Size(56, 19);
            this.ButtonQuestSave.TabIndex = 14;
            this.ButtonQuestSave.Text = "S&ave";
            this.ButtonQuestSave.UseVisualStyleBackColor = true;
            this.ButtonQuestSave.Click += new System.EventHandler(this.ButtonQuestSave_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(4, 14);
            this.Label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(66, 13);
            this.Label12.TabIndex = 2;
            this.Label12.Text = "Quest Name";
            // 
            // TBQuestQuestName
            // 
            this.TBQuestQuestName.Location = new System.Drawing.Point(131, 11);
            this.TBQuestQuestName.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestQuestName.Name = "TBQuestQuestName";
            this.TBQuestQuestName.Size = new System.Drawing.Size(137, 20);
            this.TBQuestQuestName.TabIndex = 0;
            // 
            // TBQuestID
            // 
            this.TBQuestID.Location = new System.Drawing.Point(131, 34);
            this.TBQuestID.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestID.Name = "TBQuestID";
            this.TBQuestID.Size = new System.Drawing.Size(78, 20);
            this.TBQuestID.TabIndex = 1;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(4, 37);
            this.Label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(18, 13);
            this.Label11.TabIndex = 4;
            this.Label11.Text = "ID";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(146, 310);
            this.Label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(52, 13);
            this.Label19.TabIndex = 26;
            this.Label19.Text = "TurnIn ID";
            // 
            // CBClassMask
            // 
            this.CBClassMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBClassMask.FormattingEnabled = true;
            this.CBClassMask.Location = new System.Drawing.Point(264, 109);
            this.CBClassMask.Margin = new System.Windows.Forms.Padding(2);
            this.CBClassMask.Name = "CBClassMask";
            this.CBClassMask.Size = new System.Drawing.Size(90, 21);
            this.CBClassMask.TabIndex = 3;
            this.CBClassMask.Visible = false;
            // 
            // TBQuestTurnInID
            // 
            this.TBQuestTurnInID.Location = new System.Drawing.Point(202, 308);
            this.TBQuestTurnInID.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestTurnInID.Name = "TBQuestTurnInID";
            this.TBQuestTurnInID.Size = new System.Drawing.Size(76, 20);
            this.TBQuestTurnInID.TabIndex = 9;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(4, 111);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(61, 13);
            this.Label13.TabIndex = 13;
            this.Label13.Text = "Class Mask";
            // 
            // CheckBoxItemPickUp
            // 
            this.CheckBoxItemPickUp.AutoSize = true;
            this.CheckBoxItemPickUp.Location = new System.Drawing.Point(282, 288);
            this.CheckBoxItemPickUp.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxItemPickUp.Name = "CheckBoxItemPickUp";
            this.CheckBoxItemPickUp.Size = new System.Drawing.Size(84, 17);
            this.CheckBoxItemPickUp.TabIndex = 10;
            this.CheckBoxItemPickUp.Text = "Item PickUp";
            this.CheckBoxItemPickUp.UseVisualStyleBackColor = true;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(4, 191);
            this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(62, 13);
            this.Label14.TabIndex = 14;
            this.Label14.Text = "Race Mask";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(146, 288);
            this.Label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(56, 13);
            this.Label18.TabIndex = 23;
            this.Label18.Text = "PickUp ID";
            // 
            // TBQuestLevel
            // 
            this.TBQuestLevel.Location = new System.Drawing.Point(68, 285);
            this.TBQuestLevel.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestLevel.Name = "TBQuestLevel";
            this.TBQuestLevel.Size = new System.Drawing.Size(76, 20);
            this.TBQuestLevel.TabIndex = 5;
            // 
            // TBQuestPickUpID
            // 
            this.TBQuestPickUpID.Location = new System.Drawing.Point(202, 285);
            this.TBQuestPickUpID.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestPickUpID.Name = "TBQuestPickUpID";
            this.TBQuestPickUpID.Size = new System.Drawing.Size(76, 20);
            this.TBQuestPickUpID.TabIndex = 8;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(6, 286);
            this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(64, 13);
            this.Label15.TabIndex = 16;
            this.Label15.Text = "Quest Level";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(6, 332);
            this.Label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(56, 13);
            this.Label17.TabIndex = 21;
            this.Label17.Text = "Max Level";
            // 
            // CBRaceMask
            // 
            this.CBRaceMask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRaceMask.FormattingEnabled = true;
            this.CBRaceMask.Location = new System.Drawing.Point(264, 188);
            this.CBRaceMask.Margin = new System.Windows.Forms.Padding(2);
            this.CBRaceMask.Name = "CBRaceMask";
            this.CBRaceMask.Size = new System.Drawing.Size(90, 21);
            this.CBRaceMask.TabIndex = 4;
            this.CBRaceMask.Visible = false;
            // 
            // TBQuestMaxLvl
            // 
            this.TBQuestMaxLvl.Location = new System.Drawing.Point(68, 330);
            this.TBQuestMaxLvl.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestMaxLvl.Name = "TBQuestMaxLvl";
            this.TBQuestMaxLvl.Size = new System.Drawing.Size(76, 20);
            this.TBQuestMaxLvl.TabIndex = 7;
            // 
            // TBQuestMinLvl
            // 
            this.TBQuestMinLvl.Location = new System.Drawing.Point(68, 308);
            this.TBQuestMinLvl.Margin = new System.Windows.Forms.Padding(2);
            this.TBQuestMinLvl.Name = "TBQuestMinLvl";
            this.TBQuestMinLvl.Size = new System.Drawing.Size(76, 20);
            this.TBQuestMinLvl.TabIndex = 6;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(6, 309);
            this.Label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(53, 13);
            this.Label16.TabIndex = 19;
            this.Label16.Text = "Min Level";
            // 
            // TabPageObjectives
            // 
            this.TabPageObjectives.Controls.Add(this.ButtonObjHotSpotsPlayerPosRelative);
            this.TabPageObjectives.Controls.Add(this.ButtonObjImportGPSExtraPoint);
            this.TabPageObjectives.Controls.Add(this.label49);
            this.TabPageObjectives.Controls.Add(this.TBObjExtraFloat);
            this.TabPageObjectives.Controls.Add(this.label48);
            this.TabPageObjectives.Controls.Add(this.TBObjExtraInt);
            this.TabPageObjectives.Controls.Add(this.label47);
            this.TabPageObjectives.Controls.Add(this.TBObjExtraPoint);
            this.TabPageObjectives.Controls.Add(this.label46);
            this.TabPageObjectives.Controls.Add(this.TBObjExtraString);
            this.TabPageObjectives.Controls.Add(this.ButtonObjHotSpotsTargetPos);
            this.TabPageObjectives.Controls.Add(this.label45);
            this.TabPageObjectives.Controls.Add(this.TBObjLuaMacro);
            this.TabPageObjectives.Controls.Add(this.label41);
            this.TabPageObjectives.Controls.Add(this.TBObjCompletedScript);
            this.TabPageObjectives.Controls.Add(this.CBObjPressKeys);
            this.TabPageObjectives.Controls.Add(this.label43);
            this.TabPageObjectives.Controls.Add(this.TBObjMessage);
            this.TabPageObjectives.Controls.Add(this.label42);
            this.TabPageObjectives.Controls.Add(this.LBObjHotspots);
            this.TabPageObjectives.Controls.Add(this.CBObjInternalQuestIdManual);
            this.TabPageObjectives.Controls.Add(this.Label37);
            this.TabPageObjectives.Controls.Add(this.TBObjInternalIndex);
            this.TabPageObjectives.Controls.Add(this.ButtonObjDumpIndex);
            this.TabPageObjectives.Controls.Add(this.PanelObjAll);
            this.TabPageObjectives.Controls.Add(this.ButtonObjHotSpotsPlayerPos);
            this.TabPageObjectives.Controls.Add(this.ButtonObjImportFromGame);
            this.TabPageObjectives.Controls.Add(this.CBObjKillMobPickUpItem);
            this.TabPageObjectives.Controls.Add(this.CBObjInternalQuestID);
            this.TabPageObjectives.Controls.Add(this.CBInternalObj);
            this.TabPageObjectives.Controls.Add(this.Label32);
            this.TabPageObjectives.Controls.Add(this.CBObjIgnoreQuestCompleted);
            this.TabPageObjectives.Controls.Add(this.Label30);
            this.TabPageObjectives.Controls.Add(this.TBObjQuestName);
            this.TabPageObjectives.Controls.Add(this.Label29);
            this.TabPageObjectives.Controls.Add(this.TBObjQuestID);
            this.TabPageObjectives.Controls.Add(this.LabelObjNPCIDorName);
            this.TabPageObjectives.Controls.Add(this.TBObjNPCId);
            this.TabPageObjectives.Controls.Add(this.ButtonObjectiveNew);
            this.TabPageObjectives.Controls.Add(this.ButtonObjectiveSave);
            this.TabPageObjectives.Controls.Add(this.Label8);
            this.TabPageObjectives.Controls.Add(this.Label7);
            this.TabPageObjectives.Controls.Add(this.CBObjType);
            this.TabPageObjectives.Controls.Add(this.PanelObjTaxi);
            this.TabPageObjectives.Location = new System.Drawing.Point(4, 22);
            this.TabPageObjectives.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageObjectives.Name = "TabPageObjectives";
            this.TabPageObjectives.Padding = new System.Windows.Forms.Padding(2);
            this.TabPageObjectives.Size = new System.Drawing.Size(375, 539);
            this.TabPageObjectives.TabIndex = 1;
            this.TabPageObjectives.Text = "Objectives";
            this.TabPageObjectives.UseVisualStyleBackColor = true;
            // 
            // ButtonObjHotSpotsPlayerPosRelative
            // 
            this.ButtonObjHotSpotsPlayerPosRelative.Location = new System.Drawing.Point(247, 403);
            this.ButtonObjHotSpotsPlayerPosRelative.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjHotSpotsPlayerPosRelative.Name = "ButtonObjHotSpotsPlayerPosRelative";
            this.ButtonObjHotSpotsPlayerPosRelative.Size = new System.Drawing.Size(61, 36);
            this.ButtonObjHotSpotsPlayerPosRelative.TabIndex = 102;
            this.ButtonObjHotSpotsPlayerPosRelative.Text = "Add HS Me.PosAbs";
            this.ButtonObjHotSpotsPlayerPosRelative.UseVisualStyleBackColor = true;
            this.ButtonObjHotSpotsPlayerPosRelative.Click += new System.EventHandler(this.ButtonObjHotSpotsPlayerPosRelative_Click);
            // 
            // ButtonObjImportGPSExtraPoint
            // 
            this.ButtonObjImportGPSExtraPoint.Location = new System.Drawing.Point(246, 240);
            this.ButtonObjImportGPSExtraPoint.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjImportGPSExtraPoint.Name = "ButtonObjImportGPSExtraPoint";
            this.ButtonObjImportGPSExtraPoint.Size = new System.Drawing.Size(23, 19);
            this.ButtonObjImportGPSExtraPoint.TabIndex = 101;
            this.ButtonObjImportGPSExtraPoint.Text = "Import From Game";
            this.ButtonObjImportGPSExtraPoint.UseVisualStyleBackColor = true;
            this.ButtonObjImportGPSExtraPoint.Click += new System.EventHandler(this.ButtonObjImportGPSExtraPoint_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(186, 286);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(57, 13);
            this.label49.TabIndex = 100;
            this.label49.Text = "Extra Float";
            // 
            // TBObjExtraFloat
            // 
            this.TBObjExtraFloat.Location = new System.Drawing.Point(273, 282);
            this.TBObjExtraFloat.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjExtraFloat.Name = "TBObjExtraFloat";
            this.TBObjExtraFloat.Size = new System.Drawing.Size(98, 20);
            this.TBObjExtraFloat.TabIndex = 99;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(186, 264);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(46, 13);
            this.label48.TabIndex = 98;
            this.label48.Text = "Extra Int";
            // 
            // TBObjExtraInt
            // 
            this.TBObjExtraInt.Location = new System.Drawing.Point(273, 260);
            this.TBObjExtraInt.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjExtraInt.Name = "TBObjExtraInt";
            this.TBObjExtraInt.Size = new System.Drawing.Size(98, 20);
            this.TBObjExtraInt.TabIndex = 97;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(186, 242);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(58, 13);
            this.label47.TabIndex = 96;
            this.label47.Text = "Extra Point";
            // 
            // TBObjExtraPoint
            // 
            this.TBObjExtraPoint.Location = new System.Drawing.Point(273, 238);
            this.TBObjExtraPoint.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjExtraPoint.Name = "TBObjExtraPoint";
            this.TBObjExtraPoint.Size = new System.Drawing.Size(98, 20);
            this.TBObjExtraPoint.TabIndex = 95;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(186, 220);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(61, 13);
            this.label46.TabIndex = 94;
            this.label46.Text = "Extra String";
            // 
            // TBObjExtraString
            // 
            this.TBObjExtraString.Location = new System.Drawing.Point(273, 216);
            this.TBObjExtraString.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjExtraString.Name = "TBObjExtraString";
            this.TBObjExtraString.Size = new System.Drawing.Size(98, 20);
            this.TBObjExtraString.TabIndex = 93;
            // 
            // ButtonObjHotSpotsTargetPos
            // 
            this.ButtonObjHotSpotsTargetPos.Location = new System.Drawing.Point(311, 403);
            this.ButtonObjHotSpotsTargetPos.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjHotSpotsTargetPos.Name = "ButtonObjHotSpotsTargetPos";
            this.ButtonObjHotSpotsTargetPos.Size = new System.Drawing.Size(61, 36);
            this.ButtonObjHotSpotsTargetPos.TabIndex = 92;
            this.ButtonObjHotSpotsTargetPos.Text = "Add HS Target.Pos";
            this.ButtonObjHotSpotsTargetPos.UseVisualStyleBackColor = true;
            this.ButtonObjHotSpotsTargetPos.Click += new System.EventHandler(this.ButtonObjHotSpotsTargetPos_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(186, 198);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(58, 13);
            this.label45.TabIndex = 91;
            this.label45.Text = "Lua Macro";
            // 
            // TBObjLuaMacro
            // 
            this.TBObjLuaMacro.Location = new System.Drawing.Point(273, 194);
            this.TBObjLuaMacro.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjLuaMacro.Name = "TBObjLuaMacro";
            this.TBObjLuaMacro.Size = new System.Drawing.Size(98, 20);
            this.TBObjLuaMacro.TabIndex = 90;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(186, 176);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(87, 13);
            this.label41.TabIndex = 89;
            this.label41.Text = "Completed Script";
            // 
            // TBObjCompletedScript
            // 
            this.TBObjCompletedScript.Location = new System.Drawing.Point(273, 172);
            this.TBObjCompletedScript.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjCompletedScript.Name = "TBObjCompletedScript";
            this.TBObjCompletedScript.Size = new System.Drawing.Size(98, 20);
            this.TBObjCompletedScript.TabIndex = 88;
            // 
            // CBObjPressKeys
            // 
            this.CBObjPressKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBObjPressKeys.DropDownWidth = 200;
            this.CBObjPressKeys.FormattingEnabled = true;
            this.CBObjPressKeys.Location = new System.Drawing.Point(273, 149);
            this.CBObjPressKeys.Margin = new System.Windows.Forms.Padding(2);
            this.CBObjPressKeys.Name = "CBObjPressKeys";
            this.CBObjPressKeys.Size = new System.Drawing.Size(98, 21);
            this.CBObjPressKeys.TabIndex = 87;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(186, 132);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 13);
            this.label43.TabIndex = 86;
            this.label43.Text = "Message/Script";
            // 
            // TBObjMessage
            // 
            this.TBObjMessage.Location = new System.Drawing.Point(273, 127);
            this.TBObjMessage.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjMessage.Name = "TBObjMessage";
            this.TBObjMessage.Size = new System.Drawing.Size(98, 20);
            this.TBObjMessage.TabIndex = 85;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(186, 154);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(54, 13);
            this.label42.TabIndex = 84;
            this.label42.Text = "Press Key";
            // 
            // LBObjHotspots
            // 
            this.LBObjHotspots.FormattingEnabled = true;
            this.LBObjHotspots.Location = new System.Drawing.Point(185, 443);
            this.LBObjHotspots.Margin = new System.Windows.Forms.Padding(2);
            this.LBObjHotspots.Name = "LBObjHotspots";
            this.LBObjHotspots.Size = new System.Drawing.Size(186, 69);
            this.LBObjHotspots.TabIndex = 80;
            this.LBObjHotspots.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LBObjHotspots_PreviewKeyDown);
            // 
            // CBObjInternalQuestIdManual
            // 
            this.CBObjInternalQuestIdManual.AutoSize = true;
            this.CBObjInternalQuestIdManual.Checked = true;
            this.CBObjInternalQuestIdManual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBObjInternalQuestIdManual.Location = new System.Drawing.Point(285, 326);
            this.CBObjInternalQuestIdManual.Name = "CBObjInternalQuestIdManual";
            this.CBObjInternalQuestIdManual.Size = new System.Drawing.Size(67, 17);
            this.CBObjInternalQuestIdManual.TabIndex = 79;
            this.CBObjInternalQuestIdManual.Text = "Manual?";
            this.CBObjInternalQuestIdManual.UseVisualStyleBackColor = true;
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(184, 386);
            this.Label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(68, 13);
            this.Label37.TabIndex = 78;
            this.Label37.Text = "InternalIndex";
            // 
            // TBObjInternalIndex
            // 
            this.TBObjInternalIndex.Location = new System.Drawing.Point(273, 379);
            this.TBObjInternalIndex.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjInternalIndex.Name = "TBObjInternalIndex";
            this.TBObjInternalIndex.Size = new System.Drawing.Size(103, 20);
            this.TBObjInternalIndex.TabIndex = 78;
            // 
            // ButtonObjDumpIndex
            // 
            this.ButtonObjDumpIndex.Location = new System.Drawing.Point(208, 11);
            this.ButtonObjDumpIndex.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjDumpIndex.Name = "ButtonObjDumpIndex";
            this.ButtonObjDumpIndex.Size = new System.Drawing.Size(119, 19);
            this.ButtonObjDumpIndex.TabIndex = 73;
            this.ButtonObjDumpIndex.Text = "Dump Internal Index";
            this.ButtonObjDumpIndex.UseVisualStyleBackColor = true;
            this.ButtonObjDumpIndex.Click += new System.EventHandler(this.ButtonObjDumpIndex_Click);
            // 
            // PanelObjAll
            // 
            this.PanelObjAll.Controls.Add(this.CBObjIgnoreAllFight);
            this.PanelObjAll.Controls.Add(this.CBObjIsBonusObjective);
            this.PanelObjAll.Controls.Add(this.CBObjDismissPet);
            this.PanelObjAll.Controls.Add(this.CBObjIgnoreItemNotUsable);
            this.PanelObjAll.Controls.Add(this.ButtonObjImportCursorItemID);
            this.PanelObjAll.Controls.Add(this.CBObjDeactivateMount);
            this.PanelObjAll.Controls.Add(this.CBObjIgnoreFight);
            this.PanelObjAll.Controls.Add(this.CBObjForceTravelToQuestZone);
            this.PanelObjAll.Controls.Add(this.CBObjIgnoreNotSelectable);
            this.PanelObjAll.Controls.Add(this.CBObjAllowPlayerControlled);
            this.PanelObjAll.Controls.Add(this.CBObjIgnoreBlackList);
            this.PanelObjAll.Controls.Add(this.CBObjIsDead);
            this.PanelObjAll.Controls.Add(this.TBObjGossipOption);
            this.PanelObjAll.Controls.Add(this.Label35);
            this.PanelObjAll.Controls.Add(this.Label9);
            this.PanelObjAll.Controls.Add(this.CBObjCanPullUnitsInFight);
            this.PanelObjAll.Controls.Add(this.ButtonObjImportGPS);
            this.PanelObjAll.Controls.Add(this.TBObjCount);
            this.PanelObjAll.Controls.Add(this.ButtonObjImportEntry);
            this.PanelObjAll.Controls.Add(this.TBObjEntry);
            this.PanelObjAll.Controls.Add(this.Label10);
            this.PanelObjAll.Controls.Add(this.TBObjCollectItemID);
            this.PanelObjAll.Controls.Add(this.Label20);
            this.PanelObjAll.Controls.Add(this.TBObjCollectCount);
            this.PanelObjAll.Controls.Add(this.Label21);
            this.PanelObjAll.Controls.Add(this.TBObjUseItemID);
            this.PanelObjAll.Controls.Add(this.Label22);
            this.PanelObjAll.Controls.Add(this.TBObjPosition);
            this.PanelObjAll.Controls.Add(this.Label23);
            this.PanelObjAll.Controls.Add(this.TBObjWaitMs);
            this.PanelObjAll.Controls.Add(this.Label24);
            this.PanelObjAll.Controls.Add(this.TBObjRange);
            this.PanelObjAll.Controls.Add(this.Label25);
            this.PanelObjAll.Controls.Add(this.TBObjUseSpellId);
            this.PanelObjAll.Controls.Add(this.Label26);
            this.PanelObjAll.Location = new System.Drawing.Point(12, 58);
            this.PanelObjAll.Margin = new System.Windows.Forms.Padding(2);
            this.PanelObjAll.Name = "PanelObjAll";
            this.PanelObjAll.Size = new System.Drawing.Size(168, 454);
            this.PanelObjAll.TabIndex = 14;
            this.PanelObjAll.Visible = false;
            // 
            // CBObjIgnoreAllFight
            // 
            this.CBObjIgnoreAllFight.AutoSize = true;
            this.CBObjIgnoreAllFight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjIgnoreAllFight.Location = new System.Drawing.Point(-1, 296);
            this.CBObjIgnoreAllFight.Name = "CBObjIgnoreAllFight";
            this.CBObjIgnoreAllFight.Size = new System.Drawing.Size(90, 17);
            this.CBObjIgnoreAllFight.TabIndex = 93;
            this.CBObjIgnoreAllFight.Text = "IgnoreAllFight";
            this.CBObjIgnoreAllFight.UseVisualStyleBackColor = true;
            // 
            // CBObjIsBonusObjective
            // 
            this.CBObjIsBonusObjective.AutoSize = true;
            this.CBObjIsBonusObjective.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjIsBonusObjective.Location = new System.Drawing.Point(55, 432);
            this.CBObjIsBonusObjective.Name = "CBObjIsBonusObjective";
            this.CBObjIsBonusObjective.Size = new System.Drawing.Size(109, 17);
            this.CBObjIsBonusObjective.TabIndex = 92;
            this.CBObjIsBonusObjective.Text = "IsBonusObjective";
            this.CBObjIsBonusObjective.UseVisualStyleBackColor = true;
            // 
            // CBObjDismissPet
            // 
            this.CBObjDismissPet.AutoSize = true;
            this.CBObjDismissPet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjDismissPet.Location = new System.Drawing.Point(87, 415);
            this.CBObjDismissPet.Name = "CBObjDismissPet";
            this.CBObjDismissPet.Size = new System.Drawing.Size(77, 17);
            this.CBObjDismissPet.TabIndex = 91;
            this.CBObjDismissPet.Text = "DismissPet";
            this.CBObjDismissPet.UseVisualStyleBackColor = true;
            // 
            // CBObjIgnoreItemNotUsable
            // 
            this.CBObjIgnoreItemNotUsable.AutoSize = true;
            this.CBObjIgnoreItemNotUsable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjIgnoreItemNotUsable.Location = new System.Drawing.Point(29, 398);
            this.CBObjIgnoreItemNotUsable.Name = "CBObjIgnoreItemNotUsable";
            this.CBObjIgnoreItemNotUsable.Size = new System.Drawing.Size(135, 17);
            this.CBObjIgnoreItemNotUsable.TabIndex = 90;
            this.CBObjIgnoreItemNotUsable.Text = "Ignore Item Not Usable";
            this.CBObjIgnoreItemNotUsable.UseVisualStyleBackColor = true;
            // 
            // ButtonObjImportCursorItemID
            // 
            this.ButtonObjImportCursorItemID.Location = new System.Drawing.Point(60, 126);
            this.ButtonObjImportCursorItemID.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjImportCursorItemID.Name = "ButtonObjImportCursorItemID";
            this.ButtonObjImportCursorItemID.Size = new System.Drawing.Size(23, 19);
            this.ButtonObjImportCursorItemID.TabIndex = 89;
            this.ButtonObjImportCursorItemID.Text = "Import From Game";
            this.ButtonObjImportCursorItemID.UseVisualStyleBackColor = true;
            this.ButtonObjImportCursorItemID.Click += new System.EventHandler(this.ButtonObjImportCursorItemID_Click);
            // 
            // CBObjDeactivateMount
            // 
            this.CBObjDeactivateMount.AutoSize = true;
            this.CBObjDeactivateMount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjDeactivateMount.Location = new System.Drawing.Point(53, 381);
            this.CBObjDeactivateMount.Name = "CBObjDeactivateMount";
            this.CBObjDeactivateMount.Size = new System.Drawing.Size(111, 17);
            this.CBObjDeactivateMount.TabIndex = 88;
            this.CBObjDeactivateMount.Text = "Deactivate Mount";
            this.CBObjDeactivateMount.UseVisualStyleBackColor = true;
            // 
            // CBObjIgnoreFight
            // 
            this.CBObjIgnoreFight.AutoSize = true;
            this.CBObjIgnoreFight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjIgnoreFight.Location = new System.Drawing.Point(85, 296);
            this.CBObjIgnoreFight.Name = "CBObjIgnoreFight";
            this.CBObjIgnoreFight.Size = new System.Drawing.Size(79, 17);
            this.CBObjIgnoreFight.TabIndex = 87;
            this.CBObjIgnoreFight.Text = "IgnoreFight";
            this.CBObjIgnoreFight.UseVisualStyleBackColor = true;
            // 
            // CBObjForceTravelToQuestZone
            // 
            this.CBObjForceTravelToQuestZone.AutoSize = true;
            this.CBObjForceTravelToQuestZone.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjForceTravelToQuestZone.Location = new System.Drawing.Point(15, 364);
            this.CBObjForceTravelToQuestZone.Name = "CBObjForceTravelToQuestZone";
            this.CBObjForceTravelToQuestZone.Size = new System.Drawing.Size(149, 17);
            this.CBObjForceTravelToQuestZone.TabIndex = 86;
            this.CBObjForceTravelToQuestZone.Text = "ForceTravelToQuestZone";
            this.CBObjForceTravelToQuestZone.UseVisualStyleBackColor = true;
            // 
            // CBObjIgnoreNotSelectable
            // 
            this.CBObjIgnoreNotSelectable.AutoSize = true;
            this.CBObjIgnoreNotSelectable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjIgnoreNotSelectable.Location = new System.Drawing.Point(41, 347);
            this.CBObjIgnoreNotSelectable.Name = "CBObjIgnoreNotSelectable";
            this.CBObjIgnoreNotSelectable.Size = new System.Drawing.Size(123, 17);
            this.CBObjIgnoreNotSelectable.TabIndex = 85;
            this.CBObjIgnoreNotSelectable.Text = "IgnoreNotSelectable";
            this.CBObjIgnoreNotSelectable.UseVisualStyleBackColor = true;
            // 
            // CBObjAllowPlayerControlled
            // 
            this.CBObjAllowPlayerControlled.AutoSize = true;
            this.CBObjAllowPlayerControlled.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjAllowPlayerControlled.Location = new System.Drawing.Point(34, 330);
            this.CBObjAllowPlayerControlled.Name = "CBObjAllowPlayerControlled";
            this.CBObjAllowPlayerControlled.Size = new System.Drawing.Size(130, 17);
            this.CBObjAllowPlayerControlled.TabIndex = 84;
            this.CBObjAllowPlayerControlled.Text = "AllowPlayerControlled ";
            this.CBObjAllowPlayerControlled.UseVisualStyleBackColor = true;
            // 
            // CBObjIgnoreBlackList
            // 
            this.CBObjIgnoreBlackList.AutoSize = true;
            this.CBObjIgnoreBlackList.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjIgnoreBlackList.Location = new System.Drawing.Point(82, 313);
            this.CBObjIgnoreBlackList.Name = "CBObjIgnoreBlackList";
            this.CBObjIgnoreBlackList.Size = new System.Drawing.Size(82, 17);
            this.CBObjIgnoreBlackList.TabIndex = 83;
            this.CBObjIgnoreBlackList.Text = "Ignore BList";
            this.CBObjIgnoreBlackList.UseVisualStyleBackColor = true;
            // 
            // CBObjIsDead
            // 
            this.CBObjIsDead.AutoSize = true;
            this.CBObjIsDead.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjIsDead.Location = new System.Drawing.Point(61, 279);
            this.CBObjIsDead.Name = "CBObjIsDead";
            this.CBObjIsDead.Size = new System.Drawing.Size(103, 17);
            this.CBObjIsDead.TabIndex = 78;
            this.CBObjIsDead.Text = "Target Is Dead?";
            this.CBObjIsDead.UseVisualStyleBackColor = true;
            // 
            // TBObjGossipOption
            // 
            this.TBObjGossipOption.Location = new System.Drawing.Point(88, 240);
            this.TBObjGossipOption.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjGossipOption.Name = "TBObjGossipOption";
            this.TBObjGossipOption.Size = new System.Drawing.Size(76, 20);
            this.TBObjGossipOption.TabIndex = 76;
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(2, 243);
            this.Label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(78, 13);
            this.Label35.TabIndex = 77;
            this.Label35.Text = "Gossip Options";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(2, 9);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(35, 13);
            this.Label9.TabIndex = 32;
            this.Label9.Text = "Count";
            // 
            // CBObjCanPullUnitsInFight
            // 
            this.CBObjCanPullUnitsInFight.AutoSize = true;
            this.CBObjCanPullUnitsInFight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBObjCanPullUnitsInFight.Location = new System.Drawing.Point(11, 262);
            this.CBObjCanPullUnitsInFight.Name = "CBObjCanPullUnitsInFight";
            this.CBObjCanPullUnitsInFight.Size = new System.Drawing.Size(153, 17);
            this.CBObjCanPullUnitsInFight.TabIndex = 73;
            this.CBObjCanPullUnitsInFight.Text = "CanPullUnitsAlreadyInFight";
            this.CBObjCanPullUnitsInFight.UseVisualStyleBackColor = true;
            // 
            // ButtonObjImportGPS
            // 
            this.ButtonObjImportGPS.Location = new System.Drawing.Point(60, 148);
            this.ButtonObjImportGPS.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjImportGPS.Name = "ButtonObjImportGPS";
            this.ButtonObjImportGPS.Size = new System.Drawing.Size(23, 19);
            this.ButtonObjImportGPS.TabIndex = 75;
            this.ButtonObjImportGPS.Text = "Import From Game";
            this.ButtonObjImportGPS.UseVisualStyleBackColor = true;
            this.ButtonObjImportGPS.Click += new System.EventHandler(this.ButtonObjImportGPS_Click);
            // 
            // TBObjCount
            // 
            this.TBObjCount.Location = new System.Drawing.Point(88, 5);
            this.TBObjCount.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjCount.Name = "TBObjCount";
            this.TBObjCount.Size = new System.Drawing.Size(76, 20);
            this.TBObjCount.TabIndex = 1;
            // 
            // ButtonObjImportEntry
            // 
            this.ButtonObjImportEntry.Location = new System.Drawing.Point(60, 29);
            this.ButtonObjImportEntry.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjImportEntry.Name = "ButtonObjImportEntry";
            this.ButtonObjImportEntry.Size = new System.Drawing.Size(23, 19);
            this.ButtonObjImportEntry.TabIndex = 74;
            this.ButtonObjImportEntry.Text = "Import From Game";
            this.ButtonObjImportEntry.UseVisualStyleBackColor = true;
            this.ButtonObjImportEntry.Click += new System.EventHandler(this.ButtonObjImportEntry_Click);
            // 
            // TBObjEntry
            // 
            this.TBObjEntry.Location = new System.Drawing.Point(88, 29);
            this.TBObjEntry.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjEntry.Multiline = true;
            this.TBObjEntry.Name = "TBObjEntry";
            this.TBObjEntry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBObjEntry.Size = new System.Drawing.Size(76, 48);
            this.TBObjEntry.TabIndex = 2;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(2, 33);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(31, 13);
            this.Label10.TabIndex = 34;
            this.Label10.Text = "Entry";
            // 
            // TBObjCollectItemID
            // 
            this.TBObjCollectItemID.Location = new System.Drawing.Point(88, 80);
            this.TBObjCollectItemID.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjCollectItemID.Name = "TBObjCollectItemID";
            this.TBObjCollectItemID.Size = new System.Drawing.Size(76, 20);
            this.TBObjCollectItemID.TabIndex = 3;
            this.TBObjCollectItemID.Text = "1";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(2, 84);
            this.Label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(68, 13);
            this.Label20.TabIndex = 36;
            this.Label20.Text = "CollectItemId";
            // 
            // TBObjCollectCount
            // 
            this.TBObjCollectCount.Location = new System.Drawing.Point(88, 102);
            this.TBObjCollectCount.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjCollectCount.Name = "TBObjCollectCount";
            this.TBObjCollectCount.Size = new System.Drawing.Size(76, 20);
            this.TBObjCollectCount.TabIndex = 4;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(2, 106);
            this.Label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(67, 13);
            this.Label21.TabIndex = 38;
            this.Label21.Text = "CollectCount";
            // 
            // TBObjUseItemID
            // 
            this.TBObjUseItemID.Location = new System.Drawing.Point(88, 126);
            this.TBObjUseItemID.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjUseItemID.Name = "TBObjUseItemID";
            this.TBObjUseItemID.Size = new System.Drawing.Size(76, 20);
            this.TBObjUseItemID.TabIndex = 5;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(2, 128);
            this.Label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(55, 13);
            this.Label22.TabIndex = 40;
            this.Label22.Text = "UseItemId";
            // 
            // TBObjPosition
            // 
            this.TBObjPosition.Location = new System.Drawing.Point(88, 148);
            this.TBObjPosition.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjPosition.Name = "TBObjPosition";
            this.TBObjPosition.Size = new System.Drawing.Size(76, 20);
            this.TBObjPosition.TabIndex = 6;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(2, 151);
            this.Label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(44, 13);
            this.Label23.TabIndex = 42;
            this.Label23.Text = "Position";
            // 
            // TBObjWaitMs
            // 
            this.TBObjWaitMs.Location = new System.Drawing.Point(88, 170);
            this.TBObjWaitMs.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjWaitMs.Name = "TBObjWaitMs";
            this.TBObjWaitMs.Size = new System.Drawing.Size(76, 20);
            this.TBObjWaitMs.TabIndex = 7;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(2, 174);
            this.Label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(43, 13);
            this.Label24.TabIndex = 44;
            this.Label24.Text = "WaitMs";
            // 
            // TBObjRange
            // 
            this.TBObjRange.Location = new System.Drawing.Point(88, 196);
            this.TBObjRange.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjRange.Name = "TBObjRange";
            this.TBObjRange.Size = new System.Drawing.Size(76, 20);
            this.TBObjRange.TabIndex = 8;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(2, 200);
            this.Label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(39, 13);
            this.Label25.TabIndex = 46;
            this.Label25.Text = "Range";
            // 
            // TBObjUseSpellId
            // 
            this.TBObjUseSpellId.Location = new System.Drawing.Point(88, 219);
            this.TBObjUseSpellId.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjUseSpellId.Name = "TBObjUseSpellId";
            this.TBObjUseSpellId.Size = new System.Drawing.Size(76, 20);
            this.TBObjUseSpellId.TabIndex = 9;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(2, 222);
            this.Label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(58, 13);
            this.Label26.TabIndex = 48;
            this.Label26.Text = "UseSpellId";
            // 
            // ButtonObjHotSpotsPlayerPos
            // 
            this.ButtonObjHotSpotsPlayerPos.Location = new System.Drawing.Point(184, 403);
            this.ButtonObjHotSpotsPlayerPos.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjHotSpotsPlayerPos.Name = "ButtonObjHotSpotsPlayerPos";
            this.ButtonObjHotSpotsPlayerPos.Size = new System.Drawing.Size(61, 36);
            this.ButtonObjHotSpotsPlayerPos.TabIndex = 71;
            this.ButtonObjHotSpotsPlayerPos.Text = "Add HS Me.Pos";
            this.ButtonObjHotSpotsPlayerPos.UseVisualStyleBackColor = true;
            this.ButtonObjHotSpotsPlayerPos.Click += new System.EventHandler(this.ButtonObjHotSpots_Click);
            // 
            // ButtonObjImportFromGame
            // 
            this.ButtonObjImportFromGame.Location = new System.Drawing.Point(100, 11);
            this.ButtonObjImportFromGame.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjImportFromGame.Name = "ButtonObjImportFromGame";
            this.ButtonObjImportFromGame.Size = new System.Drawing.Size(104, 19);
            this.ButtonObjImportFromGame.TabIndex = 70;
            this.ButtonObjImportFromGame.Text = "Import From Game";
            this.ButtonObjImportFromGame.UseVisualStyleBackColor = true;
            this.ButtonObjImportFromGame.Click += new System.EventHandler(this.ButtonObjImportFromGame_Click);
            // 
            // CBObjKillMobPickUpItem
            // 
            this.CBObjKillMobPickUpItem.AutoSize = true;
            this.CBObjKillMobPickUpItem.Location = new System.Drawing.Point(277, 39);
            this.CBObjKillMobPickUpItem.Name = "CBObjKillMobPickUpItem";
            this.CBObjKillMobPickUpItem.Size = new System.Drawing.Size(90, 17);
            this.CBObjKillMobPickUpItem.TabIndex = 65;
            this.CBObjKillMobPickUpItem.Text = "PickUp Item?";
            this.CBObjKillMobPickUpItem.UseVisualStyleBackColor = true;
            this.CBObjKillMobPickUpItem.Visible = false;
            this.CBObjKillMobPickUpItem.CheckedChanged += new System.EventHandler(this.CBObjKillMobPickUpItem_CheckedChanged);
            // 
            // CBObjInternalQuestID
            // 
            this.CBObjInternalQuestID.FormattingEnabled = true;
            this.CBObjInternalQuestID.Location = new System.Drawing.Point(187, 357);
            this.CBObjInternalQuestID.Name = "CBObjInternalQuestID";
            this.CBObjInternalQuestID.Size = new System.Drawing.Size(184, 21);
            this.CBObjInternalQuestID.TabIndex = 64;
            // 
            // CBInternalObj
            // 
            this.CBInternalObj.AutoSize = true;
            this.CBInternalObj.Checked = true;
            this.CBInternalObj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBInternalObj.Location = new System.Drawing.Point(187, 326);
            this.CBInternalObj.Name = "CBInternalObj";
            this.CBInternalObj.Size = new System.Drawing.Size(98, 17);
            this.CBInternalObj.TabIndex = 14;
            this.CBInternalObj.Text = "Internal Quest?";
            this.CBInternalObj.UseVisualStyleBackColor = true;
            this.CBInternalObj.CheckedChanged += new System.EventHandler(this.CBInternalObj_CheckedChanged);
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Location = new System.Drawing.Point(204, 343);
            this.Label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(85, 13);
            this.Label32.TabIndex = 57;
            this.Label32.Text = "Internal Quest Id";
            // 
            // CBObjIgnoreQuestCompleted
            // 
            this.CBObjIgnoreQuestCompleted.AutoSize = true;
            this.CBObjIgnoreQuestCompleted.Checked = true;
            this.CBObjIgnoreQuestCompleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBObjIgnoreQuestCompleted.Location = new System.Drawing.Point(187, 308);
            this.CBObjIgnoreQuestCompleted.Name = "CBObjIgnoreQuestCompleted";
            this.CBObjIgnoreQuestCompleted.Size = new System.Drawing.Size(140, 17);
            this.CBObjIgnoreQuestCompleted.TabIndex = 13;
            this.CBObjIgnoreQuestCompleted.Text = "Ignore Quest Completed";
            this.CBObjIgnoreQuestCompleted.UseVisualStyleBackColor = true;
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(186, 110);
            this.Label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(66, 13);
            this.Label30.TabIndex = 54;
            this.Label30.Text = "Quest Name";
            // 
            // TBObjQuestName
            // 
            this.TBObjQuestName.Location = new System.Drawing.Point(273, 105);
            this.TBObjQuestName.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjQuestName.Name = "TBObjQuestName";
            this.TBObjQuestName.Size = new System.Drawing.Size(98, 20);
            this.TBObjQuestName.TabIndex = 12;
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(186, 88);
            this.Label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(46, 13);
            this.Label29.TabIndex = 52;
            this.Label29.Text = "QuestID";
            // 
            // TBObjQuestID
            // 
            this.TBObjQuestID.Location = new System.Drawing.Point(273, 83);
            this.TBObjQuestID.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjQuestID.Name = "TBObjQuestID";
            this.TBObjQuestID.Size = new System.Drawing.Size(98, 20);
            this.TBObjQuestID.TabIndex = 11;
            // 
            // LabelObjNPCIDorName
            // 
            this.LabelObjNPCIDorName.AutoSize = true;
            this.LabelObjNPCIDorName.Location = new System.Drawing.Point(186, 66);
            this.LabelObjNPCIDorName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelObjNPCIDorName.Name = "LabelObjNPCIDorName";
            this.LabelObjNPCIDorName.Size = new System.Drawing.Size(41, 13);
            this.LabelObjNPCIDorName.TabIndex = 50;
            this.LabelObjNPCIDorName.Text = "NPC Id";
            // 
            // TBObjNPCId
            // 
            this.TBObjNPCId.Location = new System.Drawing.Point(273, 61);
            this.TBObjNPCId.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjNPCId.Name = "TBObjNPCId";
            this.TBObjNPCId.Size = new System.Drawing.Size(98, 20);
            this.TBObjNPCId.TabIndex = 10;
            // 
            // ButtonObjectiveNew
            // 
            this.ButtonObjectiveNew.Location = new System.Drawing.Point(74, 516);
            this.ButtonObjectiveNew.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjectiveNew.Name = "ButtonObjectiveNew";
            this.ButtonObjectiveNew.Size = new System.Drawing.Size(56, 19);
            this.ButtonObjectiveNew.TabIndex = 17;
            this.ButtonObjectiveNew.Text = "New Quest";
            this.ButtonObjectiveNew.UseVisualStyleBackColor = true;
            this.ButtonObjectiveNew.Click += new System.EventHandler(this.ButtonObjectiveNew_Click);
            // 
            // ButtonObjectiveSave
            // 
            this.ButtonObjectiveSave.Location = new System.Drawing.Point(13, 516);
            this.ButtonObjectiveSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjectiveSave.Name = "ButtonObjectiveSave";
            this.ButtonObjectiveSave.Size = new System.Drawing.Size(56, 19);
            this.ButtonObjectiveSave.TabIndex = 16;
            this.ButtonObjectiveSave.Text = "Save";
            this.ButtonObjectiveSave.UseVisualStyleBackColor = true;
            this.ButtonObjectiveSave.Click += new System.EventHandler(this.ButtonObjectiveSave_Click);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(15, 42);
            this.Label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(31, 13);
            this.Label8.TabIndex = 30;
            this.Label8.Text = "Type";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(15, 14);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(57, 13);
            this.Label7.TabIndex = 28;
            this.Label7.Text = "Objectives";
            // 
            // CBObjType
            // 
            this.CBObjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBObjType.FormattingEnabled = true;
            this.CBObjType.Location = new System.Drawing.Point(100, 37);
            this.CBObjType.Margin = new System.Windows.Forms.Padding(2);
            this.CBObjType.Name = "CBObjType";
            this.CBObjType.Size = new System.Drawing.Size(174, 21);
            this.CBObjType.TabIndex = 0;
            this.CBObjType.SelectedValueChanged += new System.EventHandler(this.CBObjType_SelectedValueChanged);
            // 
            // PanelObjTaxi
            // 
            this.PanelObjTaxi.Controls.Add(this.TBObjFlightWaitMs);
            this.PanelObjTaxi.Controls.Add(this.Label36);
            this.PanelObjTaxi.Controls.Add(this.ButtonObjGetXY);
            this.PanelObjTaxi.Controls.Add(this.TBObjDestinationY);
            this.PanelObjTaxi.Controls.Add(this.TBObjTaxiEntryId);
            this.PanelObjTaxi.Controls.Add(this.Label33);
            this.PanelObjTaxi.Controls.Add(this.TBObjDestinationX);
            this.PanelObjTaxi.Controls.Add(this.Label31);
            this.PanelObjTaxi.Controls.Add(this.Label34);
            this.PanelObjTaxi.Location = new System.Drawing.Point(12, 211);
            this.PanelObjTaxi.Margin = new System.Windows.Forms.Padding(2);
            this.PanelObjTaxi.Name = "PanelObjTaxi";
            this.PanelObjTaxi.Size = new System.Drawing.Size(170, 145);
            this.PanelObjTaxi.TabIndex = 14;
            this.PanelObjTaxi.Visible = false;
            // 
            // TBObjFlightWaitMs
            // 
            this.TBObjFlightWaitMs.Location = new System.Drawing.Point(90, 80);
            this.TBObjFlightWaitMs.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjFlightWaitMs.Name = "TBObjFlightWaitMs";
            this.TBObjFlightWaitMs.Size = new System.Drawing.Size(76, 20);
            this.TBObjFlightWaitMs.TabIndex = 64;
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(4, 81);
            this.Label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(43, 13);
            this.Label36.TabIndex = 65;
            this.Label36.Text = "WaitMs";
            // 
            // ButtonObjGetXY
            // 
            this.ButtonObjGetXY.Location = new System.Drawing.Point(2, 106);
            this.ButtonObjGetXY.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonObjGetXY.Name = "ButtonObjGetXY";
            this.ButtonObjGetXY.Size = new System.Drawing.Size(163, 31);
            this.ButtonObjGetXY.TabIndex = 14;
            this.ButtonObjGetXY.Text = "Import X Y After Flight";
            this.ButtonObjGetXY.UseVisualStyleBackColor = true;
            // 
            // TBObjDestinationY
            // 
            this.TBObjDestinationY.Location = new System.Drawing.Point(90, 56);
            this.TBObjDestinationY.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjDestinationY.Name = "TBObjDestinationY";
            this.TBObjDestinationY.Size = new System.Drawing.Size(76, 20);
            this.TBObjDestinationY.TabIndex = 62;
            // 
            // TBObjTaxiEntryId
            // 
            this.TBObjTaxiEntryId.Location = new System.Drawing.Point(90, 8);
            this.TBObjTaxiEntryId.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjTaxiEntryId.Name = "TBObjTaxiEntryId";
            this.TBObjTaxiEntryId.Size = new System.Drawing.Size(76, 20);
            this.TBObjTaxiEntryId.TabIndex = 58;
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(4, 11);
            this.Label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(60, 13);
            this.Label33.TabIndex = 60;
            this.Label33.Text = "TaxiEntryId";
            // 
            // TBObjDestinationX
            // 
            this.TBObjDestinationX.Location = new System.Drawing.Point(90, 32);
            this.TBObjDestinationX.Margin = new System.Windows.Forms.Padding(2);
            this.TBObjDestinationX.Name = "TBObjDestinationX";
            this.TBObjDestinationX.Size = new System.Drawing.Size(76, 20);
            this.TBObjDestinationX.TabIndex = 59;
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(4, 32);
            this.Label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(70, 13);
            this.Label31.TabIndex = 61;
            this.Label31.Text = "Destination X";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(4, 57);
            this.Label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(70, 13);
            this.Label34.TabIndex = 63;
            this.Label34.Text = "Destination Y";
            // 
            // TabPageBlackList
            // 
            this.TabPageBlackList.Controls.Add(this.label44);
            this.TabPageBlackList.Controls.Add(this.TBBlackListRadius);
            this.TabPageBlackList.Controls.Add(this.ButtonBlackListSave);
            this.TabPageBlackList.Controls.Add(this.TBBlackList);
            this.TabPageBlackList.Controls.Add(this.ButtonBlackListAdd);
            this.TabPageBlackList.Location = new System.Drawing.Point(4, 22);
            this.TabPageBlackList.Margin = new System.Windows.Forms.Padding(2);
            this.TabPageBlackList.Name = "TabPageBlackList";
            this.TabPageBlackList.Padding = new System.Windows.Forms.Padding(2);
            this.TabPageBlackList.Size = new System.Drawing.Size(375, 539);
            this.TabPageBlackList.TabIndex = 2;
            this.TabPageBlackList.Text = "BlackList";
            this.TabPageBlackList.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(206, 18);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(40, 13);
            this.label44.TabIndex = 82;
            this.label44.Text = "Radius";
            // 
            // TBBlackListRadius
            // 
            this.TBBlackListRadius.Location = new System.Drawing.Point(251, 15);
            this.TBBlackListRadius.Name = "TBBlackListRadius";
            this.TBBlackListRadius.Size = new System.Drawing.Size(100, 20);
            this.TBBlackListRadius.TabIndex = 81;
            // 
            // ButtonBlackListSave
            // 
            this.ButtonBlackListSave.Location = new System.Drawing.Point(11, 107);
            this.ButtonBlackListSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonBlackListSave.Name = "ButtonBlackListSave";
            this.ButtonBlackListSave.Size = new System.Drawing.Size(79, 34);
            this.ButtonBlackListSave.TabIndex = 80;
            this.ButtonBlackListSave.Text = "Save";
            this.ButtonBlackListSave.UseVisualStyleBackColor = true;
            this.ButtonBlackListSave.Click += new System.EventHandler(this.ButtonBlackListSave_Click);
            // 
            // TBBlackList
            // 
            this.TBBlackList.Location = new System.Drawing.Point(10, 41);
            this.TBBlackList.Margin = new System.Windows.Forms.Padding(2);
            this.TBBlackList.Multiline = true;
            this.TBBlackList.Name = "TBBlackList";
            this.TBBlackList.Size = new System.Drawing.Size(340, 58);
            this.TBBlackList.TabIndex = 79;
            // 
            // ButtonBlackListAdd
            // 
            this.ButtonBlackListAdd.Location = new System.Drawing.Point(10, 11);
            this.ButtonBlackListAdd.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonBlackListAdd.Name = "ButtonBlackListAdd";
            this.ButtonBlackListAdd.Size = new System.Drawing.Size(191, 28);
            this.ButtonBlackListAdd.TabIndex = 78;
            this.ButtonBlackListAdd.Text = "Add BlackList (Player Position IG)";
            this.ButtonBlackListAdd.UseVisualStyleBackColor = true;
            this.ButtonBlackListAdd.Click += new System.EventHandler(this.ButtonBlackListAdd_Click);
            // 
            // TabPageCustomPath
            // 
            this.TabPageCustomPath.Controls.Add(this.ButtonCPDeleteSelectedPoints);
            this.TabPageCustomPath.Controls.Add(this.ButtonCPAdd);
            this.TabPageCustomPath.Controls.Add(this.ButtonCPDelete);
            this.TabPageCustomPath.Controls.Add(this.ComboCPContB);
            this.TabPageCustomPath.Controls.Add(this.label54);
            this.TabPageCustomPath.Controls.Add(this.label53);
            this.TabPageCustomPath.Controls.Add(this.ComboCPContA);
            this.TabPageCustomPath.Controls.Add(this.label52);
            this.TabPageCustomPath.Controls.Add(this.ComboCPFaction);
            this.TabPageCustomPath.Controls.Add(this.CBCPUseMount);
            this.TabPageCustomPath.Controls.Add(this.CBCPRoundTrip);
            this.TabPageCustomPath.Controls.Add(this.CBCPForceFlying);
            this.TabPageCustomPath.Controls.Add(this.CBCPAllowFar);
            this.TabPageCustomPath.Controls.Add(this.label51);
            this.TabPageCustomPath.Controls.Add(this.TBCPName);
            this.TabPageCustomPath.Controls.Add(this.LBCPCustomPaths);
            this.TabPageCustomPath.Controls.Add(this.label50);
            this.TabPageCustomPath.Controls.Add(this.NumUpDownDistance);
            this.TabPageCustomPath.Controls.Add(this.LBCPPoints);
            this.TabPageCustomPath.Controls.Add(this.ButtonCPSave);
            this.TabPageCustomPath.Controls.Add(this.ButtonCPRecord);
            this.TabPageCustomPath.Location = new System.Drawing.Point(4, 22);
            this.TabPageCustomPath.Name = "TabPageCustomPath";
            this.TabPageCustomPath.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageCustomPath.Size = new System.Drawing.Size(375, 539);
            this.TabPageCustomPath.TabIndex = 3;
            this.TabPageCustomPath.Text = "Custom Paths";
            this.TabPageCustomPath.UseVisualStyleBackColor = true;
            // 
            // ButtonCPAdd
            // 
            this.ButtonCPAdd.Location = new System.Drawing.Point(206, 451);
            this.ButtonCPAdd.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCPAdd.Name = "ButtonCPAdd";
            this.ButtonCPAdd.Size = new System.Drawing.Size(70, 34);
            this.ButtonCPAdd.TabIndex = 105;
            this.ButtonCPAdd.Text = "Add";
            this.ButtonCPAdd.UseVisualStyleBackColor = true;
            this.ButtonCPAdd.Click += new System.EventHandler(this.ButtonCPAdd_Click);
            // 
            // ButtonCPDelete
            // 
            this.ButtonCPDelete.Location = new System.Drawing.Point(280, 451);
            this.ButtonCPDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCPDelete.Name = "ButtonCPDelete";
            this.ButtonCPDelete.Size = new System.Drawing.Size(70, 34);
            this.ButtonCPDelete.TabIndex = 104;
            this.ButtonCPDelete.Text = "Delete";
            this.ButtonCPDelete.UseVisualStyleBackColor = true;
            // 
            // ComboCPContB
            // 
            this.ComboCPContB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCPContB.FormattingEnabled = true;
            this.ComboCPContB.Location = new System.Drawing.Point(94, 501);
            this.ComboCPContB.Margin = new System.Windows.Forms.Padding(2);
            this.ComboCPContB.Name = "ComboCPContB";
            this.ComboCPContB.Size = new System.Drawing.Size(108, 21);
            this.ComboCPContB.TabIndex = 103;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(16, 504);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(68, 13);
            this.label54.TabIndex = 102;
            this.label54.Text = "Continent B :";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(16, 479);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(68, 13);
            this.label53.TabIndex = 101;
            this.label53.Text = "Continent A :";
            // 
            // ComboCPContA
            // 
            this.ComboCPContA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCPContA.FormattingEnabled = true;
            this.ComboCPContA.Location = new System.Drawing.Point(94, 476);
            this.ComboCPContA.Margin = new System.Windows.Forms.Padding(2);
            this.ComboCPContA.Name = "ComboCPContA";
            this.ComboCPContA.Size = new System.Drawing.Size(108, 21);
            this.ComboCPContA.TabIndex = 100;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(16, 454);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(48, 13);
            this.label52.TabIndex = 99;
            this.label52.Text = "Faction :";
            // 
            // ComboCPFaction
            // 
            this.ComboCPFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCPFaction.FormattingEnabled = true;
            this.ComboCPFaction.Location = new System.Drawing.Point(94, 451);
            this.ComboCPFaction.Margin = new System.Windows.Forms.Padding(2);
            this.ComboCPFaction.Name = "ComboCPFaction";
            this.ComboCPFaction.Size = new System.Drawing.Size(108, 21);
            this.ComboCPFaction.TabIndex = 98;
            // 
            // CBCPUseMount
            // 
            this.CBCPUseMount.AutoSize = true;
            this.CBCPUseMount.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBCPUseMount.Location = new System.Drawing.Point(261, 434);
            this.CBCPUseMount.Name = "CBCPUseMount";
            this.CBCPUseMount.Size = new System.Drawing.Size(78, 17);
            this.CBCPUseMount.TabIndex = 97;
            this.CBCPUseMount.Text = "Use Mount";
            this.CBCPUseMount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CBCPUseMount.UseVisualStyleBackColor = true;
            // 
            // CBCPRoundTrip
            // 
            this.CBCPRoundTrip.AutoSize = true;
            this.CBCPRoundTrip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBCPRoundTrip.Location = new System.Drawing.Point(176, 434);
            this.CBCPRoundTrip.Name = "CBCPRoundTrip";
            this.CBCPRoundTrip.Size = new System.Drawing.Size(79, 17);
            this.CBCPRoundTrip.TabIndex = 96;
            this.CBCPRoundTrip.Text = "Round Trip";
            this.CBCPRoundTrip.UseVisualStyleBackColor = true;
            // 
            // CBCPForceFlying
            // 
            this.CBCPForceFlying.AutoSize = true;
            this.CBCPForceFlying.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBCPForceFlying.Location = new System.Drawing.Point(94, 434);
            this.CBCPForceFlying.Name = "CBCPForceFlying";
            this.CBCPForceFlying.Size = new System.Drawing.Size(83, 17);
            this.CBCPForceFlying.TabIndex = 95;
            this.CBCPForceFlying.Text = "Force Flying";
            this.CBCPForceFlying.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CBCPForceFlying.UseVisualStyleBackColor = true;
            // 
            // CBCPAllowFar
            // 
            this.CBCPAllowFar.AutoSize = true;
            this.CBCPAllowFar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CBCPAllowFar.Location = new System.Drawing.Point(19, 434);
            this.CBCPAllowFar.Name = "CBCPAllowFar";
            this.CBCPAllowFar.Size = new System.Drawing.Size(69, 17);
            this.CBCPAllowFar.TabIndex = 94;
            this.CBCPAllowFar.Text = "Allow Far";
            this.CBCPAllowFar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CBCPAllowFar.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(7, 409);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(41, 13);
            this.label51.TabIndex = 93;
            this.label51.Text = "Name :";
            // 
            // TBCPName
            // 
            this.TBCPName.Location = new System.Drawing.Point(56, 406);
            this.TBCPName.Margin = new System.Windows.Forms.Padding(2);
            this.TBCPName.Name = "TBCPName";
            this.TBCPName.Size = new System.Drawing.Size(295, 20);
            this.TBCPName.TabIndex = 92;
            // 
            // LBCPCustomPaths
            // 
            this.LBCPCustomPaths.FormattingEnabled = true;
            this.LBCPCustomPaths.Location = new System.Drawing.Point(10, 215);
            this.LBCPCustomPaths.Name = "LBCPCustomPaths";
            this.LBCPCustomPaths.Size = new System.Drawing.Size(341, 186);
            this.LBCPCustomPaths.TabIndex = 91;
            this.LBCPCustomPaths.SelectedIndexChanged += new System.EventHandler(this.LBCPCustomPaths_SelectedIndexChanged);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(206, 11);
            this.label50.MaximumSize = new System.Drawing.Size(80, 30);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(61, 26);
            this.label50.TabIndex = 90;
            this.label50.Text = "Separation distance";
            // 
            // NumUpDownDistance
            // 
            this.NumUpDownDistance.Location = new System.Drawing.Point(290, 13);
            this.NumUpDownDistance.Name = "NumUpDownDistance";
            this.NumUpDownDistance.Size = new System.Drawing.Size(61, 20);
            this.NumUpDownDistance.TabIndex = 89;
            this.NumUpDownDistance.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // LBCPPoints
            // 
            this.LBCPPoints.FormattingEnabled = true;
            this.LBCPPoints.Location = new System.Drawing.Point(10, 42);
            this.LBCPPoints.Name = "LBCPPoints";
            this.LBCPPoints.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LBCPPoints.Size = new System.Drawing.Size(341, 147);
            this.LBCPPoints.TabIndex = 88;
            this.LBCPPoints.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.LBCPPoints_PreviewKeyDown);
            // 
            // ButtonCPSave
            // 
            this.ButtonCPSave.Location = new System.Drawing.Point(280, 488);
            this.ButtonCPSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCPSave.Name = "ButtonCPSave";
            this.ButtonCPSave.Size = new System.Drawing.Size(71, 34);
            this.ButtonCPSave.TabIndex = 85;
            this.ButtonCPSave.Text = "Save";
            this.ButtonCPSave.UseVisualStyleBackColor = true;
            this.ButtonCPSave.Click += new System.EventHandler(this.ButtonCPSave_Click);
            // 
            // ButtonCPRecord
            // 
            this.ButtonCPRecord.Location = new System.Drawing.Point(10, 11);
            this.ButtonCPRecord.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCPRecord.Name = "ButtonCPRecord";
            this.ButtonCPRecord.Size = new System.Drawing.Size(191, 28);
            this.ButtonCPRecord.TabIndex = 83;
            this.ButtonCPRecord.Text = "Record Custom Path";
            this.ButtonCPRecord.UseVisualStyleBackColor = true;
            this.ButtonCPRecord.Click += new System.EventHandler(this.ButtonCPRecord_Click);
            // 
            // ButtonSaveAsXML
            // 
            this.ButtonSaveAsXML.Location = new System.Drawing.Point(335, 50);
            this.ButtonSaveAsXML.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveAsXML.Name = "ButtonSaveAsXML";
            this.ButtonSaveAsXML.Size = new System.Drawing.Size(56, 20);
            this.ButtonSaveAsXML.TabIndex = 3;
            this.ButtonSaveAsXML.Text = "Save As";
            this.ButtonSaveAsXML.UseVisualStyleBackColor = true;
            this.ButtonSaveAsXML.Click += new System.EventHandler(this.SaveSimpleProfileAs_Click);
            // 
            // ButtonNewXML
            // 
            this.ButtonNewXML.Location = new System.Drawing.Point(455, 50);
            this.ButtonNewXML.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonNewXML.Name = "ButtonNewXML";
            this.ButtonNewXML.Size = new System.Drawing.Size(56, 20);
            this.ButtonNewXML.TabIndex = 13;
            this.ButtonNewXML.Text = "New Quest";
            this.ButtonNewXML.UseVisualStyleBackColor = true;
            this.ButtonNewXML.Click += new System.EventHandler(this.ButtonNewXML_Click);
            // 
            // CBMainDisplayXML
            // 
            this.CBMainDisplayXML.AutoSize = true;
            this.CBMainDisplayXML.Location = new System.Drawing.Point(521, 53);
            this.CBMainDisplayXML.Margin = new System.Windows.Forms.Padding(2);
            this.CBMainDisplayXML.Name = "CBMainDisplayXML";
            this.CBMainDisplayXML.Size = new System.Drawing.Size(85, 17);
            this.CBMainDisplayXML.TabIndex = 82;
            this.CBMainDisplayXML.Text = "Display XML";
            this.CBMainDisplayXML.UseVisualStyleBackColor = true;
            this.CBMainDisplayXML.CheckedChanged += new System.EventHandler(this.CBMainDisplayXML_CheckedChanged);
            // 
            // ButtonSaveXML
            // 
            this.ButtonSaveXML.Location = new System.Drawing.Point(395, 50);
            this.ButtonSaveXML.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveXML.Name = "ButtonSaveXML";
            this.ButtonSaveXML.Size = new System.Drawing.Size(56, 20);
            this.ButtonSaveXML.TabIndex = 84;
            this.ButtonSaveXML.Text = "Save";
            this.ButtonSaveXML.UseVisualStyleBackColor = true;
            this.ButtonSaveXML.Click += new System.EventHandler(this.SaveSimpleProfile_Click);
            // 
            // TNBControlMenu
            // 
            this.TNBControlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TNBControlMenu.BackgroundImage")));
            this.TNBControlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TNBControlMenu.Location = new System.Drawing.Point(0, 0);
            this.TNBControlMenu.LogoImage = ((System.Drawing.Image)(resources.GetObject("TNBControlMenu.LogoImage")));
            this.TNBControlMenu.Margin = new System.Windows.Forms.Padding(2);
            this.TNBControlMenu.Name = "TNBControlMenu";
            this.TNBControlMenu.Size = new System.Drawing.Size(664, 40);
            this.TNBControlMenu.TabIndex = 85;
            this.TNBControlMenu.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TNBControlMenu.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.TNBControlMenu.TitleText = "TheNoobBot";
            // 
            // UcXmlRichTextBox1
            // 
            this.UcXmlRichTextBox1.Font = new System.Drawing.Font("Consolas", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcXmlRichTextBox1.Location = new System.Drawing.Point(667, 50);
            this.UcXmlRichTextBox1.Name = "UcXmlRichTextBox1";
            this.UcXmlRichTextBox1.Size = new System.Drawing.Size(567, 590);
            this.UcXmlRichTextBox1.TabIndex = 86;
            this.UcXmlRichTextBox1.Text = "";
            this.UcXmlRichTextBox1.Xml = "";
            // 
            // ButtonCPDeleteSelectedPoints
            // 
            this.ButtonCPDeleteSelectedPoints.Location = new System.Drawing.Point(10, 192);
            this.ButtonCPDeleteSelectedPoints.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCPDeleteSelectedPoints.Name = "ButtonCPDeleteSelectedPoints";
            this.ButtonCPDeleteSelectedPoints.Size = new System.Drawing.Size(125, 20);
            this.ButtonCPDeleteSelectedPoints.TabIndex = 106;
            this.ButtonCPDeleteSelectedPoints.Text = "Delete Selected Points";
            this.ButtonCPDeleteSelectedPoints.UseVisualStyleBackColor = true;
            this.ButtonCPDeleteSelectedPoints.Click += new System.EventHandler(this.ButtonCPDeleteSelectedPoints_Click);
            // 
            // SimpleProfileEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 645);
            this.ControlBox = false;
            this.Controls.Add(this.UcXmlRichTextBox1);
            this.Controls.Add(this.TNBControlMenu);
            this.Controls.Add(this.ButtonSaveXML);
            this.Controls.Add(this.CBMainDisplayXML);
            this.Controls.Add(this.ButtonNewXML);
            this.Controls.Add(this.PanelSimpleQuest);
            this.Controls.Add(this.ButtonSaveAsXML);
            this.Controls.Add(this.PanelNPC);
            this.Controls.Add(this.ButtonLoadXML);
            this.Controls.Add(this.TreeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimpleProfileEditor";
            this.Load += new System.EventHandler(this.SimpleProfileEditor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SimpleProfileEditor_KeyDown);
            this.ContextMenuStrip.ResumeLayout(false);
            this.PanelNPC.ResumeLayout(false);
            this.PanelNPC.PerformLayout();
            this.PanelSimpleQuest.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPageQuest.ResumeLayout(false);
            this.TabPageQuest.PerformLayout();
            this.ContextMenuStripNeedQuest.ResumeLayout(false);
            this.TabPageObjectives.ResumeLayout(false);
            this.TabPageObjectives.PerformLayout();
            this.PanelObjAll.ResumeLayout(false);
            this.PanelObjAll.PerformLayout();
            this.PanelObjTaxi.ResumeLayout(false);
            this.PanelObjTaxi.PerformLayout();
            this.TabPageBlackList.ResumeLayout(false);
            this.TabPageBlackList.PerformLayout();
            this.TabPageCustomPath.ResumeLayout(false);
            this.TabPageCustomPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal TreeView TreeView;
        internal Button ButtonLoadXML;
        internal Panel PanelNPC;
        internal Label Label3;
        internal TextBox TBNpcPosition;
        internal Label Label2;
        internal TextBox TBNpcId;
        internal Label Label1;
        internal TextBox TBNpcName;
        internal Button ButtonNewNPC;
        internal Panel PanelSimpleQuest;
        internal Label Label19;
        internal TextBox TBQuestTurnInID;
        internal CheckBox CheckBoxItemPickUp;
        internal Label Label18;
        internal TextBox TBQuestPickUpID;
        internal Label Label17;
        internal TextBox TBQuestMaxLvl;
        internal Label Label16;
        internal TextBox TBQuestMinLvl;
        internal ComboBox CBRaceMask;
        internal Label Label15;
        internal TextBox TBQuestLevel;
        internal Label Label14;
        internal Label Label13;
        internal ComboBox CBClassMask;
        internal Label Label11;
        internal TextBox TBQuestID;
        internal Label Label12;
        internal TextBox TBQuestQuestName;
        internal Label Label8;
        internal ComboBox CBObjType;
        internal Label Label7;
        internal Button ButtonSaveAsXML;
        internal TabControl TabControl1;
        internal TabPage TabPageQuest;
        internal TabPage TabPageObjectives;
        internal Label Label24;
        internal TextBox TBObjWaitMs;
        internal Label Label23;
        internal TextBox TBObjPosition;
        internal Label Label22;
        internal TextBox TBObjUseItemID;
        internal Label Label21;
        internal TextBox TBObjCollectCount;
        internal Label Label20;
        internal TextBox TBObjCollectItemID;
        internal Label Label10;
        internal TextBox TBObjEntry;
        internal Label Label9;
        internal TextBox TBObjCount;
        internal Label Label25;
        internal TextBox TBObjRange;
        internal Label Label26;
        internal TextBox TBObjUseSpellId;
        internal Button ButtonNewXML;
        internal Button ButtonSaveNPC;
        internal Button ButtonQuestNew;
        internal Button ButtonQuestSave;
        internal TextBox TBQuestNeedQuestCompId;
        internal Label Label27;
        internal Button ButtonObjectiveNew;
        internal Button ButtonObjectiveSave;
        internal Label LabelObjNPCIDorName;
        internal TextBox TBObjNPCId;
        internal Label Label30;
        internal TextBox TBObjQuestName;
        internal Label Label29;
        internal TextBox TBObjQuestID;
        internal CheckBox CBObjIgnoreQuestCompleted;
        internal CheckBox CBInternalObj;
        internal Label Label32;
        internal Label Label34;
        internal TextBox TBObjDestinationY;
        internal Label Label31;
        internal TextBox TBObjDestinationX;
        internal Label Label33;
        internal TextBox TBObjTaxiEntryId;
        internal ComboBox CBObjInternalQuestID;
        internal CheckBox CBObjKillMobPickUpItem;
        internal Button ButtonObjImportFromGame;
        internal Button ButtonOpenWowHead;
        internal Button ButtonQuestImportFromGame;
        internal CheckedListBox CLBQuestClassMask;
        internal CheckedListBox CLBQuestRaceMask;
        internal Button ButtonObjHotSpotsPlayerPos;
        internal Button ButtonQuestAlliance;
        internal Button ButtonQuestHorde;
        internal CheckBox CBObjCanPullUnitsInFight;
        internal Button ButtonObjImportEntry;
        internal Button ButtonObjImportGPS;
        internal Panel PanelObjTaxi;
        internal Panel PanelObjAll;
        internal Button ButtonObjGetXY;
        internal Label Label6;
        internal TextBox TBNpcContinentId;
        internal Label Label5;
        internal Label Label4;
        internal ComboBox CBNpcType;
        internal ComboBox CBNpcFaction;
        internal Button ButtonNpcImport;
        internal CheckBox CBQuestAutoAccepted;
        internal Label Label28;
        internal TextBox TBQuestWQ;
        internal CheckBox CBQuestWQ;
        internal CheckBox CBMainDisplayXML;
        internal TextBox TBObjGossipOption;
        internal Label Label35;
        internal new ContextMenuStrip ContextMenuStrip;
        internal ToolStripMenuItem InsertUpToolStripMenuItem;
        internal ToolStripMenuItem InsertDownToolStripMenuItem1;
        internal ToolStripMenuItem DeleteToolStripMenuItem;
        internal ContextMenuStrip ContextMenuStripNeedQuest;
        internal ToolStripMenuItem ToolStripMenuItemAddNeedQuestComp;
        internal TextBox TBObjFlightWaitMs;
        internal Label Label36;
        internal Button ButtonSaveXML;
        internal Button ButtonObjDumpIndex;
        internal Label Label37;
        internal TextBox TBObjInternalIndex;
        private nManager.Helpful.Forms.UserControls.TnbControlMenu tnbControlMenu1;
        internal Label label38;
        internal TextBox TBQuestNeedQuestNotCompId;
        internal Label label39;
        internal TextBox TBQuestAutoCompleteIDs;
        internal Label label40;
        internal TextBox TBQuestAutoAcceptIDs;
        internal CheckBox CBObjInternalQuestIdManual;
        private ListBox LBObjHotspots;
        internal CheckBox CBObjIsDead;
        internal Label label43;
        internal TextBox TBObjMessage;
        internal Label label42;
        internal ComboBox CBObjPressKeys;
        internal Label label41;
        internal TextBox TBObjCompletedScript;
        internal CheckBox CBObjForceTravelToQuestZone;
        internal CheckBox CBObjIgnoreNotSelectable;
        internal CheckBox CBObjAllowPlayerControlled;
        internal CheckBox CBObjIgnoreBlackList;
        private TabPage TabPageBlackList;
        private Label label44;
        private TextBox TBBlackListRadius;
        internal Button ButtonBlackListSave;
        internal TextBox TBBlackList;
        internal Button ButtonBlackListAdd;
        private nManager.Helpful.Forms.UserControls.TnbControlMenu TNBControlMenu;
        internal Button QuestCompletedButton;
        internal CheckBox CBObjIgnoreFight;
        internal Label label45;
        internal TextBox TBObjLuaMacro;
        internal CheckBox CBObjDeactivateMount;
        internal Button ButtonObjHotSpotsTargetPos;
        internal Button ButtonQuestImpotTurnInID;
        internal Button ButtonObjImportCursorItemID;
        internal CheckBox CBObjIgnoreItemNotUsable;
        internal CheckBox CBObjDismissPet;
        internal Label label49;
        internal TextBox TBObjExtraFloat;
        internal Label label48;
        internal TextBox TBObjExtraInt;
        internal Label label47;
        internal TextBox TBObjExtraPoint;
        internal Label label46;
        internal TextBox TBObjExtraString;
        private nManager.Helpful.Forms.UserControls.UCXmlRichTextBox UcXmlRichTextBox1;
        internal Button ButtonObjImportGPSExtraPoint;
        internal CheckBox CBObjIsBonusObjective;
        internal CheckBox CBObjIgnoreAllFight;
        internal Button ButtonObjHotSpotsPlayerPosRelative;
        private TabPage TabPageCustomPath;
        internal Button ButtonCPSave;
        internal Button ButtonCPRecord;
        private ListBox LBCPPoints;
        private ListBox LBCPCustomPaths;
        private Label label50;
        private NumericUpDown NumUpDownDistance;
        internal CheckBox CBCPUseMount;
        internal CheckBox CBCPRoundTrip;
        internal CheckBox CBCPForceFlying;
        internal CheckBox CBCPAllowFar;
        internal Label label51;
        internal TextBox TBCPName;
        internal ComboBox ComboCPContB;
        internal Label label54;
        internal Label label53;
        internal ComboBox ComboCPContA;
        internal Label label52;
        internal ComboBox ComboCPFaction;
        internal Button ButtonCPAdd;
        internal Button ButtonCPDelete;
        internal Button ButtonCPDeleteSelectedPoints;
    }
}