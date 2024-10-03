namespace EquipmentRepair.WinForm.UI.Controls
{
    partial class SpecialControl
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
            btnLoadData = new MaterialSkin2DotNet.Controls.MaterialButton();
            datePickerStart = new DateTimePicker();
            listViewRecordsByDate = new MaterialSkin2DotNet.Controls.MaterialListView();
            datePickerEnd = new DateTimePicker();
            materialCard2 = new MaterialSkin2DotNet.Controls.MaterialCard();
            materialCard3 = new MaterialSkin2DotNet.Controls.MaterialCard();
            listViewRepairCounts = new MaterialSkin2DotNet.Controls.MaterialListView();
            btnLoadRepairCounts = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialCard4 = new MaterialSkin2DotNet.Controls.MaterialCard();
            listViewRepairCosts = new MaterialSkin2DotNet.Controls.MaterialListView();
            BtnRepairCosts = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialCard5 = new MaterialSkin2DotNet.Controls.MaterialCard();
            listViewRecordsWithDetails = new MaterialSkin2DotNet.Controls.MaterialListView();
            btnRecordsWithDetails = new MaterialSkin2DotNet.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin2DotNet.Controls.MaterialLabel();
            materialCard2.SuspendLayout();
            materialCard3.SuspendLayout();
            materialCard4.SuspendLayout();
            materialCard5.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadData
            // 
            btnLoadData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoadData.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLoadData.Depth = 0;
            btnLoadData.HighEmphasis = true;
            btnLoadData.Icon = null;
            btnLoadData.Location = new Point(50, 137);
            btnLoadData.Margin = new Padding(4, 6, 4, 6);
            btnLoadData.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnLoadData.Name = "btnLoadData";
            btnLoadData.NoAccentTextColor = Color.Empty;
            btnLoadData.Size = new Size(100, 36);
            btnLoadData.TabIndex = 0;
            btnLoadData.Text = "Load Data";
            btnLoadData.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLoadData.UseAccentColor = false;
            btnLoadData.UseVisualStyleBackColor = true;
            // 
            // datePickerStart
            // 
            datePickerStart.Location = new Point(203, 137);
            datePickerStart.Name = "datePickerStart";
            datePickerStart.Size = new Size(200, 23);
            datePickerStart.TabIndex = 2;
            // 
            // listViewRecordsByDate
            // 
            listViewRecordsByDate.AutoSizeTable = false;
            listViewRecordsByDate.BackColor = Color.FromArgb(255, 255, 255);
            listViewRecordsByDate.BorderStyle = BorderStyle.None;
            listViewRecordsByDate.Depth = 0;
            listViewRecordsByDate.FullRowSelect = true;
            listViewRecordsByDate.Location = new Point(11, 17);
            listViewRecordsByDate.MinimumSize = new Size(200, 100);
            listViewRecordsByDate.MouseLocation = new Point(-1, -1);
            listViewRecordsByDate.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            listViewRecordsByDate.Name = "listViewRecordsByDate";
            listViewRecordsByDate.OwnerDraw = true;
            listViewRecordsByDate.Size = new Size(392, 100);
            listViewRecordsByDate.TabIndex = 1;
            listViewRecordsByDate.UseCompatibleStateImageBehavior = false;
            listViewRecordsByDate.View = View.Details;
            // 
            // datePickerEnd
            // 
            datePickerEnd.Location = new Point(203, 166);
            datePickerEnd.Name = "datePickerEnd";
            datePickerEnd.Size = new Size(200, 23);
            datePickerEnd.TabIndex = 3;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.BorderStyle = BorderStyle.FixedSingle;
            materialCard2.Controls.Add(listViewRecordsByDate);
            materialCard2.Controls.Add(materialLabel1);
            materialCard2.Controls.Add(btnLoadData);
            materialCard2.Controls.Add(datePickerEnd);
            materialCard2.Controls.Add(datePickerStart);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(14, 14);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(422, 224);
            materialCard2.TabIndex = 4;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.BorderStyle = BorderStyle.FixedSingle;
            materialCard3.Controls.Add(materialLabel2);
            materialCard3.Controls.Add(listViewRepairCounts);
            materialCard3.Controls.Add(btnLoadRepairCounts);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(14, 251);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(422, 224);
            materialCard3.TabIndex = 5;
            // 
            // listViewRepairCounts
            // 
            listViewRepairCounts.AutoSizeTable = false;
            listViewRepairCounts.BackColor = Color.FromArgb(255, 255, 255);
            listViewRepairCounts.BorderStyle = BorderStyle.None;
            listViewRepairCounts.Depth = 0;
            listViewRepairCounts.FullRowSelect = true;
            listViewRepairCounts.Location = new Point(11, 17);
            listViewRepairCounts.MinimumSize = new Size(200, 100);
            listViewRepairCounts.MouseLocation = new Point(-1, -1);
            listViewRepairCounts.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            listViewRepairCounts.Name = "listViewRepairCounts";
            listViewRepairCounts.OwnerDraw = true;
            listViewRepairCounts.Size = new Size(392, 100);
            listViewRepairCounts.TabIndex = 1;
            listViewRepairCounts.UseCompatibleStateImageBehavior = false;
            listViewRepairCounts.View = View.Details;
            // 
            // btnLoadRepairCounts
            // 
            btnLoadRepairCounts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoadRepairCounts.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLoadRepairCounts.Depth = 0;
            btnLoadRepairCounts.HighEmphasis = true;
            btnLoadRepairCounts.Icon = null;
            btnLoadRepairCounts.Location = new Point(50, 137);
            btnLoadRepairCounts.Margin = new Padding(4, 6, 4, 6);
            btnLoadRepairCounts.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnLoadRepairCounts.Name = "btnLoadRepairCounts";
            btnLoadRepairCounts.NoAccentTextColor = Color.Empty;
            btnLoadRepairCounts.Size = new Size(100, 36);
            btnLoadRepairCounts.TabIndex = 0;
            btnLoadRepairCounts.Text = "Load Data";
            btnLoadRepairCounts.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLoadRepairCounts.UseAccentColor = false;
            btnLoadRepairCounts.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.BorderStyle = BorderStyle.FixedSingle;
            materialCard4.Controls.Add(materialLabel3);
            materialCard4.Controls.Add(listViewRepairCosts);
            materialCard4.Controls.Add(BtnRepairCosts);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(448, 14);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(422, 224);
            materialCard4.TabIndex = 6;
            // 
            // listViewRepairCosts
            // 
            listViewRepairCosts.AutoSizeTable = false;
            listViewRepairCosts.BackColor = Color.FromArgb(255, 255, 255);
            listViewRepairCosts.BorderStyle = BorderStyle.None;
            listViewRepairCosts.Depth = 0;
            listViewRepairCosts.FullRowSelect = true;
            listViewRepairCosts.Location = new Point(11, 17);
            listViewRepairCosts.MinimumSize = new Size(200, 100);
            listViewRepairCosts.MouseLocation = new Point(-1, -1);
            listViewRepairCosts.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            listViewRepairCosts.Name = "listViewRepairCosts";
            listViewRepairCosts.OwnerDraw = true;
            listViewRepairCosts.Size = new Size(392, 100);
            listViewRepairCosts.TabIndex = 1;
            listViewRepairCosts.UseCompatibleStateImageBehavior = false;
            listViewRepairCosts.View = View.Details;
            // 
            // BtnRepairCosts
            // 
            BtnRepairCosts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRepairCosts.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            BtnRepairCosts.Depth = 0;
            BtnRepairCosts.HighEmphasis = true;
            BtnRepairCosts.Icon = null;
            BtnRepairCosts.Location = new Point(50, 137);
            BtnRepairCosts.Margin = new Padding(4, 6, 4, 6);
            BtnRepairCosts.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            BtnRepairCosts.Name = "BtnRepairCosts";
            BtnRepairCosts.NoAccentTextColor = Color.Empty;
            BtnRepairCosts.Size = new Size(100, 36);
            BtnRepairCosts.TabIndex = 0;
            BtnRepairCosts.Text = "Load Data";
            BtnRepairCosts.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            BtnRepairCosts.UseAccentColor = false;
            BtnRepairCosts.UseVisualStyleBackColor = true;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.BorderStyle = BorderStyle.FixedSingle;
            materialCard5.Controls.Add(materialLabel4);
            materialCard5.Controls.Add(listViewRecordsWithDetails);
            materialCard5.Controls.Add(btnRecordsWithDetails);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(448, 251);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(422, 224);
            materialCard5.TabIndex = 7;
            // 
            // listViewRecordsWithDetails
            // 
            listViewRecordsWithDetails.AutoSizeTable = false;
            listViewRecordsWithDetails.BackColor = Color.FromArgb(255, 255, 255);
            listViewRecordsWithDetails.BorderStyle = BorderStyle.None;
            listViewRecordsWithDetails.Depth = 0;
            listViewRecordsWithDetails.FullRowSelect = true;
            listViewRecordsWithDetails.Location = new Point(11, 17);
            listViewRecordsWithDetails.MinimumSize = new Size(200, 100);
            listViewRecordsWithDetails.MouseLocation = new Point(-1, -1);
            listViewRecordsWithDetails.MouseState = MaterialSkin2DotNet.MouseState.OUT;
            listViewRecordsWithDetails.Name = "listViewRecordsWithDetails";
            listViewRecordsWithDetails.OwnerDraw = true;
            listViewRecordsWithDetails.Size = new Size(392, 100);
            listViewRecordsWithDetails.TabIndex = 1;
            listViewRecordsWithDetails.UseCompatibleStateImageBehavior = false;
            listViewRecordsWithDetails.View = View.Details;
            // 
            // btnRecordsWithDetails
            // 
            btnRecordsWithDetails.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRecordsWithDetails.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRecordsWithDetails.Depth = 0;
            btnRecordsWithDetails.HighEmphasis = true;
            btnRecordsWithDetails.Icon = null;
            btnRecordsWithDetails.Location = new Point(50, 137);
            btnRecordsWithDetails.Margin = new Padding(4, 6, 4, 6);
            btnRecordsWithDetails.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            btnRecordsWithDetails.Name = "btnRecordsWithDetails";
            btnRecordsWithDetails.NoAccentTextColor = Color.Empty;
            btnRecordsWithDetails.Size = new Size(100, 36);
            btnRecordsWithDetails.TabIndex = 0;
            btnRecordsWithDetails.Text = "Load Data";
            btnRecordsWithDetails.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRecordsWithDetails.UseAccentColor = false;
            btnRecordsWithDetails.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(11, -1);
            materialLabel1.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(117, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Records By Date";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(11, -1);
            materialLabel2.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(104, 19);
            materialLabel2.TabIndex = 3;
            materialLabel2.Text = "Repair Counts ";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(11, -1);
            materialLabel3.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(90, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Repair Costs";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(11, 0);
            materialLabel4.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(147, 19);
            materialLabel4.TabIndex = 4;
            materialLabel4.Text = "Records With Details";
            // 
            // SpecialControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialCard5);
            Controls.Add(materialCard4);
            Controls.Add(materialCard3);
            Controls.Add(materialCard2);
            Name = "SpecialControl";
            Size = new Size(1246, 504);
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialButton btnLoadData;
        private MaterialSkin2DotNet.Controls.MaterialListView listViewRecordsByDate;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard1;
        private DateTimePicker datePickerEnd;
        private DateTimePicker datePickerStart;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard2;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard3;
        private MaterialSkin2DotNet.Controls.MaterialListView listViewRepairCounts;
        private MaterialSkin2DotNet.Controls.MaterialButton btnLoadRepairCounts;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard4;
        private MaterialSkin2DotNet.Controls.MaterialListView listViewRepairCosts;
        private MaterialSkin2DotNet.Controls.MaterialButton BtnRepairCosts;
        private MaterialSkin2DotNet.Controls.MaterialCard materialCard5;
        private MaterialSkin2DotNet.Controls.MaterialListView listViewRecordsWithDetails;
        private MaterialSkin2DotNet.Controls.MaterialButton btnRecordsWithDetails;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel1;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel2;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel3;
        private MaterialSkin2DotNet.Controls.MaterialLabel materialLabel4;
    }
}
