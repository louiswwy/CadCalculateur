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
            //this.LineList = new System.Windows.Forms.ListBox();
            this.LayerC = new System.Windows.Forms.ComboBox();
            this.ButtonM = new System.Windows.Forms.Button();
            this.ButtonV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.formule = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // listLine
            // 
            /*this.LineList.FormattingEnabled = true;
            this.LineList.Location = new System.Drawing.Point(12, 12);
            this.LineList.Name = "listLine";
            this.LineList.Size = new System.Drawing.Size(168, 43);
            this.LineList.TabIndex = 0;*/
            // 
            // LayerC
            // 
            this.LayerC.FormattingEnabled = true;
            this.LayerC.Location = new System.Drawing.Point(225, 32);
            this.LayerC.Name = "LayerC";
            this.LayerC.Size = new System.Drawing.Size(121, 21);
            this.LayerC.TabIndex = 1;
            this.LayerC.SelectionChangeCommitted += new System.EventHandler(this.LayerC_SelectionChangeCommitted);
            // 
            // ButtonM
            // 
            this.ButtonM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonM.Location = new System.Drawing.Point(225, 76);
            this.ButtonM.Name = "ButtonM";
            this.ButtonM.Size = new System.Drawing.Size(75, 23);
            this.ButtonM.TabIndex = 2;
            this.ButtonM.Text = "减去";
            this.ButtonM.UseVisualStyleBackColor = true;
            // 
            // ButtonV
            // 
            this.ButtonV.Location = new System.Drawing.Point(225, 116);
            this.ButtonV.Name = "ButtonV";
            this.ButtonV.Size = new System.Drawing.Size(75, 23);
            this.ButtonV.TabIndex = 3;
            this.ButtonV.Text = "确认";
            this.ButtonV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Layer";
            // 
            // formule
            // 
            this.formule.Location = new System.Drawing.Point(225, 172);
            this.formule.Multiline = true;
            this.formule.Name = "formule";
            this.formule.Size = new System.Drawing.Size(121, 114);
            this.formule.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "计算公式及结果";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 61);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(168, 97);
            this.treeView1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 298);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonV);
            this.Controls.Add(this.ButtonM);
            this.Controls.Add(this.LayerC);
            //this.Controls.Add(this.LineList);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listLine;
        private System.Windows.Forms.ComboBox LayerC;
        private System.Windows.Forms.Button ButtonM;
        private System.Windows.Forms.Button ButtonV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox formule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
    }
}