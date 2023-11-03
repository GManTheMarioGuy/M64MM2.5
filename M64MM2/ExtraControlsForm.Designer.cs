﻿namespace M64MM2
{
    partial class ExtraControlsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraControlsForm));
            this.tbLevitate = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveHud = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbAddresses = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.btnBatchWrite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLevitate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLevitate
            // 
            resources.ApplyResources(this.tbLevitate, "tbLevitate");
            this.tbLevitate.Maximum = 5;
            this.tbLevitate.Name = "tbLevitate";
            this.tbLevitate.ValueChanged += new System.EventHandler(this.tbLevitate_ValueChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbLevitate);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnRemoveHud);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnRemoveHud
            // 
            resources.ApplyResources(this.btnRemoveHud, "btnRemoveHud");
            this.btnRemoveHud.Name = "btnRemoveHud";
            this.btnRemoveHud.UseVisualStyleBackColor = true;
            this.btnRemoveHud.Click += new System.EventHandler(this.btnRemoveHud_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbAddresses);
            this.groupBox3.Controls.Add(this.tbData);
            this.groupBox3.Controls.Add(this.btnClearBoxes);
            this.groupBox3.Controls.Add(this.btnBatchWrite);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // tbAddresses
            // 
            resources.ApplyResources(this.tbAddresses, "tbAddresses");
            this.tbAddresses.Name = "tbAddresses";
            // 
            // tbData
            // 
            resources.ApplyResources(this.tbData, "tbData");
            this.tbData.Name = "tbData";
            // 
            // btnClearBoxes
            // 
            resources.ApplyResources(this.btnClearBoxes, "btnClearBoxes");
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.UseVisualStyleBackColor = true;
            this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
            // 
            // btnBatchWrite
            // 
            resources.ApplyResources(this.btnBatchWrite, "btnBatchWrite");
            this.btnBatchWrite.Name = "btnBatchWrite";
            this.btnBatchWrite.UseVisualStyleBackColor = true;
            this.btnBatchWrite.Click += new System.EventHandler(this.btnBatchWrite_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ExtraControlsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExtraControlsForm";
            ((System.ComponentModel.ISupportInitialize)(this.tbLevitate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbLevitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveHud;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbAddresses;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.Button btnBatchWrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}