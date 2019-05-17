namespace WindowsFormsApp5
{
    partial class Users
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
            this.UserAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddAddr = new System.Windows.Forms.TextBox();
            this.txtAddTC = new System.Windows.Forms.TextBox();
            this.txtAddPhone = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserUpd = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUpdAddr = new System.Windows.Forms.TextBox();
            this.txtUpdTC = new System.Windows.Forms.TextBox();
            this.txtUpdPhone = new System.Windows.Forms.TextBox();
            this.txtUpdName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDlete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Boooks)).BeginInit();
            this.UserAdd.SuspendLayout();
            this.UserUpd.SuspendLayout();
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
            this.Boooks.Location = new System.Drawing.Point(0, 208);
            this.Boooks.Name = "Boooks";
            this.Boooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Boooks.Size = new System.Drawing.Size(619, 180);
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
            // UserAdd
            // 
            this.UserAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UserAdd.Controls.Add(this.btnAdd);
            this.UserAdd.Controls.Add(this.txtAddAddr);
            this.UserAdd.Controls.Add(this.txtAddTC);
            this.UserAdd.Controls.Add(this.txtAddPhone);
            this.UserAdd.Controls.Add(this.txtAddName);
            this.UserAdd.Controls.Add(this.label4);
            this.UserAdd.Controls.Add(this.label3);
            this.UserAdd.Controls.Add(this.label2);
            this.UserAdd.Controls.Add(this.label1);
            this.UserAdd.Location = new System.Drawing.Point(316, 12);
            this.UserAdd.Name = "UserAdd";
            this.UserAdd.Size = new System.Drawing.Size(302, 189);
            this.UserAdd.TabIndex = 4;
            this.UserAdd.TabStop = false;
            this.UserAdd.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(243, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtAddAddr
            // 
            this.txtAddAddr.Location = new System.Drawing.Point(74, 106);
            this.txtAddAddr.Multiline = true;
            this.txtAddAddr.Name = "txtAddAddr";
            this.txtAddAddr.Size = new System.Drawing.Size(163, 60);
            this.txtAddAddr.TabIndex = 7;
            // 
            // txtAddTC
            // 
            this.txtAddTC.Location = new System.Drawing.Point(93, 76);
            this.txtAddTC.Name = "txtAddTC";
            this.txtAddTC.Size = new System.Drawing.Size(132, 20);
            this.txtAddTC.TabIndex = 6;
            // 
            // txtAddPhone
            // 
            this.txtAddPhone.Location = new System.Drawing.Point(93, 50);
            this.txtAddPhone.Name = "txtAddPhone";
            this.txtAddPhone.Size = new System.Drawing.Size(132, 20);
            this.txtAddPhone.TabIndex = 5;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(93, 24);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(132, 20);
            this.txtAddName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name Surname:";
            // 
            // UserUpd
            // 
            this.UserUpd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UserUpd.Controls.Add(this.btnDlete);
            this.UserUpd.Controls.Add(this.button1);
            this.UserUpd.Controls.Add(this.txtUpdAddr);
            this.UserUpd.Controls.Add(this.txtUpdTC);
            this.UserUpd.Controls.Add(this.txtUpdPhone);
            this.UserUpd.Controls.Add(this.txtUpdName);
            this.UserUpd.Controls.Add(this.label5);
            this.UserUpd.Controls.Add(this.label6);
            this.UserUpd.Controls.Add(this.label7);
            this.UserUpd.Controls.Add(this.label8);
            this.UserUpd.Location = new System.Drawing.Point(8, 12);
            this.UserUpd.Name = "UserUpd";
            this.UserUpd.Size = new System.Drawing.Size(302, 189);
            this.UserUpd.TabIndex = 5;
            this.UserUpd.TabStop = false;
            this.UserUpd.Text = "Update";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtUpdAddr
            // 
            this.txtUpdAddr.Location = new System.Drawing.Point(74, 106);
            this.txtUpdAddr.Multiline = true;
            this.txtUpdAddr.Name = "txtUpdAddr";
            this.txtUpdAddr.Size = new System.Drawing.Size(163, 60);
            this.txtUpdAddr.TabIndex = 7;
            // 
            // txtUpdTC
            // 
            this.txtUpdTC.Location = new System.Drawing.Point(93, 76);
            this.txtUpdTC.Name = "txtUpdTC";
            this.txtUpdTC.Size = new System.Drawing.Size(132, 20);
            this.txtUpdTC.TabIndex = 6;
            // 
            // txtUpdPhone
            // 
            this.txtUpdPhone.Location = new System.Drawing.Point(93, 50);
            this.txtUpdPhone.Name = "txtUpdPhone";
            this.txtUpdPhone.Size = new System.Drawing.Size(132, 20);
            this.txtUpdPhone.TabIndex = 5;
            // 
            // txtUpdName
            // 
            this.txtUpdName.Location = new System.Drawing.Point(93, 24);
            this.txtUpdName.Name = "txtUpdName";
            this.txtUpdName.Size = new System.Drawing.Size(132, 20);
            this.txtUpdName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "TC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phone No:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name Surname:";
            // 
            // btnDlete
            // 
            this.btnDlete.Location = new System.Drawing.Point(9, 160);
            this.btnDlete.Name = "btnDlete";
            this.btnDlete.Size = new System.Drawing.Size(53, 23);
            this.btnDlete.TabIndex = 9;
            this.btnDlete.Text = "Delete";
            this.btnDlete.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 388);
            this.Controls.Add(this.UserUpd);
            this.Controls.Add(this.UserAdd);
            this.Controls.Add(this.Boooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.Boooks)).EndInit();
            this.UserAdd.ResumeLayout(false);
            this.UserAdd.PerformLayout();
            this.UserUpd.ResumeLayout(false);
            this.UserUpd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Boooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName_Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserAddress;
        private System.Windows.Forms.GroupBox UserAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddAddr;
        private System.Windows.Forms.TextBox txtAddTC;
        private System.Windows.Forms.TextBox txtAddPhone;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox UserUpd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUpdAddr;
        private System.Windows.Forms.TextBox txtUpdTC;
        private System.Windows.Forms.TextBox txtUpdPhone;
        private System.Windows.Forms.TextBox txtUpdName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDlete;
    }
}