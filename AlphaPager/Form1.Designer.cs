namespace AlphaPager
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
            this.butLogin = new System.Windows.Forms.Button();
            this.butConfig = new System.Windows.Forms.Button();
            this.textCitnum = new System.Windows.Forms.TextBox();
            this.textPrivPass = new System.Windows.Forms.TextBox();
            this.textWorld = new System.Windows.Forms.TextBox();
            this.textCoords = new System.Windows.Forms.TextBox();
            this.textAvatar = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolLoggedIn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBotname = new System.Windows.Forms.TextBox();
            this.lisStatus = new System.Windows.Forms.ListBox();
            this.butLogout = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butLogin
            // 
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.butLogin.Location = new System.Drawing.Point(8, 106);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(114, 35);
            this.butLogin.TabIndex = 0;
            this.butLogin.Text = "Log In";
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // butConfig
            // 
            this.butConfig.Location = new System.Drawing.Point(254, 106);
            this.butConfig.Name = "butConfig";
            this.butConfig.Size = new System.Drawing.Size(119, 35);
            this.butConfig.TabIndex = 1;
            this.butConfig.Text = "Configure";
            this.butConfig.UseVisualStyleBackColor = true;
            this.butConfig.Click += new System.EventHandler(this.butConfig_Click);
            // 
            // textCitnum
            // 
            this.textCitnum.Location = new System.Drawing.Point(67, 39);
            this.textCitnum.Name = "textCitnum";
            this.textCitnum.Size = new System.Drawing.Size(100, 20);
            this.textCitnum.TabIndex = 2;
            // 
            // textPrivPass
            // 
            this.textPrivPass.Location = new System.Drawing.Point(67, 65);
            this.textPrivPass.Name = "textPrivPass";
            this.textPrivPass.PasswordChar = '*';
            this.textPrivPass.Size = new System.Drawing.Size(100, 20);
            this.textPrivPass.TabIndex = 3;
            // 
            // textWorld
            // 
            this.textWorld.Location = new System.Drawing.Point(244, 12);
            this.textWorld.Name = "textWorld";
            this.textWorld.Size = new System.Drawing.Size(100, 20);
            this.textWorld.TabIndex = 4;
            // 
            // textCoords
            // 
            this.textCoords.Location = new System.Drawing.Point(244, 39);
            this.textCoords.Name = "textCoords";
            this.textCoords.Size = new System.Drawing.Size(100, 20);
            this.textCoords.TabIndex = 5;
            // 
            // textAvatar
            // 
            this.textAvatar.Location = new System.Drawing.Point(244, 65);
            this.textAvatar.Name = "textAvatar";
            this.textAvatar.Size = new System.Drawing.Size(44, 20);
            this.textAvatar.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLoggedIn,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(380, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolLoggedIn
            // 
            this.toolLoggedIn.Margin = new System.Windows.Forms.Padding(8, 3, 0, 2);
            this.toolLoggedIn.Name = "toolLoggedIn";
            this.toolLoggedIn.Size = new System.Drawing.Size(70, 17);
            this.toolLoggedIn.Text = "Logged Out";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Citnum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Priv Pass:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "World:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Coords:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Avatar #:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Botname:";
            // 
            // textBotname
            // 
            this.textBotname.Location = new System.Drawing.Point(67, 12);
            this.textBotname.Name = "textBotname";
            this.textBotname.Size = new System.Drawing.Size(100, 20);
            this.textBotname.TabIndex = 14;
            // 
            // lisStatus
            // 
            this.lisStatus.FormattingEnabled = true;
            this.lisStatus.Location = new System.Drawing.Point(8, 158);
            this.lisStatus.Name = "lisStatus";
            this.lisStatus.Size = new System.Drawing.Size(365, 173);
            this.lisStatus.TabIndex = 16;
            // 
            // butLogout
            // 
            this.butLogout.Location = new System.Drawing.Point(129, 106);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(119, 35);
            this.butLogout.TabIndex = 17;
            this.butLogout.Text = "Log Out";
            this.butLogout.UseVisualStyleBackColor = true;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 360);
            this.Controls.Add(this.butLogout);
            this.Controls.Add(this.lisStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBotname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textAvatar);
            this.Controls.Add(this.textCoords);
            this.Controls.Add(this.textWorld);
            this.Controls.Add(this.textPrivPass);
            this.Controls.Add(this.textCitnum);
            this.Controls.Add(this.butConfig);
            this.Controls.Add(this.butLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlphaPager";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Button butConfig;
        private System.Windows.Forms.TextBox textCitnum;
        private System.Windows.Forms.TextBox textPrivPass;
        private System.Windows.Forms.TextBox textWorld;
        private System.Windows.Forms.TextBox textCoords;
        private System.Windows.Forms.TextBox textAvatar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBotname;
        private System.Windows.Forms.ListBox lisStatus;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.ToolStripStatusLabel toolLoggedIn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

