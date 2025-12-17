using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace BankTask
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClearClientFilter = new System.Windows.Forms.Button();
            this.btnFilterClients = new System.Windows.Forms.Button();
            this.dtpClientDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblClientDateTo = new System.Windows.Forms.Label();
            this.dtpClientDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblClientDateFrom = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnImportExcel = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearRequestFilter = new System.Windows.Forms.Button();
            this.btnFilterRequests = new System.Windows.Forms.Button();
            this.dtpRequestDateTo = new System.Windows.Forms.DateTimePicker();
            this.lblRequestDateTo = new System.Windows.Forms.Label();
            this.dtpRequestDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblRequestDateFrom = new System.Windows.Forms.Label();
            this.btnDeleteRequest = new System.Windows.Forms.Button();
            this.btnEditRequest = new System.Windows.Forms.Button();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnExit);
            this.tabPage1.Controls.Add(this.btnClearClientFilter);
            this.tabPage1.Controls.Add(this.btnFilterClients);
            this.tabPage1.Controls.Add(this.dtpClientDateTo);
            this.tabPage1.Controls.Add(this.lblClientDateTo);
            this.tabPage1.Controls.Add(this.dtpClientDateFrom);
            this.tabPage1.Controls.Add(this.lblClientDateFrom);
            this.tabPage1.Controls.Add(this.btnPrint);
            this.tabPage1.Controls.Add(this.btnExportExcel);
            this.tabPage1.Controls.Add(this.btnImportExcel);
            this.tabPage1.Controls.Add(this.btnDeleteClient);
            this.tabPage1.Controls.Add(this.btnEditClient);
            this.tabPage1.Controls.Add(this.btnAddClient);
            this.tabPage1.Controls.Add(this.dgvClients);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnClearClientFilter
            // 
            resources.ApplyResources(this.btnClearClientFilter, "btnClearClientFilter");
            this.btnClearClientFilter.Name = "btnClearClientFilter";
            this.btnClearClientFilter.UseVisualStyleBackColor = true;
            this.btnClearClientFilter.Click += new System.EventHandler(this.btnClearClientFilter_Click);
            // 
            // btnFilterClients
            // 
            resources.ApplyResources(this.btnFilterClients, "btnFilterClients");
            this.btnFilterClients.Name = "btnFilterClients";
            this.btnFilterClients.UseVisualStyleBackColor = true;
            this.btnFilterClients.Click += new System.EventHandler(this.btnFilterClients_Click);
            // 
            // dtpClientDateTo
            // 
            resources.ApplyResources(this.dtpClientDateTo, "dtpClientDateTo");
            this.dtpClientDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClientDateTo.Name = "dtpClientDateTo";
            this.dtpClientDateTo.ValueChanged += new System.EventHandler(this.dtpClientDateTo_ValueChanged);
            // 
            // lblClientDateTo
            // 
            resources.ApplyResources(this.lblClientDateTo, "lblClientDateTo");
            this.lblClientDateTo.Name = "lblClientDateTo";
            this.lblClientDateTo.Click += new System.EventHandler(this.lblClientDateTo_Click);
            // 
            // dtpClientDateFrom
            // 
            resources.ApplyResources(this.dtpClientDateFrom, "dtpClientDateFrom");
            this.dtpClientDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpClientDateFrom.Name = "dtpClientDateFrom";
            this.dtpClientDateFrom.ValueChanged += new System.EventHandler(this.dtpClientDateFrom_ValueChanged);
            // 
            // lblClientDateFrom
            // 
            resources.ApplyResources(this.lblClientDateFrom, "lblClientDateFrom");
            this.lblClientDateFrom.Name = "lblClientDateFrom";
            this.lblClientDateFrom.Click += new System.EventHandler(this.lblClientDateFrom_Click);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExportExcel
            // 
            resources.ApplyResources(this.btnExportExcel, "btnExportExcel");
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnImportExcel
            // 
            resources.ApplyResources(this.btnImportExcel, "btnImportExcel");
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.UseVisualStyleBackColor = true;
            this.btnImportExcel.Click += new System.EventHandler(this.btnImportExcel_Click);
            // 
            // btnDeleteClient
            // 
            resources.ApplyResources(this.btnDeleteClient, "btnDeleteClient");
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnEditClient
            // 
            resources.ApplyResources(this.btnEditClient, "btnEditClient");
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnAddClient
            // 
            resources.ApplyResources(this.btnAddClient, "btnAddClient");
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dgvClients
            // 
            resources.ApplyResources(this.dgvClients, "dgvClients");
            this.dgvClients.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.GridColor = System.Drawing.Color.Cyan;
            this.dgvClients.Name = "dgvClients";
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.btnClearRequestFilter);
            this.tabPage2.Controls.Add(this.btnFilterRequests);
            this.tabPage2.Controls.Add(this.dtpRequestDateTo);
            this.tabPage2.Controls.Add(this.lblRequestDateTo);
            this.tabPage2.Controls.Add(this.dtpRequestDateFrom);
            this.tabPage2.Controls.Add(this.lblRequestDateFrom);
            this.tabPage2.Controls.Add(this.btnDeleteRequest);
            this.tabPage2.Controls.Add(this.btnEditRequest);
            this.tabPage2.Controls.Add(this.btnAddRequest);
            this.tabPage2.Controls.Add(this.dgvRequests);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnClearRequestFilter
            // 
            resources.ApplyResources(this.btnClearRequestFilter, "btnClearRequestFilter");
            this.btnClearRequestFilter.Name = "btnClearRequestFilter";
            this.btnClearRequestFilter.UseVisualStyleBackColor = true;
            this.btnClearRequestFilter.Click += new System.EventHandler(this.btnClearRequestFilter_Click);
            // 
            // btnFilterRequests
            // 
            resources.ApplyResources(this.btnFilterRequests, "btnFilterRequests");
            this.btnFilterRequests.Name = "btnFilterRequests";
            this.btnFilterRequests.UseVisualStyleBackColor = true;
            this.btnFilterRequests.Click += new System.EventHandler(this.btnFilterRequests_Click);
            // 
            // dtpRequestDateTo
            // 
            resources.ApplyResources(this.dtpRequestDateTo, "dtpRequestDateTo");
            this.dtpRequestDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequestDateTo.Name = "dtpRequestDateTo";
            this.dtpRequestDateTo.ValueChanged += new System.EventHandler(this.dtpRequestDateTo_ValueChanged);
            // 
            // lblRequestDateTo
            // 
            resources.ApplyResources(this.lblRequestDateTo, "lblRequestDateTo");
            this.lblRequestDateTo.Name = "lblRequestDateTo";
            // 
            // dtpRequestDateFrom
            // 
            resources.ApplyResources(this.dtpRequestDateFrom, "dtpRequestDateFrom");
            this.dtpRequestDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequestDateFrom.Name = "dtpRequestDateFrom";
            // 
            // lblRequestDateFrom
            // 
            resources.ApplyResources(this.lblRequestDateFrom, "lblRequestDateFrom");
            this.lblRequestDateFrom.Name = "lblRequestDateFrom";
            // 
            // btnDeleteRequest
            // 
            resources.ApplyResources(this.btnDeleteRequest, "btnDeleteRequest");
            this.btnDeleteRequest.Name = "btnDeleteRequest";
            this.btnDeleteRequest.UseVisualStyleBackColor = true;
            this.btnDeleteRequest.Click += new System.EventHandler(this.btnDeleteRequest_Click);
            // 
            // btnEditRequest
            // 
            resources.ApplyResources(this.btnEditRequest, "btnEditRequest");
            this.btnEditRequest.Name = "btnEditRequest";
            this.btnEditRequest.UseVisualStyleBackColor = true;
            this.btnEditRequest.Click += new System.EventHandler(this.btnEditRequest_Click);
            // 
            // btnAddRequest
            // 
            resources.ApplyResources(this.btnAddRequest, "btnAddRequest");
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.UseVisualStyleBackColor = true;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // dgvRequests
            // 
            resources.ApplyResources(this.dgvRequests, "dgvRequests");
            this.dgvRequests.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.GridColor = System.Drawing.Color.Cyan;
            this.dgvRequests.Name = "dgvRequests";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnImportExcel;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnEditRequest;
        private System.Windows.Forms.Button btnDeleteRequest;
        private System.Windows.Forms.Button btnFilterClients;
        private System.Windows.Forms.Button btnClearClientFilter;
        private System.Windows.Forms.DateTimePicker dtpClientDateTo;
        private System.Windows.Forms.Label lblClientDateTo;
        private System.Windows.Forms.DateTimePicker dtpClientDateFrom;
        private System.Windows.Forms.Label lblClientDateFrom;
        private System.Windows.Forms.Button btnFilterRequests;
        private System.Windows.Forms.Button btnClearRequestFilter;
        private System.Windows.Forms.DateTimePicker dtpRequestDateTo;
        private System.Windows.Forms.Label lblRequestDateTo;
        private System.Windows.Forms.DateTimePicker dtpRequestDateFrom;
        private System.Windows.Forms.Label lblRequestDateFrom;
    }
}