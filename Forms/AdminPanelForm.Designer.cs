namespace Log_Reg_Form
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.grbx_welcome = new System.Windows.Forms.GroupBox();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.link_usersList = new System.Windows.Forms.LinkLabel();
            this.link_logsList = new System.Windows.Forms.LinkLabel();
            this.grbx_stats = new System.Windows.Forms.GroupBox();
            this.grbx_welcome.SuspendLayout();
            this.grbx_stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_welcome
            // 
            this.grbx_welcome.BackColor = System.Drawing.Color.Transparent;
            this.grbx_welcome.Controls.Add(this.link_logout);
            this.grbx_welcome.Controls.Add(this.lbl_welcome);
            this.grbx_welcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbx_welcome.Location = new System.Drawing.Point(3, 1);
            this.grbx_welcome.Name = "grbx_welcome";
            this.grbx_welcome.Size = new System.Drawing.Size(992, 135);
            this.grbx_welcome.TabIndex = 1;
            this.grbx_welcome.TabStop = false;
            // 
            // link_logout
            // 
            this.link_logout.AutoSize = true;
            this.link_logout.BackColor = System.Drawing.Color.White;
            this.link_logout.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.link_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_logout.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.link_logout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_logout.LinkColor = System.Drawing.Color.Black;
            this.link_logout.Location = new System.Drawing.Point(833, 51);
            this.link_logout.Name = "link_logout";
            this.link_logout.Size = new System.Drawing.Size(102, 39);
            this.link_logout.TabIndex = 1;
            this.link_logout.TabStop = true;
            this.link_logout.Text = "Log Out";
            this.link_logout.VisitedLinkColor = System.Drawing.Color.Red;
            this.link_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logout_LinkClicked);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.lbl_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_welcome.Location = new System.Drawing.Point(36, 35);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(0, 39);
            this.lbl_welcome.TabIndex = 0;
            // 
            // link_usersList
            // 
            this.link_usersList.AutoSize = true;
            this.link_usersList.BackColor = System.Drawing.Color.White;
            this.link_usersList.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.link_usersList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_usersList.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.link_usersList.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_usersList.LinkColor = System.Drawing.Color.Black;
            this.link_usersList.Location = new System.Drawing.Point(17, 56);
            this.link_usersList.Name = "link_usersList";
            this.link_usersList.Size = new System.Drawing.Size(121, 39);
            this.link_usersList.TabIndex = 2;
            this.link_usersList.TabStop = true;
            this.link_usersList.Text = "Users List";
            this.link_usersList.VisitedLinkColor = System.Drawing.Color.Red;
            this.link_usersList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // link_logsList
            // 
            this.link_logsList.AutoSize = true;
            this.link_logsList.BackColor = System.Drawing.Color.White;
            this.link_logsList.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.link_logsList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link_logsList.LinkArea = new System.Windows.Forms.LinkArea(0, 9);
            this.link_logsList.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_logsList.LinkColor = System.Drawing.Color.Black;
            this.link_logsList.Location = new System.Drawing.Point(17, 122);
            this.link_logsList.Name = "link_logsList";
            this.link_logsList.Size = new System.Drawing.Size(115, 39);
            this.link_logsList.TabIndex = 3;
            this.link_logsList.TabStop = true;
            this.link_logsList.Text = "Logs List";
            this.link_logsList.VisitedLinkColor = System.Drawing.Color.Red;
            this.link_logsList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_logsList_LinkClicked);
            // 
            // grbx_stats
            // 
            this.grbx_stats.BackColor = System.Drawing.Color.Transparent;
            this.grbx_stats.Controls.Add(this.link_usersList);
            this.grbx_stats.Controls.Add(this.link_logsList);
            this.grbx_stats.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.grbx_stats.ForeColor = System.Drawing.Color.White;
            this.grbx_stats.Location = new System.Drawing.Point(12, 156);
            this.grbx_stats.Name = "grbx_stats";
            this.grbx_stats.Size = new System.Drawing.Size(974, 430);
            this.grbx_stats.TabIndex = 4;
            this.grbx_stats.TabStop = false;
            this.grbx_stats.Text = "Statistics";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 598);
            this.Controls.Add(this.grbx_stats);
            this.Controls.Add(this.grbx_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPanel_FormClosed);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.grbx_welcome.ResumeLayout(false);
            this.grbx_welcome.PerformLayout();
            this.grbx_stats.ResumeLayout(false);
            this.grbx_stats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_welcome;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.LinkLabel link_usersList;
        private System.Windows.Forms.LinkLabel link_logsList;
        private System.Windows.Forms.GroupBox grbx_stats;
    }
}