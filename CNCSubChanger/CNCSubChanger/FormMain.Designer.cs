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
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(314, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblOldSub
            // 
            this.lblOldSub.AutoSize = true;
            this.lblOldSub.Location = new System.Drawing.Point(12, 15);
            this.lblOldSub.Name = "lblOldSub";
            this.lblOldSub.Size = new System.Drawing.Size(104, 17);
            this.lblOldSub.TabIndex = 4;
            this.lblOldSub.Text = "Old sub name: ";
            // 
            // lblNewSub
            // 
            this.lblNewSub.AutoSize = true;
            this.lblNewSub.Location = new System.Drawing.Point(11, 43);
            this.lblNewSub.Name = "lblNewSub";
            this.lblNewSub.Size = new System.Drawing.Size(105, 17);
            this.lblNewSub.TabIndex = 6;
            this.lblNewSub.Text = "New sub name:";
            // 
            // txtNewSub
            // 
            this.txtNewSub.Location = new System.Drawing.Point(122, 40);
            this.txtNewSub.Name = "txtNewSub";
            this.txtNewSub.Size = new System.Drawing.Size(267, 22);
            this.txtNewSub.TabIndex = 1;
            // 
            // txtOldSub
            // 
            this.txtOldSub.Location = new System.Drawing.Point(122, 12);
            this.txtOldSub.Name = "txtOldSub";
            this.txtOldSub.Size = new System.Drawing.Size(267, 22);
            this.txtOldSub.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 102);
            this.Controls.Add(this.lblNewSub);
            this.Controls.Add(this.txtNewSub);
            this.Controls.Add(this.lblOldSub);
            this.Controls.Add(this.txtOldSub);
            this.Controls.Add(this.btnStart);
            this.Name = "FormMain";
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
    }
}

