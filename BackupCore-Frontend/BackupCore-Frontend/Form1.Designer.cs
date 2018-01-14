namespace BackupCore_Frontend
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pickFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.copiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.archiveYes = new System.Windows.Forms.RadioButton();
            this.archiveNo = new System.Windows.Forms.RadioButton();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.comparatorComboBox = new System.Windows.Forms.ComboBox();
            this.profileNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.pickConfigDialog = new System.Windows.Forms.OpenFileDialog();
            this.sourcesTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveConfigDialog = new System.Windows.Forms.SaveFileDialog();
            this.destinationsTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.profilesListBox = new System.Windows.Forms.ListBox();
            this.startBackupButton = new System.Windows.Forms.Button();
            this.consoleOutputTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.copiesNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickFileButton
            // 
            this.pickFileButton.Location = new System.Drawing.Point(12, 6);
            this.pickFileButton.Name = "pickFileButton";
            this.pickFileButton.Size = new System.Drawing.Size(47, 23);
            this.pickFileButton.TabIndex = 0;
            this.pickFileButton.Text = "Import";
            this.pickFileButton.UseVisualStyleBackColor = true;
            this.pickFileButton.Click += new System.EventHandler(this.pickFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Profile name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comparator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. of old copies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Archive?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // copiesNumericUpDown
            // 
            this.copiesNumericUpDown.Location = new System.Drawing.Point(315, 86);
            this.copiesNumericUpDown.Name = "copiesNumericUpDown";
            this.copiesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.copiesNumericUpDown.TabIndex = 7;
            this.copiesNumericUpDown.ValueChanged += new System.EventHandler(this.copiesNumericUpDown_ValueChanged);
            // 
            // archiveYes
            // 
            this.archiveYes.AutoSize = true;
            this.archiveYes.Location = new System.Drawing.Point(1, 0);
            this.archiveYes.Name = "archiveYes";
            this.archiveYes.Size = new System.Drawing.Size(43, 17);
            this.archiveYes.TabIndex = 8;
            this.archiveYes.Text = "Yes";
            this.archiveYes.UseVisualStyleBackColor = true;
            this.archiveYes.CheckedChanged += new System.EventHandler(this.archiveYes_CheckedChanged);
            // 
            // archiveNo
            // 
            this.archiveNo.AutoSize = true;
            this.archiveNo.Checked = true;
            this.archiveNo.Location = new System.Drawing.Point(50, 0);
            this.archiveNo.Name = "archiveNo";
            this.archiveNo.Size = new System.Drawing.Size(39, 17);
            this.archiveNo.TabIndex = 9;
            this.archiveNo.TabStop = true;
            this.archiveNo.Text = "No";
            this.archiveNo.UseVisualStyleBackColor = true;
            this.archiveNo.CheckedChanged += new System.EventHandler(this.archiveNo_CheckedChanged);
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Database",
            "Simple"});
            this.modeComboBox.Location = new System.Drawing.Point(314, 32);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(121, 21);
            this.modeComboBox.TabIndex = 10;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // comparatorComboBox
            // 
            this.comparatorComboBox.FormattingEnabled = true;
            this.comparatorComboBox.Items.AddRange(new object[] {
            "By write date",
            "By hash"});
            this.comparatorComboBox.Location = new System.Drawing.Point(314, 59);
            this.comparatorComboBox.Name = "comparatorComboBox";
            this.comparatorComboBox.Size = new System.Drawing.Size(121, 21);
            this.comparatorComboBox.TabIndex = 11;
            this.comparatorComboBox.SelectedIndexChanged += new System.EventHandler(this.comparatorComboBox_SelectedIndexChanged);
            // 
            // profileNameTextBox
            // 
            this.profileNameTextBox.Location = new System.Drawing.Point(314, 6);
            this.profileNameTextBox.Name = "profileNameTextBox";
            this.profileNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.profileNameTextBox.TabIndex = 13;
            this.profileNameTextBox.TextChanged += new System.EventHandler(this.profileNameTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(314, 135);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBox.TabIndex = 14;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(276, 162);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(159, 23);
            this.submitButton.TabIndex = 15;
            this.submitButton.Text = "Save currentProfile";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // pickConfigDialog
            // 
            this.pickConfigDialog.DefaultExt = "ini";
            this.pickConfigDialog.FileName = "config.ini";
            // 
            // sourcesTextBox
            // 
            this.sourcesTextBox.Location = new System.Drawing.Point(441, 32);
            this.sourcesTextBox.Multiline = true;
            this.sourcesTextBox.Name = "sourcesTextBox";
            this.sourcesTextBox.Size = new System.Drawing.Size(200, 153);
            this.sourcesTextBox.TabIndex = 16;
            this.sourcesTextBox.TextChanged += new System.EventHandler(this.sourcesTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sources";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.archiveNo);
            this.panel1.Controls.Add(this.archiveYes);
            this.panel1.Location = new System.Drawing.Point(314, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 19);
            this.panel1.TabIndex = 18;
            // 
            // destinationsTextBox
            // 
            this.destinationsTextBox.Location = new System.Drawing.Point(647, 32);
            this.destinationsTextBox.Multiline = true;
            this.destinationsTextBox.Name = "destinationsTextBox";
            this.destinationsTextBox.Size = new System.Drawing.Size(200, 153);
            this.destinationsTextBox.TabIndex = 19;
            this.destinationsTextBox.TextChanged += new System.EventHandler(this.destinationsTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(714, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Destinations";
            // 
            // profilesListBox
            // 
            this.profilesListBox.FormattingEnabled = true;
            this.profilesListBox.Location = new System.Drawing.Point(12, 32);
            this.profilesListBox.Name = "profilesListBox";
            this.profilesListBox.Size = new System.Drawing.Size(210, 160);
            this.profilesListBox.TabIndex = 21;
            this.profilesListBox.SelectedIndexChanged += new System.EventHandler(this.profilesListBox_SelectedIndexChanged);
            // 
            // startBackupButton
            // 
            this.startBackupButton.Location = new System.Drawing.Point(13, 199);
            this.startBackupButton.Name = "startBackupButton";
            this.startBackupButton.Size = new System.Drawing.Size(834, 27);
            this.startBackupButton.TabIndex = 23;
            this.startBackupButton.Text = "Start the backup!";
            this.startBackupButton.UseVisualStyleBackColor = true;
            this.startBackupButton.Click += new System.EventHandler(this.startBackupButton_Click);
            // 
            // consoleOutputTextBox
            // 
            this.consoleOutputTextBox.Location = new System.Drawing.Point(13, 233);
            this.consoleOutputTextBox.Multiline = true;
            this.consoleOutputTextBox.Name = "consoleOutputTextBox";
            this.consoleOutputTextBox.ReadOnly = true;
            this.consoleOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleOutputTextBox.Size = new System.Drawing.Size(834, 209);
            this.consoleOutputTextBox.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(147, 6);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 25;
            this.newButton.Text = "New Profile";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(66, 6);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 454);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.consoleOutputTextBox);
            this.Controls.Add(this.startBackupButton);
            this.Controls.Add(this.profilesListBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.destinationsTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sourcesTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.profileNameTextBox);
            this.Controls.Add(this.comparatorComboBox);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.copiesNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickFileButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.copiesNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pickFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown copiesNumericUpDown;
        private System.Windows.Forms.RadioButton archiveYes;
        private System.Windows.Forms.RadioButton archiveNo;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.ComboBox comparatorComboBox;
        private System.Windows.Forms.TextBox profileNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.OpenFileDialog pickConfigDialog;
        private System.Windows.Forms.TextBox sourcesTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveConfigDialog;
        private System.Windows.Forms.TextBox destinationsTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox profilesListBox;
        private System.Windows.Forms.Button startBackupButton;
        private System.Windows.Forms.TextBox consoleOutputTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

