
using EquipmentRepair.DAL;
using EquipmentRepair.DAL.Repositories;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace EquipmentRepair.WinForm.UI
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private bool isDarkTheme = false;
        private readonly RepairTypeRepository repairTypeRepo;
        public MainForm()
        {
            
            InitializeComponent();
            repairTypeRepo = new RepairTypeRepository("Server=DESKTOP-U9RGK02;Database=Test;Trusted_Connection=True");

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;


            
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green200, Accent.LightGreen200,
                TextShade.WHITE);
            LoadRepairTypes();


        }
        private void LoadRepairTypes()
        {
            listBoxRepairTypes.Items.Clear(); // Clear before reloading
            List<RepairType> repairTypes = repairTypeRepo.GetAllRepairTypes();
            foreach (var type in repairTypes)
            {
                listBoxRepairTypes.Items.Add(type.Name);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ThemeToggleButton_Click(object sender, EventArgs e)
        {
            if (isDarkTheme)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Green400, Primary.Green500,
                    Primary.Green200, Accent.LightGreen200,
                    TextShade.WHITE);
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.BlueGrey800, Primary.BlueGrey900,
                    Primary.BlueGrey500, Accent.LightBlue200,
                    TextShade.WHITE);
            }

            isDarkTheme = !isDarkTheme;
        }
    }
}
