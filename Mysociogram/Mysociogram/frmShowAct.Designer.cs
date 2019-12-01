namespace Mysociogram
{
    partial class frmShowAct
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
            this.treeAct = new System.Windows.Forms.TreeView();
            this.lblActType = new System.Windows.Forms.Label();
            this.lblActTime = new System.Windows.Forms.Label();
            this.lblActThought = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeAct
            // 
            this.treeAct.Location = new System.Drawing.Point(42, 29);
            this.treeAct.Name = "treeAct";
            this.treeAct.Size = new System.Drawing.Size(455, 506);
            this.treeAct.TabIndex = 0;
            // 
            // lblActType
            // 
            this.lblActType.AutoSize = true;
            this.lblActType.Location = new System.Drawing.Point(728, 193);
            this.lblActType.Name = "lblActType";
            this.lblActType.Size = new System.Drawing.Size(55, 15);
            this.lblActType.TabIndex = 1;
            this.lblActType.Text = "label1";
            // 
            // lblActTime
            // 
            this.lblActTime.AutoSize = true;
            this.lblActTime.Location = new System.Drawing.Point(728, 279);
            this.lblActTime.Name = "lblActTime";
            this.lblActTime.Size = new System.Drawing.Size(55, 15);
            this.lblActTime.TabIndex = 2;
            this.lblActTime.Text = "label1";
            // 
            // lblActThought
            // 
            this.lblActThought.AutoSize = true;
            this.lblActThought.Location = new System.Drawing.Point(731, 354);
            this.lblActThought.Name = "lblActThought";
            this.lblActThought.Size = new System.Drawing.Size(55, 15);
            this.lblActThought.TabIndex = 3;
            this.lblActThought.Text = "label1";
            // 
            // frmShowAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 587);
            this.Controls.Add(this.lblActThought);
            this.Controls.Add(this.lblActTime);
            this.Controls.Add(this.lblActType);
            this.Controls.Add(this.treeAct);
            this.Name = "frmShowAct";
            this.Text = "frmShowAct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeAct;
        private System.Windows.Forms.Label lblActType;
        private System.Windows.Forms.Label lblActTime;
        private System.Windows.Forms.Label lblActThought;
    }
}