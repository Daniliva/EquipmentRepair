using EquipmentRepair.DAL.Repositories;
using EquipmentRepair.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;

namespace EquipmentRepair.WinForm.UI.Controls
{
    public partial class RepairTypeControl : UserControl
    {
        private readonly RepairTypeRepository _repairTypeRepo;

        public RepairTypeControl()
        {
            _repairTypeRepo = new RepairTypeRepository("Server=DESKTOP-U9RGK02;Database=Test;Trusted_Connection=True");
            InitializeComponent();
            InitializeListView();
            LoadRepairTypes();
        }

        private void InitializeListView()
        {
            var skinManager = MaterialSkinManager.Instance;

            skinManager.Theme = MaterialSkin2DotNet.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);

            listBoxRepairTypes.View = View.Details;
            listBoxRepairTypes.FullRowSelect = true;
            listBoxRepairTypes.GridLines = true;
            listBoxRepairTypes.HideSelection = false;
            listBoxRepairTypes.TileSize = new Size(300, 150);
            listBoxRepairTypes.Columns.Add("ID", 50);
            listBoxRepairTypes.Columns.Add("Name", 100);
            listBoxRepairTypes.Columns.Add("Duration", 80);
            listBoxRepairTypes.Columns.Add("Cost", 80);
            listBoxRepairTypes.Columns.Add("Notes", 150);
            listBoxRepairTypes.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void LoadRepairTypes()
        {
            listBoxRepairTypes.Items.Clear();
            List<RepairType> repairTypes = _repairTypeRepo.GetAllRepairTypes();
            foreach (var type in repairTypes)
            {
                ListViewItem item = new ListViewItem(type.RepairTypeID.ToString());
                item.SubItems.Add(type.Name);
                item.SubItems.Add(type.Duration.ToString());
                item.SubItems.Add(type.Cost.ToString("C"));
                item.SubItems.Add(type.Notes);
                listBoxRepairTypes.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int duration = int.Parse(textBoxDuration.Text);
            decimal cost = decimal.Parse(textBoxCost.Text);
            string notes = textBoxNotes.Text;

            _repairTypeRepo.AddRepairType(name, duration, cost, notes);
            MaterialMessageBox.Show("Repair Type added successfully.");
            LoadRepairTypes();
        }
        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            var selectedItem = listBoxRepairTypes.SelectedItems[0];
            int repairTypeId = int.Parse(selectedItem.Text);
            RepairType repairType = _repairTypeRepo.GetRepairTypeByID(repairTypeId);

            textBoxName.Text = repairType.Name;
            textBoxDuration.Text = repairType.Duration.ToString();
            textBoxCost.Text = repairType.Cost.ToString();
            textBoxNotes.Text = repairType.Notes;
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            var selectedItem = listBoxRepairTypes.SelectedItems[0];
            int repairTypeId = int.Parse(selectedItem.Text);

            _repairTypeRepo.UpdateRepairType(repairTypeId,
                textBoxName.Text,
                int.Parse(textBoxDuration.Text),
                decimal.Parse(textBoxCost.Text),
                textBoxNotes.Text);

            MaterialMessageBox.Show("Repair Type updated successfully.");
            LoadRepairTypes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            var selectedItem = listBoxRepairTypes.SelectedItems[0];
            int repairTypeId = int.Parse(selectedItem.Text);

            _repairTypeRepo.DeleteRepairType(repairTypeId);
            MaterialMessageBox.Show("Repair Type deleted successfully.");
            LoadRepairTypes();
        }
    }
}
