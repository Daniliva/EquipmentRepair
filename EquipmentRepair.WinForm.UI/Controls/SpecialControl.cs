using EquipmentRepair.DAL.Repositories;
using MaterialSkin2DotNet;
using MaterialSkin2DotNet.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentRepair.WinForm.UI.Controls
{
    public partial class SpecialControl : UserControl
    {
        private readonly SpecialRepository _repository;
        public SpecialControl()
        {
            _repository = new SpecialRepository(ConfigurationManager.ConnectionStrings["RepairDatabase"].ConnectionString);
            InitializeComponent();
            Initialize();



        }
        private void Initialize()
        {
            var skinManager = MaterialSkinManager.Instance;

            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);

            listViewRecordsByDate.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            listViewRepairCounts.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            listViewRepairCosts.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            listViewRecordsWithDetails.Font = new Font("Segoe UI", 10, FontStyle.Regular);

            listViewRecordsByDate.Columns.Add("Reg. Number", 100);
            listViewRecordsByDate.Columns.Add("Country", 100);
            listViewRecordsByDate.Columns.Add("Year", 100);
            listViewRecordsByDate.Columns.Add("Brand", 100);
            listViewRecordsByDate.Columns.Add("Repair Type", 100);
            listViewRecordsByDate.Columns.Add("Start Date", 100);
            listViewRecordsByDate.Columns.Add("Quality", 100);

            listViewRepairCounts.Columns.Add("Brand", 150);
            listViewRepairCounts.Columns.Add("Repair Count", 100);

            listViewRepairCosts.Columns.Add("Repair Type", 150);
            listViewRepairCosts.Columns.Add("Average Cost", 100);


            listViewRecordsWithDetails.Columns.Add("Reg. Number", 100);
            listViewRecordsWithDetails.Columns.Add("Country", 100);
            listViewRecordsWithDetails.Columns.Add("Year", 100);
            listViewRecordsWithDetails.Columns.Add("Brand", 100);
            listViewRecordsWithDetails.Columns.Add("Repair Type", 100);
            listViewRecordsWithDetails.Columns.Add("Start Date", 100);
            listViewRecordsWithDetails.Columns.Add("Quality", 100);


            // Add Load Data button click event
            this.btnLoadData.Click += new EventHandler(BtnLoadData_Click!);
this.BtnRepairCosts.Click += new EventHandler(BtnRepairCosts_Click!);
this.btnRecordsWithDetails.Click += new EventHandler(BtnRecordsWithDetails_Click!);
this.btnLoadRepairCounts.Click += new EventHandler(BtnLoadRepairCounts_Click!);


            
        }
        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            DateTime startDate = datePickerStart.Value;
            DateTime endDate = datePickerEnd.Value;

            var records = _repository.GetRepairRecordsByDate(startDate, endDate);
            listViewRecordsByDate.Items.Clear();

            foreach (var record in records)
            {
                var listViewItem = new ListViewItem(record.RegistrationNumber.ToString());
                listViewItem.SubItems.Add(record.Country);
                listViewItem.SubItems.Add(record.ManufactureYear.ToString());
                listViewItem.SubItems.Add(record.Brand);
                listViewItem.SubItems.Add(record.RepairTypeName);
                listViewItem.SubItems.Add(record.StartDate.ToShortDateString());
                listViewItem.SubItems.Add(record.RepairQuality);
                listViewRecordsByDate.Items.Add(listViewItem);
            }
        }
        private void BtnLoadRepairCounts_Click(object sender, EventArgs e)
        {
            var counts = _repository.GetRepairCountsByEquipmentType();
            listViewRepairCounts.Items.Clear();

            foreach (var count in counts)
            {
                var listViewItem = new ListViewItem(count.Brand);
                listViewItem.SubItems.Add(count.RepairCount.ToString());
                listViewRepairCounts.Items.Add(listViewItem);
            }
        }

        private void BtnRepairCosts_Click(object sender, EventArgs e)
        {
            var costs = _repository.GetAverageRepairCostsByType();
            listViewRepairCosts.Items.Clear();

            foreach (var cost in costs)
            {
                var listViewItem = new ListViewItem(cost.RepairTypeName);
                listViewItem.SubItems.Add(cost.AverageCost.ToString("C"));
                listViewRepairCosts.Items.Add(listViewItem);
            }
        }
        private void BtnRecordsWithDetails_Click(object sender, EventArgs e)
        {
            var records = _repository.GetRepairRecordsWithDetails();
            listViewRecordsWithDetails.Items.Clear();

            foreach (var record in records)
            {
                var listViewItem = new ListViewItem(record.RegistrationNumber.ToString());
                listViewItem.SubItems.Add(record.Country);
                listViewItem.SubItems.Add(record.ManufactureYear.ToString());
                listViewItem.SubItems.Add(record.Brand);
                listViewItem.SubItems.Add(record.RepairTypeName);
                listViewItem.SubItems.Add(record.StartDate.ToShortDateString());
                listViewItem.SubItems.Add(record.RepairQuality);
                listViewRecordsWithDetails.Items.Add(listViewItem);
            }
        }


    }
}
