namespace Calculers
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
            this.Button_End = new System.Windows.Forms.Button();
            this.Button_In = new System.Windows.Forms.Button();
            this.B_DrawLine = new System.Windows.Forms.Button();
            this.B_ReloadLayer = new System.Windows.Forms.Button();
            this.buttonSelec = new System.Windows.Forms.Button();
            this.checkedListBox_Layer = new System.Windows.Forms.CheckedListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Line_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineStartPosition_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineStartPosition_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineEndPosition_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineEndPosition_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLine_Tube = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLine_TD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLine_Tv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumLine_TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Combobox_Layer
            // 
            this.Combobox_Layer.FormattingEnabled = true;
            this.Combobox_Layer.Location = new System.Drawing.Point(100, 25);
            this.Combobox_Layer.Name = "Combobox_Layer";
            this.Combobox_Layer.Size = new System.Drawing.Size(100, 21);
            this.Combobox_Layer.TabIndex = 1;
            this.Combobox_Layer.SelectionChangeCommitted += new System.EventHandler(this.LayerC_SelectionChangeCommitted);
            // 
            // ButtonM
            // 
            this.ButtonM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonM.Location = new System.Drawing.Point(3, 207);
            this.ButtonM.Name = "ButtonM";
            this.ButtonM.Size = new System.Drawing.Size(75, 23);
            this.ButtonM.TabIndex = 2;
            this.ButtonM.Text = "减去";
            this.ButtonM.UseVisualStyleBackColor = true;
            this.ButtonM.Click += new System.EventHandler(this.ButtonM_Click);
            // 
            // ButtonV
            // 
            this.ButtonV.Location = new System.Drawing.Point(3, 178);
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
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Layer";
            // 
            // formule
            // 
            this.formule.Location = new System.Drawing.Point(100, 162);
            this.formule.Multiline = true;
            this.formule.Name = "formule";
            this.formule.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.formule.Size = new System.Drawing.Size(100, 239);
            this.formule.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "计算公式及结果";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 9);
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
            this.splitContainer1.Panel1.Controls.Add(this.Button_End);
            this.splitContainer1.Panel1.Controls.Add(this.Button_In);
            this.splitContainer1.Panel1.Controls.Add(this.B_DrawLine);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.B_ReloadLayer);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSelec);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox_Layer);
            this.splitContainer1.Panel1.Controls.Add(this.Combobox_Layer);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonM);
            this.splitContainer1.Panel1.Controls.Add(this.formule);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonV);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(742, 481);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 8;
            // 
            // Button_End
            // 
            this.Button_End.Location = new System.Drawing.Point(58, 112);
            this.Button_End.Name = "Button_End";
            this.Button_End.Size = new System.Drawing.Size(20, 23);
            this.Button_End.TabIndex = 13;
            this.Button_End.Text = "button2";
            this.Button_End.UseVisualStyleBackColor = true;
            // 
            // Button_In
            // 
            this.Button_In.Location = new System.Drawing.Point(31, 112);
            this.Button_In.Name = "Button_In";
            this.Button_In.Size = new System.Drawing.Size(20, 23);
            this.Button_In.TabIndex = 12;
            this.Button_In.Text = "button1";
            this.Button_In.UseVisualStyleBackColor = true;
            this.Button_In.Click += new System.EventHandler(this.Button_In_Click);
            // 
            // B_DrawLine
            // 
            this.B_DrawLine.Location = new System.Drawing.Point(3, 236);
            this.B_DrawLine.Name = "B_DrawLine";
            this.B_DrawLine.Size = new System.Drawing.Size(75, 23);
            this.B_DrawLine.TabIndex = 11;
            this.B_DrawLine.Text = "button1";
            this.B_DrawLine.UseVisualStyleBackColor = true;
            this.B_DrawLine.Click += new System.EventHandler(this.B_DrawLine_Click);
            // 
            // B_ReloadLayer
            // 
            this.B_ReloadLayer.Location = new System.Drawing.Point(3, 112);
            this.B_ReloadLayer.Name = "B_ReloadLayer";
            this.B_ReloadLayer.Size = new System.Drawing.Size(22, 23);
            this.B_ReloadLayer.TabIndex = 10;
            this.B_ReloadLayer.Text = "button1";
            this.B_ReloadLayer.UseVisualStyleBackColor = true;
            this.B_ReloadLayer.Click += new System.EventHandler(this.B_ReloadLayer_Click);
            // 
            // buttonSelec
            // 
            this.buttonSelec.Location = new System.Drawing.Point(3, 149);
            this.buttonSelec.Name = "buttonSelec";
            this.buttonSelec.Size = new System.Drawing.Size(75, 23);
            this.buttonSelec.TabIndex = 9;
            this.buttonSelec.Text = "选择";
            this.buttonSelec.UseVisualStyleBackColor = true;
            this.buttonSelec.Click += new System.EventHandler(this.buttonSelec_Click);
            // 
            // checkedListBox_Layer
            // 
            this.checkedListBox_Layer.FormattingEnabled = true;
            this.checkedListBox_Layer.Location = new System.Drawing.Point(100, 49);
            this.checkedListBox_Layer.Name = "checkedListBox_Layer";
            this.checkedListBox_Layer.Size = new System.Drawing.Size(100, 94);
            this.checkedListBox_Layer.TabIndex = 8;
            this.checkedListBox_Layer.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Layer_ItemCheck);
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
            this.NumLine_Tube,
            this.NumLine_TD,
            this.NumLine_Tv,
            this.NumLine_TP});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 477);
            this.dataGridView1.TabIndex = 0;
            // 
            // Line_ID
            // 
            this.Line_ID.HeaderText = "ID";
            this.Line_ID.Name = "Line_ID";
            // 
            // LineStartPosition_X
            // 
            this.LineStartPosition_X.HeaderText = "Start_position_X";
            this.LineStartPosition_X.Name = "LineStartPosition_X";
            // 
            // LineStartPosition_Y
            // 
            this.LineStartPosition_Y.HeaderText = "Start_position_Y";
            this.LineStartPosition_Y.Name = "LineStartPosition_Y";
            // 
            // LineEndPosition_X
            // 
            this.LineEndPosition_X.HeaderText = "End_Position_X";
            this.LineEndPosition_X.Name = "LineEndPosition_X";
            // 
            // LineEndPosition_Y
            // 
            this.LineEndPosition_Y.HeaderText = "End_Position_Y";
            this.LineEndPosition_Y.Name = "LineEndPosition_Y";
            // 
            // NumLine_Tube
            // 
            this.NumLine_Tube.HeaderText = "Num_Tube";
            this.NumLine_Tube.Name = "NumLine_Tube";
            this.NumLine_Tube.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NumLine_Tube.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 481);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Button B_DrawLine;
        private System.Windows.Forms.Button Button_End;
        private System.Windows.Forms.Button Button_In;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineStartPosition_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineStartPosition_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineEndPosition_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineEndPosition_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLine_Tube;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLine_TD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLine_Tv;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumLine_TP;
    }
}