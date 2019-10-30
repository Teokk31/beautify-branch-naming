namespace BeautifyBranchNaming
{
    partial class BeautifyBranchNamingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeautifyBranchNamingForm));
            this.btnBeautify = new System.Windows.Forms.Button();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.ddlBranchType = new System.Windows.Forms.ComboBox();
            this.lblBranchType = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtBranchType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBeautify
            // 
            this.btnBeautify.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBeautify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBeautify.Location = new System.Drawing.Point(104, 115);
            this.btnBeautify.Name = "btnBeautify";
            this.btnBeautify.Size = new System.Drawing.Size(86, 31);
            this.btnBeautify.TabIndex = 0;
            this.btnBeautify.Text = "Beautify";
            this.btnBeautify.UseVisualStyleBackColor = false;
            this.btnBeautify.Click += new System.EventHandler(this.btnBeautify_Click);
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(88, 80);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(374, 20);
            this.txtBranchName.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(468, 80);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(40, 20);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(18, 64);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(72, 13);
            this.lblBranchName.TabIndex = 3;
            this.lblBranchName.Text = "Branch Name";
            // 
            // ddlBranchType
            // 
            this.ddlBranchType.FormattingEnabled = true;
            this.ddlBranchType.Location = new System.Drawing.Point(20, 30);
            this.ddlBranchType.Name = "ddlBranchType";
            this.ddlBranchType.Size = new System.Drawing.Size(121, 21);
            this.ddlBranchType.TabIndex = 4;
            this.ddlBranchType.SelectedIndexChanged += new System.EventHandler(this.ddlBranchType_SelectedIndexChanged);
            // 
            // lblBranchType
            // 
            this.lblBranchType.AutoSize = true;
            this.lblBranchType.Location = new System.Drawing.Point(15, 14);
            this.lblBranchType.Name = "lblBranchType";
            this.lblBranchType.Size = new System.Drawing.Size(101, 13);
            this.lblBranchType.TabIndex = 5;
            this.lblBranchType.Text = "Select Branch Type";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(21, 115);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtBranchType
            // 
            this.txtBranchType.Enabled = false;
            this.txtBranchType.Location = new System.Drawing.Point(21, 80);
            this.txtBranchType.Name = "txtBranchType";
            this.txtBranchType.Size = new System.Drawing.Size(69, 20);
            this.txtBranchType.TabIndex = 7;
            // 
            // BeautifyBranchNamingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 158);
            this.Controls.Add(this.txtBranchType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblBranchType);
            this.Controls.Add(this.ddlBranchType);
            this.Controls.Add(this.lblBranchName);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.btnBeautify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BeautifyBranchNamingForm";
            this.Text = "Beautify Branch Naming";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeautify;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.ComboBox ddlBranchType;
        private System.Windows.Forms.Label lblBranchType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtBranchType;
    }
}

