
namespace ArkTools3._0
{
    partial class clicker
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
            this.CPSTrackBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CPSValue = new System.Windows.Forms.Label();
            this.AutoClicker = new System.Windows.Forms.Timer(this.components);
            this.BtnToggle = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Random = new System.Windows.Forms.Timer(this.components);
            this.Bar2 = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.debugLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CPSTrackBar
            // 
            this.CPSTrackBar.HoverState.Parent = this.CPSTrackBar;
            this.CPSTrackBar.Location = new System.Drawing.Point(41, 145);
            this.CPSTrackBar.Maximum = 20;
            this.CPSTrackBar.Minimum = 6;
            this.CPSTrackBar.Name = "CPSTrackBar";
            this.CPSTrackBar.Size = new System.Drawing.Size(632, 34);
            this.CPSTrackBar.TabIndex = 0;
            this.CPSTrackBar.ThumbColor = System.Drawing.Color.DarkOrange;
            this.CPSTrackBar.Value = 10;
            this.CPSTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPSTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auto Clicker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Left Click CPS";
            // 
            // CPSValue
            // 
            this.CPSValue.AutoSize = true;
            this.CPSValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPSValue.ForeColor = System.Drawing.Color.DarkOrange;
            this.CPSValue.Location = new System.Drawing.Point(701, 145);
            this.CPSValue.Name = "CPSValue";
            this.CPSValue.Size = new System.Drawing.Size(100, 29);
            this.CPSValue.TabIndex = 3;
            this.CPSValue.Text = "CPS: 10";
            // 
            // AutoClicker
            // 
            this.AutoClicker.Tick += new System.EventHandler(this.AutoClicker_Tick);
            // 
            // BtnToggle
            // 
            this.BtnToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnToggle.CheckedState.FillColor = System.Drawing.Color.DarkOrange;
            this.BtnToggle.CheckedState.Parent = this.BtnToggle;
            this.BtnToggle.CustomImages.Parent = this.BtnToggle;
            this.BtnToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnToggle.DisabledState.Parent = this.BtnToggle;
            this.BtnToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BtnToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnToggle.ForeColor = System.Drawing.Color.DarkOrange;
            this.BtnToggle.HoverState.Parent = this.BtnToggle;
            this.BtnToggle.Location = new System.Drawing.Point(566, 40);
            this.BtnToggle.Name = "BtnToggle";
            this.BtnToggle.ShadowDecoration.Parent = this.BtnToggle;
            this.BtnToggle.Size = new System.Drawing.Size(217, 74);
            this.BtnToggle.TabIndex = 4;
            this.BtnToggle.Text = "Enable";
            this.BtnToggle.TextChanged += new System.EventHandler(this.BtnToggle_TextChanged);
            this.BtnToggle.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // Random
            // 
            this.Random.Enabled = true;
            this.Random.Interval = 150;
            this.Random.Tick += new System.EventHandler(this.Random_Tick);
            // 
            // Bar2
            // 
            this.Bar2.HoverState.Parent = this.Bar2;
            this.Bar2.Location = new System.Drawing.Point(41, 398);
            this.Bar2.Maximum = 30;
            this.Bar2.Name = "Bar2";
            this.Bar2.Size = new System.Drawing.Size(632, 34);
            this.Bar2.TabIndex = 5;
            this.Bar2.ThumbColor = System.Drawing.Color.DarkOrange;
            this.Bar2.Value = 10;
            // 
            // debugLabel1
            // 
            this.debugLabel1.AutoSize = true;
            this.debugLabel1.Location = new System.Drawing.Point(37, 208);
            this.debugLabel1.Name = "debugLabel1";
            this.debugLabel1.Size = new System.Drawing.Size(51, 20);
            this.debugLabel1.TabIndex = 6;
            this.debugLabel1.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(828, 444);
            this.Controls.Add(this.debugLabel1);
            this.Controls.Add(this.Bar2);
            this.Controls.Add(this.BtnToggle);
            this.Controls.Add(this.CPSValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPSTrackBar);
            this.Name = "clicker";
            this.Text = "ARK Auto Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar CPSTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CPSValue;
        private System.Windows.Forms.Timer AutoClicker;
        private Siticone.Desktop.UI.WinForms.SiticoneButton BtnToggle;
        private System.Windows.Forms.Timer Random;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar Bar2;
        private System.Windows.Forms.Label debugLabel1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}