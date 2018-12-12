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
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLocations = new System.Windows.Forms.GroupBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.comboBoxLocations = new System.Windows.Forms.ComboBox();
            this.groupBoxYears = new System.Windows.Forms.GroupBox();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.btnDeleteYear = new System.Windows.Forms.Button();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.groupBoxMonths = new System.Windows.Forms.GroupBox();
            this.btnAddMonth = new System.Windows.Forms.Button();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.btnDeleteMonth = new System.Windows.Forms.Button();
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
            this.menuStripFile.SuspendLayout();
            this.groupBoxLocations.SuspendLayout();
            this.groupBoxYears.SuspendLayout();
            this.groupBoxMonths.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Location = new System.Drawing.Point(6, 310);
            this.btnDeleteLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(184, 32);
            this.btnDeleteLocation.TabIndex = 1;
            this.btnDeleteLocation.Text = "Delete Location";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            // 
            // menuStripFile
            // 
            this.menuStripFile.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStripFile.Size = new System.Drawing.Size(1284, 24);
            this.menuStripFile.TabIndex = 4;
            this.menuStripFile.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxLocations
            // 
            this.groupBoxLocations.Controls.Add(this.btnAddLocation);
            this.groupBoxLocations.Controls.Add(this.btnEditLocation);
            this.groupBoxLocations.Controls.Add(this.btnDeleteLocation);
            this.groupBoxLocations.Controls.Add(this.comboBoxLocations);
            this.groupBoxLocations.Location = new System.Drawing.Point(11, 113);
            this.groupBoxLocations.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxLocations.Name = "groupBoxLocations";
            this.groupBoxLocations.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxLocations.Size = new System.Drawing.Size(195, 424);
            this.groupBoxLocations.TabIndex = 5;
            this.groupBoxLocations.TabStop = false;
            this.groupBoxLocations.Text = "Locations";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(4, 382);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(184, 32);
            this.btnAddLocation.TabIndex = 3;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Location = new System.Drawing.Point(6, 346);
            this.btnEditLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(184, 32);
            this.btnEditLocation.TabIndex = 2;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            // 
            // comboBoxLocations
            // 
            this.comboBoxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxLocations.FormattingEnabled = true;
            this.comboBoxLocations.Location = new System.Drawing.Point(4, 17);
            this.comboBoxLocations.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxLocations.Name = "comboBoxLocations";
            this.comboBoxLocations.Size = new System.Drawing.Size(186, 279);
            this.comboBoxLocations.TabIndex = 0;
            this.comboBoxLocations.SelectedIndexChanged += new System.EventHandler(this.comboBoxLocations_SelectedIndexChanged);
            // 
            // groupBoxYears
            // 
            this.groupBoxYears.Controls.Add(this.btnAddYear);
            this.groupBoxYears.Controls.Add(this.btnEditYear);
            this.groupBoxYears.Controls.Add(this.btnDeleteYear);
            this.groupBoxYears.Controls.Add(this.comboBoxYears);
            this.groupBoxYears.Location = new System.Drawing.Point(231, 113);
            this.groupBoxYears.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxYears.Name = "groupBoxYears";
            this.groupBoxYears.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxYears.Size = new System.Drawing.Size(195, 424);
            this.groupBoxYears.TabIndex = 6;
            this.groupBoxYears.TabStop = false;
            this.groupBoxYears.Text = "Years";
            // 
            // btnAddYear
            // 
            this.btnAddYear.Location = new System.Drawing.Point(4, 382);
            this.btnAddYear.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(184, 32);
            this.btnAddYear.TabIndex = 3;
            this.btnAddYear.Text = "Add Year";
            this.btnAddYear.UseVisualStyleBackColor = true;
            // 
            // btnEditYear
            // 
            this.btnEditYear.Location = new System.Drawing.Point(6, 346);
            this.btnEditYear.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(184, 32);
            this.btnEditYear.TabIndex = 2;
            this.btnEditYear.Text = "Edit Year";
            this.btnEditYear.UseVisualStyleBackColor = true;
            // 
            // btnDeleteYear
            // 
            this.btnDeleteYear.Location = new System.Drawing.Point(6, 310);
            this.btnDeleteYear.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteYear.Name = "btnDeleteYear";
            this.btnDeleteYear.Size = new System.Drawing.Size(184, 32);
            this.btnDeleteYear.TabIndex = 1;
            this.btnDeleteYear.Text = "Delete Year";
            this.btnDeleteYear.UseVisualStyleBackColor = true;
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(4, 17);
            this.comboBoxYears.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(186, 279);
            this.comboBoxYears.TabIndex = 0;
            this.comboBoxYears.SelectedIndexChanged += new System.EventHandler(this.comboBoxYears_SelectedIndexChanged);
            // 
            // groupBoxMonths
            // 
            this.groupBoxMonths.Controls.Add(this.btnAddMonth);
            this.groupBoxMonths.Controls.Add(this.btnEditMonth);
            this.groupBoxMonths.Controls.Add(this.btnDeleteMonth);
            this.groupBoxMonths.Controls.Add(this.comboBoxMonths);
            this.groupBoxMonths.Location = new System.Drawing.Point(456, 113);
            this.groupBoxMonths.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMonths.Name = "groupBoxMonths";
            this.groupBoxMonths.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMonths.Size = new System.Drawing.Size(195, 424);
            this.groupBoxMonths.TabIndex = 7;
            this.groupBoxMonths.TabStop = false;
            this.groupBoxMonths.Text = "Months";
            // 
            // btnAddMonth
            // 
            this.btnAddMonth.Location = new System.Drawing.Point(4, 382);
            this.btnAddMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMonth.Name = "btnAddMonth";
            this.btnAddMonth.Size = new System.Drawing.Size(184, 32);
            this.btnAddMonth.TabIndex = 3;
            this.btnAddMonth.Text = "Add Month";
            this.btnAddMonth.UseVisualStyleBackColor = true;
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Location = new System.Drawing.Point(6, 346);
            this.btnEditMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(184, 32);
            this.btnEditMonth.TabIndex = 2;
            this.btnEditMonth.Text = "Edit Month";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMonth
            // 
            this.btnDeleteMonth.Location = new System.Drawing.Point(6, 310);
            this.btnDeleteMonth.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteMonth.Name = "btnDeleteMonth";
            this.btnDeleteMonth.Size = new System.Drawing.Size(184, 32);
            this.btnDeleteMonth.TabIndex = 1;
            this.btnDeleteMonth.Text = "Delete Month";
            this.btnDeleteMonth.UseVisualStyleBackColor = true;
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Location = new System.Drawing.Point(4, 17);
            this.comboBoxMonths.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(186, 279);
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
            this.groupBoxDetails.Location = new System.Drawing.Point(677, 113);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(523, 424);
            this.groupBoxDetails.TabIndex = 8;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // lblAddressDATA
            // 
            this.lblAddressDATA.AutoSize = true;
            this.lblAddressDATA.Location = new System.Drawing.Point(153, 52);
            this.lblAddressDATA.Name = "lblAddressDATA";
            this.lblAddressDATA.Size = new System.Drawing.Size(27, 13);
            this.lblAddressDATA.TabIndex = 36;
            this.lblAddressDATA.Text = "N/A";
            // 
            // lblCoordinatesDATA
            // 
            this.lblCoordinatesDATA.AutoSize = true;
            this.lblCoordinatesDATA.Location = new System.Drawing.Point(156, 76);
            this.lblCoordinatesDATA.Name = "lblCoordinatesDATA";
            this.lblCoordinatesDATA.Size = new System.Drawing.Size(27, 13);
            this.lblCoordinatesDATA.TabIndex = 35;
            this.lblCoordinatesDATA.Text = "N/A";
            // 
            // lblNumberOfYearsInLocationDATA
            // 
            this.lblNumberOfYearsInLocationDATA.AutoSize = true;
            this.lblNumberOfYearsInLocationDATA.Location = new System.Drawing.Point(156, 99);
            this.lblNumberOfYearsInLocationDATA.Name = "lblNumberOfYearsInLocationDATA";
            this.lblNumberOfYearsInLocationDATA.Size = new System.Drawing.Size(27, 13);
            this.lblNumberOfYearsInLocationDATA.TabIndex = 34;
            this.lblNumberOfYearsInLocationDATA.Text = "N/A";
            // 
            // lblYearDATA
            // 
            this.lblYearDATA.AutoSize = true;
            this.lblYearDATA.Location = new System.Drawing.Point(156, 175);
            this.lblYearDATA.Name = "lblYearDATA";
            this.lblYearDATA.Size = new System.Drawing.Size(27, 13);
            this.lblYearDATA.TabIndex = 33;
            this.lblYearDATA.Text = "N/A";
            // 
            // lblYearDescriptionDATA
            // 
            this.lblYearDescriptionDATA.AutoSize = true;
            this.lblYearDescriptionDATA.Location = new System.Drawing.Point(156, 196);
            this.lblYearDescriptionDATA.Name = "lblYearDescriptionDATA";
            this.lblYearDescriptionDATA.Size = new System.Drawing.Size(27, 13);
            this.lblYearDescriptionDATA.TabIndex = 32;
            this.lblYearDescriptionDATA.Text = "N/A";
            // 
            // lblMonthDATA
            // 
            this.lblMonthDATA.AutoSize = true;
            this.lblMonthDATA.Location = new System.Drawing.Point(156, 263);
            this.lblMonthDATA.Name = "lblMonthDATA";
            this.lblMonthDATA.Size = new System.Drawing.Size(27, 13);
            this.lblMonthDATA.TabIndex = 31;
            this.lblMonthDATA.Text = "N/A";
            // 
            // lblMaximumTemperatureDATA
            // 
            this.lblMaximumTemperatureDATA.AutoSize = true;
            this.lblMaximumTemperatureDATA.Location = new System.Drawing.Point(156, 284);
            this.lblMaximumTemperatureDATA.Name = "lblMaximumTemperatureDATA";
            this.lblMaximumTemperatureDATA.Size = new System.Drawing.Size(27, 13);
            this.lblMaximumTemperatureDATA.TabIndex = 30;
            this.lblMaximumTemperatureDATA.Text = "N/A";
            // 
            // lblMinimumTemperatureDATA
            // 
            this.lblMinimumTemperatureDATA.AutoSize = true;
            this.lblMinimumTemperatureDATA.Location = new System.Drawing.Point(156, 307);
            this.lblMinimumTemperatureDATA.Name = "lblMinimumTemperatureDATA";
            this.lblMinimumTemperatureDATA.Size = new System.Drawing.Size(27, 13);
            this.lblMinimumTemperatureDATA.TabIndex = 29;
            this.lblMinimumTemperatureDATA.Text = "N/A";
            // 
            // lblHoursOfSunshineDATA
            // 
            this.lblHoursOfSunshineDATA.AutoSize = true;
            this.lblHoursOfSunshineDATA.Location = new System.Drawing.Point(156, 372);
            this.lblHoursOfSunshineDATA.Name = "lblHoursOfSunshineDATA";
            this.lblHoursOfSunshineDATA.Size = new System.Drawing.Size(27, 13);
            this.lblHoursOfSunshineDATA.TabIndex = 28;
            this.lblHoursOfSunshineDATA.Text = "N/A";
            // 
            // lblMillimetresOfRainfallDATA
            // 
            this.lblMillimetresOfRainfallDATA.AutoSize = true;
            this.lblMillimetresOfRainfallDATA.Location = new System.Drawing.Point(156, 352);
            this.lblMillimetresOfRainfallDATA.Name = "lblMillimetresOfRainfallDATA";
            this.lblMillimetresOfRainfallDATA.Size = new System.Drawing.Size(27, 13);
            this.lblMillimetresOfRainfallDATA.TabIndex = 27;
            this.lblMillimetresOfRainfallDATA.Text = "N/A";
            // 
            // lblNumberOfDaysOfAirfrostDATA
            // 
            this.lblNumberOfDaysOfAirfrostDATA.AutoSize = true;
            this.lblNumberOfDaysOfAirfrostDATA.Location = new System.Drawing.Point(156, 329);
            this.lblNumberOfDaysOfAirfrostDATA.Name = "lblNumberOfDaysOfAirfrostDATA";
            this.lblNumberOfDaysOfAirfrostDATA.Size = new System.Drawing.Size(27, 13);
            this.lblNumberOfDaysOfAirfrostDATA.TabIndex = 26;
            this.lblNumberOfDaysOfAirfrostDATA.Text = "N/A";
            // 
            // lblHoursOfSunshine
            // 
            this.lblHoursOfSunshine.AutoSize = true;
            this.lblHoursOfSunshine.Location = new System.Drawing.Point(7, 372);
            this.lblHoursOfSunshine.Name = "lblHoursOfSunshine";
            this.lblHoursOfSunshine.Size = new System.Drawing.Size(97, 13);
            this.lblHoursOfSunshine.TabIndex = 25;
            this.lblHoursOfSunshine.Text = "Hours of Sunshine:";
            // 
            // lblMillimetresOfRainfall
            // 
            this.lblMillimetresOfRainfall.AutoSize = true;
            this.lblMillimetresOfRainfall.Location = new System.Drawing.Point(7, 352);
            this.lblMillimetresOfRainfall.Name = "lblMillimetresOfRainfall";
            this.lblMillimetresOfRainfall.Size = new System.Drawing.Size(108, 13);
            this.lblMillimetresOfRainfall.TabIndex = 24;
            this.lblMillimetresOfRainfall.Text = "Millimetres of Rainfall:";
            // 
            // lblNumberOfDaysOfAirfrost
            // 
            this.lblNumberOfDaysOfAirfrost.AutoSize = true;
            this.lblNumberOfDaysOfAirfrost.Location = new System.Drawing.Point(7, 329);
            this.lblNumberOfDaysOfAirfrost.Name = "lblNumberOfDaysOfAirfrost";
            this.lblNumberOfDaysOfAirfrost.Size = new System.Drawing.Size(133, 13);
            this.lblNumberOfDaysOfAirfrost.TabIndex = 23;
            this.lblNumberOfDaysOfAirfrost.Text = "Number of Days of Airfrost:";
            // 
            // lblMinimumTemperature
            // 
            this.lblMinimumTemperature.AutoSize = true;
            this.lblMinimumTemperature.Location = new System.Drawing.Point(7, 307);
            this.lblMinimumTemperature.Name = "lblMinimumTemperature";
            this.lblMinimumTemperature.Size = new System.Drawing.Size(114, 13);
            this.lblMinimumTemperature.TabIndex = 22;
            this.lblMinimumTemperature.Text = "Minimum Temperature:";
            // 
            // lblMaximumTemperature
            // 
            this.lblMaximumTemperature.AutoSize = true;
            this.lblMaximumTemperature.Location = new System.Drawing.Point(7, 284);
            this.lblMaximumTemperature.Name = "lblMaximumTemperature";
            this.lblMaximumTemperature.Size = new System.Drawing.Size(117, 13);
            this.lblMaximumTemperature.TabIndex = 21;
            this.lblMaximumTemperature.Text = "Maximum Temperature:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(7, 263);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(40, 13);
            this.lblMonth.TabIndex = 20;
            this.lblMonth.Text = "Month:";
            // 
            // lblMonthSelected
            // 
            this.lblMonthSelected.AutoSize = true;
            this.lblMonthSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthSelected.Location = new System.Drawing.Point(6, 232);
            this.lblMonthSelected.Name = "lblMonthSelected";
            this.lblMonthSelected.Size = new System.Drawing.Size(189, 24);
            this.lblMonthSelected.TabIndex = 19;
            this.lblMonthSelected.Text = "No Month Selected";
            // 
            // lblYearDescription
            // 
            this.lblYearDescription.AutoSize = true;
            this.lblYearDescription.Location = new System.Drawing.Point(7, 196);
            this.lblYearDescription.Name = "lblYearDescription";
            this.lblYearDescription.Size = new System.Drawing.Size(88, 13);
            this.lblYearDescription.TabIndex = 18;
            this.lblYearDescription.Text = "Year Description:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(7, 175);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(46, 13);
            this.lblYear.TabIndex = 17;
            this.lblYear.Text = "Year ID:";
            // 
            // lblYearSelected
            // 
            this.lblYearSelected.AutoSize = true;
            this.lblYearSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearSelected.Location = new System.Drawing.Point(6, 140);
            this.lblYearSelected.Name = "lblYearSelected";
            this.lblYearSelected.Size = new System.Drawing.Size(174, 24);
            this.lblYearSelected.TabIndex = 16;
            this.lblYearSelected.Text = "No Year Selected";
            // 
            // lblNumberOfYearsInLocation
            // 
            this.lblNumberOfYearsInLocation.AutoSize = true;
            this.lblNumberOfYearsInLocation.Location = new System.Drawing.Point(7, 99);
            this.lblNumberOfYearsInLocation.Name = "lblNumberOfYearsInLocation";
            this.lblNumberOfYearsInLocation.Size = new System.Drawing.Size(114, 13);
            this.lblNumberOfYearsInLocation.TabIndex = 15;
            this.lblNumberOfYearsInLocation.Text = "NO. Years in Location:";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Location = new System.Drawing.Point(7, 76);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(66, 13);
            this.lblCoordinates.TabIndex = 14;
            this.lblCoordinates.Text = "Coordinates:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 52);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address:";
            // 
            // lblLocationLoaded
            // 
            this.lblLocationLoaded.AutoSize = true;
            this.lblLocationLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationLoaded.Location = new System.Drawing.Point(6, 16);
            this.lblLocationLoaded.Name = "lblLocationLoaded";
            this.lblLocationLoaded.Size = new System.Drawing.Size(198, 24);
            this.lblLocationLoaded.TabIndex = 12;
            this.lblLocationLoaded.Text = "No Location Loaded";
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.Location = new System.Drawing.Point(1060, 60);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(140, 47);
            this.btnShowGraph.TabIndex = 9;
            this.btnShowGraph.Text = "Show Graph";
            this.btnShowGraph.UseVisualStyleBackColor = true;
            // 
            // lblFileLoaded
            // 
            this.lblFileLoaded.AutoSize = true;
            this.lblFileLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileLoaded.Location = new System.Drawing.Point(14, 37);
            this.lblFileLoaded.Name = "lblFileLoaded";
            this.lblFileLoaded.Size = new System.Drawing.Size(154, 24);
            this.lblFileLoaded.TabIndex = 10;
            this.lblFileLoaded.Text = "No File Loaded";
            // 
            // lblNumberOfLocationsInFile
            // 
            this.lblNumberOfLocationsInFile.AutoSize = true;
            this.lblNumberOfLocationsInFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfLocationsInFile.Location = new System.Drawing.Point(14, 69);
            this.lblNumberOfLocationsInFile.Name = "lblNumberOfLocationsInFile";
            this.lblNumberOfLocationsInFile.Size = new System.Drawing.Size(253, 24);
            this.lblNumberOfLocationsInFile.TabIndex = 11;
            this.lblNumberOfLocationsInFile.Text = "NO. Locations in File: N/A";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
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
            this.Name = "frmMain";
            this.Text = "MET Application";
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.groupBoxLocations.ResumeLayout(false);
            this.groupBoxYears.ResumeLayout(false);
            this.groupBoxMonths.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxLocations;
        private System.Windows.Forms.ComboBox comboBoxLocations;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.GroupBox groupBoxYears;
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.Button btnDeleteYear;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.GroupBox groupBoxMonths;
        private System.Windows.Forms.Button btnAddMonth;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.Button btnDeleteMonth;
        private System.Windows.Forms.ComboBox comboBoxMonths;
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
        private System.Windows.Forms.Label lblAddressDATA;
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
    }
}

