using EquipmentRepair.DAL.Repositories;
using EquipmentRepair.DAL;
using MaterialSkin2DotNet.Controls;
using MaterialSkin2DotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentRepair.DAL.Entities;

namespace EquipmentRepair.WinForm.UI.Controls
{
    public partial class EquipmentTypeControl : UserControl
    {
        private readonly EquipmentTypeRepository _equipmentTypeRepo;

        public EquipmentTypeControl()
        {
            _equipmentTypeRepo = new EquipmentTypeRepository("Server=DESKTOP-U9RGK02;Database=Test;Trusted_Connection=True");
            InitializeComponent();
            InitializeListView();
            LoadEquipmentTypes();
        }

        private void InitializeListView()
        {
            var skinManager = MaterialSkinManager.Instance;

            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);

            listViewEquipmentTypes.View = View.Details;
            listViewEquipmentTypes.FullRowSelect = true;
            listViewEquipmentTypes.GridLines = true;
            listViewEquipmentTypes.HideSelection = false;
            listViewEquipmentTypes.Columns.Add("ID", 50);
            listViewEquipmentTypes.Columns.Add("Country", 100);
            listViewEquipmentTypes.Columns.Add("Manufacture Year", 80);
            listViewEquipmentTypes.Columns.Add("Brand", 100);
            listViewEquipmentTypes.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void LoadEquipmentTypes()
        {
            listViewEquipmentTypes.Items.Clear();
            List<EquipmentType> equipmentTypes = _equipmentTypeRepo.GetAllEquipmentTypes();
            foreach (var type in equipmentTypes)
            {
                ListViewItem item = new ListViewItem(type.EquipmentTypeID.ToString());
                item.SubItems.Add(type.Country);
                item.SubItems.Add(type.ManufactureYear.ToString());
                item.SubItems.Add(type.Brand);
                listViewEquipmentTypes.Items.Add(item);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string country = textBoxCountry.Text;
            int manufactureYear = int.Parse(textBoxManufactureYear.Text);
            string brand = textBoxBrand.Text;

            _equipmentTypeRepo.AddEquipmentType(country, manufactureYear, brand);
            MaterialMessageBox.Show("Equipment Type added successfully.");
            LoadEquipmentTypes();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (listViewEquipmentTypes.SelectedItems.Count == 0) return;

            var selectedItem = listViewEquipmentTypes.SelectedItems[0];
            int equipmentTypeId = int.Parse(selectedItem.Text);
            EquipmentType equipmentType = _equipmentTypeRepo.GetEquipmentTypeByID(equipmentTypeId);

            textBoxCountry.Text = equipmentType.Country;
            textBoxManufactureYear.Text = equipmentType.ManufactureYear.ToString();
            textBoxBrand.Text = equipmentType.Brand;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listViewEquipmentTypes.SelectedItems.Count == 0) return;

            var selectedItem = listViewEquipmentTypes.SelectedItems[0];
            int equipmentTypeId = int.Parse(selectedItem.Text);

            _equipmentTypeRepo.UpdateEquipmentType(equipmentTypeId,
                textBoxCountry.Text,
                int.Parse(textBoxManufactureYear.Text),
                textBoxBrand.Text);

            MaterialMessageBox.Show("Equipment Type updated successfully.");
            LoadEquipmentTypes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewEquipmentTypes.SelectedItems.Count == 0) return;

            var selectedItem = listViewEquipmentTypes.SelectedItems[0];
            int equipmentTypeId = int.Parse(selectedItem.Text);

            _equipmentTypeRepo.DeleteEquipmentType(equipmentTypeId);
            MaterialMessageBox.Show("Equipment Type deleted successfully.");
            LoadEquipmentTypes();
        }
    }
}
