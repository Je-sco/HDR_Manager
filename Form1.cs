using System.Diagnostics;
using System.Windows.Forms;

namespace HDR_Manager
{
    public partial class Form1 : Form
    {
        static string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\HDR Manager\";
        FileControl saveData = new FileControl(appData + "HDR_Manager.txt");
        FileControl settingsData = new FileControl(appData + "HDR_Manager_Settings.txt");

        public Form1()
        {
            InitializeComponent();

            notifyIcon1.Text = "HDR-Manager";

            registeredProgramsDataGrid.Columns.Add("programColumn", "Program");
            registeredProgramsDataGrid.Columns.Add("programColumn", "");


            RestoreSavedApps();
            RestoreSettings();

            Task.Run(() => CheckIfProcessOpen());
        }

        SortedDictionary<string, bool> savedPrograms = new SortedDictionary<string, bool>();

        private async Task CheckIfProcessOpen()
        {
            bool processOpen;
            while (true)
            {
                if (!autoDisableCheckbox.Checked && !autoEnableCheckbox.Checked)
                {
                    continue;
                }

                processOpen = false;
                foreach (var item in savedPrograms)
                {
                    if (Process.GetProcessesByName(item.Key).Length > 0 && autoEnableCheckbox.Checked)
                    {
                        HDRControl.SetHDR(true);
                        processOpen = true;
                    }
                }
                if (!processOpen && autoDisableCheckbox.Checked)
                {
                    HDRControl.SetHDR(false);
                }
            }
        }

        private void RestoreSavedApps()
        {
            List<String> apps = saveData.GetAsList();
            int invalidCount = 0;
            bool invalidEntry = false;
            foreach (string app in apps)
            {
                if (!savedPrograms.ContainsKey(app))
                {
                    savedPrograms.Add(app, true);
                }
                else
                {
                    invalidCount++;
                    invalidEntry = true;
                }
            }
            updateDataGridView();

            if (invalidEntry)
            {
                invalidEntryLabel.Visible = true;
                invalidEntryLabel.Text = invalidCount + " invalid entries in HDR_Manager.txt have been ignored";
            }
        }

        private void RestoreSettings()
        {
            if (!settingsData.GetAlreadyExist() || settingsData.IsFileEmpty())
            {
                settingsData.AppendToFile("True");
                settingsData.AppendToFile("True");
            }

            List<string> settings = settingsData.GetAsList();

            try
            {
                autoEnableCheckbox.Checked = bool.Parse(settings[0]);
                autoDisableCheckbox.Checked = bool.Parse(settings[1]);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                settingsData.EmptyFile();
                MessageBox.Show("Invalid settings fixed, please restart program");
                Application.Exit();
            }
        }

        private void updateDataGridView()
        {
            registeredProgramsDataGrid.Rows.Clear();
            foreach (var item in savedPrograms)
            {
                registeredProgramsDataGrid.Rows.Add(item.Key, item.Value);
            }
        }

        private void addProgramButton_Click(object sender, EventArgs e)
        {
            string processName = programNameTextbox.Text;

            if (!savedPrograms.ContainsKey(processName))
            {
                savedPrograms.Add(processName, true);
                registeredProgramsDataGrid.Rows.Add(processName, true);
                saveData.AppendToFile(processName);
            }
            else
            {
                MessageBox.Show("Invalid process name, should not already be in list");
            }
        }

        private void removeProgramButton_Click(object sender, EventArgs e)
        {
            string processName = programNameTextbox.Text;

            if (!savedPrograms.ContainsKey(processName))
            {
                MessageBox.Show("Program name is already not saved");
                return;
            }
            saveData.DeleteLineByContent(processName);
            savedPrograms.Remove(processName);
            updateDataGridView();

        }

        private void registedProgramsDataGrid_rowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            saveData.OpenDataLocation();

        }

        private void autoEnableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            settingsData.ReplaceLine(0, autoEnableCheckbox.Checked.ToString());
        }

        private void autoDisableCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            settingsData.ReplaceLine(1, autoDisableCheckbox.Checked.ToString());
        }

        private void addFileViewButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Executable (*.exe)|*.exe;";
            openFileDialog.InitialDirectory = "C:\\";

            openFileDialog.ShowDialog();
            String processName = openFileDialog.SafeFileName;
            processName = processName.Replace(".exe", "");

            if (!savedPrograms.ContainsKey(processName))
            {
                savedPrograms.Add(processName, true);
                registeredProgramsDataGrid.Rows.Add(processName, true);
                saveData.AppendToFile(processName);
            }
            else
            {
                MessageBox.Show("Invalid process, should not already be in list");
            }
        }

        private void FormOnResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void unhideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
