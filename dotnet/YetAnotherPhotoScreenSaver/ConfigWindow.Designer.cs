﻿namespace Org.Kuhn.Yapss {
    partial class ConfigWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Button OpenLogButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigWindow));
            this.speedtrackbar = new EConTech.Windows.MACUI.MACTrackBar();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.previewButton = new System.Windows.Forms.Button();
            this.flickrCheckbox = new System.Windows.Forms.CheckBox();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flickrPanel = new System.Windows.Forms.Panel();
            this.tagLogicDropdown = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.diskCheckBox = new System.Windows.Forms.CheckBox();
            this.diskPanel = new System.Windows.Forms.Panel();
            this.EnableFileFiltercheckBox = new System.Windows.Forms.CheckBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.comicstyleDropDown = new System.Windows.Forms.ComboBox();
            this.lblComicStyle = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.xCountNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelspeed = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lableBackground = new System.Windows.Forms.Label();
            this.bgColorDropdown = new System.Windows.Forms.ComboBox();
            this.ImageStyledropdown = new System.Windows.Forms.ComboBox();
            this.labelimagestyle = new System.Windows.Forms.Label();
            this.transitionsPanel = new System.Windows.Forms.Panel();
            this.transitionoutdropdown = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.transitionindropdown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTransitions = new System.Windows.Forms.Label();
            this.DebugCheckBox = new System.Windows.Forms.CheckBox();
            this.labelslow = new System.Windows.Forms.Label();
            this.labelmedium = new System.Windows.Forms.Label();
            this.labelfast = new System.Windows.Forms.Label();
            this.versionlabel = new System.Windows.Forms.Label();
            OpenLogButton = new System.Windows.Forms.Button();
            this.flickrPanel.SuspendLayout();
            this.diskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCountNumUpDown)).BeginInit();
            this.transitionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenLogButton
            // 
            OpenLogButton.Location = new System.Drawing.Point(206, 567);
            OpenLogButton.Name = "OpenLogButton";
            OpenLogButton.Size = new System.Drawing.Size(62, 23);
            OpenLogButton.TabIndex = 30;
            OpenLogButton.Text = "Open Log";
            OpenLogButton.UseVisualStyleBackColor = true;
            OpenLogButton.Click += new System.EventHandler(this.OpenLogButton_Click);
            // 
            // speedtrackbar
            // 
            this.speedtrackbar.BackColor = System.Drawing.Color.Transparent;
            this.speedtrackbar.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.speedtrackbar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedtrackbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.speedtrackbar.IndentHeight = 6;
            this.speedtrackbar.LargeChange = 5;
            this.speedtrackbar.Location = new System.Drawing.Point(81, 72);
            this.speedtrackbar.Maximum = 100;
            this.speedtrackbar.Minimum = 0;
            this.speedtrackbar.Name = "speedtrackbar";
            this.speedtrackbar.Size = new System.Drawing.Size(318, 34);
            this.speedtrackbar.TabIndex = 31;
            this.speedtrackbar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.speedtrackbar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.speedtrackbar.TickFrequency = 25;
            this.speedtrackbar.TickHeight = 5;
            this.speedtrackbar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.speedtrackbar.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.speedtrackbar.TrackerSize = new System.Drawing.Size(16, 16);
            this.speedtrackbar.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.speedtrackbar.TrackLineHeight = 3;
            this.speedtrackbar.Value = 1;
            this.speedtrackbar.ValueChanged += new EConTech.Windows.MACUI.ValueChangedHandler(this.speedtrackbar_ValueChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(255, 537);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 25);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(174, 537);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 25);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(94, 537);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(75, 25);
            this.previewButton.TabIndex = 2;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // flickrCheckbox
            // 
            this.flickrCheckbox.AutoSize = true;
            this.flickrCheckbox.Location = new System.Drawing.Point(6, 180);
            this.flickrCheckbox.Name = "flickrCheckbox";
            this.flickrCheckbox.Size = new System.Drawing.Size(207, 17);
            this.flickrCheckbox.TabIndex = 4;
            this.flickrCheckbox.Text = "Display photos downloaded from Flickr";
            this.flickrCheckbox.UseVisualStyleBackColor = true;
            this.flickrCheckbox.CheckedChanged += new System.EventHandler(this.flickrCheckbox_CheckedChanged);
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Location = new System.Drawing.Point(13, 16);
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(344, 20);
            this.tagsTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search for tags";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter one or more tags separated by commas. For example, \"portland, nature, party" +
                "\". This field may be left blank.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Only display photos from the following user";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(13, 164);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(422, 20);
            this.userIdTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(3, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "This option can be used to show photos from only yourself or a family member. Ent" +
                "er their user name here. Leave this field blank to show photos from all users.";
            // 
            // flickrPanel
            // 
            this.flickrPanel.Controls.Add(this.tagLogicDropdown);
            this.flickrPanel.Controls.Add(this.label11);
            this.flickrPanel.Controls.Add(this.textTextBox);
            this.flickrPanel.Controls.Add(this.label10);
            this.flickrPanel.Controls.Add(this.tagsTextBox);
            this.flickrPanel.Controls.Add(this.userIdTextBox);
            this.flickrPanel.Controls.Add(this.label1);
            this.flickrPanel.Controls.Add(this.label4);
            this.flickrPanel.Controls.Add(this.label2);
            this.flickrPanel.Controls.Add(this.label3);
            this.flickrPanel.Location = new System.Drawing.Point(6, 196);
            this.flickrPanel.Name = "flickrPanel";
            this.flickrPanel.Size = new System.Drawing.Size(438, 221);
            this.flickrPanel.TabIndex = 12;
            // 
            // tagLogicDropdown
            // 
            this.tagLogicDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tagLogicDropdown.FormattingEnabled = true;
            this.tagLogicDropdown.Items.AddRange(new object[] {
            "Match any",
            "Match all"});
            this.tagLogicDropdown.Location = new System.Drawing.Point(363, 15);
            this.tagLogicDropdown.Name = "tagLogicDropdown";
            this.tagLogicDropdown.Size = new System.Drawing.Size(72, 21);
            this.tagLogicDropdown.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(3, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(432, 34);
            this.label11.TabIndex = 14;
            this.label11.Text = "A free text search. Photos who\'s title, description or tags contain the text will" +
                " be displayed. May be left blank.";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(13, 91);
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(422, 20);
            this.textTextBox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Free text search";
            // 
            // diskCheckBox
            // 
            this.diskCheckBox.AutoSize = true;
            this.diskCheckBox.Location = new System.Drawing.Point(9, 423);
            this.diskCheckBox.Name = "diskCheckBox";
            this.diskCheckBox.Size = new System.Drawing.Size(240, 17);
            this.diskCheckBox.TabIndex = 13;
            this.diskCheckBox.Text = "Display photos and comics from the local disk";
            this.diskCheckBox.UseVisualStyleBackColor = true;
            this.diskCheckBox.CheckedChanged += new System.EventHandler(this.diskCheckBox_CheckedChanged);
            // 
            // diskPanel
            // 
            this.diskPanel.Controls.Add(this.EnableFileFiltercheckBox);
            this.diskPanel.Controls.Add(this.fileNameTextBox);
            this.diskPanel.Controls.Add(this.comicstyleDropDown);
            this.diskPanel.Controls.Add(this.lblComicStyle);
            this.diskPanel.Controls.Add(this.browseButton);
            this.diskPanel.Controls.Add(this.pathTextBox);
            this.diskPanel.Controls.Add(this.label5);
            this.diskPanel.Location = new System.Drawing.Point(6, 443);
            this.diskPanel.Name = "diskPanel";
            this.diskPanel.Size = new System.Drawing.Size(438, 88);
            this.diskPanel.TabIndex = 14;
            // 
            // EnableFileFiltercheckBox
            // 
            this.EnableFileFiltercheckBox.AutoSize = true;
            this.EnableFileFiltercheckBox.Location = new System.Drawing.Point(13, 42);
            this.EnableFileFiltercheckBox.Name = "EnableFileFiltercheckBox";
            this.EnableFileFiltercheckBox.Size = new System.Drawing.Size(208, 17);
            this.EnableFileFiltercheckBox.TabIndex = 24;
            this.EnableFileFiltercheckBox.Text = "Limit files to those with this in the name";
            this.EnableFileFiltercheckBox.UseVisualStyleBackColor = true;
            this.EnableFileFiltercheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Enabled = false;
            this.fileNameTextBox.Location = new System.Drawing.Point(13, 59);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.fileNameTextBox.TabIndex = 23;
            // 
            // comicstyleDropDown
            // 
            this.comicstyleDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comicstyleDropDown.FormattingEnabled = true;
            this.comicstyleDropDown.Items.AddRange(new object[] {
            "CoversOnly",
            "AnyPage",
            "Entire"});
            this.comicstyleDropDown.Location = new System.Drawing.Point(323, 56);
            this.comicstyleDropDown.Name = "comicstyleDropDown";
            this.comicstyleDropDown.Size = new System.Drawing.Size(112, 21);
            this.comicstyleDropDown.TabIndex = 22;
            // 
            // lblComicStyle
            // 
            this.lblComicStyle.AutoSize = true;
            this.lblComicStyle.Location = new System.Drawing.Point(255, 59);
            this.lblComicStyle.Name = "lblComicStyle";
            this.lblComicStyle.Size = new System.Drawing.Size(62, 13);
            this.lblComicStyle.TabIndex = 21;
            this.lblComicStyle.Text = "Comic Style";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(360, 16);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 16;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(13, 16);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(344, 20);
            this.pathTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Use photos and comics in the folders (includes subfolders)";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // xCountNumUpDown
            // 
            this.xCountNumUpDown.Location = new System.Drawing.Point(369, 7);
            this.xCountNumUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.xCountNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xCountNumUpDown.Name = "xCountNumUpDown";
            this.xCountNumUpDown.Size = new System.Drawing.Size(49, 20);
            this.xCountNumUpDown.TabIndex = 15;
            this.xCountNumUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of small images to display in the horizontal direction";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(445, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Controls the number of images visible on the screen at one time. Adjust this sett" +
                "ing depending on your monitor size and eyesight.";
            // 
            // labelspeed
            // 
            this.labelspeed.AutoSize = true;
            this.labelspeed.Location = new System.Drawing.Point(6, 76);
            this.labelspeed.Name = "labelspeed";
            this.labelspeed.Size = new System.Drawing.Size(38, 13);
            this.labelspeed.TabIndex = 18;
            this.labelspeed.Text = "Speed";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "This software is free and open source.";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(64, 590);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(335, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://code.google.com/p/yetanotherphotoscreensavercomicedition/";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lableBackground
            // 
            this.lableBackground.AutoSize = true;
            this.lableBackground.Location = new System.Drawing.Point(73, 116);
            this.lableBackground.Name = "lableBackground";
            this.lableBackground.Size = new System.Drawing.Size(65, 13);
            this.lableBackground.TabIndex = 23;
            this.lableBackground.Text = "Background";
            // 
            // bgColorDropdown
            // 
            this.bgColorDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bgColorDropdown.FormattingEnabled = true;
            this.bgColorDropdown.Items.AddRange(new object[] {
            "Black",
            "White",
            "Random"});
            this.bgColorDropdown.Location = new System.Drawing.Point(141, 112);
            this.bgColorDropdown.Name = "bgColorDropdown";
            this.bgColorDropdown.Size = new System.Drawing.Size(82, 21);
            this.bgColorDropdown.TabIndex = 24;
            // 
            // ImageStyledropdown
            // 
            this.ImageStyledropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageStyledropdown.FormattingEnabled = true;
            this.ImageStyledropdown.Items.AddRange(new object[] {
            "Whole",
            "CenterFill",
            "Random"});
            this.ImageStyledropdown.Location = new System.Drawing.Point(291, 112);
            this.ImageStyledropdown.Name = "ImageStyledropdown";
            this.ImageStyledropdown.Size = new System.Drawing.Size(72, 21);
            this.ImageStyledropdown.TabIndex = 26;
            // 
            // labelimagestyle
            // 
            this.labelimagestyle.AutoSize = true;
            this.labelimagestyle.Location = new System.Drawing.Point(231, 116);
            this.labelimagestyle.Name = "labelimagestyle";
            this.labelimagestyle.Size = new System.Drawing.Size(62, 13);
            this.labelimagestyle.TabIndex = 25;
            this.labelimagestyle.Text = "Image Style";
            // 
            // transitionsPanel
            // 
            this.transitionsPanel.Controls.Add(this.transitionoutdropdown);
            this.transitionsPanel.Controls.Add(this.label12);
            this.transitionsPanel.Controls.Add(this.transitionindropdown);
            this.transitionsPanel.Controls.Add(this.label8);
            this.transitionsPanel.Location = new System.Drawing.Point(81, 146);
            this.transitionsPanel.Name = "transitionsPanel";
            this.transitionsPanel.Size = new System.Drawing.Size(282, 31);
            this.transitionsPanel.TabIndex = 27;
            // 
            // transitionoutdropdown
            // 
            this.transitionoutdropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transitionoutdropdown.FormattingEnabled = true;
            this.transitionoutdropdown.Items.AddRange(new object[] {
            "None",
            "Fade",
            "PageTurn",
            "Zoom"});
            this.transitionoutdropdown.Location = new System.Drawing.Point(61, 7);
            this.transitionoutdropdown.Name = "transitionoutdropdown";
            this.transitionoutdropdown.Size = new System.Drawing.Size(94, 21);
            this.transitionoutdropdown.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Out";
            // 
            // transitionindropdown
            // 
            this.transitionindropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transitionindropdown.FormattingEnabled = true;
            this.transitionindropdown.Items.AddRange(new object[] {
            "None",
            "Fade",
            "PageTurn",
            "Zoom"});
            this.transitionindropdown.Location = new System.Drawing.Point(179, 7);
            this.transitionindropdown.Name = "transitionindropdown";
            this.transitionindropdown.Size = new System.Drawing.Size(94, 21);
            this.transitionindropdown.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "In";
            // 
            // labelTransitions
            // 
            this.labelTransitions.AutoSize = true;
            this.labelTransitions.Location = new System.Drawing.Point(80, 143);
            this.labelTransitions.Name = "labelTransitions";
            this.labelTransitions.Size = new System.Drawing.Size(58, 13);
            this.labelTransitions.TabIndex = 28;
            this.labelTransitions.Text = "Transitions";
            // 
            // DebugCheckBox
            // 
            this.DebugCheckBox.AutoSize = true;
            this.DebugCheckBox.Location = new System.Drawing.Point(94, 571);
            this.DebugCheckBox.Name = "DebugCheckBox";
            this.DebugCheckBox.Size = new System.Drawing.Size(99, 17);
            this.DebugCheckBox.TabIndex = 29;
            this.DebugCheckBox.Text = "Debug Logging";
            this.DebugCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelslow
            // 
            this.labelslow.AutoSize = true;
            this.labelslow.Location = new System.Drawing.Point(74, 60);
            this.labelslow.Name = "labelslow";
            this.labelslow.Size = new System.Drawing.Size(30, 13);
            this.labelslow.TabIndex = 32;
            this.labelslow.Text = "Slow";
            // 
            // labelmedium
            // 
            this.labelmedium.AutoSize = true;
            this.labelmedium.Location = new System.Drawing.Point(224, 60);
            this.labelmedium.Name = "labelmedium";
            this.labelmedium.Size = new System.Drawing.Size(44, 13);
            this.labelmedium.TabIndex = 33;
            this.labelmedium.Text = "Medium";
            // 
            // labelfast
            // 
            this.labelfast.AutoSize = true;
            this.labelfast.Location = new System.Drawing.Point(378, 60);
            this.labelfast.Name = "labelfast";
            this.labelfast.Size = new System.Drawing.Size(27, 13);
            this.labelfast.TabIndex = 34;
            this.labelfast.Text = "Fast";
            // 
            // versionlabel
            // 
            this.versionlabel.AutoSize = true;
            this.versionlabel.Location = new System.Drawing.Point(168, 618);
            this.versionlabel.Name = "versionlabel";
            this.versionlabel.Size = new System.Drawing.Size(45, 13);
            this.versionlabel.TabIndex = 35;
            this.versionlabel.Text = "Version:";
            // 
            // ConfigWindow
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(456, 640);
            this.Controls.Add(this.versionlabel);
            this.Controls.Add(this.labelfast);
            this.Controls.Add(this.labelmedium);
            this.Controls.Add(this.labelslow);
            this.Controls.Add(this.speedtrackbar);
            this.Controls.Add(this.labelTransitions);
            this.Controls.Add(OpenLogButton);
            this.Controls.Add(this.DebugCheckBox);
            this.Controls.Add(this.transitionsPanel);
            this.Controls.Add(this.ImageStyledropdown);
            this.Controls.Add(this.labelimagestyle);
            this.Controls.Add(this.bgColorDropdown);
            this.Controls.Add(this.lableBackground);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelspeed);
            this.Controls.Add(this.xCountNumUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.diskPanel);
            this.Controls.Add(this.flickrCheckbox);
            this.Controls.Add(this.flickrPanel);
            this.Controls.Add(this.diskCheckBox);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigWindow";
            this.ShowInTaskbar = false;
            this.Text = "YetAnotherPhotoScreenSaver Comic Edition --- Configuration";
            this.Load += new System.EventHandler(this.ConfigWindow_Load);
            this.flickrPanel.ResumeLayout(false);
            this.flickrPanel.PerformLayout();
            this.diskPanel.ResumeLayout(false);
            this.diskPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xCountNumUpDown)).EndInit();
            this.transitionsPanel.ResumeLayout(false);
            this.transitionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblComicStyle;
        private System.Windows.Forms.ComboBox comicstyleDropDown;

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.CheckBox flickrCheckbox;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel flickrPanel;
        private System.Windows.Forms.CheckBox diskCheckBox;
        private System.Windows.Forms.Panel diskPanel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.NumericUpDown xCountNumUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelspeed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tagLogicDropdown;
        private System.Windows.Forms.Label lableBackground;
        private System.Windows.Forms.ComboBox bgColorDropdown;
        private System.Windows.Forms.ComboBox ImageStyledropdown;
        private System.Windows.Forms.Label labelimagestyle;
        private System.Windows.Forms.Panel transitionsPanel;
        private System.Windows.Forms.ComboBox transitionoutdropdown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox transitionindropdown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTransitions;
        private System.Windows.Forms.CheckBox DebugCheckBox;
        private System.Windows.Forms.Label labelslow;
        private System.Windows.Forms.Label labelmedium;
        private System.Windows.Forms.Label labelfast;
        private EConTech.Windows.MACUI.MACTrackBar speedtrackbar;
        private System.Windows.Forms.CheckBox EnableFileFiltercheckBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Label versionlabel;
    }
}