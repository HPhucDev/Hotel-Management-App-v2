﻿namespace Hotel_v1
{
    partial class ManageNhanVien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbLname = new System.Windows.Forms.TextBox();
            this.txbFname = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.labPicture = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.labLname = new System.Windows.Forms.Label();
            this.labFname = new System.Windows.Forms.Label();
            this.labUsername = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.cbBoxType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(824, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1516, 721);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(530, 837);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(254, 44);
            this.btnDownload.TabIndex = 83;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(1040, 81);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(944, 62);
            this.txbSearch.TabIndex = 82;
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearch.Location = new System.Drawing.Point(812, 85);
            this.labSearch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(213, 63);
            this.labSearch.TabIndex = 81;
            this.labSearch.Text = "Search:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(2020, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(320, 79);
            this.btnSearch.TabIndex = 80;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1336, 910);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(320, 79);
            this.btnReset.TabIndex = 79;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gray;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(550, 910);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(320, 79);
            this.btnEdit.TabIndex = 78;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(268, 837);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(264, 44);
            this.btnUploadImage.TabIndex = 77;
            this.btnUploadImage.Text = "Upload Image";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.Red;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Location = new System.Drawing.Point(920, 910);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(320, 79);
            this.BtnRemove.TabIndex = 76;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(134, 910);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(320, 79);
            this.btnAdd.TabIndex = 75;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picBoxImage
            // 
            this.picBoxImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.picBoxImage.Location = new System.Drawing.Point(268, 613);
            this.picBoxImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(516, 219);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImage.TabIndex = 74;
            this.picBoxImage.TabStop = false;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(268, 467);
            this.txbAddress.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(512, 106);
            this.txbAddress.TabIndex = 70;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(270, 388);
            this.txbPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(510, 31);
            this.txbPhone.TabIndex = 69;
            this.txbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPhone_KeyPress);
            // 
            // txbLname
            // 
            this.txbLname.Location = new System.Drawing.Point(270, 321);
            this.txbLname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbLname.Name = "txbLname";
            this.txbLname.Size = new System.Drawing.Size(510, 31);
            this.txbLname.TabIndex = 68;
            // 
            // txbFname
            // 
            this.txbFname.Location = new System.Drawing.Point(270, 250);
            this.txbFname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbFname.Name = "txbFname";
            this.txbFname.Size = new System.Drawing.Size(510, 31);
            this.txbFname.TabIndex = 67;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(268, 44);
            this.txbID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(510, 31);
            this.txbID.TabIndex = 66;
            // 
            // labPicture
            // 
            this.labPicture.AutoSize = true;
            this.labPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPicture.Location = new System.Drawing.Point(108, 631);
            this.labPicture.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labPicture.Name = "labPicture";
            this.labPicture.Size = new System.Drawing.Size(125, 37);
            this.labPicture.TabIndex = 65;
            this.labPicture.Text = "Picture:";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddress.Location = new System.Drawing.Point(90, 502);
            this.labAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(144, 37);
            this.labAddress.TabIndex = 64;
            this.labAddress.Text = "Address:";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhone.Location = new System.Drawing.Point(116, 388);
            this.labPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(118, 37);
            this.labPhone.TabIndex = 63;
            this.labPhone.Text = "Phone:";
            // 
            // labLname
            // 
            this.labLname.AutoSize = true;
            this.labLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLname.Location = new System.Drawing.Point(52, 317);
            this.labLname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labLname.Name = "labLname";
            this.labLname.Size = new System.Drawing.Size(182, 37);
            this.labLname.TabIndex = 60;
            this.labLname.Text = "Last Name:";
            // 
            // labFname
            // 
            this.labFname.AutoSize = true;
            this.labFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFname.Location = new System.Drawing.Point(52, 246);
            this.labFname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFname.Name = "labFname";
            this.labFname.Size = new System.Drawing.Size(184, 37);
            this.labFname.TabIndex = 59;
            this.labFname.Text = "First Name:";
            // 
            // labUsername
            // 
            this.labUsername.AutoSize = true;
            this.labUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.Location = new System.Drawing.Point(64, 44);
            this.labUsername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labUsername.Name = "labUsername";
            this.labUsername.Size = new System.Drawing.Size(173, 37);
            this.labUsername.TabIndex = 58;
            this.labUsername.Text = "Username:";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(268, 108);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(510, 31);
            this.txbPassword.TabIndex = 87;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(70, 108);
            this.labPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(167, 37);
            this.labPassword.TabIndex = 86;
            this.labPassword.Text = "Password:";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labType.Location = new System.Drawing.Point(140, 163);
            this.labType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(96, 37);
            this.labType.TabIndex = 88;
            this.labType.Text = "Type:";
            // 
            // cbBoxType
            // 
            this.cbBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxType.FormattingEnabled = true;
            this.cbBoxType.Items.AddRange(new object[] {
            "Manager",
            "Reception",
            "Labor"});
            this.cbBoxType.Location = new System.Drawing.Point(268, 167);
            this.cbBoxType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbBoxType.Name = "cbBoxType";
            this.cbBoxType.Size = new System.Drawing.Size(338, 33);
            this.cbBoxType.TabIndex = 89;
            // 
            // ManageNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2364, 1056);
            this.Controls.Add(this.cbBoxType);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.txbLname);
            this.Controls.Add(this.txbFname);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.labPicture);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labLname);
            this.Controls.Add(this.labFname);
            this.Controls.Add(this.labUsername);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ManageNhanVien";
            this.Text = "Quanlynhanvien";
            this.Load += new System.EventHandler(this.frmQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbLname;
        private System.Windows.Forms.TextBox txbFname;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label labPicture;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labLname;
        private System.Windows.Forms.Label labFname;
        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.ComboBox cbBoxType;
    }
}