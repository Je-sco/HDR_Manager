namespace HDR_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            registeredProgramsDataGrid = new DataGridView();
            addProgramButton = new Button();
            programNameTextbox = new TextBox();
            invalidEntryLabel = new Label();
            openFileButton = new Button();
            autoEnableCheckbox = new CheckBox();
            autoDisableCheckbox = new CheckBox();
            removeProgramButton = new Button();
            addFileViewButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            unhideToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)registeredProgramsDataGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // registeredProgramsDataGrid
            // 
            registeredProgramsDataGrid.AllowUserToAddRows = false;
            registeredProgramsDataGrid.AllowUserToDeleteRows = false;
            registeredProgramsDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registeredProgramsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registeredProgramsDataGrid.Location = new Point(12, 71);
            registeredProgramsDataGrid.Name = "registeredProgramsDataGrid";
            registeredProgramsDataGrid.ReadOnly = true;
            registeredProgramsDataGrid.RowHeadersWidth = 51;
            registeredProgramsDataGrid.Size = new Size(361, 188);
            registeredProgramsDataGrid.TabIndex = 1;
            registeredProgramsDataGrid.RowsRemoved += registedProgramsDataGrid_rowsRemoved;
            // 
            // addProgramButton
            // 
            addProgramButton.Location = new Point(419, 105);
            addProgramButton.Name = "addProgramButton";
            addProgramButton.Size = new Size(346, 29);
            addProgramButton.TabIndex = 2;
            addProgramButton.Text = "Add Program by name";
            addProgramButton.UseVisualStyleBackColor = true;
            addProgramButton.Click += addProgramButton_Click;
            // 
            // programNameTextbox
            // 
            programNameTextbox.Location = new Point(419, 72);
            programNameTextbox.Name = "programNameTextbox";
            programNameTextbox.Size = new Size(346, 27);
            programNameTextbox.TabIndex = 3;
            // 
            // invalidEntryLabel
            // 
            invalidEntryLabel.AutoSize = true;
            invalidEntryLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invalidEntryLabel.ForeColor = Color.Red;
            invalidEntryLabel.Location = new Point(23, 355);
            invalidEntryLabel.Name = "invalidEntryLabel";
            invalidEntryLabel.Size = new Size(755, 41);
            invalidEntryLabel.TabIndex = 4;
            invalidEntryLabel.Text = "# Invalid entries in HDR_Manager.txt have been ignored";
            invalidEntryLabel.Visible = false;
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(23, 409);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(167, 29);
            openFileButton.TabIndex = 5;
            openFileButton.Text = "Open .txt";
            openFileButton.UseMnemonic = false;
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // autoEnableCheckbox
            // 
            autoEnableCheckbox.AutoSize = true;
            autoEnableCheckbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoEnableCheckbox.Location = new Point(473, 203);
            autoEnableCheckbox.Name = "autoEnableCheckbox";
            autoEnableCheckbox.Size = new Size(212, 35);
            autoEnableCheckbox.TabIndex = 6;
            autoEnableCheckbox.Text = "Auto Enable HDR";
            autoEnableCheckbox.UseVisualStyleBackColor = true;
            autoEnableCheckbox.CheckedChanged += autoEnableCheckbox_CheckedChanged;
            // 
            // autoDisableCheckbox
            // 
            autoDisableCheckbox.AutoSize = true;
            autoDisableCheckbox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoDisableCheckbox.Location = new Point(473, 244);
            autoDisableCheckbox.Name = "autoDisableCheckbox";
            autoDisableCheckbox.Size = new Size(219, 35);
            autoDisableCheckbox.TabIndex = 7;
            autoDisableCheckbox.Text = "Auto Disable HDR";
            autoDisableCheckbox.UseVisualStyleBackColor = true;
            autoDisableCheckbox.CheckedChanged += autoDisableCheckbox_CheckedChanged;
            // 
            // removeProgramButton
            // 
            removeProgramButton.Location = new Point(419, 140);
            removeProgramButton.Name = "removeProgramButton";
            removeProgramButton.Size = new Size(346, 29);
            removeProgramButton.TabIndex = 8;
            removeProgramButton.Text = "Remove Program by Name";
            removeProgramButton.UseVisualStyleBackColor = true;
            removeProgramButton.Click += removeProgramButton_Click;
            // 
            // addFileViewButton
            // 
            addFileViewButton.Location = new Point(12, 265);
            addFileViewButton.Name = "addFileViewButton";
            addFileViewButton.Size = new Size(361, 29);
            addFileViewButton.TabIndex = 10;
            addFileViewButton.Text = "Add Program through File Explorer";
            addFileViewButton.UseVisualStyleBackColor = true;
            addFileViewButton.Click += addFileViewButton_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { unhideToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            // 
            // unhideToolStripMenuItem
            // 
            unhideToolStripMenuItem.Name = "unhideToolStripMenuItem";
            unhideToolStripMenuItem.Size = new Size(210, 24);
            unhideToolStripMenuItem.Text = "Unhide";
            unhideToolStripMenuItem.Click += unhideToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(210, 24);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addFileViewButton);
            Controls.Add(removeProgramButton);
            Controls.Add(autoDisableCheckbox);
            Controls.Add(autoEnableCheckbox);
            Controls.Add(openFileButton);
            Controls.Add(invalidEntryLabel);
            Controls.Add(programNameTextbox);
            Controls.Add(addProgramButton);
            Controls.Add(registeredProgramsDataGrid);
            Name = "Form1";
            Text = "HDR Manager";
            Resize += FormOnResize;
            ((System.ComponentModel.ISupportInitialize)registeredProgramsDataGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView registeredProgramsDataGrid;
        private Button addProgramButton;
        private TextBox programNameTextbox;
        private Label invalidEntryLabel;
        private Button openFileButton;
        private CheckBox autoEnableCheckbox;
        private CheckBox autoDisableCheckbox;
        private Button removeProgramButton;
        private Button addFileViewButton;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem unhideToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}
