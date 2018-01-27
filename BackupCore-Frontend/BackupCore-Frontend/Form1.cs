using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BackupCore_Frontend
{
    public partial class Form1 : Form
    {
        private BackupProfile currentProfile;
        private readonly ConfigHandler handler;

        public Form1()
        {
            InitializeComponent();
            currentProfile = new BackupProfile();
            handler = new ConfigHandler();
            profilesListBox.DataSource = PopulateProfileList();

            //UpdateViewFromAction(currentProfile);
        }

        private List<BackupProfile> PopulateProfileList()
        {
            profilesListBox.SelectedIndex = -1;
            if (!System.IO.Directory.Exists("./profiles")) System.IO.Directory.CreateDirectory("./profiles");
            return System.IO.Directory.EnumerateFiles("./profiles")
                .Select(path => handler.OpenConfigFile(path)).ToList();
        }

        private void pickFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                pickConfigDialog.ShowDialog();

                currentProfile = handler.OpenConfigFile(pickConfigDialog.FileName);
                if (currentProfile == null)
                {
                    currentProfile = new BackupProfile();
                    throw new ArgumentException(
                    "Configuration file either does not exist or is invalid! Check the examples.");
                }

                UpdateViewFromAction(currentProfile);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.ToString());
            }
        }

        private void UpdateViewFromAction(BackupProfile backupProfile)
        {
            profileNameTextBox.Text = backupProfile.ActionName;
            if (backupProfile.Mode == "database") modeComboBox.SelectedIndex = 0;
            if (backupProfile.Mode == "simple") modeComboBox.SelectedIndex = 1;
            if (backupProfile.Comparator == "bydate") comparatorComboBox.SelectedIndex = 0;
            if (backupProfile.Comparator == "byhash") comparatorComboBox.SelectedIndex = 1;
            copiesNumericUpDown.Value = backupProfile.BackupCopies;
            archiveYes.Checked = backupProfile.Archive;
            archiveNo.Checked = !backupProfile.Archive;
            passwordTextBox.Text = backupProfile.ArchivePassword;


            sourcesTextBox.Lines = backupProfile.SourcePath;
            destinationsTextBox.Lines = backupProfile.DestinationPath;

            profileNameTextBox.Enabled = sourcesTextBox.Enabled =
                destinationsTextBox.Enabled = modeComboBox.Enabled =
                comparatorComboBox.Enabled = copiesNumericUpDown.Enabled = !backupProfile.Locked;


        }

        private void profileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            currentProfile.ActionName = profileNameTextBox.Text;
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (modeComboBox.SelectedIndex)
            {
                case 0: currentProfile.Mode = "database";
                    break;
                case 1: currentProfile.Mode = "simple";
                    break;
            }
        }

        private void comparatorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comparatorComboBox.SelectedIndex)
            {
                case 0:
                    currentProfile.Comparator = "bydate";
                    break;
                case 1:
                    currentProfile.Comparator = "byhash";
                    break;
            }
        }

        private void copiesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            currentProfile.BackupCopies = (int)copiesNumericUpDown.Value;
        }

        private void archiveNo_CheckedChanged(object sender, EventArgs e)
        {
            currentProfile.Archive = false;
        }

        private void archiveYes_CheckedChanged(object sender, EventArgs e)
        {
            currentProfile.Archive = true;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            currentProfile.ArchivePassword = passwordTextBox.Text;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            SaveConfig(true);
        }

        private bool SaveConfig(bool ask)
        {
            if (!handler.SaveConfigToFile("./profiles/" + currentProfile.ActionName + ".ini", currentProfile,
                ask)) return false;
            string profile = currentProfile.ToString();
            profilesListBox.DataSource = PopulateProfileList();
            profilesListBox.SelectedItem = ((List<BackupProfile>) profilesListBox.DataSource).Find((s) =>s.ActionName == profile);
            return true;
        }

        private void sourcesTextBox_TextChanged(object sender, EventArgs e)
        {
            currentProfile.SourcePath = sourcesTextBox.Lines;
        }

        private void destinationsTextBox_TextChanged(object sender, EventArgs e)
        {
            currentProfile.DestinationPath = destinationsTextBox.Lines;
        }

        private void profilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (profilesListBox.SelectedIndex >= 0)
            {
                currentProfile = profilesListBox.SelectedItem as BackupProfile;
                UpdateViewFromAction(currentProfile);
            }
            //UpdateViewFromAction(profilesListBox.SelectedIndex == -1? new BackupProfile() : profilesListBox.SelectedItem as BackupProfile);
        }

        private async void startBackupButton_Click(object sender, EventArgs e)
        {
            if (!SaveConfig(false))
            {
                MessageBox.Show("Action cancelled.");
            }
            consoleOutputTextBox.Text = "";
            ProcessStartInfo start = new ProcessStartInfo
            {
                Arguments = "./profiles/" + currentProfile.ActionName + ".ini",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                //RedirectStandardInput = true,
                FileName = ".\\BackupCore.exe",

            };
            int exitCode = await Task.Run(()=>OpenConsole(start));
            // Run the external process & wait for it to finish
            MessageBox.Show(exitCode == 0
                ? "Backup performed successfully!"
                : "Program exited with errors, check the log!");
            if (currentProfile.Mode == "database" && currentProfile.Locked == false && exitCode == 0)
            {
                MessageBox.Show("Certain options in this profile will be locked due to it being a database backup.",
                    "Warning");
                currentProfile.Locked = true;
                UpdateViewFromAction(currentProfile);
            }
        }

        private int  OpenConsole(ProcessStartInfo start)
        {
            int exitCode;
            using (Process proc = Process.Start(start))
            {
                proc.OutputDataReceived += (s, eargs) => SetConsoleOutputText(eargs.Data);
                proc.ErrorDataReceived += (s, eargs) => SetConsoleOutputText(eargs.Data);

                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }
            return exitCode;
        }

        delegate void StringArgReturnVoidDelegate(string text);

        private void SetConsoleOutputText(string text)
        {

            if (this.consoleOutputTextBox.InvokeRequired)
            {
                StringArgReturnVoidDelegate d = SetConsoleOutputText;
                this.Invoke(d, text);
            }
            else
            {
                consoleOutputTextBox.Text += text + "\r\n";
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            profilesListBox.SelectedIndex = -1;
            currentProfile = new BackupProfile();
            UpdateViewFromAction(currentProfile);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete("./profiles/" + profilesListBox.SelectedItem + ".ini");
            System.IO.File.Delete("./" + profilesListBox.SelectedItem + ".db");
            profilesListBox.DataSource = PopulateProfileList();
        }

        private void addSourceButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sourcesTextBox.Text += (sourcesTextBox.Text == "" || sourcesTextBox.Text[sourcesTextBox.Text.Length-1] == '\n')
                    ? (folderBrowserDialog1.SelectedPath)
                    : ("\r\n" + folderBrowserDialog1.SelectedPath);
            }
        }

        private void addDestinationButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destinationsTextBox.Text += (destinationsTextBox.Text == "" || destinationsTextBox.Text[destinationsTextBox.Text.Length-1] == '\n')
                    ? (folderBrowserDialog1.SelectedPath)
                    : ("\r\n" + folderBrowserDialog1.SelectedPath);
            }
        }
    }
}