namespace Run
{
    partial class Run
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Run));
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.runIcon = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.decorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.openLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPanel.Controls.Add(this.okButton);
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.browseButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(0, 130);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(420, 58);
            this.buttonPanel.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(98, 16);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(93, 26);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(197, 16);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 26);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(296, 16);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(90, 26);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "&Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // runIcon
            // 
            this.runIcon.Image = ((System.Drawing.Image)(resources.GetObject("runIcon.Image")));
            this.runIcon.Location = new System.Drawing.Point(9, 21);
            this.runIcon.Name = "runIcon";
            this.runIcon.Size = new System.Drawing.Size(48, 34);
            this.runIcon.TabIndex = 1;
            this.runIcon.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(62, 22);
            this.descriptionLabel.MaximumSize = new System.Drawing.Size(350, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(349, 40);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Type the name of a program, folder, document or Internet resource, and Windows wi" +
    "ll open it for you.";
            // 
            // decorPanel
            // 
            this.decorPanel.BackColor = System.Drawing.SystemColors.Control;
            this.decorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.decorPanel.Location = new System.Drawing.Point(0, 0);
            this.decorPanel.Name = "decorPanel";
            this.decorPanel.Size = new System.Drawing.Size(420, 1);
            this.decorPanel.TabIndex = 0;
            // 
            // comboBox
            // 
            this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(51, 71);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(335, 28);
            this.comboBox.TabIndex = 0;
            this.comboBox.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLabel.Location = new System.Drawing.Point(6, 74);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(48, 20);
            this.openLabel.TabIndex = 4;
            this.openLabel.Text = "&Open:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Programs(*.exe;*.pif;*.com;*.bat:*.cmd)|*.exe;*.pif;*.com;*.bat:*.cmd|All files (" +
    "*.*)|*.*";
            this.openFileDialog.Title = "Browse";
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminCheckBox.Location = new System.Drawing.Point(65, 100);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(310, 23);
            this.adminCheckBox.TabIndex = 5;
            this.adminCheckBox.Text = "Create this task with administrative privileges.";
            this.adminCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminCheckBox.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // Run
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(420, 188);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.openLabel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.decorPanel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.runIcon);
            this.Controls.Add(this.buttonPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Run";
            this.Text = "Run";
            this.Load += new System.EventHandler(this.Run_Load);
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.PictureBox runIcon;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.FlowLayoutPanel decorPanel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.CheckBox adminCheckBox;
    }
}