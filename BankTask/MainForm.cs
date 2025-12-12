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
            dgvClients.DataSource = Data.DbAccess.GetClients();
            dgvRequests.DataSource = Data.DbAccess.GetRequests();
        }

        // === Клиенты ===
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            new ClientForm().ShowDialog();
            LoadData();
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow?.DataBoundItem is Client client)
            {
                new ClientForm(client).ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите клиента для редактирования.");
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow?.DataBoundItem is Client client)
            {
                if (MessageBox.Show($"Удалить клиента ID={client.ID}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Data.DbAccess.DeleteClient(client.ID);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.");
            }
        }

        // === Заявки ===
        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            new RequestForm().ShowDialog();
            LoadData();
        }

        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow?.DataBoundItem is Request request)
            {
                new RequestForm(request).ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Выберите заявку для редактирования.");
            }
        }

        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.CurrentRow?.DataBoundItem is Request request)
            {
                if (MessageBox.Show($"Удалить заявку ID={request.ID}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Data.DbAccess.DeleteRequest(request.ID);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку для удаления.");
            }
        }

        // === Прочее ===
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
            _context?.Dispose();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}