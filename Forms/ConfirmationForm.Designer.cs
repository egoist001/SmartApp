namespace Log_Reg_Form.Forms
{
    partial class ConfirmationForm
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
            this.txbx_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_code
            // 
            this.txbx_code.BackColor = System.Drawing.Color.White;
            this.txbx_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbx_code.Location = new System.Drawing.Point(124, 107);
            this.txbx_code.Name = "txbx_code";
            this.txbx_code.Size = new System.Drawing.Size(260, 29);
            this.txbx_code.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Confirm Code To Create Your Account ";
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.White;
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_confirm.Location = new System.Drawing.Point(196, 154);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(117, 28);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // ConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 212);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfirmationForm";
            this.Text = "ConfirmationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_confirm;
    }
}