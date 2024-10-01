namespace EquipmentRepair.WinForm.UI
{
    partial class MainForm
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
            mainlTabControl = new MaterialSkin2DotNet.Controls.MaterialTabControl();
            tabRepairTypes = new TabPage();
            repairTypeControl1 = new Controls.RepairTypeControl();
            tabPage2 = new TabPage();
            mainTabSelector = new MaterialSkin2DotNet.Controls.MaterialTabSelector();
            ThemeToggleButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            mainlTabControl.SuspendLayout();
            tabRepairTypes.SuspendLayout();
            SuspendLayout();
            // 
            // mainlTabControl
            // 
            mainlTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainlTabControl.Controls.Add(tabRepairTypes);
            mainlTabControl.Controls.Add(tabPage2);
            mainlTabControl.Depth = 0;
            mainlTabControl.Location = new Point(6, 67);
            mainlTabControl.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            mainlTabControl.Multiline = true;
            mainlTabControl.Name = "mainlTabControl";
            mainlTabControl.SelectedIndex = 0;
            mainlTabControl.Size = new Size(873, 677);
            mainlTabControl.TabIndex = 0;
            // 
            // tabRepairTypes
            // 
            tabRepairTypes.AutoScroll = true;
            tabRepairTypes.BackColor = Color.White;
            tabRepairTypes.BorderStyle = BorderStyle.FixedSingle;
            tabRepairTypes.Controls.Add(repairTypeControl1);
            tabRepairTypes.Location = new Point(4, 24);
            tabRepairTypes.Name = "tabRepairTypes";
            tabRepairTypes.Padding = new Padding(3);
            tabRepairTypes.Size = new Size(865, 649);
            tabRepairTypes.TabIndex = 0;
            tabRepairTypes.Text = "Repair Types";
            // 
            // repairTypeControl1
            // 
            repairTypeControl1.Location = new Point(6, 6);
            repairTypeControl1.Name = "repairTypeControl1";
            repairTypeControl1.Size = new Size(851, 454);
            repairTypeControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(865, 649);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // mainTabSelector
            // 
            mainTabSelector.BaseTabControl = mainlTabControl;
            mainTabSelector.CharacterCasing = MaterialSkin2DotNet.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            mainTabSelector.Depth = 0;
            mainTabSelector.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mainTabSelector.Location = new Point(181, 25);
            mainTabSelector.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            mainTabSelector.Name = "mainTabSelector";
            mainTabSelector.Size = new Size(644, 36);
            mainTabSelector.TabIndex = 0;
            mainTabSelector.Text = "materialTabSelector1";
            // 
            // ThemeToggleButton
            // 
            ThemeToggleButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ThemeToggleButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ThemeToggleButton.BackColor = Color.Transparent;
            ThemeToggleButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            ThemeToggleButton.Depth = 0;
            ThemeToggleButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 128);
            ThemeToggleButton.FlatAppearance.BorderSize = 0;
            ThemeToggleButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 0);
            ThemeToggleButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 64);
            ThemeToggleButton.FlatStyle = FlatStyle.Flat;
            ThemeToggleButton.Font = new Font("Segoe UI Black", 9F);
            ThemeToggleButton.HighEmphasis = true;
            ThemeToggleButton.Icon = null;
            ThemeToggleButton.Location = new Point(914, 91);
            ThemeToggleButton.Margin = new Padding(4, 6, 4, 6);
            ThemeToggleButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            ThemeToggleButton.Name = "ThemeToggleButton";
            ThemeToggleButton.NoAccentTextColor = Color.Empty;
            ThemeToggleButton.Size = new Size(130, 36);
            ThemeToggleButton.TabIndex = 1;
            ThemeToggleButton.TabStop = false;
            ThemeToggleButton.Text = "Toggle Theme";
            ThemeToggleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ThemeToggleButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            ThemeToggleButton.UseAccentColor = false;
            ThemeToggleButton.UseVisualStyleBackColor = false;
            ThemeToggleButton.Click += ThemeToggleButton_Click;
            // 
            // MainForm
            // 
            AccentColor = MaterialSkin2DotNet.Accent.Purple400;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1051, 750);
            Controls.Add(ThemeToggleButton);
            Controls.Add(mainTabSelector);
            Controls.Add(mainlTabControl);
            MinimumSize = new Size(1000, 500);
            Name = "MainForm";
            Text = "Equipment Repair";
            mainlTabControl.ResumeLayout(false);
            tabRepairTypes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTabControl mainlTabControl;
        private TabPage tabRepairTypes;
        private TabPage tabPage2;
        private MaterialSkin2DotNet.Controls.MaterialTabSelector mainTabSelector;
        private MaterialSkin2DotNet.Controls.MaterialButton ThemeToggleButton;
        private Controls.RepairTypeControl repairTypeControl1;
    }
}
