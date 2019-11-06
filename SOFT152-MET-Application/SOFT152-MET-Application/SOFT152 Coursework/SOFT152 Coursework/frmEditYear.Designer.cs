namespace SOFT152_Coursework
{
    partial class frmEditYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditYear));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveYear = new System.Windows.Forms.Button();
            this.grpBoxYearDetails = new System.Windows.Forms.GroupBox();
            this.txtBoxEditDescription = new System.Windows.Forms.TextBox();
            this.lblEditDescription = new System.Windows.Forms.Label();
            this.grpBoxYearDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 67);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Cancel";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(271, 347);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 67);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Revert Changes";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnSaveYear
            // 
            this.btnSaveYear.Location = new System.Drawing.Point(425, 347);
            this.btnSaveYear.Name = "btnSaveYear";
            this.btnSaveYear.Size = new System.Drawing.Size(148, 67);
            this.btnSaveYear.TabIndex = 1;
            this.btnSaveYear.Text = "Save";
            this.btnSaveYear.UseVisualStyleBackColor = true;
            this.btnSaveYear.Click += new System.EventHandler(this.btnSaveYear_Click);
            // 
            // grpBoxYearDetails
            // 
            this.grpBoxYearDetails.Controls.Add(this.txtBoxEditDescription);
            this.grpBoxYearDetails.Controls.Add(this.lblEditDescription);
            this.grpBoxYearDetails.Controls.Add(this.btnBack);
            this.grpBoxYearDetails.Controls.Add(this.btnReset);
            this.grpBoxYearDetails.Controls.Add(this.btnSaveYear);
            this.grpBoxYearDetails.Location = new System.Drawing.Point(29, 32);
            this.grpBoxYearDetails.Name = "grpBoxYearDetails";
            this.grpBoxYearDetails.Size = new System.Drawing.Size(579, 420);
            this.grpBoxYearDetails.TabIndex = 14;
            this.grpBoxYearDetails.TabStop = false;
            this.grpBoxYearDetails.Text = "Enter New Details...";
            // 
            // txtBoxEditDescription
            // 
            this.txtBoxEditDescription.Location = new System.Drawing.Point(174, 167);
            this.txtBoxEditDescription.MaxLength = 180;
            this.txtBoxEditDescription.Name = "txtBoxEditDescription";
            this.txtBoxEditDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxEditDescription.Size = new System.Drawing.Size(381, 31);
            this.txtBoxEditDescription.TabIndex = 15;
            // 
            // lblEditDescription
            // 
            this.lblEditDescription.AutoSize = true;
            this.lblEditDescription.Location = new System.Drawing.Point(19, 170);
            this.lblEditDescription.Name = "lblEditDescription";
            this.lblEditDescription.Size = new System.Drawing.Size(126, 25);
            this.lblEditDescription.TabIndex = 14;
            this.lblEditDescription.Text = "Description:";
            // 
            // frmEditYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 479);
            this.Controls.Add(this.grpBoxYearDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditYear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Year";
            this.grpBoxYearDetails.ResumeLayout(false);
            this.grpBoxYearDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveYear;
        private System.Windows.Forms.GroupBox grpBoxYearDetails;
        private System.Windows.Forms.TextBox txtBoxEditDescription;
        private System.Windows.Forms.Label lblEditDescription;
    }
}