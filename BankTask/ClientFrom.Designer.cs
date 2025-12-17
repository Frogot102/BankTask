namespace BankTask
{
    partial class ClientForm
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

        private void InitializeComponent()
        {
            this.txtClientAcc = new System.Windows.Forms.MaskedTextBox();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.numIKUSNUM = new System.Windows.Forms.NumericUpDown();
            this.txtAgreementNum = new System.Windows.Forms.TextBox();
            this.dtpAgreementDate = new System.Windows.Forms.DateTimePicker();
            this.txtAccN068 = new System.Windows.Forms.MaskedTextBox();
            this.txtAcc47426 = new System.Windows.Forms.MaskedTextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.dtpCreateDate = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateUser = new System.Windows.Forms.TextBox();
            this.dtpUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtErrorMessage = new System.Windows.Forms.TextBox();
            this.txtClientAccDop = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numIKUSNUM)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClientAcc
            // 
            this.txtClientAcc.Location = new System.Drawing.Point(201, 43);
            this.txtClientAcc.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientAcc.Mask = "00000 000 0 0000 0000000";
            this.txtClientAcc.Name = "txtClientAcc";
            this.txtClientAcc.Size = new System.Drawing.Size(265, 22);
            this.txtClientAcc.TabIndex = 0;
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.Enabled = false;
            this.dtpDateBegin.Location = new System.Drawing.Point(201, 73);
            this.dtpDateBegin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(265, 22);
            this.dtpDateBegin.TabIndex = 1;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Enabled = false;
            this.dtpDateEnd.Location = new System.Drawing.Point(201, 104);
            this.dtpDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(265, 22);
            this.dtpDateEnd.TabIndex = 2;
            // 
            // numIKUSNUM
            // 
            this.numIKUSNUM.Location = new System.Drawing.Point(201, 472);
            this.numIKUSNUM.Margin = new System.Windows.Forms.Padding(4);
            this.numIKUSNUM.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numIKUSNUM.Name = "numIKUSNUM";
            this.numIKUSNUM.Size = new System.Drawing.Size(267, 22);
            this.numIKUSNUM.TabIndex = 3;
            this.numIKUSNUM.Visible = false;
            // 
            // txtAgreementNum
            // 
            this.txtAgreementNum.Location = new System.Drawing.Point(201, 134);
            this.txtAgreementNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgreementNum.Name = "txtAgreementNum";
            this.txtAgreementNum.Size = new System.Drawing.Size(265, 22);
            this.txtAgreementNum.TabIndex = 4;
            // 
            // dtpAgreementDate
            // 
            this.dtpAgreementDate.Location = new System.Drawing.Point(201, 164);
            this.dtpAgreementDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAgreementDate.Name = "dtpAgreementDate";
            this.dtpAgreementDate.Size = new System.Drawing.Size(265, 22);
            this.dtpAgreementDate.TabIndex = 5;
            // 
            // txtAccN068
            // 
            this.txtAccN068.Location = new System.Drawing.Point(201, 195);
            this.txtAccN068.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccN068.Mask = "68000 000 0 0000 0000000";
            this.txtAccN068.Name = "txtAccN068";
            this.txtAccN068.Size = new System.Drawing.Size(265, 22);
            this.txtAccN068.TabIndex = 6;
            // 
            // txtAcc47426
            // 
            this.txtAcc47426.Location = new System.Drawing.Point(201, 226);
            this.txtAcc47426.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcc47426.Mask = "47426 000 0 0000 0000000";
            this.txtAcc47426.Name = "txtAcc47426";
            this.txtAcc47426.Size = new System.Drawing.Size(265, 22);
            this.txtAcc47426.TabIndex = 7;
            this.txtAcc47426.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtAcc47426_MaskInputRejected);
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(201, 502);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(84, 20);
            this.chkIsActive.TabIndex = 8;
            this.chkIsActive.Text = "Активен";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.Visible = false;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Enabled = false;
            this.txtCreateUser.Location = new System.Drawing.Point(201, 258);
            this.txtCreateUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(265, 22);
            this.txtCreateUser.TabIndex = 9;
            // 
            // dtpCreateDate
            // 
            this.dtpCreateDate.Enabled = false;
            this.dtpCreateDate.Location = new System.Drawing.Point(201, 288);
            this.dtpCreateDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreateDate.Name = "dtpCreateDate";
            this.dtpCreateDate.Size = new System.Drawing.Size(265, 22);
            this.dtpCreateDate.TabIndex = 10;
            // 
            // txtUpdateUser
            // 
            this.txtUpdateUser.Enabled = false;
            this.txtUpdateUser.Location = new System.Drawing.Point(201, 319);
            this.txtUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateUser.Name = "txtUpdateUser";
            this.txtUpdateUser.Size = new System.Drawing.Size(265, 22);
            this.txtUpdateUser.TabIndex = 11;
            this.txtUpdateUser.TextChanged += new System.EventHandler(this.txtUpdateUser_TextChanged);
            // 
            // dtpUpdateDate
            // 
            this.dtpUpdateDate.Enabled = false;
            this.dtpUpdateDate.Location = new System.Drawing.Point(201, 350);
            this.dtpUpdateDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpUpdateDate.Name = "dtpUpdateDate";
            this.dtpUpdateDate.Size = new System.Drawing.Size(265, 22);
            this.dtpUpdateDate.TabIndex = 12;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(201, 411);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(265, 22);
            this.txtNote.TabIndex = 14;
            this.txtNote.Visible = false;
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.Location = new System.Drawing.Point(201, 442);
            this.txtErrorMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(265, 22);
            this.txtErrorMessage.TabIndex = 15;
            this.txtErrorMessage.Visible = false;
            // 
            // txtClientAccDop
            // 
            this.txtClientAccDop.Location = new System.Drawing.Point(201, 382);
            this.txtClientAccDop.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientAccDop.Name = "txtClientAccDop";
            this.txtClientAccDop.Size = new System.Drawing.Size(265, 22);
            this.txtClientAccDop.TabIndex = 13;
            this.txtClientAccDop.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 543);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(420, 543);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Номер счета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Дата начала:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Дата конца:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 476);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "IKUSNUM:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Номер разрешения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Дата разрешения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Счет N068:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 230);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Счет 47426:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 503);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 26;
            this.label9.Text = "IS_ACTIVE:";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 261);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Создатель клиента:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 292);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "Дата создания клиента:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 323);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Клиента обновил:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 354);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Дата обновления:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 384);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "NOTE:";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 415);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "ERR_MESSAGE:";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(28, 446);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(127, 16);
            this.label16.TabIndex = 33;
            this.label16.Text = "CLIENT_ACC_DOP:";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(117, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(269, 25);
            this.label17.TabIndex = 34;
            this.label17.Text = "Редактирование клиента";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 590);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientAccDop);
            this.Controls.Add(this.txtErrorMessage);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.dtpUpdateDate);
            this.Controls.Add(this.txtUpdateUser);
            this.Controls.Add(this.dtpCreateDate);
            this.Controls.Add(this.txtCreateUser);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtAcc47426);
            this.Controls.Add(this.txtAccN068);
            this.Controls.Add(this.dtpAgreementDate);
            this.Controls.Add(this.txtAgreementNum);
            this.Controls.Add(this.numIKUSNUM);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateBegin);
            this.Controls.Add(this.txtClientAcc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientForm";
            this.Text = "Редактирование клиента";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numIKUSNUM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MaskedTextBox txtClientAcc;
        private System.Windows.Forms.DateTimePicker dtpDateBegin;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.NumericUpDown numIKUSNUM;
        private System.Windows.Forms.TextBox txtAgreementNum;
        private System.Windows.Forms.DateTimePicker dtpAgreementDate;
        private System.Windows.Forms.MaskedTextBox txtAccN068;
        private System.Windows.Forms.MaskedTextBox txtAcc47426;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.DateTimePicker dtpCreateDate;
        private System.Windows.Forms.TextBox txtUpdateUser;
        private System.Windows.Forms.DateTimePicker dtpUpdateDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtErrorMessage;
        private System.Windows.Forms.TextBox txtClientAccDop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}