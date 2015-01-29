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
            this.checkedListBox_Layer = new System.Windows.Forms.CheckedListBox();
            this.buttonSelec = new System.Windows.Forms.Button();
            this.B_ReloadLayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Combobox_Layer
            // 
            this.Combobox_Layer.FormattingEnabled = true;
            this.Combobox_Layer.Location = new System.Drawing.Point(241, 35);
            this.Combobox_Layer.Name = "Combobox_Layer";
            this.Combobox_Layer.Size = new System.Drawing.Size(121, 21);
            this.Combobox_Layer.TabIndex = 1;
            this.Combobox_Layer.SelectionChangeCommitted += new System.EventHandler(this.LayerC_SelectionChangeCommitted);
            // 
            // ButtonM
            // 
            this.ButtonM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonM.Location = new System.Drawing.Point(343, 83);
            this.ButtonM.Name = "ButtonM";
            this.ButtonM.Size = new System.Drawing.Size(75, 23);
            this.ButtonM.TabIndex = 2;
            this.ButtonM.Text = "减去";
            this.ButtonM.UseVisualStyleBackColor = true;
            // 
            // ButtonV
            // 
            this.ButtonV.Location = new System.Drawing.Point(241, 119);
            this.ButtonV.Name = "ButtonV";
            this.ButtonV.Size = new System.Drawing.Size(75, 23);
            this.ButtonV.TabIndex = 3;
            this.ButtonV.Text = "确认";
            this.ButtonV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Layer";
            // 
            // formule
            // 
            this.formule.Location = new System.Drawing.Point(241, 175);
            this.formule.Multiline = true;
            this.formule.Name = "formule";
            this.formule.Size = new System.Drawing.Size(121, 114);
            this.formule.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "计算公式及结果";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(28, 64);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(168, 97);
            this.treeView1.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.B_ReloadLayer);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSelec);
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox_Layer);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.Combobox_Layer);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonM);
            this.splitContainer1.Panel1.Controls.Add(this.formule);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonV);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(742, 481);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 8;
            // 
            // checkedListBox_Layer
            // 
            this.checkedListBox_Layer.FormattingEnabled = true;
            this.checkedListBox_Layer.Location = new System.Drawing.Point(28, 175);
            this.checkedListBox_Layer.Name = "checkedListBox_Layer";
            this.checkedListBox_Layer.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_Layer.TabIndex = 8;
            this.checkedListBox_Layer.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Layer_ItemCheck);
            // 
            // buttonSelec
            // 
            this.buttonSelec.Location = new System.Drawing.Point(241, 83);
            this.buttonSelec.Name = "buttonSelec";
            this.buttonSelec.Size = new System.Drawing.Size(75, 23);
            this.buttonSelec.TabIndex = 9;
            this.buttonSelec.Text = "选择";
            this.buttonSelec.UseVisualStyleBackColor = true;
            this.buttonSelec.Click += new System.EventHandler(this.buttonSelec_Click);
            // 
            // B_ReloadLayer
            // 
            this.B_ReloadLayer.Location = new System.Drawing.Point(28, 276);
            this.B_ReloadLayer.Name = "B_ReloadLayer";
            this.B_ReloadLayer.Size = new System.Drawing.Size(22, 23);
            this.B_ReloadLayer.TabIndex = 10;
            this.B_ReloadLayer.Text = "button1";
            this.B_ReloadLayer.UseVisualStyleBackColor = true;
            this.B_ReloadLayer.Click += new System.EventHandler(this.B_ReloadLayer_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLine;
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
    }
}