using System;
using System.Windows.Forms;
using BankTask.Data;
using BankTask.Models;

namespace BankTask
{
    public partial class ClientForm : Form
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        private Client _client;

        public ClientForm()
        {
            InitializeComponent();
            _client = new Client();
            _client.DATE_BEGIN = DateTime.Now;
            _client.CREATE_DATE = DateTime.Now;
            _client.IS_ACTIVE = true;
        }

        public ClientForm(Client client)
        {
            InitializeComponent();
            _client = client ?? new Client();
            LoadData();
        }

        private void LoadData()
        {
            if (_client.ID == 0) return;

            MessageBox.Show($"Клиент ID: {_client.ID}\nСчет: {_client.CLIENT_ACC}\nАктивен: {_client.IS_ACTIVE}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_client.ID == 0)
                _context.Clients.Add(_client);
            else
                _context.Entry(_client).State = System.Data.Entity.EntityState.Modified;

            _context.SaveChanges();
            MessageBox.Show("Сохранено");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }
    }
}