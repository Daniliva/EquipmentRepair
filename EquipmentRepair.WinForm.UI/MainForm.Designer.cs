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
            tabEquipmentType = new TabPage();
            equipmentTypeControl1 = new Controls.EquipmentTypeControl();
            tabRepairRecord = new TabPage();
            repairRecordControl1 = new Controls.RepairRecordControl();
            tabSpecial = new TabPage();
            mainTabSelector = new MaterialSkin2DotNet.Controls.MaterialTabSelector();
            ThemeToggleButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            specialControl1 = new Controls.SpecialControl();
            mainlTabControl.SuspendLayout();
            tabRepairTypes.SuspendLayout();
            tabEquipmentType.SuspendLayout();
            tabRepairRecord.SuspendLayout();
            tabSpecial.SuspendLayout();
            SuspendLayout();
            // 
            // mainlTabControl
            // 
            mainlTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainlTabControl.Controls.Add(tabRepairTypes);
            mainlTabControl.Controls.Add(tabEquipmentType);
            mainlTabControl.Controls.Add(tabRepairRecord);
            mainlTabControl.Controls.Add(tabSpecial);
            mainlTabControl.Depth = 0;
            mainlTabControl.Location = new Point(6, 67);
            mainlTabControl.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            mainlTabControl.Multiline = true;
            mainlTabControl.Name = "mainlTabControl";
            mainlTabControl.SelectedIndex = 0;
            mainlTabControl.Size = new Size(873, 493);
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
            tabRepairTypes.Size = new Size(865, 465);
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
            // tabEquipmentType
            // 
            tabEquipmentType.BackColor = Color.White;
            tabEquipmentType.Controls.Add(equipmentTypeControl1);
            tabEquipmentType.Location = new Point(4, 24);
            tabEquipmentType.Name = "tabEquipmentType";
            tabEquipmentType.Padding = new Padding(3);
            tabEquipmentType.Size = new Size(865, 465);
            tabEquipmentType.TabIndex = 1;
            tabEquipmentType.Text = "Equipment Type";
            // 
            // equipmentTypeControl1
            // 
            equipmentTypeControl1.Location = new Point(9, 11);
            equipmentTypeControl1.Name = "equipmentTypeControl1";
            equipmentTypeControl1.Size = new Size(727, 448);
            equipmentTypeControl1.TabIndex = 0;
            // 
            // tabRepairRecord
            // 
            tabRepairRecord.BackColor = Color.White;
            tabRepairRecord.Controls.Add(repairRecordControl1);
            tabRepairRecord.Location = new Point(4, 24);
            tabRepairRecord.Name = "tabRepairRecord";
            tabRepairRecord.Size = new Size(865, 465);
            tabRepairRecord.TabIndex = 2;
            tabRepairRecord.Text = "Reapair Record";
            // 
            // repairRecordControl1
            // 
            repairRecordControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            repairRecordControl1.Location = new Point(18, 11);
            repairRecordControl1.Name = "repairRecordControl1";
            repairRecordControl1.Size = new Size(728, 451);
            repairRecordControl1.TabIndex = 0;
            // 
            // tabSpecial
            // 
            tabSpecial.BackColor = Color.White;
            tabSpecial.Controls.Add(specialControl1);
            tabSpecial.Location = new Point(4, 24);
            tabSpecial.Name = "tabSpecial";
            tabSpecial.Size = new Size(865, 465);
            tabSpecial.TabIndex = 3;
            tabSpecial.Text = "Special";
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
            // specialControl1
            // 
            specialControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            specialControl1.AutoScroll = true;
            specialControl1.Location = new Point(3, 3);
            specialControl1.Name = "specialControl1";
            specialControl1.Size = new Size(735, 435);
            specialControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AccentColor = MaterialSkin2DotNet.Accent.Purple400;
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1051, 566);
            Controls.Add(ThemeToggleButton);
            Controls.Add(mainTabSelector);
            Controls.Add(mainlTabControl);
            MinimumSize = new Size(1000, 500);
            Name = "MainForm";
            Text = "Equipment Repair";
            mainlTabControl.ResumeLayout(false);
            tabRepairTypes.ResumeLayout(false);
            tabEquipmentType.ResumeLayout(false);
            tabRepairRecord.ResumeLayout(false);
            tabSpecial.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTabControl mainlTabControl;
        private TabPage tabRepairTypes;
        private TabPage tabEquipmentType;
        private MaterialSkin2DotNet.Controls.MaterialTabSelector mainTabSelector;
        private MaterialSkin2DotNet.Controls.MaterialButton ThemeToggleButton;
        private Controls.RepairTypeControl repairTypeControl1;
        private Controls.EquipmentTypeControl equipmentTypeControl1;
        private TabPage tabRepairRecord;
        private Controls.RepairRecordControl repairRecordControl1;
        private TabPage tabSpecial;
        private Controls.SpecialControl specialControl1;
    }
}
