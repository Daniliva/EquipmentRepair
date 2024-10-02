
using EquipmentRepair.DAL;
using EquipmentRepair.DAL.Repositories;
using EquipmentRepair.WinForm.UI.Controls;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace EquipmentRepair.WinForm.UI
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager _materialSkinManager;
        private bool _isDarkTheme = false;

        public MainForm()
        {
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.AddFormToManage(this);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            
            _materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green200, Accent.LightGreen200,
                TextShade.WHITE);

            InitializeComponent();

        }

        

        private void ThemeToggleButton_Click(object sender, EventArgs e)
        {
            if (_isDarkTheme)
            {
                _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                _materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Green400, Primary.Green500,
                    Primary.Green200, Accent.LightGreen200,
                    TextShade.WHITE);
            }
            else
            {
                _materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                _materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800, Primary.BlueGrey900,
                    Primary.BlueGrey500, Accent.LightBlue200,
                    TextShade.WHITE);
            }
            
                        _isDarkTheme = !_isDarkTheme;
        }


    }
}
