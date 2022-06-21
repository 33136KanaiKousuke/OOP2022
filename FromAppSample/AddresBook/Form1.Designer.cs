
namespace AddresBook {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPrsons = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbTelNumber = new System.Windows.Forms.TextBox();
            this.cbFamily = new System.Windows.Forms.CheckBox();
            this.cbFriend = new System.Windows.Forms.CheckBox();
            this.cbWork = new System.Windows.Forms.CheckBox();
            this.cbOther = new System.Windows.Forms.CheckBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureClear = new System.Windows.Forms.Button();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.cbCompany = new System.Windows.Forms.ComboBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRegistDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.KindNumber = new System.Windows.Forms.GroupBox();
            this.Home = new System.Windows.Forms.RadioButton();
            this.Mobile = new System.Windows.Forms.RadioButton();
            this.tbMailAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrsons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.KindNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(102, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "メールアドレス";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(102, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "住所";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(102, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "会社";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(71, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "グループ";
            // 
            // dgvPrsons
            // 
            this.dgvPrsons.AllowUserToAddRows = false;
            this.dgvPrsons.AllowUserToDeleteRows = false;
            this.dgvPrsons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrsons.Location = new System.Drawing.Point(93, 383);
            this.dgvPrsons.MultiSelect = false;
            this.dgvPrsons.Name = "dgvPrsons";
            this.dgvPrsons.ReadOnly = true;
            this.dgvPrsons.RowTemplate.Height = 21;
            this.dgvPrsons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrsons.Size = new System.Drawing.Size(826, 191);
            this.dgvPrsons.TabIndex = 1;
            this.dgvPrsons.Click += new System.EventHandler(this.dgvPrsons_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbName.Location = new System.Drawing.Point(174, 47);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(398, 31);
            this.tbName.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAddress.Location = new System.Drawing.Point(174, 153);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(398, 68);
            this.tbAddress.TabIndex = 2;
            // 
            // tbTelNumber
            // 
            this.tbTelNumber.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTelNumber.Location = new System.Drawing.Point(174, 296);
            this.tbTelNumber.Name = "tbTelNumber";
            this.tbTelNumber.Size = new System.Drawing.Size(310, 31);
            this.tbTelNumber.TabIndex = 2;
            // 
            // cbFamily
            // 
            this.cbFamily.AutoSize = true;
            this.cbFamily.Location = new System.Drawing.Point(186, 355);
            this.cbFamily.Name = "cbFamily";
            this.cbFamily.Size = new System.Drawing.Size(48, 16);
            this.cbFamily.TabIndex = 3;
            this.cbFamily.Text = "家族";
            this.cbFamily.UseVisualStyleBackColor = true;
            // 
            // cbFriend
            // 
            this.cbFriend.AutoSize = true;
            this.cbFriend.Location = new System.Drawing.Point(267, 355);
            this.cbFriend.Name = "cbFriend";
            this.cbFriend.Size = new System.Drawing.Size(48, 16);
            this.cbFriend.TabIndex = 3;
            this.cbFriend.Text = "友人";
            this.cbFriend.UseVisualStyleBackColor = true;
            // 
            // cbWork
            // 
            this.cbWork.AutoSize = true;
            this.cbWork.Location = new System.Drawing.Point(362, 354);
            this.cbWork.Name = "cbWork";
            this.cbWork.Size = new System.Drawing.Size(48, 16);
            this.cbWork.TabIndex = 3;
            this.cbWork.Text = "仕事";
            this.cbWork.UseVisualStyleBackColor = true;
            // 
            // cbOther
            // 
            this.cbOther.AutoSize = true;
            this.cbOther.Location = new System.Drawing.Point(450, 354);
            this.cbOther.Name = "cbOther";
            this.cbOther.Size = new System.Drawing.Size(55, 16);
            this.cbOther.TabIndex = 3;
            this.cbOther.Text = "その他";
            this.cbOther.UseVisualStyleBackColor = true;
            // 
            // btAddPerson
            // 
            this.btAddPerson.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddPerson.Location = new System.Drawing.Point(597, 327);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(71, 51);
            this.btAddPerson.TabIndex = 4;
            this.btAddPerson.Text = "追加";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbPicture.Location = new System.Drawing.Point(597, 86);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(152, 152);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 5;
            this.pbPicture.TabStop = false;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(597, 244);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(75, 23);
            this.btPictureOpen.TabIndex = 6;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btPictureClear
            // 
            this.btPictureClear.Location = new System.Drawing.Point(674, 244);
            this.btPictureClear.Name = "btPictureClear";
            this.btPictureClear.Size = new System.Drawing.Size(75, 23);
            this.btPictureClear.TabIndex = 6;
            this.btPictureClear.Text = "クリア";
            this.btPictureClear.UseVisualStyleBackColor = true;
            this.btPictureClear.Click += new System.EventHandler(this.btPictureClear_Click);
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btUpdate.Location = new System.Drawing.Point(678, 326);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(71, 51);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "更新";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btdelete
            // 
            this.btdelete.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btdelete.Location = new System.Drawing.Point(755, 325);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 51);
            this.btdelete.TabIndex = 7;
            this.btdelete.Text = "削除";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // cbCompany
            // 
            this.cbCompany.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbCompany.FormattingEnabled = true;
            this.cbCompany.Location = new System.Drawing.Point(174, 239);
            this.cbCompany.Name = "cbCompany";
            this.cbCompany.Size = new System.Drawing.Size(398, 32);
            this.cbCompany.TabIndex = 8;
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btOpen.Location = new System.Drawing.Point(12, 467);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(75, 38);
            this.btOpen.TabIndex = 9;
            this.btOpen.Text = "開く";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btSave.Location = new System.Drawing.Point(12, 523);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 41);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(666, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "登録日：";
            // 
            // dtpRegistDate
            // 
            this.dtpRegistDate.Location = new System.Drawing.Point(719, 590);
            this.dtpRegistDate.Name = "dtpRegistDate";
            this.dtpRegistDate.Size = new System.Drawing.Size(200, 19);
            this.dtpRegistDate.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(48, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "電話番号";
            // 
            // KindNumber
            // 
            this.KindNumber.Controls.Add(this.Mobile);
            this.KindNumber.Controls.Add(this.Home);
            this.KindNumber.Location = new System.Drawing.Point(490, 281);
            this.KindNumber.Name = "KindNumber";
            this.KindNumber.Size = new System.Drawing.Size(82, 67);
            this.KindNumber.TabIndex = 13;
            this.KindNumber.TabStop = false;
            this.KindNumber.Text = "種別";
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Checked = true;
            this.Home.Location = new System.Drawing.Point(6, 18);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(47, 16);
            this.Home.TabIndex = 0;
            this.Home.TabStop = true;
            this.Home.Text = "自宅";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Location = new System.Drawing.Point(6, 45);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(47, 16);
            this.Mobile.TabIndex = 1;
            this.Mobile.Text = "携帯";
            this.Mobile.UseVisualStyleBackColor = true;
            // 
            // tbMailAddress
            // 
            this.tbMailAddress.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMailAddress.Location = new System.Drawing.Point(174, 108);
            this.tbMailAddress.Name = "tbMailAddress";
            this.tbMailAddress.Size = new System.Drawing.Size(398, 31);
            this.tbMailAddress.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 621);
            this.Controls.Add(this.KindNumber);
            this.Controls.Add(this.dtpRegistDate);
            this.Controls.Add(this.tbMailAddress);
            this.Controls.Add(this.tbTelNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.cbCompany);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btPictureClear);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.cbOther);
            this.Controls.Add(this.cbWork);
            this.Controls.Add(this.cbFriend);
            this.Controls.Add(this.cbFamily);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dgvPrsons);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "住所録アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrsons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.KindNumber.ResumeLayout(false);
            this.KindNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPrsons;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbTelNumber;
        private System.Windows.Forms.CheckBox cbFamily;
        private System.Windows.Forms.CheckBox cbFriend;
        private System.Windows.Forms.CheckBox cbWork;
        private System.Windows.Forms.CheckBox cbOther;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureClear;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.ComboBox cbCompany;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRegistDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox KindNumber;
        private System.Windows.Forms.RadioButton Mobile;
        private System.Windows.Forms.RadioButton Home;
        private System.Windows.Forms.TextBox tbMailAddress;
    }
}

