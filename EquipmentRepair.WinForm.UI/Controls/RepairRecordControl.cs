using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentRepair.DAL.Repositories;
using EquipmentRepair.DAL;
using MaterialSkin2DotNet.Controls;
using MaterialSkin2DotNet;

namespace EquipmentRepair.WinForm.UI.Controls
{



    public partial class RepairRecordControl : UserControl
    {
        private readonly RepairRecordRepository _repairRecordRepo;
        private readonly EquipmentTypeRepository _equipmentTypeRepo;
        private readonly RepairTypeRepository _repairTypeRepo;

        public RepairRecordControl()
        {
            _repairRecordRepo = new RepairRecordRepository("Server=DESKTOP-U9RGK02;Database=Test;Trusted_Connection=True");
            _equipmentTypeRepo = new EquipmentTypeRepository("Server=DESKTOP-U9RGK02;Database=Test;Trusted_Connection=True");
            _repairTypeRepo = new RepairTypeRepository("Server=DESKTOP-U9RGK02;Database=Test;Trusted_Connection=True");

            InitializeComponent();
            InitializeListView();
            LoadRepairRecords();
            LoadEquipmentTypes();
            LoadRepairTypes();
        }

        private void InitializeListView()
        {
            var skinManager = MaterialSkinManager.Instance;

            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);

            listBoxRepairRecords.View = View.Details;
            listBoxRepairRecords.FullRowSelect = true;
            listBoxRepairRecords.GridLines = true;
            listBoxRepairRecords.HideSelection = false;
            listBoxRepairRecords.Columns.Clear();
            listBoxRepairRecords.Columns.Add("Registration No", 100);
            listBoxRepairRecords.Columns.Add("Equipment Type ID", 150);
            listBoxRepairRecords.Columns.Add("Repair Type ID", 150);
            listBoxRepairRecords.Columns.Add("Start Date", 120);
            listBoxRepairRecords.Columns.Add("Repair Quality", 150);
            listBoxRepairRecords.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void LoadRepairRecords()
        {
            listBoxRepairRecords.Items.Clear();
            List<RepairRecord> repairRecords = _repairRecordRepo.GetAllRepairRecords();
            foreach (var record in repairRecords)
            {
                ListViewItem item = new ListViewItem(record.RegistrationNumber.ToString());
                item.SubItems.Add(record.EquipmentTypeID.ToString());
                item.SubItems.Add(record.RepairTypeID.ToString());
                item.SubItems.Add(record.StartDate.ToShortDateString());
                item.SubItems.Add(record.RepairQuality);
                listBoxRepairRecords.Items.Add(item);
            }
        }

        private void LoadEquipmentTypes()
        {
            listBoxEquipmentTypes.Items.Clear();
            List<EquipmentType> equipmentTypes = _equipmentTypeRepo.GetAllEquipmentTypes();
            foreach (var equipment in equipmentTypes)
            {
                listBoxEquipmentTypes.Items.Add(new MaterialListBoxItem(equipment.EquipmentTypeID.ToString(), equipment.Brand));
            }
        }

        private void LoadRepairTypes()
        {
            listBoxRepairTypes.Items.Clear();
            List<RepairType> repairTypes = _repairTypeRepo.GetAllRepairTypes();
            foreach (var type in repairTypes)
            {
                listBoxRepairTypes.Items.Add(new MaterialListBoxItem(type.RepairTypeID.ToString(), type.Name));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBoxEquipmentTypes.SelectedItem == null || listBoxRepairTypes.SelectedItem == null)
            {
                MaterialMessageBox.Show("Please select an equipment type and a repair type.");
                return;
            }

            int equipmentTypeId = int.Parse(listBoxEquipmentTypes.SelectedItem.Text.ToString());
            int repairTypeId = int.Parse(listBoxRepairTypes.SelectedItem.Text.ToString());
            DateTime startDate = dateTimePickerStartDate.Value;
            string repairQuality = textBoxRepairQuality.Text;

            _repairRecordRepo.AddRepairRecord(equipmentTypeId, repairTypeId, startDate, repairQuality);
            MaterialMessageBox.Show("Repair Record added successfully.");
            LoadRepairRecords();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            var selectedItem = (ListViewItem)listBoxRepairTypes.SelectedItems[0];


            int registrationNumber = int.Parse(selectedItem.Text);
            RepairRecord repairRecord = _repairRecordRepo.GetRepairRecordByID(registrationNumber);
            listBoxEquipmentTypes.SelectedItem = listBoxEquipmentTypes.Items.FirstOrDefault(x => x.Text == repairRecord.EquipmentTypeID.ToString());
            listBoxRepairTypes.SelectedItem = listBoxRepairTypes.Items.FirstOrDefault(x => x.Text == repairRecord.RepairTypeID.ToString());

            dateTimePickerStartDate.Value = repairRecord.StartDate;
            textBoxRepairQuality.Text = repairRecord.RepairQuality;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = (ListViewItem)listBoxRepairTypes.SelectedItems[0];
            int registrationNumber = int.Parse(selectedItem.Text);

            int equipmentTypeId = int.Parse(listBoxEquipmentTypes.SelectedItem.Text.ToString());
            int repairTypeId = int.Parse(listBoxRepairTypes.SelectedItem.Text.ToString());
            DateTime startDate = dateTimePickerStartDate.Value;
            string repairQuality = textBoxRepairQuality.Text;

            _repairRecordRepo.UpdateRepairRecord(registrationNumber, equipmentTypeId, repairTypeId, startDate, repairQuality);
            MaterialMessageBox.Show("Repair Record updated successfully.");
            LoadRepairRecords();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRepairTypes.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = (ListViewItem)listBoxRepairTypes.SelectedItems[0];
            int registrationNumber = int.Parse(selectedItem.Text);

            _repairRecordRepo.DeleteRepairRecord(registrationNumber);
            MaterialMessageBox.Show("Repair Record deleted successfully.");
            LoadRepairRecords();
        }

        private void RepairRecordControl_Load(object sender, EventArgs e)
        {
            InitializeListView();
            LoadRepairRecords();
            LoadEquipmentTypes();
            LoadRepairTypes();
        }

        private void materialReloadButton_Click(object sender, EventArgs e)
        {
            LoadRepairRecords();
            LoadEquipmentTypes();
            LoadRepairTypes();
        }
    }


}

