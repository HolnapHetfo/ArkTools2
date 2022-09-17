
namespace ArkTools3._0
{
    partial class Settings
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
            this.BTNSave = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.BTNSelectFolder = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TXTPath = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.TXTSteamId = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SteamIdConverter = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.TXTID = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SuspendLayout();
            // 
            // BTNSave
            // 
            this.BTNSave.CheckedState.Parent = this.BTNSave;
            this.BTNSave.CustomImages.Parent = this.BTNSave;
            this.BTNSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNSave.DisabledState.Parent = this.BTNSave;
            this.BTNSave.FillColor = System.Drawing.Color.DarkGreen;
            this.BTNSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNSave.ForeColor = System.Drawing.Color.White;
            this.BTNSave.HoverState.Parent = this.BTNSave;
            this.BTNSave.Location = new System.Drawing.Point(216, 260);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.ShadowDecoration.Parent = this.BTNSave;
            this.BTNSave.Size = new System.Drawing.Size(114, 33);
            this.BTNSave.TabIndex = 0;
            this.BTNSave.Text = "Save";
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // BTNSelectFolder
            // 
            this.BTNSelectFolder.CheckedState.Parent = this.BTNSelectFolder;
            this.BTNSelectFolder.CustomImages.Parent = this.BTNSelectFolder;
            this.BTNSelectFolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNSelectFolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNSelectFolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNSelectFolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNSelectFolder.DisabledState.Parent = this.BTNSelectFolder;
            this.BTNSelectFolder.FillColor = System.Drawing.Color.DarkGreen;
            this.BTNSelectFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNSelectFolder.ForeColor = System.Drawing.Color.White;
            this.BTNSelectFolder.HoverState.Parent = this.BTNSelectFolder;
            this.BTNSelectFolder.Location = new System.Drawing.Point(129, 200);
            this.BTNSelectFolder.Name = "BTNSelectFolder";
            this.BTNSelectFolder.ShadowDecoration.Parent = this.BTNSelectFolder;
            this.BTNSelectFolder.Size = new System.Drawing.Size(114, 33);
            this.BTNSelectFolder.TabIndex = 1;
            this.BTNSelectFolder.Text = "Select Folder";
            this.BTNSelectFolder.Click += new System.EventHandler(this.BTNSelectFolder_Click);
            // 
            // TXTPath
            // 
            this.TXTPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTPath.DefaultText = "";
            this.TXTPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTPath.DisabledState.Parent = this.TXTPath;
            this.TXTPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTPath.FocusedState.Parent = this.TXTPath;
            this.TXTPath.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TXTPath.ForeColor = System.Drawing.Color.DimGray;
            this.TXTPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTPath.HoverState.Parent = this.TXTPath;
            this.TXTPath.Location = new System.Drawing.Point(22, 162);
            this.TXTPath.Name = "TXTPath";
            this.TXTPath.PasswordChar = '\0';
            this.TXTPath.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TXTPath.PlaceholderText = "Path to ARK";
            this.TXTPath.SelectedText = "";
            this.TXTPath.ShadowDecoration.Parent = this.TXTPath;
            this.TXTPath.Size = new System.Drawing.Size(318, 23);
            this.TXTPath.TabIndex = 2;
            // 
            // TXTSteamId
            // 
            this.TXTSteamId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTSteamId.DefaultText = "";
            this.TXTSteamId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTSteamId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTSteamId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTSteamId.DisabledState.Parent = this.TXTSteamId;
            this.TXTSteamId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTSteamId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTSteamId.FocusedState.Parent = this.TXTSteamId;
            this.TXTSteamId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.TXTSteamId.ForeColor = System.Drawing.Color.DimGray;
            this.TXTSteamId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTSteamId.HoverState.Parent = this.TXTSteamId;
            this.TXTSteamId.Location = new System.Drawing.Point(63, 37);
            this.TXTSteamId.Name = "TXTSteamId";
            this.TXTSteamId.PasswordChar = '\0';
            this.TXTSteamId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TXTSteamId.PlaceholderText = "Steam ID";
            this.TXTSteamId.SelectedText = "";
            this.TXTSteamId.ShadowDecoration.Parent = this.TXTSteamId;
            this.TXTSteamId.Size = new System.Drawing.Size(226, 29);
            this.TXTSteamId.TabIndex = 3;
            // 
            // SteamIdConverter
            // 
            this.SteamIdConverter.CheckedState.Parent = this.SteamIdConverter;
            this.SteamIdConverter.CustomImages.Parent = this.SteamIdConverter;
            this.SteamIdConverter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SteamIdConverter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SteamIdConverter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SteamIdConverter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SteamIdConverter.DisabledState.Parent = this.SteamIdConverter;
            this.SteamIdConverter.FillColor = System.Drawing.Color.DarkGreen;
            this.SteamIdConverter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SteamIdConverter.ForeColor = System.Drawing.Color.White;
            this.SteamIdConverter.HoverState.Parent = this.SteamIdConverter;
            this.SteamIdConverter.Location = new System.Drawing.Point(129, 72);
            this.SteamIdConverter.Name = "SteamIdConverter";
            this.SteamIdConverter.ShadowDecoration.Parent = this.SteamIdConverter;
            this.SteamIdConverter.Size = new System.Drawing.Size(114, 33);
            this.SteamIdConverter.TabIndex = 4;
            this.SteamIdConverter.Text = "Convert";
            this.SteamIdConverter.Click += new System.EventHandler(this.SteamIdConverter_Click);
            // 
            // TXTID
            // 
            this.TXTID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTID.DefaultText = "";
            this.TXTID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTID.DisabledState.Parent = this.TXTID;
            this.TXTID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTID.FocusedState.Parent = this.TXTID;
            this.TXTID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TXTID.ForeColor = System.Drawing.Color.DimGray;
            this.TXTID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTID.HoverState.Parent = this.TXTID;
            this.TXTID.Location = new System.Drawing.Point(63, 111);
            this.TXTID.Name = "TXTID";
            this.TXTID.PasswordChar = '\0';
            this.TXTID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TXTID.PlaceholderText = "Steam User ID";
            this.TXTID.SelectedText = "";
            this.TXTID.ShadowDecoration.Parent = this.TXTID;
            this.TXTID.Size = new System.Drawing.Size(226, 29);
            this.TXTID.TabIndex = 5;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(352, 316);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.SteamIdConverter);
            this.Controls.Add(this.TXTSteamId);
            this.Controls.Add(this.TXTPath);
            this.Controls.Add(this.BTNSelectFolder);
            this.Controls.Add(this.BTNSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneButton BTNSave;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BTNSelectFolder;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TXTPath;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TXTSteamId;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton SteamIdConverter;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox TXTID;
    }
}