namespace DirectusCompanion
{
    partial class Property
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Property));
            tlpMain = new TableLayoutPanel();
            Grid = new PropertyGrid();
            tlpActions = new TableLayoutPanel();
            btnAccept = new Button();
            btnCancel = new Button();
            tlpMain.SuspendLayout();
            tlpActions.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(Grid, 0, 0);
            tlpMain.Controls.Add(tlpActions, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpMain.Size = new Size(384, 511);
            tlpMain.TabIndex = 0;
            // 
            // Grid
            // 
            Grid.Dock = DockStyle.Fill;
            Grid.Location = new Point(3, 3);
            Grid.Name = "Grid";
            Grid.Size = new Size(378, 470);
            Grid.TabIndex = 0;
            // 
            // tlpActions
            // 
            tlpActions.ColumnCount = 3;
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tlpActions.Controls.Add(btnAccept, 2, 0);
            tlpActions.Controls.Add(btnCancel, 1, 0);
            tlpActions.Dock = DockStyle.Fill;
            tlpActions.Location = new Point(0, 476);
            tlpActions.Margin = new Padding(0);
            tlpActions.Name = "tlpActions";
            tlpActions.RowCount = 1;
            tlpActions.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpActions.Size = new Size(384, 35);
            tlpActions.TabIndex = 1;
            // 
            // btnAccept
            // 
            btnAccept.Dock = DockStyle.Fill;
            btnAccept.Location = new Point(285, 3);
            btnAccept.Margin = new Padding(1, 3, 1, 3);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(98, 29);
            btnAccept.TabIndex = 0;
            btnAccept.Text = "OK";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += OnAccept;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(185, 3);
            btnCancel.Margin = new Padding(1, 3, 1, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(98, 29);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += OnCancel;
            // 
            // Property
            // 
            AcceptButton = btnAccept;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(384, 511);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Property";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            tlpMain.ResumeLayout(false);
            tlpActions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private PropertyGrid Grid;
        private TableLayoutPanel tlpActions;
        private Button btnAccept;
        private Button btnCancel;
    }
}