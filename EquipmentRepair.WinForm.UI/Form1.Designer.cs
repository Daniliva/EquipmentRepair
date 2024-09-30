namespace EquipmentRepair.WinForm.UI
{
    partial class Form1
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
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            mainTabSelector = new MaterialSkin2DotNet.Controls.MaterialTabSelector();
            ThemeToggleButton = new MaterialSkin2DotNet.Controls.MaterialButton();
            mainlTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // mainlTabControl
            // 
            mainlTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainlTabControl.Controls.Add(tabPage1);
            mainlTabControl.Controls.Add(tabPage2);
            mainlTabControl.Depth = 0;
            mainlTabControl.Location = new Point(6, 67);
            mainlTabControl.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            mainlTabControl.Multiline = true;
            mainlTabControl.Name = "mainlTabControl";
            mainlTabControl.SelectedIndex = 0;
            mainlTabControl.Size = new Size(819, 431);
            mainlTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.AllowDrop = true;
            tabPage1.AutoScroll = true;
            tabPage1.BackColor = Color.White;
            tabPage1.BorderStyle = BorderStyle.Fixed3D;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(811, 403);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(811, 403);
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
            ThemeToggleButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ThemeToggleButton.Density = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonDensity.Default;
            ThemeToggleButton.Depth = 0;
            ThemeToggleButton.HighEmphasis = true;
            ThemeToggleButton.Icon = null;
            ThemeToggleButton.Location = new Point(667, 25);
            ThemeToggleButton.Margin = new Padding(4, 6, 4, 6);
            ThemeToggleButton.MouseState = MaterialSkin2DotNet.MouseState.HOVER;
            ThemeToggleButton.Name = "ThemeToggleButton";
            ThemeToggleButton.NoAccentTextColor = Color.Empty;
            ThemeToggleButton.Size = new Size(158, 36);
            ThemeToggleButton.TabIndex = 1;
            ThemeToggleButton.Text = "materialButton1";
            ThemeToggleButton.Type = MaterialSkin2DotNet.Controls.MaterialButton.MaterialButtonType.Contained;
            ThemeToggleButton.UseAccentColor = false;
            ThemeToggleButton.UseVisualStyleBackColor = true;
            ThemeToggleButton.Click += ThemeToggleButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 504);
            Controls.Add(ThemeToggleButton);
            Controls.Add(mainTabSelector);
            Controls.Add(mainlTabControl);
            Name = "Form1";
            Text = "Equipment Repair";
            Load += Form1_Load;
            mainlTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin2DotNet.Controls.MaterialTabControl mainlTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin2DotNet.Controls.MaterialTabSelector mainTabSelector;
        private MaterialSkin2DotNet.Controls.MaterialButton ThemeToggleButton;
    }
}
