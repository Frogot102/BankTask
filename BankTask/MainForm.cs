using System;
using System.Linq;
using System.Windows.Forms;
using BankTask.Data;
using BankTask.Models;
using BankTask.Services;

namespace BankTask
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            var clientCount = _context.Clients.Count();
            var requestCount = _context.Requests.Count();

            MessageBox.Show($"Клиентов: {clientCount}\nЗаявок: {requestCount}", "Данные загружены");
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new ClientForm().ShowDialog();
            LoadData();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование клиента (заглушка)", "Информация");        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаление клиента (заглушка)", "Информация");
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            new ExcelService().ExportClientsToExcel(_context.Clients.ToList());
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            new ExcelService().ImportClientsFromExcel();
            LoadData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Печать PDF (заглушка)", "Информация");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _context.Dispose();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosed(e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}