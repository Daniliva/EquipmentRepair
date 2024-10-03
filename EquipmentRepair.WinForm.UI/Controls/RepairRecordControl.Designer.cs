namespace EquipmentRepair.WinForm.UI.Controls
{
    partial class RepairRecordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialCard3 = new MaterialSkin2DotNet.Controls.MaterialCard();
            listBoxRepairRecords = new MaterialSkin2DotNet.Controls.MaterialListView();
            materialCard2 = new MaterialSkin2DotNet.Controls.MaterialCard();
            dateTimePickerStartDate = new DateTimePicker();
            textBoxRepairQuality = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            listBoxRepairTypes = new MaterialSkin2DotNet.Controls.MaterialListBox();
            listBoxEquipmentTypes = new MaterialSkin2DotNet.Controls.MaterialListBox();
            materialCard1 = new MaterialSkin2DotNet.Controls.MaterialCard();
            buttonGet = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonAdd = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialReloadButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialCard3.SuspendLayout();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard3
            // 
            materialCard3.AutoScroll = true;
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.BorderStyle = BorderStyle.FixedSingle;
            materialCard3.Controls.Add(listBoxRepairRecords);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(14, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(364, 220);
            materialCard3.TabIndex = 13;
            // 
            // listBoxRepairRecords
            // 
            listBoxRepairRecords.AccessibleRole = AccessibleRole.Table;
            listBoxRepairRecords.AutoSizeTable = false;
            listBoxRepairRecords.BackColor = Color.FromArgb(255, 255, 255);
            listBoxRepairRecords.BorderStyle = BorderStyle.None;
            listBoxRepairRecords.CausesValidation = false;
            listBoxRepairRecords.Depth = 0;
            listBoxRepairRecords.FullRowSelect = true;
            listBoxRepairRecords.ImeMode = ImeMode.Close;
            listBoxRepairRecords.Location = new Point(14, 12);
            listBoxRepairRecords.MaximumSize = new Size(315, 200);
            listBoxRepairRecords.MinimumSize = new Size(315, 200);
            listBoxRepairRecords.MouseLocation = new Point(-1, -1);
            listBoxRepairRecords.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            listBoxRepairRecords.Name = "listBoxRepairRecords";
            listBoxRepairRecords.OwnerDraw = true;
            listBoxRepairRecords.ShowItemToolTips = true;
            listBoxRepairRecords.Size = new Size(315, 200);
            listBoxRepairRecords.Sorting = SortOrder.Ascending;
            listBoxRepairRecords.TabIndex = 7;
            listBoxRepairRecords.UseCompatibleStateImageBehavior = false;
            listBoxRepairRecords.View = View.Details;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.BorderStyle = BorderStyle.FixedSingle;
            materialCard2.Controls.Add(dateTimePickerStartDate);
            materialCard2.Controls.Add(textBoxRepairQuality);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 243);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(259, 140);
            materialCard2.TabIndex = 12;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(14, 86);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(224, 23);
            dateTimePickerStartDate.TabIndex = 1;
            // 
            // textBoxRepairQuality
            // 
            textBoxRepairQuality.AllowPromptAsInput = true;
            textBoxRepairQuality.AnimateReadOnly = false;
            textBoxRepairQuality.AsciiOnly = false;
            textBoxRepairQuality.BackgroundImageLayout = ImageLayout.None;
            textBoxRepairQuality.BeepOnError = false;
            textBoxRepairQuality.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxRepairQuality.Depth = 0;
            textBoxRepairQuality.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxRepairQuality.HelperText = "Name";
            textBoxRepairQuality.HidePromptOnLeave = false;
            textBoxRepairQuality.HideSelection = true;
            textBoxRepairQuality.InsertKeyMode = InsertKeyMode.Default;
            textBoxRepairQuality.LeadingIcon = null;
            textBoxRepairQuality.Location = new Point(18, 7);
            textBoxRepairQuality.Mask = "";
            textBoxRepairQuality.MaxLength = 32767;
            textBoxRepairQuality.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            textBoxRepairQuality.Name = "textBoxRepairQuality";
            textBoxRepairQuality.PasswordChar = '\0';
            textBoxRepairQuality.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textBoxRepairQuality.PrefixSuffixText = "Repair Quality";
            textBoxRepairQuality.PromptChar = '_';
            textBoxRepairQuality.ReadOnly = false;
            textBoxRepairQuality.RejectInputOnFirstFailure = false;
            textBoxRepairQuality.ResetOnPrompt = true;
            textBoxRepairQuality.ResetOnSpace = true;
            textBoxRepairQuality.RightToLeft = RightToLeft.No;
            textBoxRepairQuality.SelectedText = "";
            textBoxRepairQuality.SelectionLength = 0;
            textBoxRepairQuality.SelectionStart = 0;
            textBoxRepairQuality.ShortcutsEnabled = true;
            textBoxRepairQuality.Size = new Size(224, 48);
            textBoxRepairQuality.SkipLiterals = true;
            textBoxRepairQuality.TabIndex = 0;
            textBoxRepairQuality.TabStop = false;
            textBoxRepairQuality.TextAlign = HorizontalAlignment.Left;
            textBoxRepairQuality.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxRepairQuality.TrailingIcon = null;
            textBoxRepairQuality.UseSystemPasswordChar = false;
            textBoxRepairQuality.ValidatingType = null;
            // 
            // listBoxRepairTypes
            // 
            listBoxRepairTypes.BackColor = Color.White;
            listBoxRepairTypes.BorderColor = Color.LightGray;
            listBoxRepairTypes.Depth = 0;
            listBoxRepairTypes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxRepairTypes.Location = new Point(277, 316);
            listBoxRepairTypes.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            listBoxRepairTypes.Name = "listBoxRepairTypes";
            listBoxRepairTypes.SelectedIndex = -1;
            listBoxRepairTypes.SelectedItem = null;
            listBoxRepairTypes.ShowScrollBar = true;
            listBoxRepairTypes.Size = new Size(226, 67);
            listBoxRepairTypes.Style = MaterialSkin2DotNet.Controls.MaterialListBox.ListBoxStyle.ThreeLine;
            listBoxRepairTypes.TabIndex = 0;
            // 
            // listBoxEquipmentTypes
            // 
            listBoxEquipmentTypes.BackColor = Color.White;
            listBoxEquipmentTypes.BorderColor = Color.LightGray;
            listBoxEquipmentTypes.Depth = 0;
            listBoxEquipmentTypes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxEquipmentTypes.Location = new Point(277, 243);
            listBoxEquipmentTypes.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            listBoxEquipmentTypes.Name = "listBoxEquipmentTypes";
            listBoxEquipmentTypes.SelectedIndex = -1;
            listBoxEquipmentTypes.SelectedItem = null;
            listBoxEquipmentTypes.ShowBorder = false;
            listBoxEquipmentTypes.Size = new Size(226, 67);
            listBoxEquipmentTypes.Style = MaterialSkin2DotNet.Controls.MaterialListBox.ListBoxStyle.TwoLine;
            listBoxEquipmentTypes.TabIndex = 0;
            listBoxEquipmentTypes.Tag = "Equipment Types";
            listBoxEquipmentTypes.UseAccentColor = true;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.BorderStyle = BorderStyle.FixedSingle;
            materialCard1.Controls.Add(buttonGet);
            materialCard1.Controls.Add(buttonDelete);
            materialCard1.Controls.Add(buttonUpdate);
            materialCard1.Controls.Add(buttonAdd);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(389, 15);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(114, 220);
            materialCard1.TabIndex = 11;
            materialCard1.TabStop = true;
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
            buttonGet.Click += buttonGet_Click;
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
            buttonDelete.Click += buttonDelete_Click;
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
            buttonUpdate.Click += buttonUpdate_Click;
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
            buttonAdd.Click += buttonAdd_Click;
            // 
            // materialReloadButton
            // 
            materialReloadButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialReloadButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialReloadButton.Depth = 0;
            materialReloadButton.HighEmphasis = true;
            materialReloadButton.Icon = null;
            materialReloadButton.Location = new Point(521, 35);
            materialReloadButton.Margin = new Padding(4, 6, 4, 6);
            materialReloadButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialReloadButton.Name = "materialReloadButton";
            materialReloadButton.NoAccentTextColor = Color.Empty;
            materialReloadButton.Size = new Size(77, 36);
            materialReloadButton.TabIndex = 14;
            materialReloadButton.Text = "Reload";
            materialReloadButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            materialReloadButton.UseAccentColor = false;
            materialReloadButton.UseVisualStyleBackColor = true;
            materialReloadButton.Click += materialReloadButton_Click;
            // 
            // RepairRecordControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxEquipmentTypes);
            Controls.Add(listBoxRepairTypes);
            Controls.Add(materialReloadButton);
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Name = "RepairRecordControl";
            Size = new Size(635, 405);
            Load += RepairRecordControl_Load;
            materialCard3.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialCard materialCard3;
        public MaterialSkin2DotNet.Controls.MaterialListView listBoxRepairRecords;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard2;
        private MaterialSkin2DotNet.Controls.MaterialListBox listBoxRepairTypes;
        private MaterialSkin2DotNet.Controls.MaterialListBox listBoxEquipmentTypes;
        private DateTimePicker dateTimePickerStartDate;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textBoxRepairQuality;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard1;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonGet;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonDelete;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonUpdate;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonAdd;
        private MaterialSkin2DotNet.Controls.MaterialButton materialReloadButton;
    }
}
