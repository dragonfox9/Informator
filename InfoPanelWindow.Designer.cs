namespace Informator
{
    partial class InfoPanelWindow
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
            this.msgTB = new System.Windows.Forms.TextBox();
            this.fromLb = new System.Windows.Forms.Label();
            this.expiryDateLb = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addedByLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msgTB
            // 
            this.msgTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.msgTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgTB.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.msgTB.Location = new System.Drawing.Point(12, 57);
            this.msgTB.Multiline = true;
            this.msgTB.Name = "msgTB";
            this.msgTB.ReadOnly = true;
            this.msgTB.Size = new System.Drawing.Size(378, 271);
            this.msgTB.TabIndex = 0;
            // 
            // fromLb
            // 
            this.fromLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromLb.AutoSize = true;
            this.fromLb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.fromLb.Location = new System.Drawing.Point(12, 331);
            this.fromLb.Name = "fromLb";
            this.fromLb.Size = new System.Drawing.Size(27, 13);
            this.fromLb.TabIndex = 1;
            this.fromLb.Text = "from";
            this.fromLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // expiryDateLb
            // 
            this.expiryDateLb.AutoSize = true;
            this.expiryDateLb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.expiryDateLb.Location = new System.Drawing.Point(12, 344);
            this.expiryDateLb.Name = "expiryDateLb";
            this.expiryDateLb.Size = new System.Drawing.Size(97, 13);
            this.expiryDateLb.TabIndex = 2;
            this.expiryDateLb.Text = "Data/zatwierdzono";
            this.expiryDateLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleTB
            // 
            this.titleTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.titleTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.titleTB.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleTB.Location = new System.Drawing.Point(12, 31);
            this.titleTB.Name = "titleTB";
            this.titleTB.ReadOnly = true;
            this.titleTB.Size = new System.Drawing.Size(378, 20);
            this.titleTB.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.closeBtn.Location = new System.Drawing.Point(315, 374);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Zamknij";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addedByLb
            // 
            this.addedByLb.AutoSize = true;
            this.addedByLb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.addedByLb.Location = new System.Drawing.Point(12, 357);
            this.addedByLb.Name = "addedByLb";
            this.addedByLb.Size = new System.Drawing.Size(51, 13);
            this.addedByLb.TabIndex = 5;
            this.addedByLb.Text = "added by";
            // 
            // InfoPanelWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(402, 410);
            this.Controls.Add(this.addedByLb);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.expiryDateLb);
            this.Controls.Add(this.fromLb);
            this.Controls.Add(this.msgTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoPanelWindow";
            this.Text = "InfoPanelWindow";
            this.Load += new System.EventHandler(this.InfoPanelWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InfoPanelWindow_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgTB;
        private System.Windows.Forms.Label fromLb;
        private System.Windows.Forms.Label expiryDateLb;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label addedByLb;
    }
}