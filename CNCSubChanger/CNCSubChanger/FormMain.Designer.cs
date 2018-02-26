namespace CNCSubChanger
{
    partial class FormMain
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblOldSub = new System.Windows.Forms.Label();
            this.lblNewSub = new System.Windows.Forms.Label();
            this.txtNewSub = new System.Windows.Forms.TextBox();
            this.txtOldSub = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.lblSubRef = new System.Windows.Forms.Label();
            this.txtSubRef = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(315, 61);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 26);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblOldSub
            // 
            this.lblOldSub.AutoSize = true;
            this.lblOldSub.Location = new System.Drawing.Point(8, 41);
            this.lblOldSub.Name = "lblOldSub";
            this.lblOldSub.Size = new System.Drawing.Size(65, 17);
            this.lblOldSub.TabIndex = 6;
            this.lblOldSub.Text = "Old sub: ";
            // 
            // lblNewSub
            // 
            this.lblNewSub.AutoSize = true;
            this.lblNewSub.Location = new System.Drawing.Point(202, 41);
            this.lblNewSub.Name = "lblNewSub";
            this.lblNewSub.Size = new System.Drawing.Size(66, 17);
            this.lblNewSub.TabIndex = 8;
            this.lblNewSub.Text = "New sub:";
            // 
            // txtNewSub
            // 
            this.txtNewSub.Location = new System.Drawing.Point(273, 37);
            this.txtNewSub.Name = "txtNewSub";
            this.txtNewSub.Size = new System.Drawing.Size(114, 22);
            this.txtNewSub.TabIndex = 3;
            this.txtNewSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowIntOnly);
            // 
            // txtOldSub
            // 
            this.txtOldSub.Location = new System.Drawing.Point(79, 37);
            this.txtOldSub.Name = "txtOldSub";
            this.txtOldSub.Size = new System.Drawing.Size(117, 22);
            this.txtOldSub.TabIndex = 2;
            this.txtOldSub.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowIntOnly);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(79, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(270, 22);
            this.txtFile.TabIndex = 0;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(9, 15);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(34, 17);
            this.lblFile.TabIndex = 8;
            this.lblFile.Text = "File:";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(351, 11);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(38, 26);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "...";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // lblSubRef
            // 
            this.lblSubRef.AutoSize = true;
            this.lblSubRef.Location = new System.Drawing.Point(8, 66);
            this.lblSubRef.Name = "lblSubRef";
            this.lblSubRef.Size = new System.Drawing.Size(62, 17);
            this.lblSubRef.TabIndex = 10;
            this.lblSubRef.Text = "Sub call:";
            // 
            // txtSubRef
            // 
            this.txtSubRef.Location = new System.Drawing.Point(79, 61);
            this.txtSubRef.Name = "txtSubRef";
            this.txtSubRef.Size = new System.Drawing.Size(160, 22);
            this.txtSubRef.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(241, 61);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(399, 99);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSubRef);
            this.Controls.Add(this.lblSubRef);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblNewSub);
            this.Controls.Add(this.txtNewSub);
            this.Controls.Add(this.lblOldSub);
            this.Controls.Add(this.txtOldSub);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "CNCSubChanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblOldSub;
        private System.Windows.Forms.Label lblNewSub;
        private System.Windows.Forms.TextBox txtNewSub;
        private System.Windows.Forms.TextBox txtOldSub;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label lblSubRef;
        private System.Windows.Forms.TextBox txtSubRef;
        private System.Windows.Forms.Button btnSave;
    }
}

