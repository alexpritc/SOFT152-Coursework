namespace SOFT152_Coursework
{
    partial class frmLocationAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocationAnalysis));
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.panelValues = new System.Windows.Forms.Panel();
            this.panelYears = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.panelLocationAnalysis = new System.Windows.Forms.Panel();
            this.groupBoxLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLocation.Controls.Add(this.panelValues);
            this.groupBoxLocation.Controls.Add(this.panelYears);
            this.groupBoxLocation.Controls.Add(this.btnOk);
            this.groupBoxLocation.Controls.Add(this.comboBoxMenu);
            this.groupBoxLocation.Controls.Add(this.panelLocationAnalysis);
            this.groupBoxLocation.Location = new System.Drawing.Point(35, 29);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(676, 554);
            this.groupBoxLocation.TabIndex = 1;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Bar Chart";
            // 
            // panelValues
            // 
            this.panelValues.Location = new System.Drawing.Point(603, 42);
            this.panelValues.Name = "panelValues";
            this.panelValues.Size = new System.Drawing.Size(50, 442);
            this.panelValues.TabIndex = 8;
            // 
            // panelYears
            // 
            this.panelYears.Location = new System.Drawing.Point(22, 42);
            this.panelYears.Name = "panelYears";
            this.panelYears.Size = new System.Drawing.Size(50, 442);
            this.panelYears.TabIndex = 0;
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
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // panelLocationAnalysis
            // 
            this.panelLocationAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLocationAnalysis.AutoScroll = true;
            this.panelLocationAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLocationAnalysis.Location = new System.Drawing.Point(75, 42);
            this.panelLocationAnalysis.Margin = new System.Windows.Forms.Padding(0);
            this.panelLocationAnalysis.Name = "panelLocationAnalysis";
            this.panelLocationAnalysis.Size = new System.Drawing.Size(525, 442);
            this.panelLocationAnalysis.TabIndex = 0;
            this.panelLocationAnalysis.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLocationAnalysis_Paint);
            // 
            // frmLocationAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 613);
            this.Controls.Add(this.groupBoxLocation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLocationAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Analysis";
            this.groupBoxLocation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.Panel panelLocationAnalysis;
        private System.Windows.Forms.ComboBox comboBoxMenu;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panelYears;
        private System.Windows.Forms.Panel panelValues;
    }
}