namespace Log_Reg_Form.Forms
{
    partial class LogsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsListForm));
            this.grbx_welcome = new System.Windows.Forms.GroupBox();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.rtxbx_logs = new System.Windows.Forms.RichTextBox();
            this.grbx_welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_welcome
            // 
            this.grbx_welcome.BackColor = System.Drawing.Color.Transparent;
            this.grbx_welcome.Controls.Add(this.link_logout);
            this.grbx_welcome.Controls.Add(this.lbl_welcome);
            this.grbx_welcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbx_welcome.Location = new System.Drawing.Point(2, 2);
            this.grbx_welcome.Name = "grbx_welcome";
            this.grbx_welcome.Size = new System.Drawing.Size(994, 135);
            this.grbx_welcome.TabIndex = 3;
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
            // rtxbx_logs
            // 
            this.rtxbx_logs.Location = new System.Drawing.Point(2, 143);
            this.rtxbx_logs.Name = "rtxbx_logs";
            this.rtxbx_logs.ReadOnly = true;
            this.rtxbx_logs.Size = new System.Drawing.Size(994, 453);
            this.rtxbx_logs.TabIndex = 4;
            this.rtxbx_logs.Text = "";
            // 
            // LogsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(999, 600);
            this.Controls.Add(this.rtxbx_logs);
            this.Controls.Add(this.grbx_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LogsListForm";
            this.Text = "LogsListForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogsListForm_FormClosed);
            this.Load += new System.EventHandler(this.LogsListForm_Load);
            this.grbx_welcome.ResumeLayout(false);
            this.grbx_welcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_welcome;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.RichTextBox rtxbx_logs;
    }
}