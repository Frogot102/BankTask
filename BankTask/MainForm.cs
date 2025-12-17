using System;
using System.Windows.Forms;
using BankTask.Data;
using BankTask.Models;
using BankTask.Services;

namespace BankTask
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeDateFilters(); // <-- Добавлено!
            LoadData();
        }

        private void InitializeDateFilters()
        {
            // Инициализация элементов управления для фильтрации
            lblClientDateFrom = new Label();
            lblClientDateTo = new Label();
            dtpClientDateFrom = new DateTimePicker();
            dtpClientDateTo = new DateTimePicker();
            btnFilterClients = new Button();
            btnClearClientFilter = new Button();

            lblRequestDateFrom = new Label();
            lblRequestDateTo = new Label();
            dtpRequestDateFrom = new DateTimePicker();
            dtpRequestDateTo = new DateTimePicker();
            btnFilterRequests = new Button();
            btnClearRequestFilter = new Button();

            // Clients
            lblClientDateFrom.Text = "Дата от:";
            lblClientDateTo.Text = "Дата до:";
            dtpClientDateFrom.Format = DateTimePickerFormat.Short;
            dtpClientDateTo.Format = DateTimePickerFormat.Short;
            btnFilterClients.Text = "Фильтровать";
            btnClearClientFilter.Text = "Сброс";

            tabPage1.Controls.Add(lblClientDateFrom);
            tabPage1.Controls.Add(dtpClientDateFrom);
            tabPage1.Controls.Add(lblClientDateTo);
            tabPage1.Controls.Add(dtpClientDateTo);
            tabPage1.Controls.Add(btnFilterClients);
            tabPage1.Controls.Add(btnClearClientFilter);

            // Requests
            lblRequestDateFrom.Text = "Дата от:";
            lblRequestDateTo.Text = "Дата до:";
            dtpRequestDateFrom.Format = DateTimePickerFormat.Short;
            dtpRequestDateTo.Format = DateTimePickerFormat.Short;
            btnFilterRequests.Text = "Фильтровать";
            btnClearRequestFilter.Text = "Сброс";

            tabPage2.Controls.Add(lblRequestDateFrom);
            tabPage2.Controls.Add(dtpRequestDateFrom);
            tabPage2.Controls.Add(lblRequestDateTo);
            tabPage2.Controls.Add(dtpRequestDateTo);
            tabPage2.Controls.Add(btnFilterRequests);
            tabPage2.Controls.Add(btnClearRequestFilter);

            // Positioning
            int startY = 420;
            lblClientDateFrom.Location = new System.Drawing.Point(20, startY);
            dtpClientDateFrom.Location = new System.Drawing.Point(90, startY);
            lblClientDateTo.Location = new System.Drawing.Point(220, startY);
            dtpClientDateTo.Location = new System.Drawing.Point(290, startY);
            btnFilterClients.Location = new System.Drawing.Point(420, startY - 3);
            btnClearClientFilter.Location = new System.Drawing.Point(525, startY - 3);

            lblRequestDateFrom.Location = new System.Drawing.Point(20, startY);
            dtpRequestDateFrom.Location = new System.Drawing.Point(90, startY);
            lblRequestDateTo.Location = new System.Drawing.Point(220, startY);
            dtpRequestDateTo.Location = new System.Drawing.Point(290, startY);
            btnFilterRequests.Location = new System.Drawing.Point(420, startY - 3);
            btnClearRequestFilter.Location = new System.Drawing.Point(525, startY - 3);

            // Events
            btnFilterClients.Click += (s, e) => LoadClientsWithFilter();
            btnClearClientFilter.Click += (s, e) =>
            {
                dtpClientDateFrom.Value = DateTime.Now.AddYears(-1);
                dtpClientDateTo.Value = DateTime.Now;
                LoadClientsWithFilter();
            };

            btnFilterRequests.Click += (s, e) => LoadRequestsWithFilter();
            btnClearRequestFilter.Click += (s, e) =>
            {
                dtpRequestDateFrom.Value = DateTime.Now.AddYears(-1);
                dtpRequestDateTo.Value = DateTime.Now;
                LoadRequestsWithFilter();
            };
        }

        private void LoadClientsWithFilter()
        {
            DateTime from = dtpClientDateFrom.Value.Date;
            DateTime to = dtpClientDateTo.Value.Date;

            if (AuthService.IsAdmin)
                dgvClients.DataSource = DbAccess.GetClientsByDate(from, to);
            else
                dgvClients.DataSource = DbAccess.GetClientsByUserAndDate(AuthService.CurrentUser, from, to);
        }

        private void LoadRequestsWithFilter()
        {
            DateTime from = dtpRequestDateFrom.Value.Date;
            DateTime to = dtpRequestDateTo.Value.Date;

            if (AuthService.IsAdmin)
                dgvRequests.DataSource = DbAccess.GetRequestsByDate(from, to);
            else
                dgvRequests.DataSource = DbAccess.GetRequestsByUserAndDate(AuthService.CurrentUser, from, to);
        }

        private void LoadData()
        {
            // Reset filters to defaults
            dtpClientDateFrom.Value = DateTime.Now.AddYears(-1);
            dtpClientDateTo.Value = DateTime.Now;
            dtpRequestDateFrom.Value = DateTime.Now.AddYears(-1);
            dtpRequestDateTo.Value = DateTime.Now;

            LoadClientsWithFilter();
            LoadRequestsWithFilter();
        }

        // === Clients ===
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
                    DbAccess.DeleteClient(client.ID);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для удаления.");
            }
        }

        // === Requests ===
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
                    DbAccess.DeleteRequest(request.ID);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите заявку для удаления.");
            }
        }

        // === Other ===
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            var clients = AuthService.IsAdmin
                ? DbAccess.GetClients()
                : DbAccess.GetClientsByUser(AuthService.CurrentUser);
            new ExcelService().ExportClientsToExcel(clients);
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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
    }
}