﻿namespace Calculers
{
    partial class MainForm
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
            this.Combobox_Layer = new System.Windows.Forms.ComboBox();
            this.ButtonM = new System.Windows.Forms.Button();
            this.ButtonV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.formule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_ReloadLayer = new System.Windows.Forms.Button();
            this.checkedListBox_Layer = new System.Windows.Forms.CheckedListBox();
            this.groupBox_1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Num_Etage = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.BA_DrawLine = new System.Windows.Forms.Button();
            this.BA_Port = new System.Windows.Forms.Button();
            this.T_etage = new System.Windows.Forms.TextBox();
            this.CheckBox_TD = new System.Windows.Forms.CheckBox();
            this.CheckBox_TP = new System.Windows.Forms.CheckBox();
            this.BA_ChuanLou = new System.Windows.Forms.Button();
            this.CheckBox_TV = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BA_RuKou = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Button_End = new System.Windows.Forms.Button();
            this.Button_In = new System.Windows.Forms.Button();
            this.buttonSelec = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Line_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineStartPosition_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineStartPosition_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineEndPosition_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineEndPosition_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLine_Tube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLine_TD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLine_Tv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLine_TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Valide_M2 = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Etage)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Combobox_Layer
            // 
            this.Combobox_Layer.FormattingEnabled = true;
            this.Combobox_Layer.Location = new System.Drawing.Point(9, 32);
            this.Combobox_Layer.Name = "Combobox_Layer";
            this.Combobox_Layer.Size = new System.Drawing.Size(121, 21);
            this.Combobox_Layer.TabIndex = 1;
            this.Combobox_Layer.SelectionChangeCommitted += new System.EventHandler(this.Combobox_Layer_SelectionChangeCommitted);
            // 
            // ButtonM
            // 
            this.ButtonM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonM.Location = new System.Drawing.Point(13, 205);
            this.ButtonM.Name = "ButtonM";
            this.ButtonM.Size = new System.Drawing.Size(75, 23);
            this.ButtonM.TabIndex = 2;
            this.ButtonM.Text = "减去?";
            this.ButtonM.UseVisualStyleBackColor = true;
            this.ButtonM.Click += new System.EventHandler(this.ButtonM_Click);
            // 
            // ButtonV
            // 
            this.ButtonV.Location = new System.Drawing.Point(13, 176);
            this.ButtonV.Name = "ButtonV";
            this.ButtonV.Size = new System.Drawing.Size(75, 23);
            this.ButtonV.TabIndex = 3;
            this.ButtonV.Text = "确认";
            this.ButtonV.UseVisualStyleBackColor = true;
            this.ButtonV.Click += new System.EventHandler(this.ButtonV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Layer";
            // 
            // formule
            // 
            this.formule.Location = new System.Drawing.Point(117, 43);
            this.formule.Multiline = true;
            this.formule.Name = "formule";
            this.formule.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.formule.Size = new System.Drawing.Size(230, 239);
            this.formule.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "计算公式及结果";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 15);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(75, 97);
            this.treeView1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(742, 481);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 457);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_ReloadLayer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Combobox_Layer);
            this.groupBox1.Controls.Add(this.checkedListBox_Layer);
            this.groupBox1.Location = new System.Drawing.Point(6, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图层";
            // 
            // B_ReloadLayer
            // 
            this.B_ReloadLayer.Location = new System.Drawing.Point(9, 156);
            this.B_ReloadLayer.Name = "B_ReloadLayer";
            this.B_ReloadLayer.Size = new System.Drawing.Size(22, 23);
            this.B_ReloadLayer.TabIndex = 10;
            this.B_ReloadLayer.Text = "button1";
            this.B_ReloadLayer.UseVisualStyleBackColor = true;
            this.B_ReloadLayer.Click += new System.EventHandler(this.B_ReloadLayer_Click);
            // 
            // checkedListBox_Layer
            // 
            this.checkedListBox_Layer.FormattingEnabled = true;
            this.checkedListBox_Layer.Location = new System.Drawing.Point(9, 56);
            this.checkedListBox_Layer.Name = "checkedListBox_Layer";
            this.checkedListBox_Layer.Size = new System.Drawing.Size(121, 94);
            this.checkedListBox_Layer.TabIndex = 8;
            this.checkedListBox_Layer.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Layer_ItemCheck);
            // 
            // groupBox_1
            // 
            this.groupBox_1.Controls.Add(this.Button_Valide_M2);
            this.groupBox_1.Controls.Add(this.label6);
            this.groupBox_1.Controls.Add(this.Num_Etage);
            this.groupBox_1.Controls.Add(this.label5);
            this.groupBox_1.Controls.Add(this.BA_DrawLine);
            this.groupBox_1.Controls.Add(this.BA_Port);
            this.groupBox_1.Controls.Add(this.T_etage);
            this.groupBox_1.Controls.Add(this.CheckBox_TD);
            this.groupBox_1.Controls.Add(this.CheckBox_TP);
            this.groupBox_1.Controls.Add(this.BA_ChuanLou);
            this.groupBox_1.Controls.Add(this.CheckBox_TV);
            this.groupBox_1.Controls.Add(this.label4);
            this.groupBox_1.Controls.Add(this.BA_RuKou);
            this.groupBox_1.Controls.Add(this.label3);
            this.groupBox_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox_1.Location = new System.Drawing.Point(6, 6);
            this.groupBox_1.Name = "groupBox_1";
            this.groupBox_1.Size = new System.Drawing.Size(379, 191);
            this.groupBox_1.TabIndex = 14;
            this.groupBox_1.TabStop = false;
            this.groupBox_1.Text = "画图";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "现在的楼层";
            // 
            // Num_Etage
            // 
            this.Num_Etage.Location = new System.Drawing.Point(135, 20);
            this.Num_Etage.Name = "Num_Etage";
            this.Num_Etage.Size = new System.Drawing.Size(61, 20);
            this.Num_Etage.TabIndex = 22;
            this.Num_Etage.ValueChanged += new System.EventHandler(this.Num_Etage_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "楼层";
            // 
            // BA_DrawLine
            // 
            this.BA_DrawLine.Enabled = false;
            this.BA_DrawLine.Location = new System.Drawing.Point(9, 101);
            this.BA_DrawLine.Name = "BA_DrawLine";
            this.BA_DrawLine.Size = new System.Drawing.Size(61, 32);
            this.BA_DrawLine.TabIndex = 11;
            this.BA_DrawLine.Text = "画线(?)";
            this.BA_DrawLine.UseVisualStyleBackColor = true;
            this.BA_DrawLine.Click += new System.EventHandler(this.BA_DrawLine_Click);
            // 
            // BA_Port
            // 
            this.BA_Port.Location = new System.Drawing.Point(135, 101);
            this.BA_Port.Name = "BA_Port";
            this.BA_Port.Size = new System.Drawing.Size(61, 30);
            this.BA_Port.TabIndex = 19;
            this.BA_Port.Text = "端口";
            this.BA_Port.UseVisualStyleBackColor = true;
            this.BA_Port.Click += new System.EventHandler(this.BA_Port_Click);
            // 
            // T_etage
            // 
            this.T_etage.Location = new System.Drawing.Point(9, 19);
            this.T_etage.Name = "T_etage";
            this.T_etage.Size = new System.Drawing.Size(61, 20);
            this.T_etage.TabIndex = 20;
            this.T_etage.TextChanged += new System.EventHandler(this.T_etage_TextChanged);
            // 
            // CheckBox_TD
            // 
            this.CheckBox_TD.AutoSize = true;
            this.CheckBox_TD.Location = new System.Drawing.Point(204, 147);
            this.CheckBox_TD.Name = "CheckBox_TD";
            this.CheckBox_TD.Size = new System.Drawing.Size(65, 17);
            this.CheckBox_TD.TabIndex = 18;
            this.CheckBox_TD.Text = "TD端口";
            this.CheckBox_TD.UseVisualStyleBackColor = true;
            this.CheckBox_TD.CheckedChanged += new System.EventHandler(this.CheckBox_TD_CheckedChanged);
            // 
            // CheckBox_TP
            // 
            this.CheckBox_TP.AutoSize = true;
            this.CheckBox_TP.Location = new System.Drawing.Point(205, 124);
            this.CheckBox_TP.Name = "CheckBox_TP";
            this.CheckBox_TP.Size = new System.Drawing.Size(64, 17);
            this.CheckBox_TP.TabIndex = 17;
            this.CheckBox_TP.Text = "TP端口";
            this.CheckBox_TP.UseVisualStyleBackColor = true;
            this.CheckBox_TP.CheckedChanged += new System.EventHandler(this.CheckBox_TP_CheckedChanged);
            // 
            // BA_ChuanLou
            // 
            this.BA_ChuanLou.Enabled = false;
            this.BA_ChuanLou.Location = new System.Drawing.Point(135, 52);
            this.BA_ChuanLou.Name = "BA_ChuanLou";
            this.BA_ChuanLou.Size = new System.Drawing.Size(61, 30);
            this.BA_ChuanLou.TabIndex = 6;
            this.BA_ChuanLou.Text = "穿墙洞";
            this.BA_ChuanLou.UseVisualStyleBackColor = true;
            this.BA_ChuanLou.Click += new System.EventHandler(this.BA_ChuanLou_Click);
            // 
            // CheckBox_TV
            // 
            this.CheckBox_TV.AutoSize = true;
            this.CheckBox_TV.Location = new System.Drawing.Point(205, 101);
            this.CheckBox_TV.Name = "CheckBox_TV";
            this.CheckBox_TV.Size = new System.Drawing.Size(64, 17);
            this.CheckBox_TV.TabIndex = 16;
            this.CheckBox_TV.Text = "TV端口";
            this.CheckBox_TV.UseVisualStyleBackColor = true;
            this.CheckBox_TV.CheckedChanged += new System.EventHandler(this.CheckBox_TV_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "穿楼洞:";
            // 
            // BA_RuKou
            // 
            this.BA_RuKou.Location = new System.Drawing.Point(9, 52);
            this.BA_RuKou.Name = "BA_RuKou";
            this.BA_RuKou.Size = new System.Drawing.Size(61, 32);
            this.BA_RuKou.TabIndex = 5;
            this.BA_RuKou.Text = "入口";
            this.BA_RuKou.UseVisualStyleBackColor = true;
            this.BA_RuKou.Click += new System.EventHandler(this.BA_RuKou_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "入口:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Controls.Add(this.formule);
            this.tabPage3.Controls.Add(this.Button_End);
            this.tabPage3.Controls.Add(this.ButtonV);
            this.tabPage3.Controls.Add(this.Button_In);
            this.tabPage3.Controls.Add(this.ButtonM);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.buttonSelec);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(391, 431);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Button_End
            // 
            this.Button_End.Location = new System.Drawing.Point(68, 118);
            this.Button_End.Name = "Button_End";
            this.Button_End.Size = new System.Drawing.Size(20, 23);
            this.Button_End.TabIndex = 13;
            this.Button_End.Text = "?";
            this.Button_End.UseVisualStyleBackColor = true;
            // 
            // Button_In
            // 
            this.Button_In.Location = new System.Drawing.Point(41, 118);
            this.Button_In.Name = "Button_In";
            this.Button_In.Size = new System.Drawing.Size(20, 23);
            this.Button_In.TabIndex = 12;
            this.Button_In.Text = "?";
            this.Button_In.UseVisualStyleBackColor = true;
            this.Button_In.Click += new System.EventHandler(this.Button_In_Click);
            // 
            // buttonSelec
            // 
            this.buttonSelec.Location = new System.Drawing.Point(13, 147);
            this.buttonSelec.Name = "buttonSelec";
            this.buttonSelec.Size = new System.Drawing.Size(75, 23);
            this.buttonSelec.TabIndex = 9;
            this.buttonSelec.Text = "选择";
            this.buttonSelec.UseVisualStyleBackColor = true;
            this.buttonSelec.Click += new System.EventHandler(this.buttonSelec_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(311, 477);
            this.splitContainer2.SplitterDistance = 92;
            this.splitContainer2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Line_ID,
            this.LineStartPosition_X,
            this.LineStartPosition_Y,
            this.LineEndPosition_X,
            this.LineEndPosition_Y,
            this.LineLength,
            this.NumLine_Tube,
            this.NumLine_TD,
            this.NumLine_Tv,
            this.NumLine_TP});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(311, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            // 
            // Line_ID
            // 
            this.Line_ID.HeaderText = "ID";
            this.Line_ID.Name = "Line_ID";
            this.Line_ID.ReadOnly = true;
            // 
            // LineStartPosition_X
            // 
            this.LineStartPosition_X.HeaderText = "Start_position_X";
            this.LineStartPosition_X.Name = "LineStartPosition_X";
            this.LineStartPosition_X.ReadOnly = true;
            // 
            // LineStartPosition_Y
            // 
            this.LineStartPosition_Y.HeaderText = "Start_position_Y";
            this.LineStartPosition_Y.Name = "LineStartPosition_Y";
            this.LineStartPosition_Y.ReadOnly = true;
            // 
            // LineEndPosition_X
            // 
            this.LineEndPosition_X.HeaderText = "End_Position_X";
            this.LineEndPosition_X.Name = "LineEndPosition_X";
            this.LineEndPosition_X.ReadOnly = true;
            // 
            // LineEndPosition_Y
            // 
            this.LineEndPosition_Y.HeaderText = "End_Position_Y";
            this.LineEndPosition_Y.Name = "LineEndPosition_Y";
            this.LineEndPosition_Y.ReadOnly = true;
            // 
            // LineLength
            // 
            this.LineLength.HeaderText = "Length";
            this.LineLength.Name = "LineLength";
            this.LineLength.ReadOnly = true;
            // 
            // NumLine_Tube
            // 
            this.NumLine_Tube.HeaderText = "Num_Tube";
            this.NumLine_Tube.Name = "NumLine_Tube";
            this.NumLine_Tube.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NumLine_TD
            // 
            this.NumLine_TD.HeaderText = "Num_TD";
            this.NumLine_TD.Name = "NumLine_TD";
            // 
            // NumLine_Tv
            // 
            this.NumLine_Tv.HeaderText = "Num_TV";
            this.NumLine_Tv.Name = "NumLine_Tv";
            // 
            // NumLine_TP
            // 
            this.NumLine_TP.HeaderText = "Num_TP";
            this.NumLine_TP.Name = "NumLine_TP";
            // 
            // Button_Valide_M2
            // 
            this.Button_Valide_M2.Location = new System.Drawing.Point(9, 147);
            this.Button_Valide_M2.Name = "Button_Valide_M2";
            this.Button_Valide_M2.Size = new System.Drawing.Size(61, 30);
            this.Button_Valide_M2.TabIndex = 24;
            this.Button_Valide_M2.Text = "确认";
            this.Button_Valide_M2.UseVisualStyleBackColor = true;
            this.Button_Valide_M2.Click += new System.EventHandler(this.Button_Valide_M2_Click);
            // 
            // treeView2
            // 
            this.treeView2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.treeView2.Location = new System.Drawing.Point(164, 203);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(191, 150);
            this.treeView2.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 481);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_1.ResumeLayout(false);
            this.groupBox_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Etage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.ListBox listLine;
        private System.Windows.Forms.ComboBox Combobox_Layer;
        private System.Windows.Forms.Button ButtonM;
        private System.Windows.Forms.Button ButtonV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.CheckedListBox checkedListBox_Layer;
        private System.Windows.Forms.Button buttonSelec;
        private System.Windows.Forms.Button B_ReloadLayer;
        private System.Windows.Forms.Button BA_DrawLine;
        private System.Windows.Forms.Button Button_End;
        private System.Windows.Forms.Button Button_In;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BA_ChuanLou;
        private System.Windows.Forms.Button BA_RuKou;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox CheckBox_TD;
        private System.Windows.Forms.CheckBox CheckBox_TP;
        private System.Windows.Forms.CheckBox CheckBox_TV;
        private System.Windows.Forms.Button BA_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineStartPosition_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineStartPosition_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineEndPosition_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineEndPosition_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLine_Tube;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLine_TD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLine_Tv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLine_TP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox T_etage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Num_Etage;
        private System.Windows.Forms.Button Button_Valide_M2;
        private System.Windows.Forms.TreeView treeView2;
    }
}