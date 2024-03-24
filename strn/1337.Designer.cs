namespace Win_1337_Patch
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.t1337 = new System.Windows.Forms.TextBox();
            this.texe = new System.Windows.Forms.TextBox();
            this.btnSelect1337 = new System.Windows.Forms.Button();
            this.linkdfox = new System.Windows.Forms.LinkLabel();
            this.Patch = new System.Windows.Forms.Button();
            this.controlloBackup = new System.Windows.Forms.CheckBox();
            this.cfileoffsett = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(21, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 41);
            this.label7.TabIndex = 17;
            this.label7.Text = "Patch (.1337):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t1337
            // 
            this.t1337.AllowDrop = true;
            this.t1337.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.t1337.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t1337.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1337.ForeColor = System.Drawing.Color.White;
            this.t1337.Location = new System.Drawing.Point(261, 81);
            this.t1337.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.t1337.Multiline = true;
            this.t1337.Name = "t1337";
            this.t1337.ReadOnly = true;
            this.t1337.Size = new System.Drawing.Size(704, 55);
            this.t1337.TabIndex = 16;
            this.t1337.TabStop = false;
            this.t1337.Text = "Select a patch file (.1337)...";
            this.t1337.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t1337.DragDrop += new System.Windows.Forms.DragEventHandler(this.t1337_DragDrop);
            this.t1337.DragEnter += new System.Windows.Forms.DragEventHandler(this.t1337_DragEnter);
            this.t1337.DoubleClick += new System.EventHandler(this.t1337_DoubleClick);
            // 
            // texe
            // 
            this.texe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.texe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texe.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texe.ForeColor = System.Drawing.Color.White;
            this.texe.Location = new System.Drawing.Point(261, 148);
            this.texe.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.texe.Multiline = true;
            this.texe.Name = "texe";
            this.texe.ReadOnly = true;
            this.texe.Size = new System.Drawing.Size(704, 55);
            this.texe.TabIndex = 14;
            this.texe.TabStop = false;
            this.texe.Text = "Select a file to patch...";
            this.texe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSelect1337
            // 
            this.btnSelect1337.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSelect1337.CausesValidation = false;
            this.btnSelect1337.FlatAppearance.BorderSize = 0;
            this.btnSelect1337.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect1337.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect1337.ForeColor = System.Drawing.Color.White;
            this.btnSelect1337.Location = new System.Drawing.Point(973, 81);
            this.btnSelect1337.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect1337.Name = "btnSelect1337";
            this.btnSelect1337.Size = new System.Drawing.Size(184, 122);
            this.btnSelect1337.TabIndex = 19;
            this.btnSelect1337.Text = "Select... (both)";
            this.btnSelect1337.UseVisualStyleBackColor = false;
            this.btnSelect1337.Click += new System.EventHandler(this.btnSelect1337_Click);
            // 
            // linkdfox
            // 
            this.linkdfox.AutoSize = true;
            this.linkdfox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkdfox.ForeColor = System.Drawing.Color.Plum;
            this.linkdfox.LinkColor = System.Drawing.Color.DarkViolet;
            this.linkdfox.Location = new System.Drawing.Point(683, 231);
            this.linkdfox.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.linkdfox.Name = "linkdfox";
            this.linkdfox.Size = new System.Drawing.Size(221, 34);
            this.linkdfox.TabIndex = 73;
            this.linkdfox.TabStop = true;
            this.linkdfox.Text = "Made By Payson";
            this.linkdfox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkdfox_LinkClicked);
            // 
            // Patch
            // 
            this.Patch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Patch.FlatAppearance.BorderSize = 0;
            this.Patch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patch.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patch.ForeColor = System.Drawing.Color.White;
            this.Patch.Location = new System.Drawing.Point(923, 219);
            this.Patch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Patch.Name = "Patch";
            this.Patch.Size = new System.Drawing.Size(235, 55);
            this.Patch.TabIndex = 74;
            this.Patch.Text = "Patch";
            this.Patch.UseVisualStyleBackColor = false;
            this.Patch.Click += new System.EventHandler(this.Patch_Click);
            // 
            // controlloBackup
            // 
            this.controlloBackup.AutoSize = true;
            this.controlloBackup.Checked = true;
            this.controlloBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.controlloBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlloBackup.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlloBackup.ForeColor = System.Drawing.Color.White;
            this.controlloBackup.Location = new System.Drawing.Point(29, 229);
            this.controlloBackup.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.controlloBackup.Name = "controlloBackup";
            this.controlloBackup.Size = new System.Drawing.Size(146, 38);
            this.controlloBackup.TabIndex = 76;
            this.controlloBackup.Text = "Backup";
            this.controlloBackup.UseVisualStyleBackColor = true;
            this.controlloBackup.CheckedChanged += new System.EventHandler(this.controlloBackup_CheckedChanged);
            // 
            // cfileoffsett
            // 
            this.cfileoffsett.AutoSize = true;
            this.cfileoffsett.Checked = true;
            this.cfileoffsett.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cfileoffsett.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cfileoffsett.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfileoffsett.ForeColor = System.Drawing.Color.White;
            this.cfileoffsett.Location = new System.Drawing.Point(219, 229);
            this.cfileoffsett.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cfileoffsett.Name = "cfileoffsett";
            this.cfileoffsett.Size = new System.Drawing.Size(172, 38);
            this.cfileoffsett.TabIndex = 77;
            this.cfileoffsett.Text = "Fix Offset";
            this.cfileoffsett.UseVisualStyleBackColor = true;
            this.cfileoffsett.CheckedChanged += new System.EventHandler(this.cfileoffsett_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(21, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 41);
            this.label1.TabIndex = 78;
            this.label1.Text = "File (.exe, .dll):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 67);
            this.panel1.TabIndex = 79;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1123, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 80;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1200, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "Saturn Patch Tool";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1195, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cfileoffsett);
            this.Controls.Add(this.controlloBackup);
            this.Controls.Add(this.Patch);
            this.Controls.Add(this.linkdfox);
            this.Controls.Add(this.btnSelect1337);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.t1337);
            this.Controls.Add(this.texe);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1195, 291);
            this.MinimumSize = new System.Drawing.Size(1195, 291);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saturn Patcher";
            this.Load += new System.EventHandler(this.DFoX_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t1337;
        private System.Windows.Forms.TextBox texe;
        private System.Windows.Forms.Button btnSelect1337;
        private System.Windows.Forms.LinkLabel linkdfox;
        private System.Windows.Forms.Button Patch;
        private System.Windows.Forms.CheckBox controlloBackup;
        private System.Windows.Forms.CheckBox cfileoffsett;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

