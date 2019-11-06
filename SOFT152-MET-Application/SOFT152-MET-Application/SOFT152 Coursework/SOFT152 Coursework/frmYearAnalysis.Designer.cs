namespace SOFT152_Coursework
{
    partial class frmYearAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYearAnalysis));
            this.groupBoxYear = new System.Windows.Forms.GroupBox();
            this.panelValues = new System.Windows.Forms.Panel();
            this.panelMonths = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.panelYearAnalysis = new System.Windows.Forms.Panel();
            this.groupBoxYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxYear
            // 
            this.groupBoxYear.Controls.Add(this.panelValues);
            this.groupBoxYear.Controls.Add(this.panelMonths);
            this.groupBoxYear.Controls.Add(this.btnOk);
            this.groupBoxYear.Controls.Add(this.comboBoxMenu);
            this.groupBoxYear.Controls.Add(this.panelYearAnalysis);
            this.groupBoxYear.Location = new System.Drawing.Point(36, 29);
            this.groupBoxYear.Name = "groupBoxYear";
            this.groupBoxYear.Size = new System.Drawing.Size(682, 554);
            this.groupBoxYear.TabIndex = 2;
            this.groupBoxYear.TabStop = false;
            this.groupBoxYear.Text = "Bar Chart";
            // 
            // panelValues
            // 
            this.panelValues.Location = new System.Drawing.Point(599, 42);
            this.panelValues.Name = "panelValues";
            this.panelValues.Size = new System.Drawing.Size(77, 442);
            this.panelValues.TabIndex = 8;
            // 
            // panelMonths
            // 
            this.panelMonths.Location = new System.Drawing.Point(22, 42);
            this.panelMonths.Name = "panelMonths";
            this.panelMonths.Size = new System.Drawing.Size(50, 442);
            this.panelMonths.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnOk.Location = new System.Drawing.Point(499, 491);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 44);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Items.AddRange(new object[] {
            "Maximum Temperature",
            "Minimum Temperature",
            "Days of Airfrost",
            "Millimetres of Rainfall",
            "Hours of Sunshine"});
            this.comboBoxMenu.Location = new System.Drawing.Point(75, 491);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(383, 33);
            this.comboBoxMenu.TabIndex = 1;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged_1);
            // 
            // panelYearAnalysis
            // 
            this.panelYearAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelYearAnalysis.AutoScroll = true;
            this.panelYearAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYearAnalysis.Location = new System.Drawing.Point(75, 42);
            this.panelYearAnalysis.Margin = new System.Windows.Forms.Padding(0);
            this.panelYearAnalysis.Name = "panelYearAnalysis";
            this.panelYearAnalysis.Size = new System.Drawing.Size(521, 442);
            this.panelYearAnalysis.TabIndex = 0;
            this.panelYearAnalysis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelYearAnalysis_Paint_1);
            // 
            // frmYearAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 613);
            this.Controls.Add(this.groupBoxYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmYearAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Year Analysis";
            this.groupBoxYear.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxYear;
        private System.Windows.Forms.Panel panelMonths;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Panel panelYearAnalysis;
        private System.Windows.Forms.Panel panelValues;
    }
}