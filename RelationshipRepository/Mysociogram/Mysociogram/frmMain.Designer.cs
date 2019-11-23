namespace Mysociogram
{
    partial class frmMain
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
            this.btnMyPage = new System.Windows.Forms.Button();
            this.btnShowPersonInRole = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMyPage
            // 
            this.btnMyPage.BackColor = System.Drawing.Color.Transparent;
            this.btnMyPage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMyPage.FlatAppearance.BorderSize = 5;
            this.btnMyPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyPage.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMyPage.ForeColor = System.Drawing.Color.White;
            this.btnMyPage.Location = new System.Drawing.Point(523, 109);
            this.btnMyPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyPage.Name = "btnMyPage";
            this.btnMyPage.Size = new System.Drawing.Size(240, 54);
            this.btnMyPage.TabIndex = 1;
            this.btnMyPage.Text = "个人资料";
            this.btnMyPage.UseVisualStyleBackColor = false;
            this.btnMyPage.Click += new System.EventHandler(this.btnMyPage_Click);
            // 
            // btnShowPersonInRole
            // 
            this.btnShowPersonInRole.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPersonInRole.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShowPersonInRole.FlatAppearance.BorderSize = 5;
            this.btnShowPersonInRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPersonInRole.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowPersonInRole.ForeColor = System.Drawing.Color.White;
            this.btnShowPersonInRole.Location = new System.Drawing.Point(523, 228);
            this.btnShowPersonInRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowPersonInRole.Name = "btnShowPersonInRole";
            this.btnShowPersonInRole.Size = new System.Drawing.Size(240, 62);
            this.btnShowPersonInRole.TabIndex = 2;
            this.btnShowPersonInRole.Text = "人际关系";
            this.btnShowPersonInRole.UseVisualStyleBackColor = false;
            this.btnShowPersonInRole.Click += new System.EventHandler(this.btnShowPersonInRole_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 5;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(523, 355);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "退出登录";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mysiciogram";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Mysociogram.Properties.Resources.beijing1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnShowPersonInRole);
            this.Controls.Add(this.btnMyPage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "主页面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMyPage;
        private System.Windows.Forms.Button btnShowPersonInRole;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}