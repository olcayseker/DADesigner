﻿namespace DADesignerFormsGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cbAvailabilityState = new System.Windows.Forms.CheckBox();
            this.cbPerformanceState = new System.Windows.Forms.CheckBox();
            this.cbSecurityState = new System.Windows.Forms.CheckBox();
            this.cbConfigurationState = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeviewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tsbShowXML = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.treeviewContextMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertyGrid1);
            this.splitContainer1.Size = new System.Drawing.Size(907, 476);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbAvailabilityState, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPerformanceState, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbSecurityState, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbConfigurationState, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 329);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 147);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "WorstOf",
            "BestOf"});
            this.comboBox4.Location = new System.Drawing.Point(187, 111);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(105, 21);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.Text = "WorstOf";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "WorstOf",
            "BestOf"});
            this.comboBox3.Location = new System.Drawing.Point(187, 75);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(105, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "WorstOf";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "WorstOf",
            "BestOf"});
            this.comboBox2.Location = new System.Drawing.Point(187, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Text = "WorstOf";
            // 
            // cbAvailabilityState
            // 
            this.cbAvailabilityState.AutoSize = true;
            this.cbAvailabilityState.Checked = true;
            this.cbAvailabilityState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAvailabilityState.Location = new System.Drawing.Point(3, 3);
            this.cbAvailabilityState.Name = "cbAvailabilityState";
            this.cbAvailabilityState.Size = new System.Drawing.Size(100, 17);
            this.cbAvailabilityState.TabIndex = 0;
            this.cbAvailabilityState.Tag = "AvailabilityState";
            this.cbAvailabilityState.Text = "AvailabilityState";
            this.cbAvailabilityState.UseVisualStyleBackColor = true;
            // 
            // cbPerformanceState
            // 
            this.cbPerformanceState.AutoSize = true;
            this.cbPerformanceState.Checked = true;
            this.cbPerformanceState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPerformanceState.Location = new System.Drawing.Point(3, 39);
            this.cbPerformanceState.Name = "cbPerformanceState";
            this.cbPerformanceState.Size = new System.Drawing.Size(111, 17);
            this.cbPerformanceState.TabIndex = 1;
            this.cbPerformanceState.Tag = "PerformanceState";
            this.cbPerformanceState.Text = "PerformanceState";
            this.cbPerformanceState.UseVisualStyleBackColor = true;
            // 
            // cbSecurityState
            // 
            this.cbSecurityState.AutoSize = true;
            this.cbSecurityState.Checked = true;
            this.cbSecurityState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSecurityState.Location = new System.Drawing.Point(3, 75);
            this.cbSecurityState.Name = "cbSecurityState";
            this.cbSecurityState.Size = new System.Drawing.Size(89, 17);
            this.cbSecurityState.TabIndex = 2;
            this.cbSecurityState.Tag = "SecurityState";
            this.cbSecurityState.Text = "SecurityState";
            this.cbSecurityState.UseVisualStyleBackColor = true;
            // 
            // cbConfigurationState
            // 
            this.cbConfigurationState.AutoSize = true;
            this.cbConfigurationState.Checked = true;
            this.cbConfigurationState.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbConfigurationState.Location = new System.Drawing.Point(3, 111);
            this.cbConfigurationState.Name = "cbConfigurationState";
            this.cbConfigurationState.Size = new System.Drawing.Size(113, 17);
            this.cbConfigurationState.TabIndex = 3;
            this.cbConfigurationState.Tag = "ConfigurationState";
            this.cbConfigurationState.Text = "ConfigurationState";
            this.cbConfigurationState.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "WorstOf",
            "BestOf"});
            this.comboBox1.Location = new System.Drawing.Point(187, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "WorstOf";
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.treeviewContextMenu;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(369, 476);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
            // 
            // treeviewContextMenu
            // 
            this.treeviewContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNodeToolStripMenuItem});
            this.treeviewContextMenu.Name = "treeviewContextMenu";
            this.treeviewContextMenu.Size = new System.Drawing.Size(129, 26);
            // 
            // addNodeToolStripMenuItem
            // 
            this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            this.addNodeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addNodeToolStripMenuItem.Text = "Add Node";
            this.addNodeToolStripMenuItem.Click += new System.EventHandler(this.addNodeToolStripMenuItem_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(534, 476);
            this.propertyGrid1.TabIndex = 0;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton,
            this.tsbShowXML});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(907, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // tsbShowXML
            // 
            this.tsbShowXML.Image = ((System.Drawing.Image)(resources.GetObject("tsbShowXML.Image")));
            this.tsbShowXML.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShowXML.Name = "tsbShowXML";
            this.tsbShowXML.Size = new System.Drawing.Size(83, 22);
            this.tsbShowXML.Text = "Show XML";
            this.tsbShowXML.Click += new System.EventHandler(this.tsbShowXML_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 501);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 523);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.treeviewContextMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip treeviewContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox cbAvailabilityState;
        private System.Windows.Forms.CheckBox cbPerformanceState;
        private System.Windows.Forms.CheckBox cbSecurityState;
        private System.Windows.Forms.CheckBox cbConfigurationState;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStripButton tsbShowXML;
    }
}

