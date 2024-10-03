namespace EquipmentRepair.WinForm.UI.Controls
{
    partial class EquipmentTypeControl
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
            listViewEquipmentTypes = new MaterialSkin2DotNet.Controls.MaterialListView();
            materialCard2 = new MaterialSkin2DotNet.Controls.MaterialCard();
            textBoxBrand = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            textBoxManufactureYear = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            textBoxCountry = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            materialCard1 = new MaterialSkin2DotNet.Controls.MaterialCard();
            buttonGet = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonAdd = new MaterialSkin2DotNet.Controls.MaterialButton();
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
            materialCard3.Controls.Add(listViewEquipmentTypes);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(14, 14);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(364, 220);
            materialCard3.TabIndex = 10;
            // 
            // listViewEquipmentTypes
            // 
            listViewEquipmentTypes.AccessibleRole = AccessibleRole.Table;
            listViewEquipmentTypes.AutoSizeTable = false;
            listViewEquipmentTypes.BackColor = Color.FromArgb(255, 255, 255);
            listViewEquipmentTypes.BorderStyle = BorderStyle.None;
            listViewEquipmentTypes.CausesValidation = false;
            listViewEquipmentTypes.Depth = 0;
            listViewEquipmentTypes.FullRowSelect = true;
            listViewEquipmentTypes.ImeMode = ImeMode.Close;
            listViewEquipmentTypes.Location = new Point(14, 12);
            listViewEquipmentTypes.MaximumSize = new Size(315, 200);
            listViewEquipmentTypes.MinimumSize = new Size(315, 200);
            listViewEquipmentTypes.MouseLocation = new Point(-1, -1);
            listViewEquipmentTypes.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            listViewEquipmentTypes.Name = "listViewEquipmentTypes";
            listViewEquipmentTypes.OwnerDraw = true;
            listViewEquipmentTypes.ShowItemToolTips = true;
            listViewEquipmentTypes.Size = new Size(315, 200);
            listViewEquipmentTypes.Sorting = SortOrder.Ascending;
            listViewEquipmentTypes.TabIndex = 7;
            listViewEquipmentTypes.UseCompatibleStateImageBehavior = false;
            listViewEquipmentTypes.View = View.Details;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.BorderStyle = BorderStyle.FixedSingle;
            materialCard2.Controls.Add(textBoxBrand);
            materialCard2.Controls.Add(textBoxManufactureYear);
            materialCard2.Controls.Add(textBoxCountry);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 243);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(489, 125);
            materialCard2.TabIndex = 9;
            // 
            // textBoxBrand
            // 
            textBoxBrand.AccessibleDescription = "";
            textBoxBrand.AccessibleName = "";
            textBoxBrand.AllowPromptAsInput = true;
            textBoxBrand.AnimateReadOnly = false;
            textBoxBrand.AsciiOnly = false;
            textBoxBrand.BackgroundImageLayout = ImageLayout.None;
            textBoxBrand.BeepOnError = false;
            textBoxBrand.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxBrand.Depth = 0;
            textBoxBrand.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxBrand.HelperText = "Cost";
            textBoxBrand.HidePromptOnLeave = false;
            textBoxBrand.HideSelection = true;
            textBoxBrand.InsertKeyMode = InsertKeyMode.Default;
            textBoxBrand.LeadingIcon = null;
            textBoxBrand.Location = new Point(248, 8);
            textBoxBrand.Mask = "";
            textBoxBrand.MaxLength = 32767;
            textBoxBrand.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.PasswordChar = '\0';
            textBoxBrand.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textBoxBrand.PrefixSuffixText = "Brand";
            textBoxBrand.PromptChar = '_';
            textBoxBrand.ReadOnly = false;
            textBoxBrand.RejectInputOnFirstFailure = false;
            textBoxBrand.ResetOnPrompt = true;
            textBoxBrand.ResetOnSpace = true;
            textBoxBrand.RightToLeft = RightToLeft.No;
            textBoxBrand.SelectedText = "";
            textBoxBrand.SelectionLength = 0;
            textBoxBrand.SelectionStart = 0;
            textBoxBrand.ShortcutsEnabled = true;
            textBoxBrand.Size = new Size(224, 48);
            textBoxBrand.SkipLiterals = true;
            textBoxBrand.TabIndex = 3;
            textBoxBrand.TabStop = false;
            textBoxBrand.TextAlign = HorizontalAlignment.Left;
            textBoxBrand.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxBrand.TrailingIcon = null;
            textBoxBrand.UseSystemPasswordChar = false;
            textBoxBrand.ValidatingType = null;
            // 
            // textBoxManufactureYear
            // 
            textBoxManufactureYear.AllowPromptAsInput = true;
            textBoxManufactureYear.AnimateReadOnly = false;
            textBoxManufactureYear.AsciiOnly = false;
            textBoxManufactureYear.BackgroundImageLayout = ImageLayout.None;
            textBoxManufactureYear.BeepOnError = false;
            textBoxManufactureYear.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxManufactureYear.Depth = 0;
            textBoxManufactureYear.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxManufactureYear.HelperText = "Duration";
            textBoxManufactureYear.HidePromptOnLeave = false;
            textBoxManufactureYear.HideSelection = true;
            textBoxManufactureYear.InsertKeyMode = InsertKeyMode.Default;
            textBoxManufactureYear.LeadingIcon = null;
            textBoxManufactureYear.Location = new Point(18, 62);
            textBoxManufactureYear.Mask = "";
            textBoxManufactureYear.MaxLength = 32767;
            textBoxManufactureYear.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            textBoxManufactureYear.Name = "textBoxManufactureYear";
            textBoxManufactureYear.PasswordChar = '\0';
            textBoxManufactureYear.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textBoxManufactureYear.PrefixSuffixText = "Manufacture Year";
            textBoxManufactureYear.PromptChar = '_';
            textBoxManufactureYear.ReadOnly = false;
            textBoxManufactureYear.RejectInputOnFirstFailure = false;
            textBoxManufactureYear.ResetOnPrompt = true;
            textBoxManufactureYear.ResetOnSpace = true;
            textBoxManufactureYear.RightToLeft = RightToLeft.No;
            textBoxManufactureYear.SelectedText = "";
            textBoxManufactureYear.SelectionLength = 0;
            textBoxManufactureYear.SelectionStart = 0;
            textBoxManufactureYear.ShortcutsEnabled = true;
            textBoxManufactureYear.Size = new Size(224, 48);
            textBoxManufactureYear.SkipLiterals = true;
            textBoxManufactureYear.TabIndex = 1;
            textBoxManufactureYear.TabStop = false;
            textBoxManufactureYear.TextAlign = HorizontalAlignment.Left;
            textBoxManufactureYear.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxManufactureYear.TrailingIcon = null;
            textBoxManufactureYear.UseSystemPasswordChar = false;
            textBoxManufactureYear.ValidatingType = null;
            // 
            // textBoxCountry
            // 
            textBoxCountry.AllowPromptAsInput = true;
            textBoxCountry.AnimateReadOnly = false;
            textBoxCountry.AsciiOnly = false;
            textBoxCountry.BackgroundImageLayout = ImageLayout.None;
            textBoxCountry.BeepOnError = false;
            textBoxCountry.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxCountry.Depth = 0;
            textBoxCountry.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxCountry.HelperText = "Name";
            textBoxCountry.HidePromptOnLeave = false;
            textBoxCountry.HideSelection = true;
            textBoxCountry.InsertKeyMode = InsertKeyMode.Default;
            textBoxCountry.LeadingIcon = null;
            textBoxCountry.Location = new Point(18, 8);
            textBoxCountry.Mask = "";
            textBoxCountry.MaxLength = 32767;
            textBoxCountry.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.PasswordChar = '\0';
            textBoxCountry.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textBoxCountry.PrefixSuffixText = "Country";
            textBoxCountry.PromptChar = '_';
            textBoxCountry.ReadOnly = false;
            textBoxCountry.RejectInputOnFirstFailure = false;
            textBoxCountry.ResetOnPrompt = true;
            textBoxCountry.ResetOnSpace = true;
            textBoxCountry.RightToLeft = RightToLeft.No;
            textBoxCountry.SelectedText = "";
            textBoxCountry.SelectionLength = 0;
            textBoxCountry.SelectionStart = 0;
            textBoxCountry.ShortcutsEnabled = true;
            textBoxCountry.Size = new Size(224, 48);
            textBoxCountry.SkipLiterals = true;
            textBoxCountry.TabIndex = 0;
            textBoxCountry.TabStop = false;
            textBoxCountry.TextAlign = HorizontalAlignment.Left;
            textBoxCountry.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxCountry.TrailingIcon = null;
            textBoxCountry.UseSystemPasswordChar = false;
            textBoxCountry.ValidatingType = null;
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
            materialCard1.TabIndex = 8;
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
            // EquipmentTypeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Name = "EquipmentTypeControl";
            Size = new Size(521, 382);
            materialCard3.ResumeLayout(false);
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialCard materialCard3;
        public MaterialSkin2DotNet.Controls.MaterialListView listViewEquipmentTypes;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard2;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textBoxBrand;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textBoxManufactureYear;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textBoxCountry;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard1;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonGet;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonDelete;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonUpdate;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonAdd;
    }
}
