using MaterialSkin2DotNet;

namespace EquipmentRepair.WinForm.UI.Controls
{
    partial class RepairTypeControl
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
            materialCard2 = new MaterialSkin2DotNet.Controls.MaterialCard();
            textBoxCost = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            textBoxNotes = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            textBoxDuration = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            textBoxName = new MaterialSkin2DotNet.Controls.MaterialMaskedTextBox();
            materialCard1 = new MaterialSkin2DotNet.Controls.MaterialCard();
            buttonGet = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonDelete = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonUpdate = new MaterialSkin2DotNet.Controls.MaterialButton();
            buttonAdd = new MaterialSkin2DotNet.Controls.MaterialButton();
            listBoxRepairTypes = new MaterialSkin2DotNet.Controls.MaterialListView();
            materialCard2.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.BorderStyle = BorderStyle.FixedSingle;
            materialCard2.Controls.Add(textBoxCost);
            materialCard2.Controls.Add(textBoxNotes);
            materialCard2.Controls.Add(textBoxDuration);
            materialCard2.Controls.Add(textBoxName);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 243);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(550, 125);
            materialCard2.TabIndex = 6;
            // 
            // textBoxCost
            // 
            textBoxCost.AccessibleDescription = "";
            textBoxCost.AccessibleName = "";
            textBoxCost.AllowPromptAsInput = true;
            textBoxCost.AnimateReadOnly = false;
            textBoxCost.AsciiOnly = false;
            textBoxCost.BackgroundImageLayout = ImageLayout.None;
            textBoxCost.BeepOnError = false;
            textBoxCost.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxCost.Depth = 0;
            textBoxCost.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxCost.HelperText = "Cost";
            textBoxCost.HidePromptOnLeave = false;
            textBoxCost.HideSelection = true;
            textBoxCost.InsertKeyMode = InsertKeyMode.Default;
            textBoxCost.LeadingIcon = null;
            textBoxCost.Location = new Point(248, 7);
            textBoxCost.Mask = "";
            textBoxCost.MaxLength = 32767;
            textBoxCost.MouseState = MouseState.OUT;
            textBoxCost.Name = "textBoxCost";
            textBoxCost.PasswordChar = '\0';
            textBoxCost.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textBoxCost.PrefixSuffixText = "Cost";
            textBoxCost.PromptChar = '_';
            textBoxCost.ReadOnly = false;
            textBoxCost.RejectInputOnFirstFailure = false;
            textBoxCost.ResetOnPrompt = true;
            textBoxCost.ResetOnSpace = true;
            textBoxCost.RightToLeft = RightToLeft.No;
            textBoxCost.SelectedText = "";
            textBoxCost.SelectionLength = 0;
            textBoxCost.SelectionStart = 0;
            textBoxCost.ShortcutsEnabled = true;
            textBoxCost.Size = new Size(224, 48);
            textBoxCost.SkipLiterals = true;
            textBoxCost.TabIndex = 3;
            textBoxCost.TabStop = false;
            textBoxCost.TextAlign = HorizontalAlignment.Left;
            textBoxCost.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxCost.TrailingIcon = null;
            textBoxCost.UseSystemPasswordChar = false;
            textBoxCost.ValidatingType = null;
            // 
            // textBoxNotes
            // 
            textBoxNotes.AllowPromptAsInput = true;
            textBoxNotes.AnimateReadOnly = false;
            textBoxNotes.AsciiOnly = false;
            textBoxNotes.BackgroundImageLayout = ImageLayout.None;
            textBoxNotes.BeepOnError = false;
            textBoxNotes.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxNotes.Depth = 0;
            textBoxNotes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxNotes.HelperText = "Notes";
            textBoxNotes.HidePromptOnLeave = false;
            textBoxNotes.HideSelection = true;
            textBoxNotes.InsertKeyMode = InsertKeyMode.Default;
            textBoxNotes.LeadingIcon = null;
            textBoxNotes.Location = new Point(248, 61);
            textBoxNotes.Mask = "";
            textBoxNotes.MaxLength = 32767;
            textBoxNotes.MouseState = MouseState.OUT;
            textBoxNotes.Name = "textBoxNotes";
            textBoxNotes.PasswordChar = '\0';
            textBoxNotes.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textBoxNotes.PrefixSuffixText = "Notes";
            textBoxNotes.PromptChar = '_';
            textBoxNotes.ReadOnly = false;
            textBoxNotes.RejectInputOnFirstFailure = false;
            textBoxNotes.ResetOnPrompt = true;
            textBoxNotes.ResetOnSpace = true;
            textBoxNotes.RightToLeft = RightToLeft.No;
            textBoxNotes.SelectedText = "";
            textBoxNotes.SelectionLength = 0;
            textBoxNotes.SelectionStart = 0;
            textBoxNotes.ShortcutsEnabled = true;
            textBoxNotes.Size = new Size(224, 48);
            textBoxNotes.SkipLiterals = true;
            textBoxNotes.TabIndex = 2;
            textBoxNotes.TabStop = false;
            textBoxNotes.TextAlign = HorizontalAlignment.Left;
            textBoxNotes.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxNotes.TrailingIcon = null;
            textBoxNotes.UseSystemPasswordChar = false;
            textBoxNotes.ValidatingType = null;
            // 
            // textBoxDuration
            // 
            textBoxDuration.AllowPromptAsInput = true;
            textBoxDuration.AnimateReadOnly = false;
            textBoxDuration.AsciiOnly = false;
            textBoxDuration.BackgroundImageLayout = ImageLayout.None;
            textBoxDuration.BeepOnError = false;
            textBoxDuration.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxDuration.Depth = 0;
            textBoxDuration.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxDuration.HelperText = "Duration";
            textBoxDuration.HidePromptOnLeave = false;
            textBoxDuration.HideSelection = true;
            textBoxDuration.InsertKeyMode = InsertKeyMode.Default;
            textBoxDuration.LeadingIcon = null;
            textBoxDuration.Location = new Point(18, 62);
            textBoxDuration.Mask = "";
            textBoxDuration.MaxLength = 32767;
            textBoxDuration.MouseState = MouseState.OUT;
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.PasswordChar = '\0';
            textBoxDuration.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textBoxDuration.PrefixSuffixText = "Duration";
            textBoxDuration.PromptChar = '_';
            textBoxDuration.ReadOnly = false;
            textBoxDuration.RejectInputOnFirstFailure = false;
            textBoxDuration.ResetOnPrompt = true;
            textBoxDuration.ResetOnSpace = true;
            textBoxDuration.RightToLeft = RightToLeft.No;
            textBoxDuration.SelectedText = "";
            textBoxDuration.SelectionLength = 0;
            textBoxDuration.SelectionStart = 0;
            textBoxDuration.ShortcutsEnabled = true;
            textBoxDuration.Size = new Size(224, 48);
            textBoxDuration.SkipLiterals = true;
            textBoxDuration.TabIndex = 1;
            textBoxDuration.TabStop = false;
            textBoxDuration.TextAlign = HorizontalAlignment.Left;
            textBoxDuration.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxDuration.TrailingIcon = null;
            textBoxDuration.UseSystemPasswordChar = false;
            textBoxDuration.ValidatingType = null;
            // 
            // textBoxName
            // 
            textBoxName.AllowPromptAsInput = true;
            textBoxName.AnimateReadOnly = false;
            textBoxName.AsciiOnly = false;
            textBoxName.BackgroundImageLayout = ImageLayout.None;
            textBoxName.BeepOnError = false;
            textBoxName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            textBoxName.Depth = 0;
            textBoxName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBoxName.HelperText = "Name";
            textBoxName.HidePromptOnLeave = false;
            textBoxName.HideSelection = true;
            textBoxName.InsertKeyMode = InsertKeyMode.Default;
            textBoxName.LeadingIcon = null;
            textBoxName.Location = new Point(18, 8);
            textBoxName.Mask = "";
            textBoxName.MaxLength = 32767;
            textBoxName.MouseState = MouseState.OUT;
            textBoxName.Name = "textBoxName";
            textBoxName.PasswordChar = '\0';
            textBoxName.PrefixSuffix = MaterialSkin2DotNet.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            textBoxName.PrefixSuffixText = "Name";
            textBoxName.PromptChar = '_';
            textBoxName.ReadOnly = false;
            textBoxName.RejectInputOnFirstFailure = false;
            textBoxName.ResetOnPrompt = true;
            textBoxName.ResetOnSpace = true;
            textBoxName.RightToLeft = RightToLeft.No;
            textBoxName.SelectedText = "";
            textBoxName.SelectionLength = 0;
            textBoxName.SelectionStart = 0;
            textBoxName.ShortcutsEnabled = true;
            textBoxName.Size = new Size(224, 48);
            textBoxName.SkipLiterals = true;
            textBoxName.TabIndex = 0;
            textBoxName.TabStop = false;
            textBoxName.TextAlign = HorizontalAlignment.Left;
            textBoxName.TextMaskFormat = MaskFormat.IncludeLiterals;
            textBoxName.TrailingIcon = null;
            textBoxName.UseSystemPasswordChar = false;
            textBoxName.ValidatingType = null;
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
            materialCard1.Location = new Point(571, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(114, 220);
            materialCard1.TabIndex = 5;
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
            buttonGet.MouseState = MouseState.HOVER;
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
            buttonDelete.MouseState = MouseState.HOVER;
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
            buttonUpdate.MouseState = MouseState.HOVER;
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
            buttonAdd.MouseState = MouseState.HOVER;
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
            // listBoxRepairTypes
            // 
            listBoxRepairTypes.AutoSizeTable = true;
            listBoxRepairTypes.BackColor = Color.FromArgb(255, 255, 255);
            listBoxRepairTypes.BorderStyle = BorderStyle.FixedSingle;
            listBoxRepairTypes.Depth = 0;
            listBoxRepairTypes.FullRowSelect = true;
            listBoxRepairTypes.Location = new Point(14, 14);
            listBoxRepairTypes.MinimumSize = new Size(200, 100);
            listBoxRepairTypes.MouseLocation = new Point(-1, -1);
            listBoxRepairTypes.MouseState = MouseState.OUT;
            listBoxRepairTypes.Name = "listBoxRepairTypes";
            listBoxRepairTypes.OwnerDraw = true;
            listBoxRepairTypes.Scrollable = false;
            listBoxRepairTypes.ShowItemToolTips = true;
            listBoxRepairTypes.Size = new Size(550, 220);
            listBoxRepairTypes.TabIndex = 7;
            listBoxRepairTypes.UseCompatibleStateImageBehavior = false;
            listBoxRepairTypes.View = View.Details;
            // 
            // RepairTypeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxRepairTypes);
            Controls.Add(materialCard2);
            Controls.Add(materialCard1);
            Name = "RepairTypeControl";
            Size = new Size(772, 396);
            materialCard2.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialCard materialCard2;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textBoxCost;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textBoxNotes;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textBoxDuration;
        private MaterialSkin2DotNet.Controls.MaterialMaskedTextBox textBoxName;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard1;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonGet;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonDelete;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonUpdate;
        private MaterialSkin2DotNet.Controls.MaterialButton buttonAdd;
        private MaterialSkin2DotNet.Controls.MaterialListView listBoxRepairTypes;
    }
}
