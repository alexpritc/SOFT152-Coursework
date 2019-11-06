namespace SOFT152_Coursework
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLocations = new System.Windows.Forms.GroupBox();
            this.txtBoxSearchLocations = new System.Windows.Forms.TextBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.comboBoxLocations = new System.Windows.Forms.ComboBox();
            this.groupBoxYears = new System.Windows.Forms.GroupBox();
            this.txtBoxSearchYears = new System.Windows.Forms.TextBox();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.groupBoxMonths = new System.Windows.Forms.GroupBox();
            this.txtBoxSearchMonths = new System.Windows.Forms.TextBox();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.lblAddressDATA = new System.Windows.Forms.Label();
            this.lblCoordinatesDATA = new System.Windows.Forms.Label();
            this.lblNumberOfYearsInLocationDATA = new System.Windows.Forms.Label();
            this.lblYearDATA = new System.Windows.Forms.Label();
            this.lblYearDescriptionDATA = new System.Windows.Forms.Label();
            this.lblMonthDATA = new System.Windows.Forms.Label();
            this.lblMaximumTemperatureDATA = new System.Windows.Forms.Label();
            this.lblMinimumTemperatureDATA = new System.Windows.Forms.Label();
            this.lblHoursOfSunshineDATA = new System.Windows.Forms.Label();
            this.lblMillimetresOfRainfallDATA = new System.Windows.Forms.Label();
            this.lblNumberOfDaysOfAirfrostDATA = new System.Windows.Forms.Label();
            this.lblHoursOfSunshine = new System.Windows.Forms.Label();
            this.lblMillimetresOfRainfall = new System.Windows.Forms.Label();
            this.lblNumberOfDaysOfAirfrost = new System.Windows.Forms.Label();
            this.lblMinimumTemperature = new System.Windows.Forms.Label();
            this.lblMaximumTemperature = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblMonthSelected = new System.Windows.Forms.Label();
            this.lblYearDescription = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearSelected = new System.Windows.Forms.Label();
            this.lblNumberOfYearsInLocation = new System.Windows.Forms.Label();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLocationLoaded = new System.Windows.Forms.Label();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.lblFileLoaded = new System.Windows.Forms.Label();
            this.lblNumberOfLocationsInFile = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.menuStripFile.SuspendLayout();
            this.groupBoxLocations.SuspendLayout();
            this.groupBoxYears.SuspendLayout();
            this.groupBoxMonths.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripFile
            // 
            this.menuStripFile.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(2564, 40);
            this.menuStripFile.TabIndex = 4;
            this.menuStripFile.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxLocations
            // 
            this.groupBoxLocations.Controls.Add(this.txtBoxSearchLocations);
            this.groupBoxLocations.Controls.Add(this.btnAddLocation);
            this.groupBoxLocations.Controls.Add(this.btnEditLocation);
            this.groupBoxLocations.Controls.Add(this.comboBoxLocations);
            this.groupBoxLocations.Location = new System.Drawing.Point(22, 228);
            this.groupBoxLocations.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxLocations.Name = "groupBoxLocations";
            this.groupBoxLocations.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxLocations.Size = new System.Drawing.Size(390, 815);
            this.groupBoxLocations.TabIndex = 5;
            this.groupBoxLocations.TabStop = false;
            this.groupBoxLocations.Text = "Locations";
            // 
            // txtBoxSearchLocations
            // 
            this.txtBoxSearchLocations.Location = new System.Drawing.Point(8, 34);
            this.txtBoxSearchLocations.Name = "txtBoxSearchLocations";
            this.txtBoxSearchLocations.Size = new System.Drawing.Size(368, 31);
            this.txtBoxSearchLocations.TabIndex = 4;
            this.txtBoxSearchLocations.TextChanged += new System.EventHandler(this.txtBoxSearchLocations_TextChanged);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(8, 740);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(368, 62);
            this.btnAddLocation.TabIndex = 3;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Location = new System.Drawing.Point(8, 670);
            this.btnEditLocation.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(368, 62);
            this.btnEditLocation.TabIndex = 2;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // comboBoxLocations
            // 
            this.comboBoxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxLocations.FormattingEnabled = true;
            this.comboBoxLocations.Location = new System.Drawing.Point(8, 33);
            this.comboBoxLocations.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLocations.Name = "comboBoxLocations";
            this.comboBoxLocations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxLocations.Size = new System.Drawing.Size(368, 633);
            this.comboBoxLocations.TabIndex = 0;
            this.comboBoxLocations.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocations_SelectedIndexChanged);
            // 
            // groupBoxYears
            // 
            this.groupBoxYears.Controls.Add(this.txtBoxSearchYears);
            this.groupBoxYears.Controls.Add(this.btnAddYear);
            this.groupBoxYears.Controls.Add(this.btnEditYear);
            this.groupBoxYears.Controls.Add(this.comboBoxYears);
            this.groupBoxYears.Location = new System.Drawing.Point(462, 228);
            this.groupBoxYears.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxYears.Name = "groupBoxYears";
            this.groupBoxYears.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxYears.Size = new System.Drawing.Size(390, 815);
            this.groupBoxYears.TabIndex = 6;
            this.groupBoxYears.TabStop = false;
            this.groupBoxYears.Text = "Years";
            // 
            // txtBoxSearchYears
            // 
            this.txtBoxSearchYears.Location = new System.Drawing.Point(7, 34);
            this.txtBoxSearchYears.Name = "txtBoxSearchYears";
            this.txtBoxSearchYears.Size = new System.Drawing.Size(366, 31);
            this.txtBoxSearchYears.TabIndex = 4;
            this.txtBoxSearchYears.TextChanged += new System.EventHandler(this.txtBoxSearchYears_TextChanged);
            // 
            // btnAddYear
            // 
            this.btnAddYear.Location = new System.Drawing.Point(8, 740);
            this.btnAddYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(368, 62);
            this.btnAddYear.TabIndex = 3;
            this.btnAddYear.Text = "Add Year";
            this.btnAddYear.UseVisualStyleBackColor = true;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
            // 
            // btnEditYear
            // 
            this.btnEditYear.Location = new System.Drawing.Point(8, 670);
            this.btnEditYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(368, 62);
            this.btnEditYear.TabIndex = 2;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            this.btnEditYear.Click += new System.EventHandler(this.btnEditYear_Click);
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(8, 33);
            this.comboBoxYears.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(368, 633);
            this.comboBoxYears.TabIndex = 0;
            this.comboBoxYears.SelectedIndexChanged += new System.EventHandler(this.comboBoxYears_SelectedIndexChanged);
            // 
            // groupBoxMonths
            // 
            this.groupBoxMonths.Controls.Add(this.txtBoxSearchMonths);
            this.groupBoxMonths.Controls.Add(this.btnEditMonth);
            this.groupBoxMonths.Controls.Add(this.comboBoxMonths);
            this.groupBoxMonths.Location = new System.Drawing.Point(912, 228);
            this.groupBoxMonths.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMonths.Name = "groupBoxMonths";
            this.groupBoxMonths.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMonths.Size = new System.Drawing.Size(390, 815);
            this.groupBoxMonths.TabIndex = 7;
            this.groupBoxMonths.TabStop = false;
            this.groupBoxMonths.Text = "Months";
            // 
            // txtBoxSearchMonths
            // 
            this.txtBoxSearchMonths.Location = new System.Drawing.Point(10, 34);
            this.txtBoxSearchMonths.Name = "txtBoxSearchMonths";
            this.txtBoxSearchMonths.Size = new System.Drawing.Size(366, 31);
            this.txtBoxSearchMonths.TabIndex = 5;
            this.txtBoxSearchMonths.TextChanged += new System.EventHandler(this.txtBoxSearchMonths_TextChanged);
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Location = new System.Drawing.Point(8, 670);
            this.btnEditMonth.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(368, 132);
            this.btnEditMonth.TabIndex = 2;
            this.btnEditMonth.Text = "Edit Month";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            this.btnEditMonth.Click += new System.EventHandler(this.btnEditMonth_Click);
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Location = new System.Drawing.Point(8, 33);
            this.comboBoxMonths.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(368, 633);
            this.comboBoxMonths.TabIndex = 0;
            this.comboBoxMonths.SelectedIndexChanged += new System.EventHandler(this.comboBoxMonths_SelectedIndexChanged);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.lblAddressDATA);
            this.groupBoxDetails.Controls.Add(this.lblCoordinatesDATA);
            this.groupBoxDetails.Controls.Add(this.lblNumberOfYearsInLocationDATA);
            this.groupBoxDetails.Controls.Add(this.lblYearDATA);
            this.groupBoxDetails.Controls.Add(this.lblYearDescriptionDATA);
            this.groupBoxDetails.Controls.Add(this.lblMonthDATA);
            this.groupBoxDetails.Controls.Add(this.lblMaximumTemperatureDATA);
            this.groupBoxDetails.Controls.Add(this.lblMinimumTemperatureDATA);
            this.groupBoxDetails.Controls.Add(this.lblHoursOfSunshineDATA);
            this.groupBoxDetails.Controls.Add(this.lblMillimetresOfRainfallDATA);
            this.groupBoxDetails.Controls.Add(this.lblNumberOfDaysOfAirfrostDATA);
            this.groupBoxDetails.Controls.Add(this.lblHoursOfSunshine);
            this.groupBoxDetails.Controls.Add(this.lblMillimetresOfRainfall);
            this.groupBoxDetails.Controls.Add(this.lblNumberOfDaysOfAirfrost);
            this.groupBoxDetails.Controls.Add(this.lblMinimumTemperature);
            this.groupBoxDetails.Controls.Add(this.lblMaximumTemperature);
            this.groupBoxDetails.Controls.Add(this.lblMonth);
            this.groupBoxDetails.Controls.Add(this.lblMonthSelected);
            this.groupBoxDetails.Controls.Add(this.lblYearDescription);
            this.groupBoxDetails.Controls.Add(this.lblYear);
            this.groupBoxDetails.Controls.Add(this.lblYearSelected);
            this.groupBoxDetails.Controls.Add(this.lblNumberOfYearsInLocation);
            this.groupBoxDetails.Controls.Add(this.lblCoordinates);
            this.groupBoxDetails.Controls.Add(this.lblAddress);
            this.groupBoxDetails.Controls.Add(this.lblLocationLoaded);
            this.groupBoxDetails.Location = new System.Drawing.Point(1354, 228);
            this.groupBoxDetails.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxDetails.Size = new System.Drawing.Size(1046, 815);
            this.groupBoxDetails.TabIndex = 8;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // lblAddressDATA
            // 
            this.lblAddressDATA.AutoSize = true;
            this.lblAddressDATA.Location = new System.Drawing.Point(312, 100);
            this.lblAddressDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddressDATA.Name = "lblAddressDATA";
            this.lblAddressDATA.Size = new System.Drawing.Size(47, 25);
            this.lblAddressDATA.TabIndex = 36;
            this.lblAddressDATA.Text = "N/A";
            // 
            // lblCoordinatesDATA
            // 
            this.lblCoordinatesDATA.AutoSize = true;
            this.lblCoordinatesDATA.Location = new System.Drawing.Point(312, 146);
            this.lblCoordinatesDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCoordinatesDATA.Name = "lblCoordinatesDATA";
            this.lblCoordinatesDATA.Size = new System.Drawing.Size(47, 25);
            this.lblCoordinatesDATA.TabIndex = 35;
            this.lblCoordinatesDATA.Text = "N/A";
            // 
            // lblNumberOfYearsInLocationDATA
            // 
            this.lblNumberOfYearsInLocationDATA.AutoSize = true;
            this.lblNumberOfYearsInLocationDATA.Location = new System.Drawing.Point(312, 190);
            this.lblNumberOfYearsInLocationDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfYearsInLocationDATA.Name = "lblNumberOfYearsInLocationDATA";
            this.lblNumberOfYearsInLocationDATA.Size = new System.Drawing.Size(47, 25);
            this.lblNumberOfYearsInLocationDATA.TabIndex = 34;
            this.lblNumberOfYearsInLocationDATA.Text = "N/A";
            // 
            // lblYearDATA
            // 
            this.lblYearDATA.AutoSize = true;
            this.lblYearDATA.Location = new System.Drawing.Point(312, 337);
            this.lblYearDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYearDATA.Name = "lblYearDATA";
            this.lblYearDATA.Size = new System.Drawing.Size(47, 25);
            this.lblYearDATA.TabIndex = 33;
            this.lblYearDATA.Text = "N/A";
            // 
            // lblYearDescriptionDATA
            // 
            this.lblYearDescriptionDATA.AutoSize = true;
            this.lblYearDescriptionDATA.Location = new System.Drawing.Point(312, 377);
            this.lblYearDescriptionDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYearDescriptionDATA.Name = "lblYearDescriptionDATA";
            this.lblYearDescriptionDATA.Size = new System.Drawing.Size(47, 25);
            this.lblYearDescriptionDATA.TabIndex = 32;
            this.lblYearDescriptionDATA.Text = "N/A";
            // 
            // lblMonthDATA
            // 
            this.lblMonthDATA.AutoSize = true;
            this.lblMonthDATA.Location = new System.Drawing.Point(312, 506);
            this.lblMonthDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMonthDATA.Name = "lblMonthDATA";
            this.lblMonthDATA.Size = new System.Drawing.Size(47, 25);
            this.lblMonthDATA.TabIndex = 31;
            this.lblMonthDATA.Text = "N/A";
            // 
            // lblMaximumTemperatureDATA
            // 
            this.lblMaximumTemperatureDATA.AutoSize = true;
            this.lblMaximumTemperatureDATA.Location = new System.Drawing.Point(312, 546);
            this.lblMaximumTemperatureDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaximumTemperatureDATA.Name = "lblMaximumTemperatureDATA";
            this.lblMaximumTemperatureDATA.Size = new System.Drawing.Size(47, 25);
            this.lblMaximumTemperatureDATA.TabIndex = 30;
            this.lblMaximumTemperatureDATA.Text = "N/A";
            // 
            // lblMinimumTemperatureDATA
            // 
            this.lblMinimumTemperatureDATA.AutoSize = true;
            this.lblMinimumTemperatureDATA.Location = new System.Drawing.Point(312, 590);
            this.lblMinimumTemperatureDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMinimumTemperatureDATA.Name = "lblMinimumTemperatureDATA";
            this.lblMinimumTemperatureDATA.Size = new System.Drawing.Size(47, 25);
            this.lblMinimumTemperatureDATA.TabIndex = 29;
            this.lblMinimumTemperatureDATA.Text = "N/A";
            // 
            // lblHoursOfSunshineDATA
            // 
            this.lblHoursOfSunshineDATA.AutoSize = true;
            this.lblHoursOfSunshineDATA.Location = new System.Drawing.Point(312, 715);
            this.lblHoursOfSunshineDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHoursOfSunshineDATA.Name = "lblHoursOfSunshineDATA";
            this.lblHoursOfSunshineDATA.Size = new System.Drawing.Size(47, 25);
            this.lblHoursOfSunshineDATA.TabIndex = 28;
            this.lblHoursOfSunshineDATA.Text = "N/A";
            // 
            // lblMillimetresOfRainfallDATA
            // 
            this.lblMillimetresOfRainfallDATA.AutoSize = true;
            this.lblMillimetresOfRainfallDATA.Location = new System.Drawing.Point(312, 677);
            this.lblMillimetresOfRainfallDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMillimetresOfRainfallDATA.Name = "lblMillimetresOfRainfallDATA";
            this.lblMillimetresOfRainfallDATA.Size = new System.Drawing.Size(47, 25);
            this.lblMillimetresOfRainfallDATA.TabIndex = 27;
            this.lblMillimetresOfRainfallDATA.Text = "N/A";
            // 
            // lblNumberOfDaysOfAirfrostDATA
            // 
            this.lblNumberOfDaysOfAirfrostDATA.AutoSize = true;
            this.lblNumberOfDaysOfAirfrostDATA.Location = new System.Drawing.Point(312, 633);
            this.lblNumberOfDaysOfAirfrostDATA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfDaysOfAirfrostDATA.Name = "lblNumberOfDaysOfAirfrostDATA";
            this.lblNumberOfDaysOfAirfrostDATA.Size = new System.Drawing.Size(47, 25);
            this.lblNumberOfDaysOfAirfrostDATA.TabIndex = 26;
            this.lblNumberOfDaysOfAirfrostDATA.Text = "N/A";
            // 
            // lblHoursOfSunshine
            // 
            this.lblHoursOfSunshine.AutoSize = true;
            this.lblHoursOfSunshine.Location = new System.Drawing.Point(14, 715);
            this.lblHoursOfSunshine.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHoursOfSunshine.Name = "lblHoursOfSunshine";
            this.lblHoursOfSunshine.Size = new System.Drawing.Size(195, 25);
            this.lblHoursOfSunshine.TabIndex = 25;
            this.lblHoursOfSunshine.Text = "Hours of Sunshine:";
            // 
            // lblMillimetresOfRainfall
            // 
            this.lblMillimetresOfRainfall.AutoSize = true;
            this.lblMillimetresOfRainfall.Location = new System.Drawing.Point(14, 677);
            this.lblMillimetresOfRainfall.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMillimetresOfRainfall.Name = "lblMillimetresOfRainfall";
            this.lblMillimetresOfRainfall.Size = new System.Drawing.Size(223, 25);
            this.lblMillimetresOfRainfall.TabIndex = 24;
            this.lblMillimetresOfRainfall.Text = "Millimetres of Rainfall:";
            // 
            // lblNumberOfDaysOfAirfrost
            // 
            this.lblNumberOfDaysOfAirfrost.AutoSize = true;
            this.lblNumberOfDaysOfAirfrost.Location = new System.Drawing.Point(14, 633);
            this.lblNumberOfDaysOfAirfrost.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfDaysOfAirfrost.Name = "lblNumberOfDaysOfAirfrost";
            this.lblNumberOfDaysOfAirfrost.Size = new System.Drawing.Size(270, 25);
            this.lblNumberOfDaysOfAirfrost.TabIndex = 23;
            this.lblNumberOfDaysOfAirfrost.Text = "Number of Days of Airfrost:";
            // 
            // lblMinimumTemperature
            // 
            this.lblMinimumTemperature.AutoSize = true;
            this.lblMinimumTemperature.Location = new System.Drawing.Point(14, 590);
            this.lblMinimumTemperature.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMinimumTemperature.Name = "lblMinimumTemperature";
            this.lblMinimumTemperature.Size = new System.Drawing.Size(232, 25);
            this.lblMinimumTemperature.TabIndex = 22;
            this.lblMinimumTemperature.Text = "Minimum Temperature:";
            // 
            // lblMaximumTemperature
            // 
            this.lblMaximumTemperature.AutoSize = true;
            this.lblMaximumTemperature.Location = new System.Drawing.Point(14, 546);
            this.lblMaximumTemperature.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaximumTemperature.Name = "lblMaximumTemperature";
            this.lblMaximumTemperature.Size = new System.Drawing.Size(238, 25);
            this.lblMaximumTemperature.TabIndex = 21;
            this.lblMaximumTemperature.Text = "Maximum Temperature:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(14, 506);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(78, 25);
            this.lblMonth.TabIndex = 20;
            this.lblMonth.Text = "Month:";
            // 
            // lblMonthSelected
            // 
            this.lblMonthSelected.AutoSize = true;
            this.lblMonthSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthSelected.Location = new System.Drawing.Point(12, 446);
            this.lblMonthSelected.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMonthSelected.Name = "lblMonthSelected";
            this.lblMonthSelected.Size = new System.Drawing.Size(359, 44);
            this.lblMonthSelected.TabIndex = 19;
            this.lblMonthSelected.Text = "No Month Selected";
            // 
            // lblYearDescription
            // 
            this.lblYearDescription.AutoSize = true;
            this.lblYearDescription.Location = new System.Drawing.Point(14, 377);
            this.lblYearDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYearDescription.Name = "lblYearDescription";
            this.lblYearDescription.Size = new System.Drawing.Size(178, 25);
            this.lblYearDescription.TabIndex = 18;
            this.lblYearDescription.Text = "Year Description:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(14, 337);
            this.lblYear.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(90, 25);
            this.lblYear.TabIndex = 17;
            this.lblYear.Text = "Year ID:";
            // 
            // lblYearSelected
            // 
            this.lblYearSelected.AutoSize = true;
            this.lblYearSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearSelected.Location = new System.Drawing.Point(12, 269);
            this.lblYearSelected.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblYearSelected.Name = "lblYearSelected";
            this.lblYearSelected.Size = new System.Drawing.Size(331, 44);
            this.lblYearSelected.TabIndex = 16;
            this.lblYearSelected.Text = "No Year Selected";
            // 
            // lblNumberOfYearsInLocation
            // 
            this.lblNumberOfYearsInLocation.AutoSize = true;
            this.lblNumberOfYearsInLocation.Location = new System.Drawing.Point(14, 190);
            this.lblNumberOfYearsInLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfYearsInLocation.Name = "lblNumberOfYearsInLocation";
            this.lblNumberOfYearsInLocation.Size = new System.Drawing.Size(229, 25);
            this.lblNumberOfYearsInLocation.TabIndex = 15;
            this.lblNumberOfYearsInLocation.Text = "NO. Years in Location:";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(14, 146);
            this.lblCoordinates.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(134, 25);
            this.lblCoordinates.TabIndex = 14;
            this.lblCoordinates.Text = "Coordinates:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 100);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(97, 25);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address:";
            // 
            // lblLocationLoaded
            // 
            this.lblLocationLoaded.AutoSize = true;
            this.lblLocationLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationLoaded.Location = new System.Drawing.Point(12, 31);
            this.lblLocationLoaded.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLocationLoaded.Name = "lblLocationLoaded";
            this.lblLocationLoaded.Size = new System.Drawing.Size(376, 44);
            this.lblLocationLoaded.TabIndex = 12;
            this.lblLocationLoaded.Text = "No Location Loaded";
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Location = new System.Drawing.Point(1807, 116);
            this.btnShowGraph.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(280, 90);
            this.btnShowGraph.TabIndex = 9;
            this.btnShowGraph.Text = "Show Graph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // lblFileLoaded
            // 
            this.lblFileLoaded.AutoSize = true;
            this.lblFileLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLoaded.Location = new System.Drawing.Point(28, 71);
            this.lblFileLoaded.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFileLoaded.Name = "lblFileLoaded";
            this.lblFileLoaded.Size = new System.Drawing.Size(290, 44);
            this.lblFileLoaded.TabIndex = 10;
            this.lblFileLoaded.Text = "No File Loaded";
            // 
            // lblNumberOfLocationsInFile
            // 
            this.lblNumberOfLocationsInFile.AutoSize = true;
            this.lblNumberOfLocationsInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfLocationsInFile.Location = new System.Drawing.Point(28, 133);
            this.lblNumberOfLocationsInFile.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfLocationsInFile.Name = "lblNumberOfLocationsInFile";
            this.lblNumberOfLocationsInFile.Size = new System.Drawing.Size(483, 44);
            this.lblNumberOfLocationsInFile.TabIndex = 11;
            this.lblNumberOfLocationsInFile.Text = "NO. Locations in File: N/A";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(2120, 116);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(280, 90);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1271);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblNumberOfLocationsInFile);
            this.Controls.Add(this.lblFileLoaded);
            this.Controls.Add(this.btnShowGraph);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxMonths);
            this.Controls.Add(this.groupBoxYears);
            this.Controls.Add(this.groupBoxLocations);
            this.Controls.Add(this.menuStripFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFile;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Met Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.groupBoxLocations.ResumeLayout(false);
            this.groupBoxLocations.PerformLayout();
            this.groupBoxYears.ResumeLayout(false);
            this.groupBoxYears.PerformLayout();
            this.groupBoxMonths.ResumeLayout(false);
            this.groupBoxMonths.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxLocations;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.GroupBox groupBoxYears;
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.GroupBox groupBoxMonths;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.Label lblFileLoaded;
        private System.Windows.Forms.Label lblNumberOfLocationsInFile;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLocationLoaded;
        private System.Windows.Forms.Label lblNumberOfYearsInLocation;
        private System.Windows.Forms.Label lblYearSelected;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblMonthSelected;
        private System.Windows.Forms.Label lblYearDescription;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblNumberOfDaysOfAirfrost;
        private System.Windows.Forms.Label lblMinimumTemperature;
        private System.Windows.Forms.Label lblMaximumTemperature;
        private System.Windows.Forms.Label lblMillimetresOfRainfall;
        private System.Windows.Forms.Label lblHoursOfSunshine;
        private System.Windows.Forms.Label lblCoordinatesDATA;
        private System.Windows.Forms.Label lblNumberOfYearsInLocationDATA;
        private System.Windows.Forms.Label lblYearDATA;
        private System.Windows.Forms.Label lblYearDescriptionDATA;
        private System.Windows.Forms.Label lblMonthDATA;
        private System.Windows.Forms.Label lblMaximumTemperatureDATA;
        private System.Windows.Forms.Label lblMinimumTemperatureDATA;
        private System.Windows.Forms.Label lblHoursOfSunshineDATA;
        private System.Windows.Forms.Label lblMillimetresOfRainfallDATA;
        private System.Windows.Forms.Label lblNumberOfDaysOfAirfrostDATA;
        private System.Windows.Forms.Label lblAddressDATA;
        private System.Windows.Forms.ComboBox comboBoxLocations;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtBoxSearchLocations;
        private System.Windows.Forms.TextBox txtBoxSearchYears;
        private System.Windows.Forms.TextBox txtBoxSearchMonths;
    }
}

