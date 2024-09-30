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
            materialCard2 = new MaterialSkin2DotNet.Controls.MaterialCard();
            materialCard1 = new MaterialSkin2DotNet.Controls.MaterialCard();
            buttonGet = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonAdd = new MaterialSkin2DotNet.Controls.MaterialButton();
            сardRepairTypes = new MaterialSkin2DotNet.Controls.MaterialCard();
            listBoxRepairTypes = new MaterialSkin2DotNet.Controls.MaterialListView();
            tabPage2 = new TabPage();
            mainTabSelector = new MaterialSkin2DotNet.Controls.MaterialTabSelector();
            ThemeToggleButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            mainlTabControl.SuspendLayout();
            tabRepairTypes.SuspendLayout();
            materialCard1.SuspendLayout();
            сardRepairTypes.SuspendLayout();
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
            mainlTabControl.Size = new Size(653, 431);
            mainlTabControl.TabIndex = 0;
            // 
            // tabRepairTypes
            // 
            tabRepairTypes.AllowDrop = true;
            tabRepairTypes.AutoScroll = true;
            tabRepairTypes.BackColor = Color.White;
            tabRepairTypes.BorderStyle = BorderStyle.Fixed3D;
            tabRepairTypes.Controls.Add(materialCard2);
            tabRepairTypes.Controls.Add(materialCard1);
            tabRepairTypes.Controls.Add(сardRepairTypes);
            tabRepairTypes.Location = new Point(4, 24);
            tabRepairTypes.Name = "tabRepairTypes";
            tabRepairTypes.Padding = new Padding(3);
            tabRepairTypes.Size = new Size(645, 403);
            tabRepairTypes.TabIndex = 0;
            tabRepairTypes.Text = "Repair Types";
            // 
            // materialCard2
            // 
            materialCard2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(12, 240);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(624, 154);
            materialCard2.TabIndex = 3;
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(buttonGet);
            materialCard1.Controls.Add(buttonDelete);
            materialCard1.Controls.Add(buttonUpdate);
            materialCard1.Controls.Add(buttonAdd);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(453, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(183, 217);
            materialCard1.TabIndex = 2;
            // 
            // buttonGet
            // 
            buttonGet.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonGet.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonGet.Depth = 0;
            buttonGet.HighEmphasis = true;
            buttonGet.Icon = null;
            buttonGet.Location = new Point(12, 163);
            buttonGet.Margin = new Padding(4, 6, 4, 6);
            buttonGet.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            buttonGet.Name = "buttonGet";
            buttonGet.NoAccentTextColor = Color.Empty;
            buttonGet.Size = new Size(64, 36);
            buttonGet.TabIndex = 3;
            buttonGet.Text = "Get";
            buttonGet.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonGet.UseAccentColor = false;
            buttonGet.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDelete.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonDelete.Depth = 0;
            buttonDelete.HighEmphasis = true;
            buttonDelete.Icon = null;
            buttonDelete.Location = new Point(12, 115);
            buttonDelete.Margin = new Padding(4, 6, 4, 6);
            buttonDelete.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            buttonDelete.Name = "buttonDelete";
            buttonDelete.NoAccentTextColor = Color.Empty;
            buttonDelete.Size = new Size(73, 36);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Delete";
            buttonDelete.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonDelete.UseAccentColor = false;
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonUpdate.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonUpdate.Depth = 0;
            buttonUpdate.HighEmphasis = true;
            buttonUpdate.Icon = null;
            buttonUpdate.Location = new Point(12, 67);
            buttonUpdate.Margin = new Padding(4, 6, 4, 6);
            buttonUpdate.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.NoAccentTextColor = Color.Empty;
            buttonUpdate.Size = new Size(77, 36);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonUpdate.UseAccentColor = false;
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonAdd.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            buttonAdd.Depth = 0;
            buttonAdd.HighEmphasis = true;
            buttonAdd.Icon = null;
            buttonAdd.Location = new Point(12, 19);
            buttonAdd.Margin = new Padding(4, 6, 4, 6);
            buttonAdd.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            buttonAdd.Name = "buttonAdd";
            buttonAdd.NoAccentTextColor = Color.Empty;
            buttonAdd.Size = new Size(64, 36);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            buttonAdd.UseAccentColor = false;
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // сardRepairTypes
            // 
            сardRepairTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            сardRepairTypes.BackColor = Color.FromArgb(255, 255, 255);
            сardRepairTypes.Controls.Add(listBoxRepairTypes);
            сardRepairTypes.Depth = 0;
            сardRepairTypes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            сardRepairTypes.Location = new Point(12, 12);
            сardRepairTypes.Margin = new Padding(14);
            сardRepairTypes.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            сardRepairTypes.Name = "сardRepairTypes";
            сardRepairTypes.Padding = new Padding(14);
            сardRepairTypes.Size = new Size(435, 219);
            сardRepairTypes.TabIndex = 1;
            // 
            // listBoxRepairTypes
            // 
            listBoxRepairTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxRepairTypes.AutoSizeTable = false;
            listBoxRepairTypes.BackColor = Color.FromArgb(255, 255, 255);
            listBoxRepairTypes.BorderStyle = BorderStyle.None;
            listBoxRepairTypes.Depth = 0;
            listBoxRepairTypes.FullRowSelect = true;
            listBoxRepairTypes.Location = new Point(31, 21);
            listBoxRepairTypes.MinimumSize = new Size(200, 100);
            listBoxRepairTypes.MouseLocation = new Point(-1, -1);
            listBoxRepairTypes.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            listBoxRepairTypes.Name = "listBoxRepairTypes";
            listBoxRepairTypes.OwnerDraw = true;
            listBoxRepairTypes.Size = new Size(387, 181);
            listBoxRepairTypes.TabIndex = 0;
            listBoxRepairTypes.UseCompatibleStateImageBehavior = false;
            listBoxRepairTypes.View = View.Details;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(645, 403);
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
            ThemeToggleButton.Location = new Point(666, 91);
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
            ClientSize = new Size(831, 504);
            Controls.Add(ThemeToggleButton);
            Controls.Add(mainTabSelector);
            Controls.Add(mainlTabControl);
            Name = "MainForm";
            Text = "Equipment Repair";
            Load += Form1_Load;
            mainlTabControl.ResumeLayout(false);
            tabRepairTypes.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            сardRepairTypes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTabControl mainlTabControl;
        private TabPage tabRepairTypes;
        private TabPage tabPage2;
        private MaterialSkin2DotNet.Controls.MaterialTabSelector mainTabSelector;
        private MaterialSkin2DotNet.Controls.MaterialButton ThemeToggleButton;
        private MaterialSkin2DotNet.Controls.MaterialListView listBoxRepairTypes;
        private MaterialSkin2DotNet.Controls.MaterialCard сardRepairTypes;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard1;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard2;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonGet;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonDelete;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonUpdate;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonAdd;
    }
}
