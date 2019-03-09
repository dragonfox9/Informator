namespace Informator
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addInfoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoMainPanel = new System.Windows.Forms.Panel();
            this.previousPageBtn = new System.Windows.Forms.Button();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pageTB = new System.Windows.Forms.TextBox();
            this.lastPageLb = new System.Windows.Forms.Label();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addInfoBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 436);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(13, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj użytkownika";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addInfoBtn
            // 
            this.addInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.addInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addInfoBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.addInfoBtn.Location = new System.Drawing.Point(13, 56);
            this.addInfoBtn.Name = "addInfoBtn";
            this.addInfoBtn.Size = new System.Drawing.Size(112, 23);
            this.addInfoBtn.TabIndex = 1;
            this.addInfoBtn.Text = "Dodaj info";
            this.addInfoBtn.UseVisualStyleBackColor = false;
            this.addInfoBtn.Click += new System.EventHandler(this.addInfoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // infoMainPanel
            // 
            this.infoMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoMainPanel.Location = new System.Drawing.Point(161, 58);
            this.infoMainPanel.Name = "infoMainPanel";
            this.infoMainPanel.Size = new System.Drawing.Size(627, 411);
            this.infoMainPanel.TabIndex = 2;
            // 
            // previousPageBtn
            // 
            this.previousPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.previousPageBtn.Enabled = false;
            this.previousPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousPageBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.previousPageBtn.Location = new System.Drawing.Point(406, 475);
            this.previousPageBtn.Name = "previousPageBtn";
            this.previousPageBtn.Size = new System.Drawing.Size(31, 23);
            this.previousPageBtn.TabIndex = 1;
            this.previousPageBtn.Text = "<<";
            this.previousPageBtn.UseVisualStyleBackColor = false;
            this.previousPageBtn.Click += new System.EventHandler(this.previousPageBtn_Click);
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.nextPageBtn.Enabled = false;
            this.nextPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextPageBtn.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.nextPageBtn.Location = new System.Drawing.Point(487, 475);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(31, 23);
            this.nextPageBtn.TabIndex = 0;
            this.nextPageBtn.Text = ">>";
            this.nextPageBtn.UseVisualStyleBackColor = false;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informator";
            // 
            // pageTB
            // 
            this.pageTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pageTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageTB.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pageTB.Location = new System.Drawing.Point(443, 478);
            this.pageTB.Name = "pageTB";
            this.pageTB.Size = new System.Drawing.Size(38, 20);
            this.pageTB.TabIndex = 4;
            this.pageTB.Text = "1";
            this.pageTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageTB_KeyDown);
            this.pageTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pageTB_KeyPress);
            // 
            // lastPageLb
            // 
            this.lastPageLb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastPageLb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lastPageLb.Location = new System.Drawing.Point(413, 504);
            this.lastPageLb.Name = "lastPageLb";
            this.lastPageLb.Size = new System.Drawing.Size(100, 23);
            this.lastPageLb.TabIndex = 5;
            this.lastPageLb.Text = "Ilość stron: 1";
            this.lastPageLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablePanel
            // 
            this.tablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablePanel.Controls.Add(this.label6);
            this.tablePanel.Controls.Add(this.label5);
            this.tablePanel.Controls.Add(this.label4);
            this.tablePanel.Controls.Add(this.label3);
            this.tablePanel.Location = new System.Drawing.Point(161, 33);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(627, 28);
            this.tablePanel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(395, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pozostało:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(268, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ważne do:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(144, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tytuł:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(12, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Info od:";
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::Informator.Properties.Resources.x;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Location = new System.Drawing.Point(777, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 25);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            this.closeBtn.MouseHover += new System.EventHandler(this.closeBtn_MouseHover);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(802, 526);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.lastPageLb);
            this.Controls.Add(this.pageTB);
            this.Controls.Add(this.previousPageBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nextPageBtn);
            this.Controls.Add(this.infoMainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tablePanel.ResumeLayout(false);
            this.tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel infoMainPanel;
        private System.Windows.Forms.Button addInfoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.Button previousPageBtn;
        private System.Windows.Forms.TextBox pageTB;
        private System.Windows.Forms.Label lastPageLb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

