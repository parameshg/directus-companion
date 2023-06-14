namespace Directus.Companion
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            tlpHome = new TableLayoutPanel();
            pSplash = new PictureBox();
            tlpActions = new TableLayoutPanel();
            btnMinimize = new Button();
            btnSettings = new Button();
            btnBackup = new Button();
            btnRestore = new Button();
            Progress = new ProgressBar();
            Status = new Label();
            Tray = new NotifyIcon(components);
            TrayMenu = new ContextMenuStrip(components);
            tsmiShow = new ToolStripMenuItem();
            Seperator = new ToolStripSeparator();
            tsmiExit = new ToolStripMenuItem();
            tlpHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pSplash).BeginInit();
            tlpActions.SuspendLayout();
            TrayMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tlpHome
            // 
            tlpHome.ColumnCount = 1;
            tlpHome.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpHome.Controls.Add(pSplash, 0, 0);
            tlpHome.Controls.Add(tlpActions, 0, 3);
            tlpHome.Controls.Add(Progress, 0, 2);
            tlpHome.Controls.Add(Status, 0, 1);
            tlpHome.Dock = DockStyle.Fill;
            tlpHome.Location = new Point(0, 0);
            tlpHome.Name = "tlpHome";
            tlpHome.RowCount = 4;
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tlpHome.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpHome.Size = new Size(580, 407);
            tlpHome.TabIndex = 0;
            // 
            // pSplash
            // 
            pSplash.Dock = DockStyle.Fill;
            pSplash.Image = (Image)resources.GetObject("pSplash.Image");
            pSplash.Location = new Point(0, 0);
            pSplash.Margin = new Padding(0);
            pSplash.Name = "pSplash";
            pSplash.Size = new Size(580, 322);
            pSplash.SizeMode = PictureBoxSizeMode.StretchImage;
            pSplash.TabIndex = 1;
            pSplash.TabStop = false;
            // 
            // tlpActions
            // 
            tlpActions.ColumnCount = 5;
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpActions.Controls.Add(btnMinimize, 0, 0);
            tlpActions.Controls.Add(btnSettings, 1, 0);
            tlpActions.Controls.Add(btnBackup, 4, 0);
            tlpActions.Controls.Add(btnRestore, 3, 0);
            tlpActions.Dock = DockStyle.Fill;
            tlpActions.Location = new Point(0, 372);
            tlpActions.Margin = new Padding(0);
            tlpActions.Name = "tlpActions";
            tlpActions.RowCount = 1;
            tlpActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpActions.Size = new Size(580, 35);
            tlpActions.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Fill;
            btnMinimize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.Location = new Point(1, 3);
            btnMinimize.Margin = new Padding(1, 3, 1, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(98, 29);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "Minimize";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += OnMinimize;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.Location = new Point(101, 3);
            btnSettings.Margin = new Padding(1, 3, 1, 3);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(98, 29);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += OnSettings;
            // 
            // btnBackup
            // 
            btnBackup.Dock = DockStyle.Fill;
            btnBackup.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackup.Location = new Point(481, 3);
            btnBackup.Margin = new Padding(1, 3, 1, 3);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(98, 29);
            btnBackup.TabIndex = 2;
            btnBackup.Text = "Backup";
            btnBackup.UseVisualStyleBackColor = true;
            btnBackup.Click += OnBackup;
            // 
            // btnRestore
            // 
            btnRestore.Dock = DockStyle.Fill;
            btnRestore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRestore.Location = new Point(381, 3);
            btnRestore.Margin = new Padding(1, 3, 1, 3);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(98, 29);
            btnRestore.TabIndex = 3;
            btnRestore.Text = "Restore";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += OnRestore;
            // 
            // Progress
            // 
            Progress.Dock = DockStyle.Fill;
            Progress.Location = new Point(0, 347);
            Progress.Margin = new Padding(0);
            Progress.Name = "Progress";
            Progress.Size = new Size(580, 25);
            Progress.TabIndex = 2;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Dock = DockStyle.Fill;
            Status.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Status.Location = new Point(3, 322);
            Status.Name = "Status";
            Status.Size = new Size(574, 25);
            Status.TabIndex = 3;
            Status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Tray
            // 
            Tray.ContextMenuStrip = TrayMenu;
            Tray.Icon = (Icon)resources.GetObject("Tray.Icon");
            Tray.Text = "Directus Companion";
            Tray.Visible = true;
            // 
            // TrayMenu
            // 
            TrayMenu.Items.AddRange(new ToolStripItem[] { tsmiShow, Seperator, tsmiExit });
            TrayMenu.Name = "TrayMenu";
            TrayMenu.Size = new Size(141, 54);
            // 
            // tsmiShow
            // 
            tsmiShow.Name = "tsmiShow";
            tsmiShow.Size = new Size(140, 22);
            tsmiShow.Text = "Show Dialog";
            tsmiShow.Click += OnShow;
            // 
            // Seperator
            // 
            Seperator.Name = "Seperator";
            Seperator.Size = new Size(137, 6);
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(140, 22);
            tsmiExit.Text = "Exit";
            tsmiExit.Click += OnExit;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnMinimize;
            ClientSize = new Size(580, 407);
            Controls.Add(tlpHome);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Directus Companion";
            tlpHome.ResumeLayout(false);
            tlpHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pSplash).EndInit();
            tlpActions.ResumeLayout(false);
            TrayMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpHome;
        private TableLayoutPanel tlpActions;
        private Button btnMinimize;
        private Button btnSettings;
        private Button btnBackup;
        private PictureBox pSplash;
        private Button btnRestore;
        private ProgressBar Progress;
        private Label Status;
        private NotifyIcon Tray;
        private ContextMenuStrip TrayMenu;
        private ToolStripMenuItem tsmiExit;
        private ToolStripSeparator Seperator;
        private ToolStripMenuItem tsmiShow;
    }
}