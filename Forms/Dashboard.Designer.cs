namespace Log_Reg_Form
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.grbx_welcome = new System.Windows.Forms.GroupBox();
            this.link_logout = new System.Windows.Forms.LinkLabel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.link_setPicture = new System.Windows.Forms.LinkLabel();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grbx_welcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbx_welcome
            // 
            this.grbx_welcome.BackColor = System.Drawing.Color.Transparent;
            this.grbx_welcome.Controls.Add(this.link_logout);
            this.grbx_welcome.Controls.Add(this.lbl_welcome);
            this.grbx_welcome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grbx_welcome.Location = new System.Drawing.Point(3, 3);
            this.grbx_welcome.Name = "grbx_welcome";
            this.grbx_welcome.Size = new System.Drawing.Size(992, 135);
            this.grbx_welcome.TabIndex = 0;
            this.grbx_welcome.TabStop = false;
            // 
            // link_logout
            // 
            this.link_logout.AutoSize = true;
            this.link_logout.BackColor = System.Drawing.Color.White;
            this.link_logout.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.link_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.lbl_name.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.lbl_name.Location = new System.Drawing.Point(28, 156);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(0, 39);
            this.lbl_name.TabIndex = 1;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surname.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.lbl_surname.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.lbl_surname.Location = new System.Drawing.Point(28, 211);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(0, 39);
            this.lbl_surname.TabIndex = 2;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.BackColor = System.Drawing.Color.Transparent;
            this.lbl_age.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.lbl_age.Font = new System.Drawing.Font("Viner Hand ITC", 18F);
            this.lbl_age.Location = new System.Drawing.Point(28, 267);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(0, 39);
            this.lbl_age.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(659, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // link_setPicture
            // 
            this.link_setPicture.AutoSize = true;
            this.link_setPicture.BackColor = System.Drawing.Color.White;
            this.link_setPicture.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_setPicture.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.link_setPicture.LinkColor = System.Drawing.Color.Black;
            this.link_setPicture.Location = new System.Drawing.Point(808, 219);
            this.link_setPicture.Name = "link_setPicture";
            this.link_setPicture.Size = new System.Drawing.Size(151, 26);
            this.link_setPicture.TabIndex = 5;
            this.link_setPicture.TabStop = true;
            this.link_setPicture.Text = "Set Profile Picture\r\n";
            this.link_setPicture.VisitedLinkColor = System.Drawing.Color.Red;
            this.link_setPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_setPicture_LinkClicked);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "fileDialog";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 598);
            this.Controls.Add(this.link_setPicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.grbx_welcome);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.grbx_welcome.ResumeLayout(false);
            this.grbx_welcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_welcome;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.LinkLabel link_logout;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel link_setPicture;
        private System.Windows.Forms.OpenFileDialog fileDialog;
    }
}