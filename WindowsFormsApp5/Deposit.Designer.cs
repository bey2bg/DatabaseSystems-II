namespace WindowsFormsApp5
{
    partial class Deposit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Boooks = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupAddDep = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepName = new System.Windows.Forms.TextBox();
            this.txtDepBook = new System.Windows.Forms.TextBox();
            this.DepRetTime = new System.Windows.Forms.DateTimePicker();
            this.btnDepAdd = new System.Windows.Forms.Button();
            this.groupUpdDep = new System.Windows.Forms.GroupBox();
            this.dtpUpd = new System.Windows.Forms.Button();
            this.ReturnTime = new System.Windows.Forms.DateTimePicker();
            this.txtUpDepBook = new System.Windows.Forms.TextBox();
            this.txtDepUpName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDelete = new System.Windows.Forms.Button();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Boooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupAddDep.SuspendLayout();
            this.groupUpdDep.SuspendLayout();
            this.SuspendLayout();
            // 
            // Boooks
            // 
            this.Boooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Boooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Boooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName_Surname,
            this.UserPhone,
            this.UserTC,
            this.UserAddress});
            this.Boooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Boooks.Location = new System.Drawing.Point(0, 388);
            this.Boooks.Name = "Boooks";
            this.Boooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Boooks.Size = new System.Drawing.Size(623, 0);
            this.Boooks.TabIndex = 1;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // UserName_Surname
            // 
            this.UserName_Surname.DataPropertyName = "UserName_Surname";
            this.UserName_Surname.HeaderText = "User Name";
            this.UserName_Surname.Name = "UserName_Surname";
            // 
            // UserPhone
            // 
            this.UserPhone.DataPropertyName = "UserPhone";
            this.UserPhone.HeaderText = "User Phone No";
            this.UserPhone.Name = "UserPhone";
            // 
            // UserTC
            // 
            this.UserTC.DataPropertyName = "UserTC";
            this.UserTC.HeaderText = "User TC";
            this.UserTC.Name = "UserTC";
            // 
            // UserAddress
            // 
            this.UserAddress.DataPropertyName = "UserAddress";
            this.UserAddress.HeaderText = "User Address";
            this.UserAddress.Name = "UserAddress";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.BookName,
            this.BookExp,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 180);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupAddDep
            // 
            this.groupAddDep.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupAddDep.Controls.Add(this.btnDepAdd);
            this.groupAddDep.Controls.Add(this.DepRetTime);
            this.groupAddDep.Controls.Add(this.txtDepBook);
            this.groupAddDep.Controls.Add(this.txtDepName);
            this.groupAddDep.Controls.Add(this.label3);
            this.groupAddDep.Controls.Add(this.label2);
            this.groupAddDep.Controls.Add(this.label1);
            this.groupAddDep.Location = new System.Drawing.Point(315, 12);
            this.groupAddDep.Name = "groupAddDep";
            this.groupAddDep.Size = new System.Drawing.Size(296, 190);
            this.groupAddDep.TabIndex = 3;
            this.groupAddDep.TabStop = false;
            this.groupAddDep.Text = "AddDeposit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Return Date:";
            // 
            // txtDepName
            // 
            this.txtDepName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDepName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDepName.Location = new System.Drawing.Point(117, 32);
            this.txtDepName.Name = "txtDepName";
            this.txtDepName.Size = new System.Drawing.Size(158, 20);
            this.txtDepName.TabIndex = 3;
            // 
            // txtDepBook
            // 
            this.txtDepBook.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDepBook.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDepBook.Location = new System.Drawing.Point(117, 63);
            this.txtDepBook.Name = "txtDepBook";
            this.txtDepBook.Size = new System.Drawing.Size(158, 20);
            this.txtDepBook.TabIndex = 4;
            // 
            // DepRetTime
            // 
            this.DepRetTime.Location = new System.Drawing.Point(44, 112);
            this.DepRetTime.Name = "DepRetTime";
            this.DepRetTime.Size = new System.Drawing.Size(200, 20);
            this.DepRetTime.TabIndex = 5;
            // 
            // btnDepAdd
            // 
            this.btnDepAdd.Location = new System.Drawing.Point(126, 148);
            this.btnDepAdd.Name = "btnDepAdd";
            this.btnDepAdd.Size = new System.Drawing.Size(84, 30);
            this.btnDepAdd.TabIndex = 6;
            this.btnDepAdd.Text = "Add";
            this.btnDepAdd.UseVisualStyleBackColor = true;
            // 
            // groupUpdDep
            // 
            this.groupUpdDep.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupUpdDep.Controls.Add(this.dtpDelete);
            this.groupUpdDep.Controls.Add(this.dtpUpd);
            this.groupUpdDep.Controls.Add(this.ReturnTime);
            this.groupUpdDep.Controls.Add(this.txtUpDepBook);
            this.groupUpdDep.Controls.Add(this.txtDepUpName);
            this.groupUpdDep.Controls.Add(this.label4);
            this.groupUpdDep.Controls.Add(this.label5);
            this.groupUpdDep.Controls.Add(this.label6);
            this.groupUpdDep.Location = new System.Drawing.Point(13, 12);
            this.groupUpdDep.Name = "groupUpdDep";
            this.groupUpdDep.Size = new System.Drawing.Size(296, 190);
            this.groupUpdDep.TabIndex = 4;
            this.groupUpdDep.TabStop = false;
            this.groupUpdDep.Text = "AddDeposit";
            // 
            // dtpUpd
            // 
            this.dtpUpd.Location = new System.Drawing.Point(126, 148);
            this.dtpUpd.Name = "dtpUpd";
            this.dtpUpd.Size = new System.Drawing.Size(84, 30);
            this.dtpUpd.TabIndex = 6;
            this.dtpUpd.Text = "Upgrade";
            this.dtpUpd.UseVisualStyleBackColor = true;
            // 
            // ReturnTime
            // 
            this.ReturnTime.Location = new System.Drawing.Point(44, 112);
            this.ReturnTime.Name = "ReturnTime";
            this.ReturnTime.Size = new System.Drawing.Size(200, 20);
            this.ReturnTime.TabIndex = 5;
            // 
            // txtUpDepBook
            // 
            this.txtUpDepBook.Location = new System.Drawing.Point(117, 63);
            this.txtUpDepBook.Name = "txtUpDepBook";
            this.txtUpDepBook.Size = new System.Drawing.Size(158, 20);
            this.txtUpDepBook.TabIndex = 4;
            // 
            // txtDepUpName
            // 
            this.txtDepUpName.Location = new System.Drawing.Point(117, 32);
            this.txtDepUpName.Name = "txtDepUpName";
            this.txtDepUpName.Size = new System.Drawing.Size(158, 20);
            this.txtDepUpName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Return Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Book Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Name:";
            // 
            // dtpDelete
            // 
            this.dtpDelete.Location = new System.Drawing.Point(20, 148);
            this.dtpDelete.Name = "dtpDelete";
            this.dtpDelete.Size = new System.Drawing.Size(75, 30);
            this.dtpDelete.TabIndex = 7;
            this.dtpDelete.Text = "Delete";
            this.dtpDelete.UseVisualStyleBackColor = true;
            // 
            // clmID
            // 
            this.clmID.DataPropertyName = "ID";
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.Visible = false;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Book Name";
            this.BookName.Name = "BookName";
            // 
            // BookExp
            // 
            this.BookExp.DataPropertyName = "BookExp";
            this.BookExp.HeaderText = "Book Explanation";
            this.BookExp.Name = "BookExp";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DepositUser";
            this.dataGridViewTextBoxColumn2.HeaderText = "Deposit User Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserTC";
            this.dataGridViewTextBoxColumn3.HeaderText = "TC No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 388);
            this.Controls.Add(this.groupUpdDep);
            this.Controls.Add(this.groupAddDep);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Boooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Boooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupAddDep.ResumeLayout(false);
            this.groupAddDep.PerformLayout();
            this.groupUpdDep.ResumeLayout(false);
            this.groupUpdDep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Boooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAddress;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupAddDep;
        private System.Windows.Forms.Button btnDepAdd;
        private System.Windows.Forms.DateTimePicker DepRetTime;
        private System.Windows.Forms.TextBox txtDepBook;
        private System.Windows.Forms.TextBox txtDepName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupUpdDep;
        private System.Windows.Forms.Button dtpDelete;
        private System.Windows.Forms.Button dtpUpd;
        private System.Windows.Forms.DateTimePicker ReturnTime;
        private System.Windows.Forms.TextBox txtUpDepBook;
        private System.Windows.Forms.TextBox txtDepUpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookExp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}